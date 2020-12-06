<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentElection.aspx.cs" Inherits="Q1.StudentElection" UnobtrusiveValidationMode ="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 306px">
    <form id="form1" runat="server">
        <div style="height: 336px">
            <asp:Label ID="Label1" runat="server" Text="Candidate"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="candidate_DDL" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            House&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList_House" runat="server">
            </asp:RadioButtonList>
            <br />
            Class
            <asp:TextBox ID="TextBox_Class" runat="server"></asp:TextBox>
            <br />
            <br />
            Email
            <asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox>
            <br />
            <br />
            Parent Contact&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_ParentContact" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <asp:RequiredFieldValidator ID ="rfvCandidate" runat ="server" ControlToValidate = "Candidate_DDL" ErrorMessage ="Please choose a candidate" InitialValue ="Choose a candidate"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID ="rfvClass" runat ="server" ControlToValidate = "TextBox_Class" ErrorMessage ="Enter a Class"></asp:RequiredFieldValidator><br />
            <asp:RequiredFieldValidator ID ="rfvEmail" runat ="server" ControlToValidate = "TextBox_Email" ErrorMessage ="Enter an Email ID"></asp:RequiredFieldValidator><br />
            <asp:RequiredFieldValidator ID ="rfvHouse" runat ="server" ControlToValidate = "RadioButtonList_House" ErrorMessage ="Select a house"></asp:RequiredFieldValidator><br />
            
            <asp:RangeValidator ID ="rngvClass" MaximumValue ="12" runat ="server" MinimumValue ="6" Type ="Integer" ErrorMessage = "Enter a class between 6 and 12" ControlToValidate ="TextBox_Class"></asp:RangeValidator>
            <br />
            <asp:RegularExpressionValidator id="vldEmail" runat="server" ErrorMessage="This email is missing the @ symbol." ValidationExpression=".+@.+" ControlToValidate="TextBox_Email" />
            <br />
            <asp:CustomValidator ID="vldPhone" runat="server" ErrorMessage="Enter a valid phone number" ValidateEmptyText="False" ControlToValidate="TextBox_ParentContact" onServerValidate="vldPhone_ServerValidate" />
            <br />
            <asp:ValidationSummary id="valSum" DisplayMode="BulletList" runat="server" HeaderText = "Following Fields have errors in them:"/>

        </div>
    </form>
</body>
</html>
