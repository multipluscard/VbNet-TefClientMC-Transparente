Imports System.IO
Imports System.Reflection

Friend Class Util
    Public Shared Sub AdicionaLog(ByVal strMsg As String, ByVal Optional strStackTrace As String = Nothing)
        CriarArquivo("tef", strMsg, strStackTrace)
    End Sub

    Private Shared Sub CriarArquivo(ByVal sNomeArquivo As String, ByVal strMsg As String, ByVal Optional strStackTrace As String = "")

        If String.IsNullOrEmpty(strMsg) AndAlso String.IsNullOrEmpty(strStackTrace) Then Return

        If File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}nlog.txt") Then Return

        If String.IsNullOrEmpty(sNomeArquivo) Then Return

        If ArquivoEmUso(AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}.log") Then Return
        Try
            'Versão sistema
            Dim assembly As Assembly = assembly.GetExecutingAssembly()
            Dim fvi = FileVersionInfo.GetVersionInfo(assembly.Location)
            Dim version = fvi.FileVersion

            Dim info As FileInfo = New FileInfo(AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}.log")
            If info.Exists AndAlso info.Length >= 314572800 Then
                Try
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}_old.log")
                    File.Move(AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}.log", AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}_old.log")
                Catch
                End Try
            End If

            Dim objLog = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory & $"{sNomeArquivo}.log", True)

            If Not Equals(strMsg, "") Then objLog.WriteLine(Date.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") & $" v. {version}" & " :: " & strMsg)

            If Not String.IsNullOrEmpty(strStackTrace) Then objLog.WriteLine(Date.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") & $" v. {version}" & " :: " & strStackTrace)

            objLog.Close()
            objLog.Dispose()
            objLog = Nothing
        Catch
        End Try
    End Sub

    Public Shared Function ArquivoEmUso(ByVal caminhoArquivo As String) As Boolean
        Try
            Dim fs = File.OpenWrite(caminhoArquivo)
            fs.Close()
            Return False
        Catch
            Return True
        End Try
    End Function
End Class
