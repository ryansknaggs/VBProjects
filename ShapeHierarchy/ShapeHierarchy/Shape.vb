Public MustInherit Class Shape

    Private ShapeName As String

    Public Sub New(ByVal shape As String)
        ShapeName = shape
    End Sub

    Public ReadOnly Property shape() As String
        Get
            Return ShapeName
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("Shape: {0}", ShapeName)
    End Function

End Class
