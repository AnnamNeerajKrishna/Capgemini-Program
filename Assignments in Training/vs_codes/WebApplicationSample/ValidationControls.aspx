<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="WebApplicationSample.ValidationControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #0000CC;
        }
        .auto-style2 {
            font-size: medium;
            background-color: #FFFFCC;
        }
        .auto-style3 {
            font-size: medium;
            height: 26px;
            text-align: center;
            color: #000000;
            background-color: #FFFFCC;
        }
        .auto-style4 {
            font-size: medium;
            width: 305px;
            color: #000000;
            background-color: #FFFFCC;
        }
        .auto-style5 {
            font-size: medium;
            width: 305px;
            height: 26px;
            color: #000000;
            background-color: #FFFFCC;
        }
        .auto-style6 {
            font-size: medium;
            height: 26px;
            background-color: #FFFFCC;
        }
        .auto-style7 {
            font-size: medium;
            width: 305px;
            height: 26px;
            text-align: center;
            background-color: #FFFFCC;
        }
        .auto-style8 {
            font-size: medium;
            color: #000000;
            height: 73px;
            background-color: #FFFFCC;
        }
        .auto-style9 {
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Validation Controls Demo</strong></div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style3" colspan="2">Registration Form</td>
            </tr>
            <tr>
                <td class="auto-style5">Enter Username :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="User sholud not be empty" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Enter Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="password must not be empty" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Re-Enter Passord</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldAValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Both password should be same" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Enter Age</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Age should not be empty" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Enter Email-Id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox1" ErrorMessage="Email should not be empty" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style9"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
