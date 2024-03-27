Imports System.Data.SqlClient
Imports System.Web.Mvc
Imports Microsoft.Ajax.Utilities

Namespace Controllers
    Public Class UsersController
        Inherits Controller

        Private connectionString As String = ConfigurationManager.ConnectionStrings("SnackItDB").ConnectionString

        <HttpGet>
        Function Login() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Login(userLogin As UserLogin) As ActionResult
            Dim userName As String = Nothing
            Using connection As New SqlConnection(connectionString)
                Dim sqlQuery As String = "SELECT * FROM Users WHERE UserName=@Username AND Password=@Password"
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@UserName", userLogin.UserName)
                    command.Parameters.AddWithValue("@Password", userLogin.Password)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                userName = reader.GetString(1)
                            End While
                        End If
                    End Using
                    connection.Close()
                    If Not String.IsNullOrEmpty(userName) Then
                        Return Redirect("/Home/Foods")
                    End If
                End Using
            End Using
            Return View()
        End Function

        <HttpGet>
        Function SignUp() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function SignUp(userSignUp As UserSignUp) As ActionResult
            Using connection As New SqlConnection(connectionString)
                Dim sqlQuery As String = "INSERT INTO Users (Id, UserName, Password) VALUES (@Id, @UserName, @Password)"
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Id", Guid.NewGuid())
                    command.Parameters.AddWithValue("@UserName", userSignUp.UserName)
                    command.Parameters.AddWithValue("@Password", userSignUp.Password)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
            End Using
            Return Redirect("Login")
        End Function
    End Class
End Namespace