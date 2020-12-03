using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                manList.Items.Add("Hyundai");
                manList.Items.Add("Mahindra");
                manList.Items.Add("Ford");

                modelTextBox.Text = "";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = modelTextBox.Text;
            string manu = manList.SelectedItem.Text;

            string url = "NewPage.aspx?model=" + Server.UrlEncode(model) + "&manufacturer=" + Server.UrlEncode(manu);

            Response.Redirect(url);
        }
    }
}