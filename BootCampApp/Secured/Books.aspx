<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="Books.aspx.vb" Inherits="BootCampApp.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function OpenWnd() {
            radopen("/Secured/AddBooks.aspx", "RadWindow1");
        }

        
        </script>
            <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
            <script type="text/javascript">

                function InitiateAjaxRequest() {
                    var ajaxManager = $find("<%= ramManager.ClientID%>");
                    ajaxManager.ajaxRequest();
                }
            </script>
        </telerik:RadCodeBlock>

    <telerik:RadAjaxManager ID="ramManager" runat="server" >
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ramManager">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ddlAllBooks" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>

    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" EnableShadow="true">
    <Windows>
        <telerik:RadWindow ID="RadWindow1" runat="server" VisibleOnPageLoad="false" OnClientClose="InitiateAjaxRequest"
            ShowContentDuringLoad="false" Width="400px"
            Height="400px" Title="Add Book" Behaviors="Default">
        </telerik:RadWindow>
    </Windows>
</telerik:RadWindowManager>

    <telerik:RadComboBox ID="ddlAllBooks" runat="server"></telerik:RadComboBox><asp:LinkButton ID="btnEditInfo" Text="Edit Description" runat="server"></asp:LinkButton>
    <br />
    <%-- This is invisible --%>
    <telerik:RadEditor ID="redDescription" runat="server" Visible="false"></telerik:RadEditor>
    <asp:Button ID="btnSaveDescription" runat="server" Text="Save Changes" Visible="false" />
    <br />
    <asp:Button ID="btnAddBook" Text="Add New Book" runat="server" OnClientClick="OpenWnd(); return false;"/>
</asp:Content>
