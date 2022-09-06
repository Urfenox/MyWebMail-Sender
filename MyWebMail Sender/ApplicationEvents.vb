Imports Microsoft.VisualBasic.ApplicationServices
Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: Se genera cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: Se genera después de haberse cerrado todos los formularios de aplicación.  Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: Se genera si la aplicación encuentra una excepción no controlada.
    ' StartupNextInstance: Se genera cuando se inicia una aplicación de instancia única y dicha aplicación está ya activa. 
    ' NetworkAvailabilityChanged: Se genera cuando se conecta o desconecta la conexión de red.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            Utilidades.SaveConfig()
            Utilidades.AddToLog("Event", My.Application.Info.AssemblyName & " " & My.Application.Info.Version.ToString & " (" & System.Windows.Forms.Application.ProductVersion & ")" & " has finished! " & DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy"), True)
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Utilidades.AddToLog("Event", My.Application.Info.AssemblyName & " " & My.Application.Info.Version.ToString & " (" & System.Windows.Forms.Application.ProductVersion & ")" & " has started! " & DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy"), True)
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Utilidades.AddToLog("Event", e.Exception.Data.Count & vbCrLf & e.Exception.InnerException.ToString & vbCrLf & e.Exception.Message & vbCrLf & e.Exception.Source & vbCrLf & e.Exception.StackTrace & vbCrLf & e.Exception.TargetSite.Name & vbCrLf & e.Exception.HelpLink, True)
        End Sub
    End Class
End Namespace
