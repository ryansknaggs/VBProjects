Public Class Circle
    Inherits twoDimensional

    Public Sub New(ByVal radius As Decimal)
        MyBase.New("Circle", -1, -1, radius)
    End Sub

    Public Overrides Function GetArea() As String
        Return CDec(Math.PI * (Me.Radius ^ 2)).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}{2}Area: {1}cm²", MyBase.ToString, GetArea, Environment.NewLine)
    End Function

End Class
