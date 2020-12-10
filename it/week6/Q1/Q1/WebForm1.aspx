<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Staff ID :
            <asp:DropDownList ID="DDL_Staff_ID" runat="server" OnSelectedIndexChanged="DDL_Staff_ID_SelectedIndexChanged" AutoPostBack ="true">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            City:
            <asp:ListBox ID="LB_City" runat="server">
                <asp:ListItem>Manipal</asp:ListItem>
                 <asp:ListItem>Bangalore</asp:ListItem>
                 <asp:ListItem>Chennai</asp:ListItem>
                 <asp:ListItem>Hyderabad</asp:ListItem>
                 <asp:ListItem>Kochi</asp:ListItem>
                 <asp:ListItem>Mysore</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" AutoPostBack ="true"/>
            <br />
            <br />

        </div>
    </form>
</body>
</html>
