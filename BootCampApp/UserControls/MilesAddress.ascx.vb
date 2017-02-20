Imports System.Web
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Public Class MilesAddress
    Inherits System.Web.UI.UserControl

    Public Property showCountry As Boolean = True
    Public Property required As Boolean = True
    Public country As String
    Public state As String

#Region "Control Load"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        HideCountry(showCountry)
        RequiredFields(required)

        If Not Page.IsPostBack Then
            PopulateDDL()
        End If


    End Sub

#End Region

#Region "Hidden and Required Fields"

    Public Sub HideCountry(showCountry As Boolean)

        If showCountry = False Then
            lblCountry.Visible = False
            ddlCountry.Visible = False
            rfvCountry.Enabled = False
        End If

    End Sub

    Public Sub RequiredFields(required As Boolean)
        If required = False Then
            rfvAddress1.Enabled = False
            rfvCity.Enabled = False
            rfvCountry.Enabled = False
            rfvState.Enabled = False
            rfvZip.Enabled = False
        End If
    End Sub

#End Region

#Region "Populate DDLs"
    Public Function GetAddress()
        Dim address As String
        address = txtAddress1.Text & vbNewLine & txtAddress2.Text & vbNewLine & txtCity.Text & ", " & ddlState.SelectedValue & ", " & txtZip.Text & vbNewLine & country
        Return address
    End Function

    Private Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCountry.SelectedIndexChanged

        country = ddlCountry.SelectedValue
        If ddlCountry.SelectedValue = "United States" Then
            ddlState.DataSource = BootCampLibrary.GetStates()
            ddlState.DataBind()
        End If
    End Sub

    Private Sub PopulateDDL()

        ddlCountry.DataSource = BootCampLibrary.GetCountry()
        ddlCountry.DataBind()


    End Sub

    'Private Sub ddlState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlState.SelectedIndexChanged
    '    state = ddlState.SelectedValue
    'End Sub

#End Region

End Class