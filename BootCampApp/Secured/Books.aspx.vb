Public Class Books
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PopulateDDL()
        End If

    End Sub

    Private Sub PopulateDDL()

        ddlAllBooks.DataSource = BootCampLibrary.BookManager.GetBooks()
        ddlAllBooks.DataTextField = "Title"
        ddlAllBooks.DataValueField = "BookID"
        ddlAllBooks.DataBind()

    End Sub



    Private Sub ramManager_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles ramManager.AjaxRequest

        PopulateDDL()

    End Sub

    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        If redDescription.Visible = True Then
            redDescription.Visible = False
            btnSaveDescription.Visible = False
        Else
            redDescription.Visible = True
            btnSaveDescription.Visible = True
        End If
    End Sub

    Private Sub btnSaveDescription_Click(sender As Object, e As EventArgs) Handles btnSaveDescription.Click


        Dim book As DataLibrary.Book = BootCampLibrary.BookManager.GetBookByID(ddlAllBooks.SelectedValue)
        book.Description = redDescription.Content

        Using ctx As New DataLibrary.jburrowsEntities
            ctx.Books.Attach(book)
            ctx.SaveChanges()


        End Using



    End Sub
End Class