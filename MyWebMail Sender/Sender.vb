Imports System.Net.Mail

Namespace Sender

    Public Class OneSender

        Sub New()
            Console.WriteLine("OneSender instance created!")
        End Sub

        Sub SendIt()
            Dim MIHTML As String = Main.FastColoredTextBox1.Text 'TEXTO HTML QUE SE ENVIARA
            Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(MIHTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
            Try
                Dim MENSAJE As MailMessage = New MailMessage 'DECLARA EL MENSAJE....
                MENSAJE.AlternateViews.Add(VISTAHTML) '... Y QUE VA EN FORMATO HTML
                MENSAJE.From = New MailAddress(EmailList.emailFrom, EmailList.emailIdentification) 'DEFINE EL ORIGEN
                MENSAJE.To.Add(ToEmailList.emailTo) 'DEFINE EL DESTINO
                MENSAJE.Subject = Main.Txb_Subject.Text 'DEFINE EL ASUNTO
                Dim MISMT As SmtpClient = New SmtpClient(EmailList.emailServer) 'CLIENTE MAIL QUE USAMOS
                MISMT.EnableSsl = EmailList.SSLEnabled 'SISTEMA DE SEGURIDAD
                MISMT.Port = EmailList.emailPort
                MISMT.Credentials = New Net.NetworkCredential(EmailList.emailFrom, EmailList.emailPassword) 'CREDENCIALES DEL ORIGEN
                MISMT.Send(MENSAJE) 'ENVIA
                MsgBox("Email sended succefully!", MsgBoxStyle.Information, "OneSender")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "One Sender")
            End Try
        End Sub

    End Class

    Public Class ManySender

        Sub New()
            Console.WriteLine("ManySender instance created!")
        End Sub


    End Class

End Namespace