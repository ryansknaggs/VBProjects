Public Class Form1
    Dim product1, product2, product3, product4, product5, total As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        outputLabel.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productLabel As Integer = NumericUpDown.Value
        Dim quantitySold As Integer = quanitySoldTextBox.Text
        Select Case productLabel
            Case 1
                product1 += 2.98 * quantitySold
                total += product1
            Case 2
                product2 += 4.5 * quantitySold
                total += product1
            Case 3
                product3 += 9.98 * quantitySold
                total += product1
            Case 4
                product4 += 4.49 * quantitySold
                total += product1
            Case 5
                product5 += 6.87 * quantitySold
                total += product1
        End Select

        outputLabel.Text = "Product 1 " & FormatCurrency(product1) & vbNewLine _
                         & "Product 2 " & FormatCurrency(product2) & vbNewLine _
                         & "Product 3 " & FormatCurrency(product3) & vbNewLine _
                         & "Product 4 " & FormatCurrency(product4) & vbNewLine _
                         & "Product 5 " & FormatCurrency(product5) & vbNewLine _
                         & "Total of all products sold: " & FormatCurrency(total)
    End Sub
End Class
