<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="BookList.aspx.vb" Inherits="BootCampApp.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadListView ID="rlvBooks" runat="server" RenderMode="Lightweight">
<ItemTemplate>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblTagISBN" runat="server" Text="ISBN"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblISBN" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">   
            <div class="col-md-1">
                <asp:Label ID="lblTagTitle" runat="server" Text="Title"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblTitle" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblTagDescription" runat="server" Text="Description"></asp:Label>
            </div>
            <div class="col-md-11">
                <asp:Label ID="lblDescription" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblTagQuantity" runat="server" Text="Quantity"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblQuantity" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblTagCost" runat="server" Text="Cost"></asp:Label>
            </div>
            <div class="col-md-2">
                <label id="lblCost" runat="server"></label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblTagPrice" runat="server" Text="Price"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:Label id="lblPrice" runat="server"></asp:Label>
            </div>
        </div>
    </div> 

<br />  
</ItemTemplate>
    </telerik:RadListView>
</asp:Content>
