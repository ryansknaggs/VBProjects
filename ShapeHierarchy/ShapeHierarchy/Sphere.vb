Public Class Sphere
    Inherits threeDimensional

    Public Sub New(ByVal zRadius As Decimal)
        MyBase.New("Sphere", -1, -1, zRadius)
    End Sub

    Public Overrides Function GetSurfaceArea() As String
        Return CDec(4 * Math.PI * Me.Radius ^ 2).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function GetVolume() As String
        Return CDec((4 / 3) * Math.PI * Me.Radius ^ 3).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}{3}{3}Surface Area: {1}cm²{3}Volume: {2}cm³", MyBase.ToString, GetSurfaceArea, GetVolume, Environment.NewLine)
    End Function

End Class
