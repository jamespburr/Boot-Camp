<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="BootCampApp.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form runat="server">
     
    <asp:Label ID="lblUserName" runat="server" Text="Username:"></asp:Label><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" Text="Login" />
     <asp:LinkButton ID="lnkLogout" runat="server"  Text="Logout"></asp:LinkButton>
    <asp:Label ID="lblInvalid" runat="server" Text="Invalid Login. Try Again" Font-Bold="true" ForeColor="Red" Visible="false"></asp:Label>
</form>
</body>
</html>