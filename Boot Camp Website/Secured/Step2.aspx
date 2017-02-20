<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Step2.aspx.vb" Inherits="Boot_Camp_Website.Step1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="PlateNumber" runat="server" Text="Plate Number"></asp:Label><asp:TextBox ID="txtPlateNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblVIN" runat="server" Text="VIN"></asp:Label><asp:TextBox ID="txtVIN" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMileage" runat="server" Text="Mileage"></asp:Label><asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblColor" runat="server" Text="Color"></asp:Label><asp:DropDownList ID="ddlColor" runat="server"></asp:DropDownList>
        <br />
        <asp:RadioButtonList ID="rblRegistration" runat="server"></asp:RadioButtonList>
        <br />
        <asp:RadioButtonList ID="rblpayment" runat="server"></asp:RadioButtonList>
        <br />
        <asp:CheckBox ID="chkTerms" runat="server" Text="I agree to all the terms and conditions" />
        <br />
        <asp:Button ID="btnBack" runat="server" Text="Cancel" />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CausesValidation="true"/>
        <asp:RequiredFieldValidator ID="rfvColor" runat="server" Display="None" ControlToValidate="ddlColor" ErrorMessage="Please choose a color" InitialValue="0" ></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cvMileage" runat="server" ControlToValidate="txtMileage" Operator="DataTypeCheck" Type="Integer" ErrorMessage="Please enter a whole number" Display="None"></asp:CompareValidator>
        <asp:ValidationSummary ID="vsSummary" runat="server" />
    </div>
</asp:Content>