<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="MilesAddress.ascx.vb" Inherits="BootCampApp.MilesAddress" %>
<div>
<asp:Label ID="lblAddress1" runat="server" Text="Address 1"></asp:Label><asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1" ErrorMessage="Please enter an Address"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="lblAddress2" runat="server" Text="Address 2"></asp:Label><asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblCity" runat="server" Text="City"></asp:Label><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="Please enter a City"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label><asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true"></asp:DropDownList>
<asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="ddlCountry" ErrorMessage="Please select a country"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="lblState" runat="server" Text="State"></asp:Label><asp:DropDownList ID="ddlState" runat="server"></asp:DropDownList>
<asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="ddlState" ErrorMessage="Please select a State"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label><asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvZip" runat="server" ControlToValidate="txtZip" ErrorMessage="Please enter a zip code"></asp:RequiredFieldValidator>
</div>