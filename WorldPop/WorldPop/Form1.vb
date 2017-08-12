Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim curPop As Double = Convert.ToDouble(currentPop.Text)
        Dim growRate As Double = Convert.ToDouble(growthRate.Text)
        growRate = growRate / 100

        Dim popIncrease As Double
        resultBox.Items.Clear()
        For count As Integer = 1 To 75
            popIncrease = curPop * growRate
            curPop += popIncrease
            resultBox.Items.Add(count & vbTab & Math.Truncate(curPop) & vbTab & Math.Truncate(popIncrease))
        Next
    End Sub
End Class
