Friend Class SqlCommand
    Private v As String
    Private conexao As SqlConnection

    Public Sub New(v As String, conexao As SqlConnection)
        Me.v = v
        Me.conexao = conexao
    End Sub

    Friend Function Parameters() As Object
        Throw New NotImplementedException()
    End Function
End Class
