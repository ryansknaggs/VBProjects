Public Class Square
    Inherits twoDimensional

    Public Sub New(ByVal xSize As Decimal, ByVal ySize As Decimal)
        MyBase.New("Square", xSize, ySize, -1)
    End Sub

    Public Overrides Function GetArea() As String
        Return (Me.xSide * Me.ySide).ToString("f3").Replace(".000", "")
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}{2}Area: {1}cm²", MyBase.ToString, GetArea, Environment.NewLine)
    End Function

End Class
