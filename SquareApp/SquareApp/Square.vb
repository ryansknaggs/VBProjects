Public Class Square
    Private side As Integer

    Public Sub New(newSide As Integer)
        side = newSide
    End Sub

    Public ReadOnly Property Perimeter()
        Get
            Return (4 * side)
        End Get
    End Property

    Public ReadOnly Property Area()
        Get
            Return (side * side)
        End Get
    End Property

    Public ReadOnly Property Diagonal()
        Get
            Return Math.Round(side * (Math.Sqrt(2)), 2, MidpointRounding.AwayFromZero)
        End Get
    End Property
End Class
