<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Main.aspx.vb" Inherits="BootCampApp.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:Label ID="lblFirstname" Text="Firstname" runat="server"></asp:Label><asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastname" Text="Lastname" runat="server"></asp:Label><asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAge" Text="Age" runat="server"></asp:Label><asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress1" Text="Address 1" runat="server"></asp:Label><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress2" Text="Address 2" runat="server"></asp:Label><asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCity" Text="City" runat="server"></asp:Label><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lclState" Text="State" runat="server"></asp:Label><asp:TextBox ID="txtState" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblZip" Text="Zip Code" runat="server"></asp:Label><asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
</asp:Content>
