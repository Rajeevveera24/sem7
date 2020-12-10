<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="A1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AllowSorting ="true" AutoGenerateColumns ="false" DataSourceID ="SqlDataSource1" DataKeyNames ="id">
                <Columns>
                    <asp:BoundField DataField ="id" HeaderText = "Id" SortExpression ="id" ReadOnly = "true"/>
                    <asp:BoundField DataField ="name" HeaderText ="Soap" SortExpression = "name"/>
                    <asp:TemplateField HeaderText ="Details">
                        <ItemTemplate>
                            Price: 
                            <%# Eval("price") %>
                            <br />
                            Quantity: 
                            <%# Eval("qty") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            Price: 
                            <%# Eval("price") %>
                            <br />
                            Quantity: 
                            <asp:TextBox ID ="TextBox1" runat ="server" Text = '<%# Bind("qty") %>'>
                            </asp:TextBox>
                            <asp:RangeValidator runat ="server" ControlToValidate ="TextBox1" MinimumValue = "1" EnableClientScript="false" MaximumValue ="20" Type ="Integer" ErrorMessage = "Enter a value between 1 and 20" >
                            </asp:RangeValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton = "true" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=A1;Integrated Security=True;Pooling=False" SelectCommand ="SELECT id, name, price, qty FROM Product" UpdateCommand ="UPDATE Product SET name = @name, qty = @qty WHERE id = @id"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
