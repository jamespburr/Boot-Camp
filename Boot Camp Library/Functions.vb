Imports System.Net.Mail
Imports System.Globalization
Imports System.Collections.Specialized
Imports System.Configuration
Public Module Functions


    Public Function AddYear(startyear As Integer, yearRange As Integer)
        Dim intYears(yearRange - 1) As Integer
        Dim i As Integer = 0
        While i < yearRange
            intYears(i) = startyear
            startyear -= 1
            i += 1
        End While
        Return intYears
    End Function

    Public Function EmailResult(EmailFrom As String, EmailTo As String, userinfo As BootCampLibrary.User)

        Try

            Dim Smpt_Server As New SmtpClient
            Dim email As New MailMessage

            Smpt_Server.Host = "outbound01.4miles.com"

            email.From = New MailAddress(EmailFrom)
            email.To.Add(EmailTo)
            email.Subject = "Results"
            email.Body = userinfo.firstname & " " & userinfo.lastname & vbNewLine & userinfo.age & vbNewLine & userinfo.address1 & vbNewLine & userinfo.address2 & vbNewLine & userinfo.city & ", " & userinfo.state & "," & userinfo.zip & vbNewLine
            Smpt_Server.Send(email)

            Return True

        Catch error_t As Exception

            Return False

        End Try

    End Function
#Region "Country and State Lists"

    Public Function GetCountry() As List(Of String)
        Dim objcountries As New List(Of String)()
        Dim objculture As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
        For Each getculture As CultureInfo In objculture
            Dim objregion As New RegionInfo(getculture.LCID)
            If Not (objcountries.Contains(objregion.EnglishName)) Then
                objcountries.Add(objregion.EnglishName)
            End If
        Next
        objcountries.Sort()
        Return objcountries
    End Function

    Public Function GetStates() As Object

        Dim states As Array = {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"}
        Return states

    End Function
#End Region
End Module
