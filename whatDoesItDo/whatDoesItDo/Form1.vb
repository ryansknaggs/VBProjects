Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer
        Dim x As Integer
        Dim mysteryValue As Integer

        x = 1
        mysteryValue = 0
        Do
            y = x ^ 2
            ListBox1.Items.Add(y)
            mysteryValue += 1
            x += 1
        Loop While x <= 10
        TextBox1.Text = mysteryValue
    End Sub
End Class
