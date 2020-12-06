<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 461px; width: 1054px">
            
            <asp:Panel ID="Panel1" runat="server" Width="451px" Height="347px" style =" float:left">
                <asp:Label ID="Label1" runat="server" Text="Backgorund Color"></asp:Label> &nbsp &nbsp
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br/>
                <asp:Label ID="Label2" runat="server" Text="Select Image"></asp:Label> &nbsp &nbsp
                <asp:DropDownList ID="DropDownList2" runat="server" Height="80px">
                </asp:DropDownList>
                <br/>
                <asp:Label ID="Label4" runat="server" Text="Font Size"></asp:Label> &nbsp &nbsp
                <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Font Family"></asp:Label> &nbsp &nbsp
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Input Message"></asp:Label> &nbsp &nbsp
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Button" onClick ="Button1_Click"/>
                
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Height="361px" style ="float:right" HorizontalAlign="center" Width="514px">
                <asp:Label ID="Label6" runat="server" Text="Label" style ="align-content:center"></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" Height="106px" Width="174px" />                
             </asp:Panel>
        </div>
    </form>
</body>
</html>
