Public Class Form1
    Dim count As Integer = 1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim square As New Square(TextBox.Text)
        ListBox.Items.Add("Square Number: " & count)
        ListBox.Items.Add("Side: " & TextBox.Text)
        ListBox.Items.Add("Perimeter: " & square.Perimeter)
        ListBox.Items.Add("Area: " & square.Area)
        ListBox.Items.Add("Diagonal: " & square.Diagonal)
        ListBox.Items.Add("")
        count += 1
    End Sub
End Class
