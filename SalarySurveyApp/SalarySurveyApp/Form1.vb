Public Class SalarySurvey
    Dim intCounter(9) As Integer
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim salary As Integer = salesTextBox.Text
        Dim salaryTotal As Integer = (0.09 * salary) + 200
        Select Case (salaryTotal)
            Case 200 To 299
                intCounter(0) += 1
            Case 300 To 399
                intCounter(1) += 1
            Case 400 To 499
                intCounter(2) += 1
            Case 500 To 599
                intCounter(3) += 1
            Case 600 To 699
                intCounter(4) += 1
            Case 700 To 799
                intCounter(5) += 1
            Case 800 To 899
                intCounter(6) += 1
            Case 900 To 999
                intCounter(7) += 1
            Case > 999
                intCounter(8) += 1
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalTextBox.Text = "200 To 300:" & intCounter(0).ToString & vbNewLine &
                            "300 To 399:" & intCounter(1).ToString & vbNewLine &
                            "400 To 499:" & intCounter(2).ToString & vbNewLine &
                            "500 To 599:" & intCounter(3).ToString & vbNewLine &
                            "600 To 699:" & intCounter(4).ToString & vbNewLine &
                            "700 To 799:" & intCounter(5).ToString & vbNewLine &
                            "800 To 899:" & intCounter(6).ToString & vbNewLine &
                            "900 To 999:" & intCounter(7).ToString & vbNewLine &
                            "999 and greater:" & intCounter(8).ToString
    End Sub
End Class
