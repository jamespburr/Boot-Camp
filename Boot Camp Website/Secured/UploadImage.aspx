<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="UploadImage.aspx.vb" Inherits="Boot_Camp_Website.UploadImage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
    <script>
        function OnClientValidationFailed(sender, args) {
            var fileExtention = args.get_fileName().substring(args.get_fileName().lastIndexOf('.') + 1, args.get_fileName().length);
            if (args.get_fileName().lastIndexOf('.') != -1) {//this checks if the extension is correct
                if (sender.get_allowedFileExtensions().indexOf(fileExtention) == -1) {
                    alert("Unsupported File Type");
                }
                else {
                    alert("File is too large");
                }
            }
            else {
                alert("Unsupported File Type");
            }
        }
    </script>

    <asp:Label ID="lblFileName" Text="Enter File Name" runat="server"></asp:Label><asp:TextBox ID="txtFileName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDescription" Text="Enter Description" runat="server"></asp:Label>
    <br />
    <telerik:RadEditor ID="redDescription" runat="server"></telerik:RadEditor>
    <br />
    <telerik:RadAsyncUpload ID="ruUploadImage" runat="server" PostbackTriggers="btnSave" AllowedFileExtensions="jpg,gif" MaxFileSize="512000" Localization-Select="Select a File" InitialFileInputsCount="1" OnClientValidationFailed="OnClientValidationFailed"></telerik:RadAsyncUpload>
    <br />
    <asp:Button ID="btnSave" Text="Save" runat="server" />

</asp:Content>
