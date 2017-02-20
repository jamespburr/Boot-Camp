Public Class ConfirmImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            lblFilename.Text = Session("FriendlyName")
            lblDescription.Text = Session("FileDescription")
            imgUpload.ImageUrl = ConfigurationManager.AppSettings("ImageURLPath") & Session("FileName")
            imgUpload.Visible = True


        End If
    End Sub

End Class