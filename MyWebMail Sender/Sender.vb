Imports System.Net.Mail
Namespace MailSender
    Module MailInformation
        Public emailFrom As String
        Public emailIdentification As String
        Public emailPassword As String
        Public emailServer As String
        Public emailPort As Integer
        Public SSLEnabled As Boolean
    End Module

    Public Class OneSender

        Sub New()
            AddToLog("[OneSender]", "OneSender instance created!")
        End Sub

        Sub SendIt() 'funciona. test v0 02/09/2022 11:21 PM
            Dim MIHTML As String = Main.FastColoredTextBox1.Text 'TEXTO HTML QUE SE ENVIARA
            Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(MIHTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
            Try
                Dim MENSAJE As MailMessage = New MailMessage 'DECLARA EL MENSAJE....
                MENSAJE.AlternateViews.Add(VISTAHTML) '... Y QUE VA EN FORMATO HTML
                MENSAJE.From = New MailAddress(MailInformation.emailFrom, MailInformation.emailIdentification) 'DEFINE EL ORIGEN
                If Main.TextBox1.Text.Contains(";") Then
                    Dim correos() As String = Main.TextBox1.Text.Split(";")
                    For Each correo As String In correos
                        MENSAJE.To.Add(correo) 'DEFINE EL DESTINO
                    Next
                Else
                    MENSAJE.To.Add(Main.TextBox1.Text) 'DEFINE EL DESTINO
                End If
                MENSAJE.Subject = Main.Txb_Subject.Text 'DEFINE EL ASUNTO
                Dim MISMT As SmtpClient = New SmtpClient(MailInformation.emailServer) 'CLIENTE MAIL QUE USAMOS
                MISMT.EnableSsl = MailInformation.SSLEnabled 'SISTEMA DE SEGURIDAD
                MISMT.Port = MailInformation.emailPort
                MISMT.Credentials = New Net.NetworkCredential(MailInformation.emailFrom, MailInformation.emailPassword) 'CREDENCIALES DEL ORIGEN
                MISMT.Send(MENSAJE) 'ENVIA
                MsgBox("Email sended succefully!", MsgBoxStyle.Information, "OneSender")
                AddToLog("[OneSender]", "Email sended succefully!")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "One Sender")
                AddToLog("[SendIt@MailSender::OneSender]", "Error: " & ex.Message, True)
            End Try
        End Sub
    End Class

    Public Class ManySender

        Sub New()
            AddToLog("[ManySender]", "ManySender instance created!")
        End Sub


    End Class

End Namespace