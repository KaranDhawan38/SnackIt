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

    Function GetFoodItems(type As Integer) As List(Of FoodItem)
        Dim foodItems As New List(Of FoodItem)()
        Using connection As New SqlConnection(connectionString)
            Dim sqlQuery As String = "SELECT * FROM FoodItems WHERE Type=@Type"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@Type", type)
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

                            foodItems.Add(foodItem)
                        End While
                    End If
                End Using
                connection.Close()
            End Using
        End Using
        Return foodItems
    End Function
End Class
