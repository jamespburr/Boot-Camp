<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Step1.aspx.vb" Inherits="BootCampApp.Step1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlStep1" runat="server">
        <asp:Label ID="lblOwnerName" runat="server" Text="Owner Name"></asp:Label><asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox>
        <br />
        
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label><asp:TextBox ID="txtState" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label><asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />
        
        <br />
        <asp:Label id="lblMake" runat="server" Text="Make"></asp:Label><asp:DropDownList ID="ddlMake" runat="server"  AutoPostBack="true"></asp:DropDownList>
        <br />
        <asp:Label id="lblModel" runat="server" Text="Model"></asp:Label><asp:DropDownList ID="ddlModel" runat="server"></asp:DropDownList>
        <br />
        <asp:Label id="lblYear" runat="server" Text="Year"></asp:Label><asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="btnNext" runat="server" Text="Next" CausesValidation="true" />
        <br />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false"/>
        <asp:RequiredFieldValidator ID="rfOwnerName" runat="server" ControlToValidate="txtOwnerName"  ErrorMessage="Please enter a name" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Enter a valid phone number" ValidationExpression="^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}$" Display="None"></asp:RegularExpressionValidator>
        <asp:ValidationSummary runat="server" />
    </asp:Panel>
</asp:Content>
