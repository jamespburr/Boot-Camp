<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Step3.aspx.vb" Inherits="BootCampApp.Step3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="lblOwnerName" runat="server" Text="Owner Name"></asp:Label><asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox>
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
        <asp:Label id="lblMake" runat="server" Text="Make"></asp:Label><asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
        <br />
        <asp:Label id="lblModel" runat="server" Text="Model"></asp:Label><asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        <br />
        <asp:Label id="lblYear" runat="server" Text="Year"></asp:Label><asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="PlateNumber" runat="server" Text="Plate Number"></asp:Label><asp:TextBox ID="txtPlateNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblVIN" runat="server" Text="VIN"></asp:Label><asp:TextBox ID="txtVIN" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMileage" runat="server" Text="Mileage"></asp:Label><asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblColor" runat="server" Text="Color"></asp:Label><asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblRegistration" runat="server" Text="Registration Type"></asp:Label><asp:TextBox ID="txtRegistration" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPayment" runat="server" Text="Payment Type"></asp:Label><asp:TextBox ID="txtPayment" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAgree" runat="server" Text="Agreed to Terms?"></asp:Label><asp:TextBox ID="txtAgreed" runat="server"></asp:TextBox>
    </div>
</asp:Content>
