<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Q3.Home"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 214px">
            <asp:Panel ID ="Panel1" runat ="server" Height="186px" Width="665px">
                <asp:Label ID="Label1" runat="server" Text="Select Theme:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DDL_Theme" runat="server" OnSelectedIndexChanged="DDL_Theme_SelectedIndexChanged" AutoPostBack = "True">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button runat = "server" Text ="Sample Button" ID ="Button1" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
