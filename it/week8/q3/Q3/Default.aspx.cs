using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Q3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           	string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Cars.xml");
            XElement ele1 = new XElement("Detail", 
                new XElement("Name", "I20"), 
                new XElement("Make", "Hyundai"), 
                new XElement("Price", "70000")
            );

            XElement ele2 = new XElement("Detail",
                new XElement("Name", "I20"),
                new XElement("Make", "Hyundai"),
                new XElement("Price", "70000")
            );

            XElement ele = new XElement("Car",
                from el in ele1.Elements()
                select el
            );

            ele.Add(ele2);

            XDocument doc = new XDocument(ele);

            doc.Save(file);
        }
    }
}