<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="SendResults.aspx.vb" Inherits="BootCampApp.SendResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="lblFromEmail" Text="From Email" runat="server"></asp:Label>
    <asp:TextBox ID="txtFromEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblToEmail" Text="To Email" runat="server"></asp:Label>
    <asp:TextBox ID="txtToEmail" runat="server"></asp:TextBox>
    <br  />
    <asp:Button ID="btnSend" Text="Send" runat="server" />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</asp:Content>
