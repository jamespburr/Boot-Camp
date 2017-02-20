Imports System.Net

Public Class EmployeeRegistration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            rblEmployeeType.Items.Add(New ListItem("Exisiting Employee", 1))
            rblEmployeeType.Items.Add(New ListItem("New Employee", 2))


        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim employeename As String
        Dim companyName As String
        Dim userName As String
        Dim age As Integer
        Dim phoneNumber As String
        Dim exisitingEmployee As Boolean

        employeename = txtEmployeeName.Text
        companyName = txtCompanyName.Text
        userName = txtUserName.Text
        age = txtAge.Text
        phoneNumber = txtPhoneNumber.Text


        If rblEmployeeType.SelectedValue = 1 Then
            exisitingEmployee = True
        ElseIf rblEmployeeType.SelectedValue = 2 Then
            exisitingEmployee = False

        End If

        Response.Redirect("ThankYou.aspx?Name=" & employeename & "&Company=" & companyName & "&User=" + userName & "&Age=" & age & "&Phone=" & phoneNumber & "&Existing=" & exisitingEmployee)


    End Sub




    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtEmployeeName.Text = ""
        txtCompanyName.Text = ""
        txtUserName.Text = ""
        txtAge.Text = ""
        txtPhoneNumber.Text = ""
        rblEmployeeType.ClearSelection()


    End Sub
End Class