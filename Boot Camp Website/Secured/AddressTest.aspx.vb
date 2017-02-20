Public Class AddressTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnPrintAddress_Click(sender As Object, e As EventArgs) Handles btnPrintAddress.Click
        lblAddress.Text = addr.GetAddress
    End Sub
End Class