<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Solved_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDS1" runat="server" ConnectionString="<%$ConnectionStrings:Student%>" SelectCommand="SELECT * FROM Student">
            </asp:SqlDataSource>

            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDS1" DataTextField="Name" DataValueField="id" AutoPostBack="True">
            </asp:DropDownList>
            <br /> <br /> <br />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDS2" AutoGenerateEditButton="False" Height="76px" Width="254px" >
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDS2" ConnectionString="<%$ConnectionStrings:Student %>" runat="server" SelectCommand="SELECT * FROM Student WHERE id=@id" >
            <SelectParameters>
                <asp:ControlParameter Name="id" ControlID="DropDownList1" PropertyName="SelectedValue" />
            </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
