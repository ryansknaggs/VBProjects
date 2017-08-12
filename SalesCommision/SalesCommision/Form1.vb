Public Class Form1
    Dim pcent As Double
    Dim total, totalWComm As Double
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim quanity As Integer = itemsSoldBox.Text
        percentage(quanity)
        grossSales(quanity)
        earnings(quanity)

    End Sub

    Private Sub percentage(quanitySold)
        Select Case (quanitySold)
            Case 0 To 50
                pcent = 0.06
                perCentLabel.Text = FormatPercent(0.06)
            Case 50 To 100
                pcent = 0.07
                perCentLabel.Text = FormatPercent(0.07)
            Case 101 To 150
                pcent = 0.08
                perCentLabel.Text = FormatPercent(0.08)
            Case Is > 150
                pcent = 0.09
                perCentLabel.Text = FormatPercent(0.09)
        End Select
    End Sub

    Private Sub grossSales(quanitySold)
        total = quanitySold * 10
        totalWComm = (total * pcent) + total
        grossLabel.Text = FormatCurrency(totalWComm)
    End Sub

    Private Sub earnings(quanitySold)
        earningsLabel.Text = FormatCurrency(total * pcent)
    End Sub


End Class
