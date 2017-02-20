Public Class ThankYou
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            lblEmployeeName.Text = Request.QueryString("Name")
            lblCompanyName.Text = Request.QueryString("Company")
            lblUserName.Text = Request.QueryString("User")
            lblAge.Text = Request.QueryString("Age")
            lblPhoneNumber.Text = Request.QueryString("Phone")
            If Request.QueryString("Existing") = "True" Then
                lblEmoloyeeType.Text = "Exisiting"
            ElseIf Request.QueryString("Existing") = "False" Then
                lblEmoloyeeType.Text = "New"
            End If
        End If
    End Sub

End Class