<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Solved_Example.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="themeDropDown" runat="server" AutoPostBack="true" OnSelectedIndexChanged="themeDropDown_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="ThemeDemo"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Text=" "></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click Me"/>
        </div>
    </form>
</body>
</html>
