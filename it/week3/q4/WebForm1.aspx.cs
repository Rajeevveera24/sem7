using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                TextBox2.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(TextBox2.Text);
            if (TextBox1.Text.Equals("ACBD"))
            {
                count = 0;
                TextBox2.Text = Convert.ToString(count);
                TextBox1.Text = "Correct!";
            }
            else
            {
                count++;
                if (count >= 3)
                {
                    TextBox1.Enabled = false;
                }
                TextBox1.Text = "Incorrect!";
            }

            TextBox2.Text = Convert.ToString(count);
        }
    }
}