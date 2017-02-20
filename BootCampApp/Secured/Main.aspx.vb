Public Class Main
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub




    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Session("Firstname") = txtFirstname.Text
        Session("Lastname") = txtLastname.Text
        Session("Age") = txtAge.Text
        Session("Address1") = txtAddress.Text
        Session("Address2") = txtAddress2.Text
        Session("City") = txtCity.Text
        Session("State") = txtState.Text
        Session("Zip") = txtZip.Text

        Response.Redirect("~/Secured/Results.aspx")
    End Sub

End Class