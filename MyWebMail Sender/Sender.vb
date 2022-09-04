Imports System.Net.Mail
Namespace MailSender
    Module MailInformation
        Public emailID As Integer = -1
        Public emailFrom As String
        Public emailIdentification As String
        Public emailPassword As String
        Public emailServer As String
        Public emailPort As Integer
        Public SSLEnabled As Boolean
    End Module

    Public Class OneSender
        Dim subject, message, toAddress, bccAddress, ccAddress As String
        Sub New(ByVal subject As String, ByVal message As String, ByVal toAddress As String, ByVal bccAddress As String, ByVal ccAddress As String)
            Me.subject = subject
            Me.message = message
            Me.toAddress = toAddress
            Me.bccAddress = bccAddress
            Me.ccAddress = ccAddress
            AddToLog("OneSender", "OneSender instance created!")
        End Sub

        Sub SendIt() 'funciona. test v4 04/09/2022 03:01 AM
            Dim MIHTML As String = message 'TEXTO HTML QUE SE ENVIARA
            Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(MIHTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
            Try
                Dim MENSAJE As MailMessage = New MailMessage 'DECLARA EL MENSAJE....
                MENSAJE.AlternateViews.Add(VISTAHTML) '... Y QUE VA EN FORMATO HTML
                MENSAJE.From = New MailAddress(MailInformation.emailFrom, MailInformation.emailIdentification) 'DEFINE EL ORIGEN
                If toAddress.Contains(";") Then
                    Dim correos() As String = toAddress.Split(";")
                    For Each correo As String In correos
                        MENSAJE.To.Add(correo) 'DEFINE EL DESTINO
                    Next
                Else
                    MENSAJE.To.Add(toAddress) 'DEFINE EL DESTINO
                End If
                If bccAddress <> Nothing Then
                    If bccAddress.Contains(";") Then
                        Dim correos() As String = bccAddress.Split(";")
                        For Each correo As String In correos
                            MENSAJE.Bcc.Add(correo) 'DEFINE EL DESTINO CON COPIA OCULTO
                        Next
                    Else
                        MENSAJE.Bcc.Add(bccAddress) 'DEFINE EL DESTINO CON COPIA OCULTO
                    End If
                End If
                If ccAddress <> Nothing Then
                    If ccAddress.Contains(";") Then
                        Dim correos() As String = ccAddress.Split(";")
                        For Each correo As String In correos
                            MENSAJE.CC.Add(correo) 'DEFINE EL DESTINO CON COPIA
                        Next
                    Else
                        MENSAJE.CC.Add(ccAddress) 'DEFINE EL DESTINO CON COPIA
                    End If
                End If
                MENSAJE.Subject = subject 'DEFINE EL ASUNTO
                Dim MISMT As SmtpClient = New SmtpClient(MailInformation.emailServer) 'CLIENTE MAIL QUE USAMOS
                MISMT.EnableSsl = MailInformation.SSLEnabled 'SISTEMA DE SEGURIDAD
                MISMT.Port = MailInformation.emailPort
                MISMT.Credentials = New Net.NetworkCredential(MailInformation.emailFrom, MailInformation.emailPassword) 'CREDENCIALES DEL ORIGEN
                MISMT.Send(MENSAJE) 'ENVIA
                MsgBox("Email sended succefully!", MsgBoxStyle.Information, "OneSender")
                AddToLog("OneSender", "Email sended succefully!")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "One Sender")
                AddToLog("SendIt@MailSender::OneSender", "Error: " & ex.Message, True)
            End Try
        End Sub
    End Class

    Public Class ManySender
        Dim subject, message, toAddress(), bccAddress, ccAddress As String
        Sub New(ByVal subject As String, ByVal message As String, ByVal toAddress() As String, ByVal bccAddress As String, ByVal ccAddress As String)
            Me.subject = subject
            Me.message = message
            Me.toAddress = toAddress
            Me.bccAddress = bccAddress
            Me.ccAddress = ccAddress
            AddToLog("ManySender", "ManySender instance created!")
        End Sub

        'Sub SendIt()
        '    Dim MIHTML As String = message 'TEXTO HTML QUE SE ENVIARA
        '    Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(MIHTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
        '    Try
        '        Dim MENSAJE As MailMessage = New MailMessage 'DECLARA EL MENSAJE....
        '        MENSAJE.AlternateViews.Add(VISTAHTML) '... Y QUE VA EN FORMATO HTML
        '        MENSAJE.From = New MailAddress(MailInformation.emailFrom, MailInformation.emailIdentification) 'DEFINE EL ORIGEN
        '        'OJITO: el codigo de abajo incluye que toda persona que reciba el correo pueda ver las direcciones de correo
        '        'For Each correo As String In toAddress
        '        '    MENSAJE.To.Add(correo)
        '        'Next
        '        'por la que un pseudocodigo seria:
        '        '   for each correo as string in ToEmailList
        '        '       ...
        '        If bccAddress <> Nothing Then
        '            If bccAddress.Contains(";") Then
        '                Dim correos() As String = bccAddress.Split(";")
        '                For Each correo As String In correos
        '                    MENSAJE.Bcc.Add(correo) 'DEFINE EL DESTINO CON COPIA OCULTO
        '                Next
        '            Else
        '                MENSAJE.Bcc.Add(bccAddress) 'DEFINE EL DESTINO CON COPIA OCULTO
        '            End If
        '        End If
        '        If ccAddress <> Nothing Then
        '            If ccAddress.Contains(";") Then
        '                Dim correos() As String = ccAddress.Split(";")
        '                For Each correo As String In correos
        '                    MENSAJE.CC.Add(correo) 'DEFINE EL DESTINO CON COPIA
        '                Next
        '            Else
        '                MENSAJE.CC.Add(ccAddress) 'DEFINE EL DESTINO CON COPIA
        '            End If
        '        End If
        '        MENSAJE.Subject = subject 'DEFINE EL ASUNTO
        '        Dim MISMT As SmtpClient = New SmtpClient(MailInformation.emailServer) 'CLIENTE MAIL QUE USAMOS
        '        MISMT.EnableSsl = MailInformation.SSLEnabled 'SISTEMA DE SEGURIDAD
        '        MISMT.Port = MailInformation.emailPort
        '        MISMT.Credentials = New Net.NetworkCredential(MailInformation.emailFrom, MailInformation.emailPassword) 'CREDENCIALES DEL ORIGEN
        '        MISMT.Send(MENSAJE) 'ENVIA
        '        MsgBox("Email sended succefully!", MsgBoxStyle.Information, "OneSender")
        '        AddToLog("OneSender", "Email sended succefully!")
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "One Sender")
        '        AddToLog("SendIt@MailSender::OneSender", "Error: " & ex.Message, True)
        '    End Try
        'End Sub

    End Class

End Namespace