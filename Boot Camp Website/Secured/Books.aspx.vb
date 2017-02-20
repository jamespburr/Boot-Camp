Public Class Books
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PopulateDDL()
        End If

    End Sub

    Private Sub PopulateDDL()

        ddlAllBooks.DataSource = BootCampLibrary.BookManager.GetBook()
        ddlAllBooks.DataTextField = "Title"
        ddlAllBooks.DataValueField = "BookID"
        ddlAllBooks.DataBind()

    End Sub

End Class