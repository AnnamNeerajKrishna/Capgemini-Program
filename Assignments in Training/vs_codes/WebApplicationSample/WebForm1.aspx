<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationSample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Hello"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Your Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="BtnDisplay" runat="server" OnClick="BtnDisplay_Click" Text="Display" />
        <br />
        <asp:Label ID="LbMsg" runat="server" ForeColor="Blue"></asp:Label>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
