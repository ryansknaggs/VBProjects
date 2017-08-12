Public Class Form1
    ' calculate amount in account after one year
    Private Sub calculateButton_Click(ByVal sender As System.Object,
       ByVal e As System.EventArgs) Handles calculateButton.Click

        Select Case startingAmountTextBox.Text Mod 2
            Case 0
                resultLabel.Text = "odd"
            Case 1
                resultLabel.Text = "even"
        End Select
    End Sub ' calculateButton_Click
End Class
