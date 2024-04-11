Public Class CartItem
    Private foodItemIdText As Integer
    Public Property FoodItemId() As Integer
        Get
            Return foodItemIdText
        End Get
        Set(ByVal value As Integer)
            foodItemIdText = value
        End Set
    End Property

    Private nameText As String
    Public Property Name() As String
        Get
            Return nameText
        End Get
        Set(ByVal value As String)
            nameText = value
        End Set
    End Property

    Private priceText As Integer
    Public Property Price() As Integer
        Get
            Return priceText
        End Get
        Set(ByVal value As Integer)
            priceText = value
        End Set
    End Property

    Private imageUrlText As String
    Public Property ImageUrl() As String
        Get
            Return imageUrlText
        End Get
        Set(ByVal value As String)
            imageUrlText = value
        End Set
    End Property

    Private cartValueText As Integer
    Public Property CartValue() As Integer
        Get
            Return cartValueText
        End Get
        Set(ByVal value As Integer)
            cartValueText = value
        End Set
    End Property
End Class
