Public Class Form1
    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        Dim celsiusTempConvert As Double = CInt(celBox.Text)
        celLabel.Text = celsiusFunc(celsiusTempConvert)
    End Sub

    Private Sub fButton_Click(sender As Object, e As EventArgs) Handles fButton.Click
        Dim fahrenhitTempConvert As Double = CInt(fahBox.Text)
        fahLabel.Text = fahrenheitFunc(fahrenhitTempConvert)

    End Sub
    Function celsiusFunc(ByRef cTemp As Double)
        Dim fahrenheit As Double
        fahrenheit = (9 / 5) * cTemp + 32
        Return fahrenheit
    End Function

    Function fahrenheitFunc(ByVal fTemp As Double)
        Dim celsius As Double
        celsius = ((5 / 9) * (fTemp - 32))
        Return celsius
    End Function
End Class
