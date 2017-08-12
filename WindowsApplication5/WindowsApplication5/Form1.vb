Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim power As Integer = 5
        Dim number As Integer = 10
        Dim result As Integer = number
        For i As Integer = 1 To (power - 1)
            result *= number
        Next
        TextBox1.AppendText(result)

    End Sub
End Class
