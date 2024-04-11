Public Class DbData
    Private foodItemsText As List(Of FoodItem)
    Public Property FoodItems() As List(Of FoodItem)
        Get
            Return foodItemsText
        End Get
        Set(ByVal value As List(Of FoodItem))
            foodItemsText = value
        End Set
    End Property

    Private usersListText As List(Of UserLogin)
    Public Property UsersList() As List(Of UserLogin)
        Get
            Return usersListText
        End Get
        Set(ByVal value As List(Of UserLogin))
            usersListText = value
        End Set
    End Property
End Class
