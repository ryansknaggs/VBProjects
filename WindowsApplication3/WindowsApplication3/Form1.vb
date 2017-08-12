Public Class Form1

    Private Sub submitResultsButton_Click(sender As Object, e As EventArgs) Handles submitResultsButton.Click
        If resultListBox.Items.Count < 10 Then
            resultListBox.Items.Add(resultListBox.Text)
            resultTextBox.Clear()
            resultTextBox.Focus()
        End If

        If resultListBox.Items.Count = 10 Then
            submitResultsButton.Enabled = False
            resultTextBox.Enabled = False
            analyzeResultsButton.Enabled = True
        End If
    End Sub

    Private Sub analyzeResultsButton_Click(sender As Object, e As EventArgs) Handles analyzeResultsButton.Click
        Dim passes As Integer = 0
        Dim failures As Integer = 0
        Dim student As Integer = 0
        Dim result As String

        Do While student < 10
            result = resultListBox.Items(student)
            If result = "P" Then
                passes += 1
            Else failures += 1
            End If
            student += 1
        Loop
        analysisResultsLabel.Text = "Passed: " & passes & vbCrLf & "Failed: " & failures & vbCrLf
        If passes > 8 Then
            analysisResultsLabel.Text &= "Bonus to instructor!"
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        resultListBox.Items.Clear()
        analysisResultsLabel.Text = String.Empty
        submitResultsButton.Enabled = True
        analyzeResultsButton.Enabled = False
        resultTextBox.Focus()
    End Sub
End Class
