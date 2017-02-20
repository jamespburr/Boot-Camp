<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Results.aspx.vb" Inherits="BootCampApp.Results" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
        <asp:Label ID="lblFirstname" Text="Firstname" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblFirstnameResults" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblLastname" Text="Lastname" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblLastnameResults" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAge" Text="Age" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAgeResults" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAddress1" Text="Address 1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAddress1Results" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAddress2" Text="Address 2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAddress2Results" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblCity" Text="City" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblCityResults" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblState" Text="State" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblStateResults" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblZip" Text="Zip Code" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblZipResults" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnSendResult" Text="Send Result" runat="server" />
        <br />
        <asp:Label ID="lblSendResult" runat="server"></asp:Label>
</asp:Content>
