Public Class Main
    Dim OpenFile As New OpenFileDialog
    Dim SaveFile As New SaveFileDialog
    Dim ActualFilePath As String = Nothing

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        OpenFile.Filter = "Todos los Archivos (*.*)|*.*"
        OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OpenFile.Title = "Abrir Archivo..."
        If OpenFile.ShowDialog() = DialogResult.OK Then
            ActualFilePath = OpenFile.FileName
            FastColoredTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
        End If
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarArchivo()
    End Sub
    Private Sub GuardarcomoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarcomoToolStripMenuItem.Click
        GuardarArchivo()
    End Sub
    Sub GuardarArchivo()
        SaveFile.Filter = "Todos los Archivos (*.*)|*.*"
        SaveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        SaveFile.Title = "Guardar Archivo..."
        If ActualFilePath = Nothing Then
            If SaveFile.ShowDialog() = DialogResult.OK Then
                ActualFilePath = SaveFile.FileName
                My.Computer.FileSystem.WriteAllText(SaveFile.FileName, FastColoredTextBox1.Text, False)
            End If
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
#End Region

#Region "Editar"
    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click

    End Sub
    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click

    End Sub
    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click

    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click

    End Sub
    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click

    End Sub
    Private Sub SeleccionartodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionartodoToolStripMenuItem.Click

    End Sub
#End Region

#Region "Herramientas"
    Private Sub PersonalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizarToolStripMenuItem.Click

    End Sub
    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub
    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click

    End Sub
#End Region

#Region "Ayuda"
    Private Sub AcercadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercadeToolStripMenuItem.Click

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
        Dim enviador As New Sender.OneSender
        If MessageBox.Show("¿Seguro que desea enviar este correo a los destinatarios indicados?", "Confirmar Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            enviador.SendIt()
        End If
    End Sub
    Sub SendAll()
        Dim enviador As New Sender.ManySender

    End Sub
End Class