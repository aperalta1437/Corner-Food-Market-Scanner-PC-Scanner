Public Class SaleCalculator

    Private dblSubtotal As Double = 0.0
    Private dblTax As Double = 0.0
    Private dblFoodStamp As Double = 0.0
    Private dblTotal As Double = 0.0
    Private Const TAX_RATE = 0.06               ' 6% Tax rate

    Public Sub New()

    End Sub

    Public Property Subtotal() As Double
        Get
            Return dblSubtotal
        End Get
        Set(ByVal value As Double)
            dblSubtotal = value
        End Set
    End Property

    Public Property Tax() As Double
        Get
            Return dblTax
        End Get
        Set(ByVal value As Double)
            Throw New System.Exception("This action is not allowed")
            ' dblTax = value
        End Set
    End Property

    Public Property FoodStamp() As Double
        Get
            Return dblFoodStamp
        End Get
        Set(ByVal value As Double)
            Throw New System.Exception("This action is not allowed")
            ' dblFoodStamp = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return dblTotal
        End Get
        Set(ByVal value As Double)
            Throw New System.Exception("This action is not allowed")
            ' dblTotal = value
        End Set
    End Property

    Private Sub calcTax()
        dblTax = dblSubtotal * TAX_RATE
    End Sub

    Private Sub calcTotal()
        dblTotal = Subtotal + Tax + FoodStamp
    End Sub

    Public Sub calcSale()
        calcTax()
        calcTotal()
    End Sub
End Class
