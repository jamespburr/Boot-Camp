<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="ConfirmImage.aspx.vb" Inherits="Boot_Camp_Website.ConfirmImage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblFilename" runat="server"></asp:Label>
    <br />
    <asp:Label id="lblDescription" runat="server"></asp:Label>
    <%--Remember this is invisible --%>
    <asp:Image ID="imgUpload" runat="server" Visible="false" />
    
</asp:Content>
