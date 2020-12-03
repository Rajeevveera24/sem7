using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Emp1");
                DropDownList1.Items.Add("Emp2");
                DropDownList1.Items.Add("Emp3");
            }
            Label1.Text = "";
        }

        protected void Button1_Click(object Sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime join = Convert.ToDateTime(TextBox2.Text);
            int days = (dt - join).Days;
            int years = days / 365;
            
            if(years >= 5)
            {
                Label1.Text = "YES";
            }
            else
            {
                Label1.Text = "NO";
            }
        }

        protected void emp_select(object Sender, EventArgs e)
        {
            Image1.ImageUrl = DropDownList1.SelectedItem.Text;
            Label1.Text = "Name";
        }
    }
}