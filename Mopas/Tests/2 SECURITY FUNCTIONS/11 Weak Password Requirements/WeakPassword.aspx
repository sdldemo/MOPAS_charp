<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeakPassword.aspx.cs" Inherits="Mopas.Tests.WeakPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextUsername" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextPassword" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
