using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "comedy");
                dict.Add(2, "romance");
                dict.Add(3, "animated");

                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";
                DropDownList1.DataSource = dict;
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=True;Pooling=False");

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT name FROM Legends WHERE category = '" + DropDownList1.SelectedItem.Text + "'", con);
                SqlDataReader reader = com.ExecuteReader();
                
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["name"].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=True;Pooling=False");

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT name, age FROM Legends WHERE category ='" + DropDownList1.SelectedItem.Text + "' AND name = @1", con);
                com.Parameters.AddWithValue("@1", ListBox1.SelectedValue);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Label1.Text = "Name: " + reader["name"].ToString() + "\nAge: " + reader["age"].ToString() + "\n";
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}