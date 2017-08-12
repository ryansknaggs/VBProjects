Public Class DuplicateElimination
    Dim array(19) As Integer
    Dim numArray(19) As Integer
    Dim i, k As Integer

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim bool As Boolean = False
        If i <= array.Length - 1 Then
            For j As Integer = 0 To numArray.Length - 1
                If array(j) = numberBox.Text Then
                    bool = True
                End If
            Next
            array(i) = numberBox.Text
        Else MessageBox.Show("You Have Entered To Many Numbers!")
        End If
        i += 1
        If bool = True Then
            numArray(k) = numberBox.Text
            k += 1
        End If
    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        uniqueValuesListBox.Items.Clear()
        numbersEnteredListBox.Items.Clear()
        For a As Integer = 0 To numArray.Length - 1
            If numArray(a) = 0 Then
            Else uniqueValuesListBox.Items.Add(numArray(a))
            End If
        Next
        For b As Integer = 0 To array.Length - 1
            If array(b) = 0 Then
            Else numbersEnteredListBox.Items.Add(array(b))
            End If
        Next
    End Sub
End Class
