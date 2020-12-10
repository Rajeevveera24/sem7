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
            if (!IsPostBack) {
                List<String> Fruits = new List<String>();
                Fruits.Add("Mango");
                Fruits.Add("Orange");
                Fruits.Add("Strawberry");
                List<String> IceCreams = new List<String>();
                IceCreams.Add("Vanilla");
                IceCreams.Add("Chocolate");
                IceCreams.Add("Pista");
                IceCreams.Add("Black Current");
                CheckBoxList1.DataSource = Fruits;
                CheckBoxList1.DataBind();
                RadioButtonList1.DataSource = IceCreams;
                RadioButtonList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 10, 20, 30};
            Random r = new Random();
            int index = r.Next(0, 3);
            Label1.Text = "Fruit: " + CheckBoxList1.SelectedItem.Text + "<br/>Ice Cream: " + RadioButtonList1.SelectedItem.Text + "<br/>Price: " + arr[index].ToString(); 
        }
    }

}