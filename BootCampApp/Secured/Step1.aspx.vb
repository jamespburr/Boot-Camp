Public Class Step1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ddlMake.Items.Add(New ListItem("Choose Make", 0))
            ddlMake.Items.Add(New ListItem("BMW", 1))
            ddlMake.Items.Add(New ListItem("Acura", 2))
            ddlMake.SelectedIndex = 0
            Dim years() As Integer
            years = BootCampLibrary.AddYear(2016, ConfigurationManager.AppSettings("AddYearRange"))
            ddlYear.DataSource = years
            ddlYear.DataBind()

        End If

    End Sub

    Private Sub ddlMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlMake.SelectedIndexChanged
        ddlModel.Items.Clear()
        If ddlMake.SelectedValue = 1 Then
            ddlModel.Items.Add(New ListItem("X5", 1))
            ddlModel.Items.Add(New ListItem("X6", 2))
            ddlModel.Items.Add(New ListItem("M3Ci", 3))
            ddlModel.Items.Add(New ListItem("M6Ci", 4))
        ElseIf ddlMake.SelectedValue = 2 Then
            ddlModel.Items.Add(New ListItem("Model 1", 5))
            ddlModel.Items.Add(New ListItem("Model 2", 6))
            'End If
            'ElseIf ddlMake.SelectedValue = 3 Then

            'Else

        End If
        'if
        'else
        '''''if

        '''''endif    
        'end if
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtOwnerName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        ddlMake.SelectedIndex = 0
        ddlMake.Items.Clear()
        ddlYear.SelectedIndex = 0
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Session("Owner Name") = txtOwnerName.Text
        Session("Address") = txtAddress.Text
        Session("City") = txtCity.Text
        Session("State") = txtState.Text
        Session("Zip") = txtZip.Text
        Session("Email") = txtEmail.Text
        Session("Phone Number") = txtPhoneNumber.Text
        If ddlMake.SelectedIndex = 0 Then
            Session("Make") = ""
            Session("Model") = ""
        Else
            Session("Make") = ddlMake.SelectedItem.Text
            Session("Model") = ddlModel.SelectedItem.Text
        End If
        Session("Year") = ddlYear.SelectedValue
        Response.Redirect("~/Secured/Step2.aspx")
    End Sub

End Class