Public Class AddBooks
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Private Sub btnSaveBook_Click(sender As Object, e As EventArgs) Handles btnSaveBook.Click

        BootCampLibrary.AddBook(txtBook.Text, Nothing, Nothing)


    End Sub

End Class