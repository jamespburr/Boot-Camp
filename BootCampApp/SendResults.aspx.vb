Public Class SendResults
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim userInfo As New BootCampLibrary.User

        userInfo.firstname = Session("Firstname")
        userInfo.lastname = Session("Lastname")
        userInfo.age = Session("Age")
        userInfo.address1 = Session("Address1")
        userInfo.address2 = Session("Address2")
        userInfo.city = Session("City")
        userInfo.state = Session("State")
        userInfo.zip = Session("Zip")


        lblResult.Text = BootCampLibrary.EmailResult(txtFromEmail.Text, txtToEmail.Text, userInfo)


    End Sub

End Class