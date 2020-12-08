using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solved_Example
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                themeDropDown.Items.Add("Monochrome");
                themeDropDown.Items.Add("Darkgrey");

                if(Session["theme"] != null)
                {
                    themeDropDown.Items.FindByText(Session["theme"].ToString()).Selected = true;
                }
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(Session["theme"] != null)
            {
                Page.Theme = Session["theme"].ToString();
            }
        }

        protected void themeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["theme"] = themeDropDown.SelectedValue;
            Server.Transfer(Request.FilePath);
        }
    }
}