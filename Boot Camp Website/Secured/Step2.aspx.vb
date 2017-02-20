Public Class Step1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ddlColor.Items.Add(New ListItem("Choose a color", 0))
            ddlColor.Items.Add(New ListItem("Black", 1))
            ddlColor.Items.Add(New ListItem("Red", 2))
            ddlColor.Items.Add(New ListItem("Pearl White", 3))

            rblRegistration.Items.Add(New ListItem("Renewal", 1))
            rblRegistration.Items.Add(New ListItem("New", 2))

            rblpayment.Items.Add(New ListItem("Check", 1))
            rblpayment.Items.Add(New ListItem("Credit Card", 2))
            rblpayment.Items.Add(New ListItem("Cash", 3))

        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Session("Plate Number") = txtPlateNumber.Text
        Session("VIN") = txtVIN.Text
        Session("Mileage") = txtMileage.Text
        Session("Color") = ddlColor.SelectedValue

        If rblRegistration.SelectedIndex = 0 Then
            Session("Registration Type") = ""
        Else

            Session("Registration Type") = rblRegistration.SelectedItem.Text

        End If

        If rblpayment.SelectedIndex = 0 Then

            Session("Payment Type") = 0
        Else

            Session("Payment Type") = rblpayment.SelectedItem.Text

        End If

        If chkTerms.Checked = True Then
            Session("Agree") = "Yes"
        ElseIf chkTerms.Checked = False Then
            Session("Agree") = "No"
        Else
            Session("Agree") = ""
        End If
        Server.Transfer("~/Secured/Step3.aspx")
    End Sub
End Class