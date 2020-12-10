using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "TN");
                dict.Add(2, "Kar");
                dict.Add(3, "Ker");
                dict.Add(4, "AP");
                DropDownList1.DataSource = dict;

                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";

                DropDownList1.DataBind();
            }
        }
    }
}