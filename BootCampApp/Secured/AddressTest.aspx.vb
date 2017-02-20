Imports System.Web.Optimization
Public Class AddressTest

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

        End If
    End Sub

    Private Sub btnPrintAddress_Click(sender As Object, e As EventArgs) Handles btnPrintAddress.Click
        lblAddress.Text = addr.GetAddress
    End Sub

    Private Sub ddlTest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTest.SelectedIndexChanged
        addr.required = True
    End Sub
End Class