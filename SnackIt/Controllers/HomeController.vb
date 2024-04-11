Imports System.Data.SqlClient

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private connectionString As String = ConfigurationManager.ConnectionStrings("SnackItDB").ConnectionString

    Function Foods() As ActionResult
        ViewBag.FoodType = "Foods"
        Return View("FoodsGrid", GetFoodItems(0))
    End Function

    Function Drinks() As ActionResult
        ViewBag.FoodType = "Drinks"
        Return View("FoodsGrid", GetFoodItems(1))
    End Function

    Function Deserts() As ActionResult
        ViewBag.FoodType = "Deserts"
        Return View("FoodsGrid", GetFoodItems(2))
    End Function

    Function Cart() As ActionResult
        ViewBag.FoodType = "Cart"
        Dim cartItems As New List(Of CartItem)()
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "select c.FoodId, f.Name, f.Price, f.Image, COUNT(c.FoodId) as CartValue from cart c
join FoodItems f on c.FoodId=f.Id
where UserId=@UserId
group by c.FoodId, f.Name, f.Price, f.Image"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserId", Session("UserId"))
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim cartItem As New CartItem()
                            cartItem.FoodItemId = reader.GetInt32(0)
                            cartItem.Name = reader.GetString(1)
                            cartItem.Price = reader.GetInt32(2)
                            cartItem.ImageUrl = reader.GetString(3)
                            cartItem.CartValue = reader.GetInt32(4)

                            cartItems.Add(cartItem)
                        End While
                    End If
                End Using
                connection.Close()
            End Using
        End Using
        Return View(cartItems)
    End Function

    Function DbData() As ActionResult
        ViewBag.FoodType = "DbData"
        Dim dbData1 As New DbData()
        dbData1.FoodItems = New List(Of FoodItem)
        dbData1.UsersList = New List(Of UserLogin)
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "SELECT * from foodItems"
            Using command As New SqlCommand(sqlQuery, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim foodItem As New FoodItem()
                            foodItem.Id = reader.GetInt32(0)
                            foodItem.Name = reader.GetString(1)
                            foodItem.Type = reader.GetInt32(2)
                            foodItem.Price = reader.GetInt32(3)
                            foodItem.ImageUrl = reader.GetString(4)

                            dbData1.FoodItems.Add(foodItem)
                        End While
                    End If
                End Using
                connection.Close()
            End Using
        End Using
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "SELECT * from users"
            Using command As New SqlCommand(sqlQuery, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim user As New UserLogin()
                            user.Id = reader.GetGuid(0)
                            user.UserName = reader.GetString(1)
                            user.Password = reader.GetString(2)

                            dbData1.UsersList.Add(user)
                        End While
                    End If
                End Using
                connection.Close()
            End Using
        End Using
        Return View(dbData1)
    End Function

    Function GetFoodItems(type As Integer) As List(Of FoodItem)
        Dim foodItems As New List(Of FoodItem)()
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "select x.Id, x.name, x.Type, x.Price, x.Image, x.CartValue from 
(SELECT f.*, c.UserId AS UserId1, count(c.FoodId) as CartValue FROM FoodItems f
full join cart c on f.Id=c.FoodId
WHERE f.Type=@Type
group by f.Id, f.name, f.Type, f.Price, f.Image, c.UserId) x
where x.UserId1=@UserId or x.UserId1 is NULL"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@Type", type)
                command.Parameters.AddWithValue("@UserId", Session("UserId"))
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim foodItem As New FoodItem()
                            foodItem.Id = reader.GetInt32(0)
                            foodItem.Name = reader.GetString(1)
                            foodItem.Type = reader.GetInt32(2)
                            foodItem.Price = reader.GetInt32(3)
                            foodItem.ImageUrl = reader.GetString(4)
                            foodItem.CartValue = reader.GetInt32(5)

                            foodItems.Add(foodItem)
                        End While
                    End If
                End Using
                connection.Close()
            End Using
        End Using
        Return foodItems
    End Function

    <HttpPost>
    Function AddFoodToCart(foodId As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "INSERT INTO Cart (Id, UserId, FoodId) VALUES (@Id, @UserId, @FoodId)"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@Id", Guid.NewGuid())
                command.Parameters.AddWithValue("@UserId", Session("UserId"))
                command.Parameters.AddWithValue("@FoodId", foodId)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
    End Function

    <HttpPost>
    Function RemoveFoodFromCart(foodId As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "DELETE FROM Cart WHERE Id IN (select Id from
(SELECT Id, 
ROW_NUMBER() OVER (PARTITION BY UserId, FoodId ORDER BY UserId) AS RowNum FROM CART where FoodId=@FoodId AND UserId=@UserId) as x
where x.RowNum=1)"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserId", Session("UserId"))
                command.Parameters.AddWithValue("@FoodId", foodId)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
    End Function
End Class
