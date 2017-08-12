
Public Class Form1
    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate.Click
        Dim hoursParked As Double = Convert.ToDouble(hoursBox.Text)
        totalLabel.Text = String.Format("{0:C}", calculateCharges(hoursParked))
    End Sub

    Function calculateCharges(ByVal hours As Double) As Decimal
        Dim Charge As Decimal = 2D
        If hours < 3.0 Then
            Charge = 2D
        ElseIf hours > 3.0 Then
            Charge = (0.5D * hours) + 0.5D
        End If
        If Charge > 10D Then
            Return 10D
        Else Return Charge
        End If
    End Function
End Class

