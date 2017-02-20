<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="AddressTest.aspx.vb" Inherits="BootCampApp.AddressTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
    <miles:Address ID="addr" runat="server" required="false" ></miles:Address>
    <asp:Button ID="btnPrintAddress" runat="server" Text="Print Address" />
    <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlTest" runat="server" AutoPostBack="true">
                <asp:ListItem Text="test1">
                </asp:ListItem>
                <asp:ListItem Text="test2"></asp:ListItem>
            </asp:DropDownList>
    </div>
</asp:Content>
