using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Label1.Text = "Welcome, New User !";
            }

            HttpCookie cookie = Request.Cookies["shop_cart"];
            if(cookie != null)
            {
                TextBox2.Text = (string)cookie["items"];
                Label1.Text = "Welcome back, " + (string)cookie["name"] + " !";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("shop_cart");
            cookie["items"] = TextBox2.Text;
            cookie["name"] = TextBox1.Text;
            cookie.Expires = DateTime.Now.AddMinutes(60);
            Response.Cookies.Add(cookie);
        }
    }
}