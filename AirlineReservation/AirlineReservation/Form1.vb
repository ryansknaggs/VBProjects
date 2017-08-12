Public Class Form1
    Dim seats(9) As Boolean
    Dim i As Integer
    Dim j As Integer = 5
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim economySelect As Boolean = economyBox.Checked
        Dim firstClassSelect As Boolean = firstClassBox.Checked

        If economySelect = True Then
            If j >= 5 And j <= 9 Then
                If seats(j) = False And seats.Length - 1 Then
                    seats(j) = True
                    displayBox.Text = "Yor Seat Number is: " & j + 1
                    j += 1
                End If
            ElseIf MessageBox.Show("Next Flight In 3 Hours") Then
            End If
        End If

        If firstClassSelect = True Then
            If i < 5 Then
                If seats(i) = False And j < seats.Length - 1 Then
                    seats(i) = True
                    displayBox.Text = "Yor Seat Number is: " & i + 1
                    i += 1
                End If
            Else MessageBox.Show("Next Flight In 3 Hours")
            End If
        End If

    End Sub
End Class
