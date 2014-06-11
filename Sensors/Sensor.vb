Public Class Sensor
  Public ID As Integer
  Public location As String
  Public available As boolean
  
  
  Private Function getLocation (ByVal ID) As String
    Try
      Result = dbConnection(run usp_getLocationByID)
      
      If Result > 0 Then
        Dim test As Log = Log.Instance
        Return Result
      End
    Catch
     Throw
    End Try
  End Function
  
    Private Function isAvailable (ByVal ID) As Boolean
    Try
      Result = dbConnection(run usp_getAvailabilityByID)
      
      If Not Result Is Nothing Then
        Return Result
      End
    Catch
     Throw
    End Try
  End Function
  
End Class
