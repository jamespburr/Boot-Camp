Public Class TelerikControlsBasic
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PopulateDDL()
        End If
    End Sub



    Private Sub PopulateDDL()
        ddlBookCategories.DataSource = BootCampLibrary.CategoryManager.GetCategory()
        ddlBookCategories.DataTextField = "CategoryName"
        ddlBookCategories.DataValueField = "CategoryID"
        ddlBookCategories.DataBind()

        ddlBooks.DataSource = BootCampLibrary.BookManager.GetBook()
        ddlBooks.DataTextField = "Title"
        ddlBooks.DataValueField = "BookID"
        ddlBooks.DataBind()

    End Sub

    Private Sub DisplayResults()

        For Each c As Telerik.Web.UI.RadComboBoxItem In ddlBookCategories.Items

            If c.Checked = True Then
                lblResults.Text = lblResults.Text & c.Text & ", "

            End If
        Next

        lblResults.Text = lblResults.Text.Trim({" "c, ","c})

    End Sub

    Private Function UpdatePrices()
        Try
            Using ctx As New DataLibrary.jburrowsEntities

                For Each l As Telerik.Web.UI.RadComboBoxItem In ddlBooks.Items
                    If l.Checked = True Then
                        Dim book As DataLibrary.Book = (From b As DataLibrary.Book In ctx.Books
                                                         Select b
                                                         Where b.BookID = l.Value).FirstOrDefault

                        book.Price = txtPrice.Text

                        ctx.SaveChanges()

                    End If
                Next

            End Using
        Catch e As Exception
            Return False
        End Try
        Return True

    End Function

    Private Sub btnDisplayResults_Click(sender As Object, e As EventArgs) Handles btnDisplayResults.Click
        DisplayResults()
    End Sub

    Private Sub btnUpdatePrices_Click(sender As Object, e As EventArgs) Handles btnUpdatePrices.Click
        lblUpdatePrice.Text = ""
        If UpdatePrices() = True Then
            lblUpdatePrice.Text = "Price has been updated for the selected books"
        Else
            lblUpdatePrice.Text = "Price was not updated"
        End If
    End Sub
End Class
