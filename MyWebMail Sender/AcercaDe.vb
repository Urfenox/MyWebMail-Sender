Public Class AcercaDe

    Private Sub AcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Acerca de " & My.Application.Info.ProductName
            lblAppName.Text = My.Application.Info.ProductName
            lblAppDescription.Text = My.Application.Info.Description
            lblInfo.Text = "v" & My.Application.Info.Version.ToString & " (" & Application.ProductVersion & ")"
        Catch
        End Try
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        Try
            Process.Start("https://github.com/Urfenox")
        Catch
        End Try
    End Sub

    Private Sub AcercaDe_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        MsgBox(My.Application.Info.ProductName &
               vbCrLf & """" & My.Application.Info.Description & """" &
               vbCrLf &
               vbCrLf &
               vbCrLf & lblInfo.Text, MsgBoxStyle.Information, My.Application.Info.CompanyName)
    End Sub
End Class