Public Class Main
    Dim OpenFile As New OpenFileDialog
    Dim SaveFile As New SaveFileDialog
    Dim ActualFilePath As String = Nothing

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.Init()
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub
    Private Sub Main_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        AcercaDe.Show()
        AcercaDe.Focus()
    End Sub

#Region "MenuTool1"
#Region "Archivo"
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro desea crear un documento nuevo?", "Confirmar Accion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FastColoredTextBox1.Clear()
            ActualFilePath = Nothing
        End If
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Try
            OpenFile.Filter = "Todos los Archivos (*.*)|*.*"
            OpenFile.InitialDirectory = Utilidades.Memory.Main_OpenPath
            OpenFile.Title = "Abrir Archivo..."
            If OpenFile.ShowDialog() = DialogResult.OK Then
                ActualFilePath = OpenFile.FileName
                Utilidades.Memory.Main_OpenPath = IO.Path.GetDirectoryName(OpenFile.FileName)
                FastColoredTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
            End If
        Catch ex As Exception
            Utilidades.AddToLog("AbrirToolStripMenuItem_Click@Main", "Error: " & ex.Message, True)
        End Try
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarArchivo()
    End Sub
    Private Sub GuardarcomoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarcomoToolStripMenuItem.Click
        GuardarArchivo(True)
    End Sub
    Sub GuardarArchivo(Optional ByVal IsSaveAs As Boolean = False)
        Try
            SaveFile.Filter = "Todos los Archivos (*.*)|*.*"
            SaveFile.InitialDirectory = Utilidades.Memory.Main_SavePath
            SaveFile.Title = "Guardar Archivo..."
            If IsSaveAs Then
                If SaveFile.ShowDialog() = DialogResult.OK Then
                    ActualFilePath = SaveFile.FileName
                    Utilidades.Memory.Main_SavePath = IO.Path.GetDirectoryName(SaveFile.FileName)
                    My.Computer.FileSystem.WriteAllText(SaveFile.FileName, FastColoredTextBox1.Text, False)
                End If
            Else
                My.Computer.FileSystem.WriteAllText(OpenFile.FileName, FastColoredTextBox1.Text, False)
            End If
        Catch ex As Exception
            Utilidades.AddToLog("GuardarArchivo@Main", "Error: " & ex.Message, True)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
#End Region

#Region "Editar"
    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub
    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub
    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        FastColoredTextBox1.Cut()
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
    End Sub
    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
    End Sub
    Private Sub SeleccionartodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionartodoToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
    End Sub
#End Region

#Region "Herramientas"
    Private Sub VisaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisaPreviaToolStripMenuItem.Click
        HTML_Preview.Show()
        HTML_Preview.Focus()
    End Sub
    Private Sub PersonalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizarToolStripMenuItem.Click

    End Sub
    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub
    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click

    End Sub
#End Region

#Region "Ayuda"
    Private Sub AcercadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercadeToolStripMenuItem.Click
        AcercaDe.ShowDialog()
    End Sub
#End Region
#End Region

    Private Sub Btn_SeeEmailList_Click(sender As Object, e As EventArgs) Handles Btn_SeeEmailList.Click
        EmailList.Show()
        EmailList.Focus()
    End Sub
    Private Sub Btn_SeeToEmailList_Click(sender As Object, e As EventArgs) Handles Btn_SeeToEmailList.Click
        ToEmailList.Show()
        ToEmailList.Focus()
    End Sub

    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles Btn_Send.Click
        SendOne()
    End Sub
    Private Sub Btn_SendToAll_Click(sender As Object, e As EventArgs) Handles Btn_SendToAll.Click
        SendAll()
    End Sub
    Sub SendOne()
        Try
            If Txb_Subject.Text = Nothing Or FastColoredTextBox1.Text = Nothing Then
                MsgBox("Faltan datos", MsgBoxStyle.Critical, "Datos Faltantes")
            Else
                If MailSender.emailFrom = Nothing Or MailSender.emailPassword = Nothing Then
                    MsgBox("Correo de envio no indicado", MsgBoxStyle.Critical, "Datos Faltantes")
                Else
                    Utilidades.AddToLog("Main", "Sending one...")
                    Dim enviador As New MailSender.OneSender(Txb_Subject.Text, FastColoredTextBox1.Text, Txb_Addressee.Text, Txb_AddresseeBCC.Text, Txb_AddresseeCC.Text)
                    'Dim threadSend = New Threading.Thread(Sub() enviador.SendIt())
                    If MessageBox.Show("¿Seguro que desea enviar este correo a los destinatarios indicados?", "Confirmar Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'threadSend.Start()
                        enviador.SendIt()
                    End If
                End If
            End If
        Catch ex As Exception
            Utilidades.AddToLog("SendOne@Main", "Error: " & ex.Message, True)
        End Try
    End Sub
    Sub SendAll()
        If Txb_Subject.Text = Nothing Or FastColoredTextBox1.Text = Nothing Then
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "Datos Faltantes")
        Else
            If MailSender.emailFrom = Nothing Or MailSender.emailPassword = Nothing Then
                MsgBox("Correo de envio no indicado", MsgBoxStyle.Critical, "Datos Faltantes")
            Else
                Utilidades.AddToLog("Main", "Sending many...")
                Dim enviador As New MailSender.ManySender(Txb_Subject.Text, FastColoredTextBox1.Text)
                'Dim threadSend = New Threading.Thread(Sub() enviador.SendAdmin())
                'threadSend.Start()
                enviador.SendAdmin()
            End If
        End If
    End Sub

    Private Sub FastColoredTextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles FastColoredTextBox1.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim strRutaArchivos() As String
                strRutaArchivos = e.Data.GetData(DataFormats.FileDrop)
                ActualFilePath = strRutaArchivos(0)
                OpenFile.FileName = strRutaArchivos(0)
                SaveFile.FileName = strRutaArchivos(0)
                FastColoredTextBox1.Text = My.Computer.FileSystem.ReadAllText(ActualFilePath)
            End If
        Catch ex As Exception
            Utilidades.AddToLog("FastColoredTextBox1_DragDrop@Main", "Error: " & ex.Message, True)
        End Try
    End Sub
    Private Sub FastColoredTextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles FastColoredTextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
End Class