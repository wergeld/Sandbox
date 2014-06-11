Imports System.IO
Imports System.Text

Public Class Log
    Private Shared ReadOnly _instance As New Lazy(Of Log)(Function() New Log(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
    Private _logPath As String = "C:\Users\csmith\Desktop\log.txt"
    Private Shared _logMessage As String = String.Empty

    Private Sub New()
        Create()
        Write()
    End Sub

    Public Shared Sub InitLog(ByVal inputMessage As String)
        _logMessage = inputMessage
    End Sub

    Public Sub Create()
        If Not File.Exists(_logPath) Then
            File.Create("C:\Users\csmith\Desktop\log.txt").Dispose()
        End If
    End Sub

    Public Sub Write()
        Dim swLog As StreamWriter = File.AppendText(_logPath)
        'Dim swLogInfo As Byte() = New UTF8Encoding(True).GetBytes("Log log log")
        Dim swLogInfo As Byte() = New UTF8Encoding(True).GetBytes(_logMessage)
        swLog.WriteLine(System.Text.Encoding.UTF8.GetString(swLogInfo))
        swLog.Close()
    End Sub

    Public Shared ReadOnly Property Instance() As Log
        Get
            Return _instance.Value
        End Get
    End Property
End Class
