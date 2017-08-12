Public Class Form1
    Dim operand, count, numberOfnumbers As Integer

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        operand = enterOperandTextBox.Text
        operandListBox.Items.Add(operand)
        resultLabel.Clear()
        numberOfnumbers += 1
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim total As Integer
        For i As Integer = 0 To numberOfnumbers Step +1
            If count = operandListBox.Items.Count Then
                count = 0
            Else
                total += operandListBox.Items.Item(i)
                count += 1
            End If
        Next
        resultLabel.AppendText(total)
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        Dim total As Integer = 1
        For i As Integer = 0 To numberOfnumbers Step +1
            If count = operandListBox.Items.Count Then
                count = 0
            Else
                total *= operandListBox.Items.Item(i)
                count += 1
            End If
        Next
        resultLabel.AppendText(total)
    End Sub
End Class
