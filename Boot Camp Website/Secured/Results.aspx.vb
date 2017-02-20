Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            lblFirstnameResults.Text = Session("Firstname")
            lblLastnameResults.Text = Session("Lastname")
            lblAgeResults.Text = Session("Age")
            lblAddress1Results.Text = Session("Address1")
            lblAddress2Results.Text = Session("Address2")
            lblCityResults.Text = Session("City")
            lblStateResults.Text = Session("State")
            lblZipResults.Text = Session("Zip")
            Master.labelText = "Welcome " + Session("Firstname") + " " + Session("Lastname")

        End If

    End Sub

    Protected Sub btnSendResult_Click(sender As Object, e As EventArgs) Handles btnSendResult.Click

        If Session("Firstname") = "" Or Session("Lastname") = "" Then
            lblSendResult.Text = "Please enter firstname and lastname before you can send result"

        Else
            Response.Redirect("SendResults.aspx")
        End If



    End Sub
End Class