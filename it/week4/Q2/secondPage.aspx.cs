using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Button1.Text = "0";
                HttpCookie cookie = new HttpCookie("Counter");
                cookie["Counter"] = "0";
                Response.Cookies.Add(cookie);
            }
            string name = (string)Session["Name"];
            string roll = (string)Session["Roll"];
            string subject = (string)Session["Subject"];
            Label1.Text = "Name: " + name + "\nRoll: " + roll + "\nSubject: " + subject + "\n";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Counter"];
            if(cookie != null)
            {
                int val = Int32.Parse(cookie["Counter"]);
                val++;
                Button1.Text = val.ToString();
                cookie["Counter"] = val.ToString();
                Response.Cookies.Add(cookie);
            }
        }
    }
}