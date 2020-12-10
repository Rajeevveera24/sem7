<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID ="Panel1" runat ="server" Height="234px" Width="514px" style ="float:left">
                Name:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                Company:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                Salary:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" AutoPostBack ="true"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </asp:Panel>
            <asp:Panel runat ="server" ID ="Panel2" style = "float:right" Height="272px" Width="358px">
                &nbsp;Company:
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Search" AutoPostBack ="true" OnClick="Button2_Click"/>

                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            </asp:Panel>

        </div>
    </form>
</body>
</html>
