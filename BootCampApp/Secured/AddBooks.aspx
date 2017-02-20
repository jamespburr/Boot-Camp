<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddBooks.aspx.vb" Inherits="BootCampApp.AddBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblBook" runat="server" Text="Enter Book:"></asp:Label><asp:TextBox ID="txtBook" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSaveBook" runat="server" Text="Save Book"  OnClientClick="window.close();"/>

    </div>
    </form>
</body>
</html>
