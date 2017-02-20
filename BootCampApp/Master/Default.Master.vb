Public Class _Default1
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
        If Not Page.IsPostBack Then
            lblWelcome.Text = "Welcome " & Session("Firstname") & " " & Session("Lastname")
            'Server.Transfer("~/Secured/Main.aspx")
            rmMasterMenu.LoadContentFile("~/XML/Menu.xml")
        End If


    End Sub

    Protected Sub lnkLogout_Click(sender As Object, e As EventArgs) Handles lnkLogout.Click
        FormsAuthentication.SignOut()
        Response.Redirect("~/Unsecured/Login.aspx")
    End Sub

End Class