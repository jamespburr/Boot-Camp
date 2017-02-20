<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="ConfirmButtonTest.aspx.vb" Inherits="Boot_Camp_Website.ConfirmButtonTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <miles:ConfirmButton ID="btnConfirm" runat="server" Text="confirm" />
    </div>
</asp:Content>
