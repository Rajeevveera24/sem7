<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        </div>
    &nbsp;&nbsp;&nbsp; Employee Id&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged = "emp_select">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="90px" Width="191px" />
        <br />
        <br />
        Name of Employee<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 47px"></asp:TextBox>
        <br />
        <br />
        DOJ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="AM I eligible for Promotion ?" OnClick ="Button1_Click"/>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
