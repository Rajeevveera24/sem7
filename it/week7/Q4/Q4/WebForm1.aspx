<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Genre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack = "true" DataSourceID ="SqlDataSource1" DataValueField = "category">
            </asp:DropDownList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack = "true" DataSourceID = "SqlDataSource2" DataTextField ="name"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="false" DataSourceID ="SqlDataSource3">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test2;Integrated Security=True;Pooling=False" SelectCommand ="SELECT DISTINCT category FROM Legends">
            </asp:SqlDataSource>
            <asp:SqlDataSource ID ="SqlDataSource2" runat = "server" ConnectionString = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test2;Integrated Security=True;Pooling=False" SelectCommand ="SELECT name FROM Legends WHERE category = @category">
                <SelectParameters>
                    <asp:ControlParameter Name ="category" ControlID ="DropDownList1" PropertyName ="SelectedValue"/>
                </SelectParameters>

            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString ="Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test2;Integrated Security=True;Pooling=False" SelectCommand ="SELECT name, age FROM Legends WHERE name = @name">
                <SelectParameters>
                    <asp:ControlParameter Name ="name" ControlID ="ListBox1" PropertyName ="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
