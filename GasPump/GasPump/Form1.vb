Public Class GasPump
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles regButton.Click
        Dim regularGallons As Double = regBox.Text
        totalCost(regularGallons, regButton.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles specialButton.Click
        Dim specialGallons As Double = specialBox.Text
        totalCost(specialGallons, specialButton.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles superButton.Click
        Dim superGallons As Double = superBox.Text
        totalCost(superGallons, superButton.Text)
    End Sub

    Private Sub totalCost(gallons, gasType)
        If gasType = "Regular" Then
            totalBox.Text = FormatCurrency(gallons * 2.69)
        ElseIf gasType = "Special" Then
            totalBox.Text = FormatCurrency(gallons * 2.79)
        ElseIf gasType = "Super" Then
            totalBox.Text = FormatCurrency(gallons * 2.89)
        End If
    End Sub
End Class
