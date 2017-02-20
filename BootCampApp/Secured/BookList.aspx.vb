Imports Telerik.Web.UI

Public Class BookList
    Inherits System.Web.UI.Page

    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub rlvBooks_ItemDataBound(sender As Object, e As Telerik.Web.UI.RadListViewItemEventArgs) Handles rlvBooks.ItemDataBound

        If TypeOf e.Item Is RadListViewDataItem Then
            Dim item As RadListViewDataItem = CType(e.Item, RadListViewDataItem)
            Dim b As DataLibrary.Book = CType(item.DataItem, DataLibrary.Book)

            Dim lblISBN As Label = TryCast(e.Item.FindControl("lblISBN"), Label)
            lblISBN.Text = b.ISBN
            Dim lblTitle As Label = TryCast(e.Item.FindControl("lblTitle"), Label)
            lblTitle.Text = b.Title
            Dim lblDescription As Label = TryCast(e.Item.FindControl("lblDescription"), Label)
            lblDescription.Text = b.Description
            Dim lblQuantity As Label = TryCast(e.Item.FindControl("lblQuantity"), Label)
            lblQuantity.Text = b.QuantityOnHand
            Dim lblCost As Label = TryCast(e.Item.FindControl("lblCost"), Label)
            lblCost.Text = b.Cost.ToString()
            Dim lblPrice As Label = TryCast(e.Item.FindControl("lblPrice"), Label)
            lblPrice.Text = b.Price


        End If
    End Sub

    Private Sub rlvBooks_NeedDataSource(sender As Object, e As Telerik.Web.UI.RadListViewNeedDataSourceEventArgs) Handles rlvBooks.NeedDataSource
        rlvBooks.DataSource = BootCampLibrary.BookManager.GetBooks()
    End Sub


End Class
