Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim hourlyWage As Double = wageBox.Text
        Dim weeklyHours As Double = hoursBox.Text
        Dim grossEarnings As Double = hourlyWage * weeklyHours
        Dim tax As Double = 0.15
        Dim grossEarningsTaxed As Double = grossEarnings * tax
        Dim overtimeHours As Double
        Dim overtime As Double
        Dim overtimeTotal As Double

        If weeklyHours > 40 Then
            grossEarnings = hourlyWage * 40
            overtimeHours = weeklyHours - 40
            overtime = overtimeHours * 1.5 * hourlyWage
            overtimeTotal = (grossEarnings + overtime)

            gEarningsBox.Text = Format(overtimeTotal, "c")
            fwtBox.Text = Format(overtimeTotal * tax, "c")
            nEarningsBox.Text = Format(overtimeTotal - (overtimeTotal * tax), "c")
        Else
            gEarningsBox.Text = Format(grossEarnings, "c")
            fwtBox.Text = Format(grossEarningsTaxed, "c")
            nEarningsBox.Text = Format(grossEarnings - grossEarningsTaxed, "c")
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        gEarningsBox.Clear()
        wageBox.Clear()
        hoursBox.Clear()
        fwtBox.Clear()
        nEarningsBox.Clear()
    End Sub
End Class
