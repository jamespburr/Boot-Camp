Imports System.Collections.Specialized
Imports System.Configuration
Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'txtUserName.Text = ConfigurationManager.AppSettings("App.Username")
        'txtPassword.Text = ConfigurationManager.AppSettings("App.Password")

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text = ConfigurationManager.AppSettings("App.Username") And txtPassword.Text = ConfigurationManager.AppSettings("App.Password") Then

            FormsAuthentication.RedirectFromLoginPage(ConfigurationManager.AppSettings("App.Username"), True)
        Else
            lblInvalid.Visible = True

        End If


    End Sub

    Private Sub lnkLogout_Click(sender As Object, e As EventArgs) Handles lnkLogout.Click
        FormsAuthentication.SignOut()
    End Sub

End Class