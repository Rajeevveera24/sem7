using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q4
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Session["count"] = 0;
                Application["count"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string pswd = TextBox2.Text;
            int pass_count, fail_count;

            if(name.Equals("Raj") && pswd.Equals("eev"))
            {
                pass_count = (int)Session["count"] + 1;
                Session["count"] = pass_count;
                Label3.Text = "Successfully logged in " + pass_count.ToString() + " times\n";
            }
            else
            {
                fail_count = (int)Application["count"] + 1;
                Application["count"] = fail_count;

                if(fail_count > 3)
                {
                    TextBox2.Enabled = false;
                }
            }
        }
    }
}