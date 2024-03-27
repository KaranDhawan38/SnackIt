Public Class UserLogin
    Private userIdText As String
    Public Property UserName() As String
        Get
            Return userIdText
        End Get
        Set(ByVal value As String)
            userIdText = value
        End Set
    End Property

    Private passwordText As String
    Public Property Password() As String
        Get
            Return passwordText
        End Get
        Set(ByVal value As String)
            passwordText = value
        End Set
    End Property
End Class
