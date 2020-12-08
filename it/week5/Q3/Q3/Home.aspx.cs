using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DDL_Theme.Items.Add("Monsoon");
                DDL_Theme.Items.Add("Summer");
                if (Session["Theme"] != null)
                {
                    
                    DDL_Theme.Items.FindByText(Session["Theme"].ToString()).Selected = true;
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

        protected void DDL_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["theme"] = DDL_Theme.SelectedValue;
            Server.Transfer(Request.FilePath);
        }
    }
}