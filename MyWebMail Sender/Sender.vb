Imports System.Net.Mail
Imports System.Text.RegularExpressions
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
    Module AddresseeInformation
        Public toAddresses As New ArrayList
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
        Dim subject, message As String
        Sub New(ByVal subject As String, ByVal message As String)
            Me.subject = subject
            Me.message = message
            CargarDestinatarios()
            AddToLog("ManySender", "ManySender instance created!" &
                     vbCrLf & "    " & toAddresses.Count & " Addresses")
        End Sub
        Sub CargarDestinatarios()
            Try
                toAddresses.Clear()
                Dim JSON_Conversor As New System.Web.Script.Serialization.JavaScriptSerializer
                Dim myListaCorreos As ListaToEmails = JSON_Conversor.Deserialize(My.Computer.FileSystem.ReadAllText(ToEmailList.filePath), GetType(ListaToEmails))

                For Each correo As ParaCorreo In myListaCorreos.Correos
                    toAddresses.Add(correo.Email)
                Next
            Catch ex As Exception
                AddToLog("CargarDestinatarios@MailSender::ManySender", "Error: " & ex.Message, True)
            End Try
        End Sub

        Sub SendAdmin() 'funciona. test v0 04/09/2022 04:07 PM
            Try
                If MessageBox.Show("¿Seguro que desea enviar este correo a " & toAddresses.Count & " direcciónes?", "Confirmar Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'Envio a direcciones destinatario
                    For Each destinatario As String In toAddresses
                        SendIt(destinatario)
                    Next
                    'Envio a direcciones BCC
                    '   ?
                    'Envio a direcciones CC
                    '   ?
                    MsgBox("Emails sended succefully!", MsgBoxStyle.Information, "Many Sender")
                    AddToLog("ManySender", "Emails sended succefully!")
                End If
            Catch ex As Exception
                AddToLog("SendAdmin@MailSender::ManySender", "Error: " & ex.Message, True)
            End Try
        End Sub

        Sub SendIt(ByVal emailAddress As String)
            Dim MIHTML As String = message 'TEXTO HTML QUE SE ENVIARA
            Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(MIHTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
            Try
                Dim MENSAJE As MailMessage = New MailMessage 'DECLARA EL MENSAJE....
                MENSAJE.AlternateViews.Add(VISTAHTML) '... Y QUE VA EN FORMATO HTML
                MENSAJE.From = New MailAddress(MailInformation.emailFrom, MailInformation.emailIdentification) 'DEFINE EL ORIGEN
                MENSAJE.To.Add(emailAddress)
                MENSAJE.Subject = subject 'DEFINE EL ASUNTO
                Dim MISMT As SmtpClient = New SmtpClient(MailInformation.emailServer) 'CLIENTE MAIL QUE USAMOS
                MISMT.EnableSsl = MailInformation.SSLEnabled 'SISTEMA DE SEGURIDAD
                MISMT.Port = MailInformation.emailPort
                MISMT.Credentials = New Net.NetworkCredential(MailInformation.emailFrom, MailInformation.emailPassword) 'CREDENCIALES DEL ORIGEN
                MISMT.Send(MENSAJE) 'ENVIA
                'how to do masking/hiding email address in c#
                'https://stackoverflow.com/a/31807934
                Dim pattern As String = "(?<=[\w]{3})[\w-\._\+%]*(?=[\w]{1}@)"
                Dim result As String = Regex.Replace(emailAddress, pattern, Function(m) New String("*"c, m.Length))
                AddToLog("ManySender", "Email sended to '" & result & "' succefully!")
            Catch ex As Exception
                AddToLog("SendIt@MailSender::ManySender", "Error: " & ex.Message, True)
            End Try
        End Sub
    End Class

End Namespace