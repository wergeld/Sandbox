Public NotInheritable Class Log
    Private Shared ReadOnly _instance As New Lazy(Of MySingleton)(Function() New
        Log(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Log
        Get
            Return _instance.Value
        End Get
    End Property
End Class
