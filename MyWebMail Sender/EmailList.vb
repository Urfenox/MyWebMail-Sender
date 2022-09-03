Public Class EmailList
    Dim idCorreo As Integer = 0

    Dim myListaCorreos As New ListaEmails 'Objeto principal
    Dim Emails As New List(Of Correo) 'Lista de correos para embeber dentro del 'Objeto principal'
    Dim myCorreo As Correo 'Correo para agregar a la 'Lista de correos'

    Dim JSON_String As String
    Dim JSON_Conversor As New System.Web.Script.Serialization.JavaScriptSerializer

    Dim iCorreos As Integer = 0
    Dim cCorreos As Integer = 0

    Private Sub EmailList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerLista()
        RefreshLabel()
    End Sub
    Private Sub EmailList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GenerarLista()
    End Sub

#Region "Buttons"
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        Txb_ID.Clear()
        Txb_Email.Clear()
        Txb_Identification.Clear()
        Txb_Password.Clear()

        Txb_Server.Clear()
        Txb_Type.Clear()
        Txb_Port.Clear()
        Txb_StatusSSL.Clear()

        iCorreos = -1
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            'Genera un nuevo item correo para agregarlo a ListaEmails
            myCorreo = New Correo 'Crea el nuevo correo

            myCorreo.ID = cCorreos
            myCorreo.Email = Txb_Email.Text
            myCorreo.Identification = Txb_Identification.Text
            myCorreo.Password = Txb_Password.Text

            myCorreo.Server = Txb_Server.Text
            myCorreo.Type = Txb_Type.Text
            myCorreo.Port = Txb_Port.Text
            myCorreo.StatusSSL = Txb_StatusSSL.Text

            Emails.Add(myCorreo) 'Agrega el correo a la lista

            cCorreos += 1 'Incrementa en 1 la cantidad.
            Txb_ID.Text = cCorreos

            GenerarLista() 'Guardar cambios
            'CONSIDERACION: SE GENERA UN New Correo. por lo que un item seleccionado NO se sobreescribira. si no que se
            'generara uno nuevo.
        Catch ex As Exception
            AddToLog("GenerarLista@EmailList", "Error: " & ex.Message, True)
        End Try
    End Sub
    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Try
            If MessageBox.Show("¿Seguro que desea eliminar el correo '" & iCorreos & ":" & Emails(iCorreos).Email & "'?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                myListaCorreos.Correos.RemoveAt(iCorreos)
                Emails.RemoveAt(iCorreos)
                MsgBox("Correo eliminado", MsgBoxStyle.Critical, "Lista de correos")
                AddToLog("EmailList", "Email address deleted.")
            End If
        Catch ex As Exception
            AddToLog("Btn_Remove_Click@EmailList", "Error: " & ex.Message, True)
        End Try
    End Sub
#End Region

    Sub GenerarLista()
        Try
            myListaCorreos.AssemblyName = My.Application.Info.AssemblyName
            myListaCorreos.AssemblyVersion = My.Application.Info.Version.ToString

            myListaCorreos.ProductVersion = Application.ProductVersion
            myListaCorreos.Company = My.Application.Info.CompanyName

            myListaCorreos.Author = Environment.UserName
            myListaCorreos.DateCreated = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

            myListaCorreos.Correos = Emails

            JSON_String = JSON_Conversor.Serialize(myListaCorreos)

            If My.Computer.FileSystem.FileExists(DIRCommons & "\EmailList.json") = True Then
                My.Computer.FileSystem.DeleteFile(DIRCommons & "\EmailList.json")
            End If
            My.Computer.FileSystem.WriteAllText(DIRCommons & "\EmailList.json", JSON_String, False)
            AddToLog("EmailList", "EmailList.json saved!")

            LeerLista()
        Catch ex As Exception
            AddToLog("GenerarLista@EmailList", "Error: " & ex.Message, True)
        End Try
    End Sub

    Sub LeerLista()
        Try
            If My.Computer.FileSystem.FileExists(DIRCommons & "\EmailList.json") = False Then
                MsgBox("No hay una lista de correos.", MsgBoxStyle.Critical, "Lista de correos")
                AddToLog("EmailList", "File EmailList.json doesn't exist.")
            Else
                myListaCorreos = JSON_Conversor.Deserialize(My.Computer.FileSystem.ReadAllText(DIRCommons & "\EmailList.json"), GetType(ListaEmails))
                Emails = myListaCorreos.Correos
                IndexToListBox()
            End If
        Catch ex As Exception
            AddToLog("LeerLista@EmailList", "Error: " & ex.Message, True)
        End Try
    End Sub
    Sub IndexToListBox()
        ListBox1.Items.Clear()
        cCorreos = 0
        iCorreos = 0
        For Each correo As Correo In Emails
            ListBox1.Items.Add(correo.ID & ": " & correo.Email)
            cCorreos += 1
        Next
    End Sub

#Region "View y Select"
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'ver
        iCorreos = ListBox1.SelectedIndex

        Txb_ID.Text = myListaCorreos.Correos(iCorreos).ID
        Txb_Email.Text = myListaCorreos.Correos(iCorreos).Email
        Txb_Identification.Text = myListaCorreos.Correos(iCorreos).Identification
        Txb_Password.Text = myListaCorreos.Correos(iCorreos).Password

        Txb_Server.Text = myListaCorreos.Correos(iCorreos).Server
        Txb_Type.Text = myListaCorreos.Correos(iCorreos).Type
        Txb_Port.Text = myListaCorreos.Correos(iCorreos).Port
        Txb_StatusSSL.Text = myListaCorreos.Correos(iCorreos).StatusSSL
    End Sub
    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        'seleccionar
        SelectEmailAddress(iCorreos)
    End Sub
    Sub SelectEmailAddress(ByVal index As Integer)
        Try
            MailSender.MailInformation.emailFrom = myListaCorreos.Correos(index).Email
            MailSender.MailInformation.emailIdentification = myListaCorreos.Correos(index).Identification
            MailSender.MailInformation.emailPassword = myListaCorreos.Correos(index).Password
            MailSender.MailInformation.emailServer = myListaCorreos.Correos(index).Server
            MailSender.MailInformation.emailPort = myListaCorreos.Correos(index).Port
            MailSender.MailInformation.SSLEnabled = myListaCorreos.Correos(index).StatusSSL
            idCorreo = index
            RefreshLabel()
        Catch ex As Exception
            AddToLog("SelectEmailAddress@EmailList", "Error: " & ex.Message, True)
        End Try
    End Sub
    Sub RefreshLabel()
        Lbl_CurrentEmail.Text = "Actualmente en uso" &
            vbCrLf & "    Correo: " & MailSender.MailInformation.emailFrom &
            vbCrLf & "    Identificación: " & MailSender.MailInformation.emailIdentification
        AddToLog("EmailList", "Email provider selected!")
    End Sub
#End Region
End Class
'IMPORTANTES
'   Que se pueda exportar/importar como JSON
Partial Class ListaEmails
    Public AssemblyName As String
    Public AssemblyVersion As String
    Public ProductVersion As String
    Public Company As String

    Public Author As String
    Public DateCreated As String

    Public Correos As New List(Of Correo)
End Class
Partial Class Correo
    Public ID As Integer
    Public Email As String
    Public Identification As String
    Public Password As String

    Public Server As String
    Public Type As String
    Public Port As Integer
    Public StatusSSL As Boolean
End Class