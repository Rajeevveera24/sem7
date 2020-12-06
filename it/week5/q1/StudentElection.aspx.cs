using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q1
{
    public partial class StudentElection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                candidate_DDL.Items.Add("A");
                candidate_DDL.Items.Add("B");
                candidate_DDL.Items.Add("C");

                RadioButtonList_House.Items.Add("A");
                RadioButtonList_House.Items.Add("B");
                RadioButtonList_House.Items.Add("C");
                RadioButtonList_House.Items.Add("D");
            }
        }

        protected void vldPhone_ServerValidate(Object source, ServerValidateEventArgs e)
        {
            try
            {
                int val = Int32.Parse(e.Value.Substring(0, 3));
                e.IsValid = true;
            }
            catch
            {
                e.IsValid = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Successfully Submitted\n";
        }
    }
}