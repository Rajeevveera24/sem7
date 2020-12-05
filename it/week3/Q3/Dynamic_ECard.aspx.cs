using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Q3
{
    public partial class Dynamic_ECard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                foreach(FontFamily f in FontFamily.Families)
                {
                    DropDownList2.Items.Add(f.Name);
                }
                DropDownList2.SelectedIndex = 0;

                foreach(string color in Enum.GetNames(typeof(KnownColor)))
                {
                    DropDownList1.Items.Add(color);
                }
                DropDownList1.SelectedIndex = 0;

                Image1.ImageUrl = "Capture.png";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), DropDownList1.SelectedValue));
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Label5.Font.Size = Convert.ToInt32(TextBox1.Text);
            }
            catch
            {

            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Label5.Text = TextBox2.Text;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label5.Font.Name = DropDownList2.SelectedValue;
        }
    }
}