Public Class UploadImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub




    Private Sub ruUploadImage_FileUploaded(sender As Object, e As Telerik.Web.UI.FileUploadedEventArgs) Handles ruUploadImage.FileUploaded


        Dim target As String = Server.MapPath(ConfigurationManager.AppSettings("ImageURLPath"))
        Dim file As Telerik.Web.UI.UploadedFile = e.File
        Try

            'The AddFile function returns the custom filename which appends the fileID to the file name
            Dim filename As String = BootCampLibrary.LinqQueries.AddFile(txtFileName.Text, e.File.FileName, redDescription.Text)

            e.File.SaveAs(target & filename)



            Session("FriendlyName") = txtFileName.Text
            Session("FileDescription") = redDescription.Text
            Session("FileName") = filename
        Catch e As Exception
        End Try
        Response.Redirect("~/Secured/ConfirmImage.aspx")

    End Sub
End Class