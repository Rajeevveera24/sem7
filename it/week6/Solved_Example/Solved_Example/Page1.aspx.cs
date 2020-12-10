using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Solved_Example
{
    public partial class Page1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Solved_Example;Integrated Security=True;Pooling=False");
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT DISTINCT sales_id FROM Sales", con);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        DDL_sales_id.Items.Add(reader["sales_id"].ToString());
                    }
                }
                catch
                {
                    DDL_sales_id.Items.Add("HI");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void DDL_sales_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Solved_Example;Integrated Security=True;Pooling=False");
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Sales WHERE sales_id = @sales_id", con);
                com.Parameters.AddWithValue("@sales_id", DDL_sales_id.SelectedItem.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(ds, "sales_details");
                Grid_sales.DataSource = ds;
                Grid_sales.DataBind();
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