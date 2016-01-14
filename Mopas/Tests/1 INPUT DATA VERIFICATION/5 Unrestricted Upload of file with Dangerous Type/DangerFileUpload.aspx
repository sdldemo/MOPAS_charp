<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangerFileUpload.aspx.cs" Inherits="Mopas.Tests.DangerFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" onchange="if (confirm('Upload ' + this.value + '?')) this.form.submit();" />
    </div>
    </form>
</body>
</html>
