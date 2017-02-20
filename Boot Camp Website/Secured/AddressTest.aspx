<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="AddressTest.aspx.vb" Inherits="Boot_Camp_Website.AddressTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <miles:Address ID="addr" runat="server" ></miles:Address>
    <asp:Button ID="btnPrintAddress" runat="server" Text="Print Address" />
    <asp:Label ID="lblAddress" runat="server"></asp:Label>
    </div>
</asp:Content>
