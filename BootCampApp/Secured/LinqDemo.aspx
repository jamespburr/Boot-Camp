<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="LinqDemo.aspx.vb" Inherits="BootCampApp.LinqDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:DropDownList ID="ddlQuerySelect" runat="server" AutoPostBack="true"></asp:DropDownList>
    <asp:Label ID="lblParam1" runat="server" Visible="false"></asp:Label><asp:TextBox ID="txtParam1" runat="server" Visible="false"></asp:TextBox><asp:DropDownList ID="ddlParamList" runat="server" Visible="false"></asp:DropDownList>
    <asp:Label ID="lblParam2" runat="server" Visible="false"></asp:Label><telerik:RadNumericTextBox ID="txtParam2" runat="server" NumberFormat-DecimalDigits="2" Type="Currency" Visible="false"></telerik:RadNumericTextBox><asp:DropDownList ID="ddlParamList2" runat="server" Visible="false"></asp:DropDownList>
    <asp:Label ID="lblParam3" runat="server" Visible="false"></asp:Label><asp:TextBox ID="txtParam3" runat="server" Visible="false"></asp:TextBox>
    <asp:Button ID="btnRunQuery" Text="Run Query" runat="server" />
    <br />
    <telerik:RadGrid ID="rgResults" runat="server"></telerik:RadGrid>   
    <asp:RequiredFieldValidator ID="rfvParam1" ControlToValidate="txtParam1" runat="server" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="rfvParam2" ControlToValidate="txtParam2" runat="server" Display="None"></asp:RequiredFieldValidator>
    <asp:ValidationSummary ID="vsSummary" runat="server" />
</asp:Content>
