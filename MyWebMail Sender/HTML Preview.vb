Public Class HTML_Preview

    Private Sub HTML_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualizarCodigoHTML()
    End Sub

    Sub VisualizarCodigoHTML()
        Try
            WebBrowser1.DocumentText = Main.FastColoredTextBox1.Text
            WebBrowser1.Update()
            Me.Refresh()
        Catch ex As Exception
            Utilidades.AddToLog("VisualizarCodigoHTML@HTML_Preview", "Error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub HTML_Preview_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            VisualizarCodigoHTML()
        End If
    End Sub
End Class