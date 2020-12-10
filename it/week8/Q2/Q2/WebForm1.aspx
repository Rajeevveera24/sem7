<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames ="Id" BackColor ="Green" HeaderStyle-Font-Bold ="True" ForeColor ="Red" AllowPaging ="True" PageSize ="3" DataSourceID ="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowEditButton ="true" />
                    <asp:BoundField DataField ="Id" HeaderText ="Id" ReadOnly ="true" />
                    <asp:TemplateField HeaderText ="Status">
                        <ItemTemplate>
                            <b>First Name: </b>
                            <%# Eval("fname") %>
                            <br />
                            <b>Last Name: </b>
                            <%#  Eval("lname") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <b>First Name: </b>
                            <asp:TextBox ID ="TextBox1" runat ="server" Text ='<%# Bind("fname") %>'>
                            </asp:TextBox>
                            <br />
                            <b>Last Name: </b>
                            <%# Eval("lname")%>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField ="title" HeaderText = "Book Title" ReadOnly ="true"/>
                    <asp:BoundField DataField ="genre" HeaderText = "Genre" ReadOnly ="True" />
                    <asp:BoundField DataField = "copies" HeaderText = "Copies Sold" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString ="Data Source=(localdb)\mssqllocaldb;Initial Catalog=Authors;Integrated Security=True;Pooling=False" SelectCommand ="SELECT Id, fname, lname, title, genre, copies FROM Authors" UpdateCommand ="UPDATE Authors SET fname = @fname, copies = @copies WHERE ID = @Id">

            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
