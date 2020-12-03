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
                SubjectList.Items.Add("DS");
                SubjectList.Items.Add("DBMS");
                SubjectList.Items.Add("DAA");
                SubjectList.Items.Add("PSUC");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = NameTextBox.Text;
            Session["Roll"] = RollTextBox.Text;
            Session["Subject"] = SubjectList.SelectedItem.Text;
            string url = Server.UrlEncode("secondPage.aspx");
            Response.Redirect(url);
        }
    }
}