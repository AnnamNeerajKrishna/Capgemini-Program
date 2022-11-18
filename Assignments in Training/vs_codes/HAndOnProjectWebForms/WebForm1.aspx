<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HAndOnProjectWebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Namelb" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTxt" Display="Dynamic" ErrorMessage="*Requried Field"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="PhNumberLb" runat="server" Text="PhoneNumber"></asp:Label>
&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PhNumberTxt" runat="server" OnTextChanged="PhNumberTxt_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PhNumberTxt" Display="Dynamic" ErrorMessage="*Requried Field" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PhNumberTxt" Display="Dynamic" ErrorMessage="Incorrect Phone Number. Use The Following Formate 999-999-9999" SetFocusOnError="True" ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$"></asp:RegularExpressionValidator>
        <p>
            <asp:Label ID="EamilIdLb" runat="server" Text="EmailId"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="EmailIdTxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="EmailIdTxt" Display="Dynamic" ErrorMessage="*Requried Field"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="EmailIdTxt" Display="Dynamic" ErrorMessage="Incorrect Email Address Formate" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="MinPriceLb" runat="server" Text="MinPrice"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="MinPriceTxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="MinPriceTxt" Display="Dynamic" ErrorMessage="*Requried Field"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="MinPriceTxt" Display="Dynamic" ErrorMessage="Has to be an integer and greater than 0" SetFocusOnError="True" ValidationExpression="^[1-9][0-9]*$"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="MaxPriceLb" runat="server" Text="MaxPrice"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="MaxPriceTxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="MaxPriceTxt" Display="Dynamic" ErrorMessage="*Requried Field"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="MaxPriceTxt" Display="Dynamic" ErrorMessage="Has to be an integer and greater than 0" SetFocusOnError="True" ValidationExpression="^[1-9][0-9]*$"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="MinPriceTxt" ControlToValidate="MaxPriceTxt" Display="Dynamic" ErrorMessage="Maximum price should be greater than minimum price" Operator="GreaterThan" Type="Integer"></asp:CompareValidator>
        </p>
        <p class="auto-style1">
            <asp:Button ID="SubmitBt" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dashed" />
    </form>
</body>
</html>
