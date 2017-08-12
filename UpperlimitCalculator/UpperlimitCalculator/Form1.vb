Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim upperLimit As Integer = TextBox1.Text
        Dim count As Integer = 1
        ListBox1.Items.Clear()
        ListBox1.Items.Add("n" & vbTab & "n^2" & vbTab & "n^3")
        Do While upperLimit >= count
            ListBox1.Items.Add(count ^ 1 & vbTab & count ^ 2 & vbTab & count ^ 3)
            count += 1
        Loop
    End Sub
End Class
