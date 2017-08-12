Public Class Form1
    Dim array(3, 3) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Integer
        Dim col As Integer
        Dim counter As Integer = 1
        For row = 0 To 3

            For i = 0 To 3
                array(i, i) = 1
            Next

        Next
        For row = 0 To 3

            For i = 0 To 3
                Label1.Text &= array(i, i)
            Next
        Next
    End Sub
End Class
