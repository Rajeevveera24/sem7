using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                foreach(FontFamily f in FontFamily.Families)
                {
                    DropDownList3.Items.Add(f.Name);
                }

                DropDownList2.Items.Add("pic.png");
                DropDownList2.Items.Add("pic1.png");
                DropDownList2.Items.Add("pic2.png");

                foreach(string c in Enum.GetNames(typeof(KnownColor)))
                {
                    DropDownList1.Items.Add(c);
                }

                Image1.ImageUrl = "pic.png";
            }
        }

        protected void Button1_Click(object Sender, EventArgs e)
        {
            Image1.ImageUrl = DropDownList2.SelectedItem.Value;
            Label6.Text = TextBox2.Text;
            Label6.Font.Name = DropDownList3.SelectedItem.Text;
            Label6.Font.Size = FontUnit.Parse(TextBox1.Text);
            Panel2.BackColor = ColorTranslator.FromHtml(DropDownList1.SelectedValue);
        }
    }
}