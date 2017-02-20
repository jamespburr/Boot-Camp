Imports System.Net.Mail

Public Module Email

    Public Function EmailResult(emailFrom As String, emailTo As String, user As BootCampLibrary.User)

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(emailFrom)
            e_mail.To.Add(emailTo)
            e_mail.Subject = "User Info"
            e_mail.IsBodyHtml = False
            e_mail.Body = "User Name: " & user.firstname & " " & user.lastname & "Age: " & user.age & "Address: " & user.address1 & " " & user.address2 & ", " & user.city & ", " & user.state & ", " & user.zip
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try



    End Function


End Module
