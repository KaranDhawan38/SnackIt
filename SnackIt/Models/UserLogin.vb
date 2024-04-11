Public Class UserLogin
    Private idText As Guid
    Public Property Id() As Guid
        Get
            Return idText
        End Get
        Set(ByVal value As Guid)
            idText = value
        End Set
    End Property
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
