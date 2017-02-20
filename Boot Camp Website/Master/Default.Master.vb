Public Class Site1
    Inherits System.Web.UI.MasterPage

    Public Property labelText As String
        Get
            Return lblWelcome.Text
        End Get
        Set(value As String)
            lblWelcome.Text = value
        End Set


    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblWelcome.Text = "Welcome " & Session("Firstname") & " " & Session("Lastname")
        'Server.Transfer("~/Secured/Main.aspx")

    End Sub

    Protected Sub lnkLogout_Click(sender As Object, e As EventArgs) Handles lnkLogout.Click
        FormsAuthentication.SignOut()
        Response.Redirect("~/Unsecured/Login.aspx")
    End Sub
End Class