<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Q2.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tours;Integrated Security=SSPI" SelectCommand="SELECT * FROM Travel WHERE place=@place">
                <SelectParameters>
                    <asp:QueryStringParameter Name="place" QueryStringField="place"/>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
