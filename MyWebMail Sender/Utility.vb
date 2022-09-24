Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Namespace Utilidades
    Module Utility
        Public DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\CRZ_Labs\MyWebMail Sender"
        Function AddToLog(ByVal from As String, ByVal content As String, Optional ByVal flag As Boolean = False, Optional ByVal cmdColor As ConsoleColor = ConsoleColor.White) As String
            Try
                Dim OverWrite As Boolean = False
                If My.Computer.FileSystem.FileExists(DIRCommons & "\" & My.Application.Info.AssemblyName & ".log") Then
                    OverWrite = True
                End If
                Dim finalContent As String = Nothing
                If flag = True Then
                    finalContent = " [!!!]"
                End If
                Dim Message As String = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy") & finalContent & " [" & from & "] " & content
                Console.WriteLine("[" & from & "]" & finalContent & " " & content)
                Try
                    My.Computer.FileSystem.WriteAllText(DIRCommons & "\" & My.Application.Info.AssemblyName & ".log", vbCrLf & Message, OverWrite)
                Catch
                End Try
                Return finalContent & "[" & from & "]" & content
            Catch ex As Exception
                Console.WriteLine("[AddToLog@Utility]Error: " & ex.Message)
                Return "[AddToLog@Utility]Error: " & ex.Message
            End Try
        End Function
        <DllImport("kernel32")>
        Private Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
            'Use GetIniValue("KEY_HERE", "SubKEY_HERE", "filepath")
        End Function
        Public Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = Nothing) As String
            Dim sb As New StringBuilder(500)
            If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
                Return sb.ToString
            Else
                Return defaultValue
            End If
        End Function
    End Module

    Module StartUp
        Sub Init()
            'COMUNES
            LoadConfig()
            CommonActions()
            'Runtime
            EmailList.LeerLista()
            EmailList.SelectEmailAddress(MailServer_ID)
        End Sub
        Sub CommonActions()
            If My.Computer.FileSystem.DirectoryExists(DIRCommons) = False Then
                My.Computer.FileSystem.CreateDirectory(DIRCommons)
            End If
        End Sub
    End Module

    Module Memory
        Dim configPath As String = DIRCommons & "\Config.ini"

        Public MailServer_ID As Integer
        Public Main_OpenPath As String
        Public Main_SavePath As String
        Public EmailList_ExportPath As String
        Public EmailList_ImportPath As String
        Public ToEmailList_ExportPath As String
        Public ToEmailList_ImportPath As String

        Sub SaveConfig()
            Try
                If My.Computer.FileSystem.FileExists(configPath) Then
                    My.Computer.FileSystem.DeleteFile(configPath)
                End If

                Dim configuracion As String = "# MyWebMail Sender Configuration File" &
                    vbCrLf & "[Assembly]" &
                    vbCrLf & "Name=" & My.Application.Info.AssemblyName &
                    vbCrLf & "Version=" & My.Application.Info.Version.ToString &
                    vbCrLf & "Compile=" & Application.ProductVersion &
                    vbCrLf &
                    vbCrLf & "[FILE]" &
                    vbCrLf & "Author=" & Environment.UserName &
                    vbCrLf & "Created=" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") &
                    vbCrLf &
                    vbCrLf & "[MailServer]" &
                    vbCrLf & "ID=" & MailServer_ID &
                    vbCrLf &
                    vbCrLf & "[Main]" &
                    vbCrLf & "OpenPath=" & Main_OpenPath &
                    vbCrLf & "SavePath=" & Main_SavePath &
                    vbCrLf &
                    vbCrLf & "[EmailList]" &
                    vbCrLf & "ExportPath=" & EmailList_ExportPath &
                    vbCrLf & "ImportPath=" & EmailList_ImportPath &
                    vbCrLf &
                    vbCrLf & "[ToEmailList]" &
                    vbCrLf & "ExportPath=" & ToEmailList_ExportPath &
                    vbCrLf & "ImportPath=" & ToEmailList_ImportPath &
                    vbCrLf

                My.Computer.FileSystem.WriteAllText(configPath, configuracion, False)

                LoadConfig()
            Catch ex As Exception
                AddToLog("SaveConfig@Memory", "Error: " & ex.Message, True)
            End Try
        End Sub
        Sub LoadConfig()
            Try
                If My.Computer.FileSystem.FileExists(configPath) = False Then
                    AddToLog("Config.Memory", "Config file doesnt't exist.")
                    SaveConfig()
                    Exit Sub
                End If

                MailServer_ID = GetIniValue("MailServer", "ID", configPath)

                Main_OpenPath = GetIniValue("Main", "OpenPath", configPath)
                Main_SavePath = GetIniValue("Main", "SavePath", configPath)

                EmailList_ExportPath = GetIniValue("EmailList", "ExportPath", configPath)
                EmailList_ImportPath = GetIniValue("EmailList", "ImportPath", configPath)

                ToEmailList_ExportPath = GetIniValue("ToEmailList", "ExportPath", configPath)
                ToEmailList_ImportPath = GetIniValue("ToEmailList", "ImportPath", configPath)

            Catch ex As Exception
                AddToLog("LoadConfig@Memory", "Error: " & ex.Message, True)
            End Try
        End Sub

    End Module
End Namespace