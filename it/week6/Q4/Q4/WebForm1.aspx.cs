using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string company = TextBox2.Text;
            string salary = TextBox3.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Q4;Integrated Security=True;Pooling=False");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO WORKS VALUES (@1, @2, @3)", con);
                command.Parameters.AddWithValue("@1", name);
                command.Parameters.AddWithValue("@2", company);
                command.Parameters.AddWithValue("@3", salary);
                command.ExecuteNonQuery();
                Label1.Text = "Inserted Values Successfully";
                TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string company = TextBox4.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Q4;Integrated Security=True;Pooling=False");

            try
            {
                Label2.Text = "Name:    City: <br/>";
                con.Open();
                SqlCommand command = new SqlCommand("SELECT W.person_name AS name, city  FROM LIVES L INNER JOIN WORKS W ON L.person_name = W.person_name WHERE W.company_name = '" + company + "'", con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Label2.Text += reader["name"].ToString() + "    " + reader["city"].ToString() + "<br/>";
                }
            }
            catch (Exception e1)
            {
                Label2.Text = e1.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}