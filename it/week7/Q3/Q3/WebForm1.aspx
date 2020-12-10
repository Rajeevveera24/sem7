<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            State:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack ="true">
            </asp:DropDownList>
            <br />
            <br />
            City:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID ="sql1" DataTextField ="city">
            </asp:DropDownList>
            <br />
            <asp:SqlDataSource ID="sql1" runat="server" ConnectionString = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=City;Integrated Security=True;Pooling=False" SelectCommand ="SELECT city FROM Cities WHERE s_id = @s_id">
                <SelectParameters>
                    <asp:ControlParameter Name ="s_id"  ControlID ="DropDownList1" PropertyName ="SelectedValue"/>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
