<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Fruit:<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
            <br />
            Ice Cream:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Order" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
