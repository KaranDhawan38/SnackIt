Public Class FoodItem
    Private idText As Integer
    Public Property Id() As Integer
        Get
            Return idText
        End Get
        Set(ByVal value As Integer)
            idText = value
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

    Private typeText As FoodItemType
    Public Property Type() As FoodItemType
        Get
            Return typeText
        End Get
        Set(ByVal value As FoodItemType)
            typeText = value
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
End Class
