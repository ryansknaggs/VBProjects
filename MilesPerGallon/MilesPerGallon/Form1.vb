Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim miles As Double = milesBox.Text
        Dim gallons As Double = gallonsBox.Text
        Dim totalGallons As Double
        Dim totalMiles As Double
        Dim totalMPG As Double
        Dim mpg As Double
        Dim count As Double
        Dim a As Double
        If gallons <= 0 Then
            TextBox1.Text = "Gallons cant be zero!"
        Else
            mpg = miles / gallons
            mBox.Items.Add(String.Format("{0:N2}", miles))
            gBox.Items.Add(String.Format("{0:N2}", gallons))
            mpgBox.Items.Add(String.Format("{0:N2}", mpg))
            Do While count < mBox.Items.Count
                totalGallons += gBox.Items(count)
                totalMiles += mBox.Items(count)
                totalMPG += mpgBox.Items(count)
                count += 1
                a = totalMPG / count
            Loop
            TextBox1.AppendText("Total miles driven: " & vbTab & String.Format("{0:F2}", totalMiles) & vbNewLine _
                          & "Total gallons used: " & vbTab & String.Format("{0:F2}", totalGallons) & vbNewLine _
                          & "Total MPG: " & vbTab & String.Format("{0:F2}", a) & vbNewLine)
        End If
    End Sub
End Class
