Public Class Cube
    Inherits threeDimensional

    Public Sub New(ByVal xSide As Decimal, ByVal ySide As Decimal, ByVal zRadius As Decimal)
        MyBase.New("Cube", xSide, ySide, zRadius)
    End Sub

    Public Overrides Function GetSurfaceArea() As String
        Return (((Me.xSide * Me.ySide) * 2) + ((Me.xSide * Me.Radius) * 2) + ((Me.ySide * Me.Radius) * 2)).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function GetVolume() As String
        Return (Me.xSide * Me.ySide * Me.Radius).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}{3}{3}Surface Area: {1}cm²{3}Volume: {2}cm³", MyBase.ToString, GetSurfaceArea, GetVolume, Environment.NewLine)
    End Function

End Class
