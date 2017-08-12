Public MustInherit Class twoDimensional
    Inherits Shape

    Private xSideValue As Decimal
    Private ySideValue As Decimal
    Private RadiusValue As Decimal

    Public Sub New(ByVal shape As String, ByVal xSide As Decimal, ByVal ySide As Decimal, ByVal Radius As Decimal)
        MyBase.New(shape)
        Me.xSide = xSide
        Me.ySide = ySide
        Me.Radius = Radius
    End Sub

    Public Property xSide() As Decimal
        Get
            Return xSideValue
        End Get
        Set(ByVal value As Decimal)
            If value >= -1D Then
                xSideValue = value
            Else
                Throw New ArgumentOutOfRangeException("side must be greater than or equal to 0 or -1 (unused)")
            End If
        End Set
    End Property

    Public Property ySide() As Decimal
        Get
            Return ySideValue
        End Get
        Set(ByVal value As Decimal)
            If value >= -1D Then
                ySideValue = value
            Else
                Throw New ArgumentOutOfRangeException("side must be greater than or equal to 0 or -1 (unused)")
            End If
        End Set
    End Property

    Public Property Radius() As Decimal
        Get
            Return RadiusValue
        End Get
        Set(ByVal value As Decimal)
            If value >= -1D Then
                RadiusValue = value
            Else
                Throw New ArgumentOutOfRangeException("Radius must be greater than or equal to 0 or -1 (unused)")
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0}{4}{1}{2}{3}", MyBase.ToString(),
                             If(Me.xSide <> -1, String.Format("x Side: {0}cm{1}", Me.xSide, Environment.NewLine), ""),
                             If(Me.ySide <> -1, String.Format("y Side: {0}cm{1}", Me.ySide, Environment.NewLine), ""),
                             If(Me.Radius <> -1, String.Format("Radius: {0}cm{1}", Me.Radius, Environment.NewLine), ""),
                             Environment.NewLine)
    End Function

    Public MustOverride Function GetArea() As String

End Class