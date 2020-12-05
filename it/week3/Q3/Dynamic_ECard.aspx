<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dynamic_ECard.aspx.cs" Inherits="Q3.Dynamic_ECard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E Card Generator</title>
    <style type="text/css">
        #form1 {
            height: 354px;
        }
    </style>
</head>
<body style="height: 391px">
    <form id="form1" runat="server">
        <div style="height: 294px">
            <asp:Panel ID="Panel1" runat="server" style = "float:left" Width="40%" Height="295px">
                &nbsp;&nbsp;<br />
                &nbsp;
                <asp:Label ID="Label1" runat="server" Text="BackGround Color: "></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack ="True">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Font: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack ="True">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Font Size: "></asp:Label>
                
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack ="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Input Message: "></asp:Label>
                
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" AutoPostBack ="True"></asp:TextBox>
                
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" style ="float:right" Width="40%" HorizontalAlign ="center" Height="247px">
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Image ID="Image1" runat="server" Height="50%" Width="70%" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
