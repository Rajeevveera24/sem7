<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstPage.aspx.cs" Inherits="Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Roll:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="RollTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Subjects:
            <asp:DropDownList ID="SubjectList" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" AutoPostBack ="true" OnClick ="Button1_Click"/>
        </div>
    </form>
</body>
</html>
