Public Class EmailList
    Public emailFrom As String
    Public emailIdentification As String
    Public emailPassword As String
    Public emailServer As String
    Public emailPort As Integer
    Public SSLEnabled As Boolean

    Private Sub EmailList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
'IMPORTANTES
'   Que se pueda exportar/importar como JSON