Public Class Form1
    Dim max As Double
    Dim min As Double
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim value1 As Double = TextBox1.Text
        Dim value2 As Double = TextBox2.Text
        Dim value3 As Double = TextBox3.Text
        largest(value1, value2, value3)
        smallest(value1, value2, value3)
    End Sub

    Private Sub largest(value1 As Double, value2 As Double, value3 As Double)
        max = Math.Max(value1, value2)
        largestValue.Text = Math.Max(max, value3)
    End Sub

    Private Sub smallest(value1 As Double, value2 As Double, value3 As Double)
        min = Math.Min(value1, value2)
        smallestValue.Text = Math.Min(min, value3)
    End Sub
End Class
