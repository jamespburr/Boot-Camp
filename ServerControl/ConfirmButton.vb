Imports System.Web.UI.WebControls

Public Class ConfirmButton
    Inherits System.Web.UI.WebControls.Button

    'Properties are initialized to the values required for the exercise
    Public Property ConfimMessage As String = "Are you sure?"
    Public Property OnClientConfirm As String = "alert('Page will now submit')"
    Public Property OnClientDeny As String = "alert('Page will not submit'); return false"

    ' Sets default value for OnClientClick
    Public Overrides Property OnClientClick As String
        Get
            If MyBase.OnClientClick = "" Then
                Return "if (confirm('" & ConfimMessage & "') === true) {" & OnClientConfirm & "} else {" & OnClientDeny & "}"

            Else
                Return MyBase.OnClientClick
            End If
        End Get
        Set(value As String)
            MyBase.OnClientClick = value
        End Set
    End Property




End Class


