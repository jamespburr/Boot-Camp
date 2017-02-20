<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Books.aspx.vb" Inherits="Boot_Camp_Website.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function OpenWnd() {
            radopen("/Secured/AddBooks.aspx", "RadWindow1");
        }
        </script>

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" EnableShadow="true">
    <Windows>
        <telerik:RadWindow ID="RadWindow1" runat="server" VisibleOnPageLoad="false"
            ShowContentDuringLoad="false" Width="400px"
            Height="400px" Title="Add Book" Behaviors="Default">
        </telerik:RadWindow>
    </Windows>
</telerik:RadWindowManager>

    <telerik:RadComboBox ID="ddlAllBooks" runat="server"></telerik:RadComboBox>
    <br />
    <asp:Button ID="btnAddBook" Text="Add New Book" runat="server" OnClientClick="OpenWnd(); return false;"/>

</asp:Content>
