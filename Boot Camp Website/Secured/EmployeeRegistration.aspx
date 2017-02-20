<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="EmployeeRegistration.aspx.vb" Inherits="Boot_Camp_Website.EmployeeRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblEmployeeName" runat="server" Text="Employee Name (Required)"></asp:Label><asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name (Required)"></asp:Label><asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserName" runat="server" Text="User Name (Required)"></asp:Label><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAge" runat="server" Text="Age (Required)"></asp:Label><asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone#"></asp:Label><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButtonList ID="rblEmployeeType" runat="server">
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false"/>
        <asp:RequiredFieldValidator ID="rfvEmployeeName" runat="server" ControlToValidate="txtEmployeeName" ErrorMessage="Please enter an employee name" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" ControlToValidate="txtCompanyName" ErrorMessage="Please enter a company name" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfvUSerName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please enter a user name" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfvage" runat="server" ControlToValidate="txtAge" ErrorMessage="Please enter your age" Display="None"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvAge"  runat="server" ControlToValidate="txtAge" ErrorMessage="Registration is only available for ages 18-60" MaximumValue="60" MinimumValue="18" Type="Integer" Display="None"></asp:RangeValidator>
        <asp:RegularExpressionValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Enter a valid phone number" ValidationExpression="^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}$" Display="None"></asp:RegularExpressionValidator>
        <asp:ValidationSummary ID="vsSummary" runat="server" />

    </div>
</asp:Content>