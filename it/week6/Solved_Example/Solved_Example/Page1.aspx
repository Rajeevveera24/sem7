<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Solved_Example.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solved Example - Sales</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Sales ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_sales_id" runat="server" AutoPostBack ="true" OnSelectedIndexChanged="DDL_sales_id_SelectedIndexChanged">
            </asp:DropDownList>

            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="Grid_sales" runat="server" AutoGenerateColumns ="false" CellPadding="5" CellSpacing="5" BorderColor="black" BorderWidth="3" AllowSorting="true" >
                <Columns>
                    <asp:BoundField DataField ="item_name" HeaderText="Name" SortExpression="item_name" HeaderStyle-BackColor="Gray"
                        HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"/>
                    <asp:TemplateField  HeaderText = "Details" HeaderStyle-BackColor="Gray" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White">
                        <ItemTemplate>
                            <b>Amount: </b>
                            <%# Eval("item_amt") %>
                            <br />
                            <b>Quantity: </b>
                            <%# Eval("quantity") %>
                            <br />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
