Public MustInherit Class threeDimensional
    Inherits Shape

    Private xSideValue As Decimal
    Private ySideValue As Decimal
    Private zRadiusValue As Decimal

    Public Sub New(ByVal shape As String, ByVal xSide As Decimal, ByVal ySide As Decimal, ByVal zRadius As Decimal)
        MyBase.New(shape)
        Me.xSide = xSide
        Me.ySide = ySide
        Me.Radius = zRadius
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
            Return zRadiusValue
        End Get
        Set(ByVal value As Decimal)
            If value >= 0D Then
                zRadiusValue = value
            Else
                Throw New ArgumentOutOfRangeException(If(MyBase.shape = "Sphere", "Radius ", "z Value ") & "must be greater than or equal to 0")
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0}{4}{1}{2}{3}cm", MyBase.ToString(),
                             If(Me.xSide <> -1, String.Format("x Side: {0}cm{1}", Me.xSide, Environment.NewLine), ""),
                             If(Me.ySide <> -1, String.Format("y Side: {0}cm{1}", Me.ySide, Environment.NewLine), ""),
                             If(MyBase.shape = "Cube", "z Side: ", "Radius: ") & Me.Radius,
                             Environment.NewLine)
    End Function

    Public MustOverride Function GetSurfaceArea() As String
    Public MustOverride Function GetVolume() As String

End Class
