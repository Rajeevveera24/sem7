using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Q1;Integrated Security=True;Pooling=False");
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT DISTINCT StaffID FROM Staff", con);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        DDL_Staff_ID.Items.Add(reader["StaffID"].ToString());
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

        protected void DDL_Staff_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDL_Staff_ID.SelectedIndex = DDL_Staff_ID.SelectedIndex;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Q1;Integrated Security=True;Pooling=False");
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Staff WHERE StaffID = @0", con);
                com.Parameters.AddWithValue("@0", DDL_Staff_ID.SelectedItem.Text);
                
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(ds, "Staff1");

                Label1.Text = "First Name: " +
                    ds.Tables["Staff1"].Rows[0]["Firstname"].ToString() + "<br>Last Name: " +
                    ds.Tables["Staff1"].Rows[0]["Lastname"].ToString() + "<br>DNo: " +
                    ds.Tables["Staff1"].Rows[0]["DNo"].ToString() + "<br>Street: " +
                    ds.Tables["Staff1"].Rows[0]["Street"].ToString() + "<br>City: " +
                    ds.Tables["Staff1"].Rows[0]["City"].ToString() + "<br>State: " +
                    ds.Tables["Staff1"].Rows[0]["State"].ToString() + "<br>ZipCode: " +
                    ds.Tables["Staff1"].Rows[0]["ZipCode"];

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Q1;Integrated Security=True;Pooling=False");
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE Staff SET City = '" + LB_City.SelectedValue + "' WHERE StaffID = @0", con);
                com.Parameters.AddWithValue("@0", DDL_Staff_ID.SelectedValue);
                com.ExecuteNonQuery();

                com = new SqlCommand("SELECT * FROM Staff WHERE StaffID = @0", con);
                com.Parameters.AddWithValue("@0", DDL_Staff_ID.SelectedValue);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(ds, "Staff2");

                Label1.Text = "First Name: " +
                    ds.Tables["Staff2"].Rows[0]["Firstname"].ToString() + "<br>Last Name: " +
                    ds.Tables["Staff2"].Rows[0]["Lastname"].ToString() + "<br>DNo: " +
                    ds.Tables["Staff2"].Rows[0]["DNo"].ToString() + "<br>Street: " +
                    ds.Tables["Staff2"].Rows[0]["Street"].ToString() + "<br>City: " +
                    ds.Tables["Staff2"].Rows[0]["City"].ToString() + "<br>State: " +
                    ds.Tables["Staff2"].Rows[0]["State"].ToString() + "<br>ZipCode: " +
                    ds.Tables["Staff2"].Rows[0]["ZipCode"];

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