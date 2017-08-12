Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newDate As New DateInformation()

        Dim d As Integer = dBox.Text
        Dim m As Integer = mBox.Text
        Dim y As Integer = yBox.Text

        newDate.theMonth = m
        newDate.theDay = d
        newDate.theYear = y

        ListBox1.Items.Add(newDate.day & "/" & newDate.month & "/" & newDate.year)

    End Sub
End Class
