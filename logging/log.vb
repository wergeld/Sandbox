Public NotInheritable Class MySingleton
    Private Shared ReadOnly _instance As New Lazy(Of MySingleton)(Function() New
        MySingleton(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As MySingleton
        Get
            Return _instance.Value
        End Get
    End Property
End Class
