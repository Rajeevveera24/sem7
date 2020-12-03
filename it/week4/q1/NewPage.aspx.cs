using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Model is " + Request.QueryString["model"];
            Label1.Text += " and manufacturer is " + Request.QueryString["manufacturer"];
        }
    }
}