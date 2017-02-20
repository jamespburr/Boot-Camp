<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="TelerikControlsBasic.aspx.vb" Inherits="Boot_Camp_Website.TelerikControlsBasic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <telerik:RadComboBox ID="ddlBookCategories" runat="server" CheckBoxes="true" EnableCheckAllItemsCheckBox="true"></telerik:RadComboBox>
    <br />
    <asp:Button ID="btnDisplayResults" runat="server" Text="Show Results" />
    <br />
    <asp:Label ID="lblResultsHeader" runat="server" Text="Results:"></asp:Label>
    <br />
    <asp:label ID="lblResults" runat="server"></asp:label>
    <br />
    <asp:Label ID="lblDiscount" runat="server" Text="Discount"></asp:Label><telerik:RadNumericTextBox ID="txtDiscount" runat="server" NumberFormat-DecimalDigits="0" MinValue="0" MaxValue="100" Type="Percent"></telerik:RadNumericTextBox>
     <br />
    <asp:Label ID="lblQty" runat="server" Text="Quantity"></asp:Label><telerik:RadNumericTextBox ID="txtQty" runat="server" NumberFormat-DecimalDigits="0" MinValue="0" Type="Number"></telerik:RadNumericTextBox>
     <br />
    <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label><telerik:RadNumericTextBox ID="txtPrice" runat="server" NumberFormat-DecimalDigits="2" MinValue="0" type="Currency"></telerik:RadNumericTextBox>
    <br />
    <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice" ValidationGroup="1" ErrorMessage="Please enter an updated price"></asp:RequiredFieldValidator>
    <br />
    <telerik:RadComboBox ID="ddlBooks"  runat="server" CheckBoxes="true" EnableCheckAllItemsCheckBox="true"></telerik:RadComboBox>
    <br />
    <asp:Button ID="btnUpdatePrices" runat="server" Text="Update Price" ValidationGroup="1"/>
    <br />
    <asp:Label ID="lblUpdatePrice" runat="server"></asp:Label>


</asp:Content>
