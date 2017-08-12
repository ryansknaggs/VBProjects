Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim accountNum As Integer = aBox.Text
        Dim startBal As Double = sBox.Text
        Dim totalCharges As Double = chargeBox.Text
        Dim totalCredit As Double = creditBox.Text
        Dim creditLimit As Double = limitBox.Text
        Dim newBalance As Double = startBal - totalCredit + totalCharges
        If totalCharges + totalCredit > creditLimit Or newBalance > creditLimit Then
            newbalanceBox.Text = 0
            rCreditBox.Text = "You have exceded your credit limit!"
        ElseIf startBal > creditLimit Or newBalance < 0 Then
            newbalanceBox.Text = 0
            rCreditBox.Text = "Balance Error"
        Else
            newbalanceBox.Text = String.Format("{0:C}", newBalance)
        rCreditBox.Text = "Remaining cedit : " & String.Format("{0:C}", creditLimit - newBalance)
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        aBox.Clear()
        sBox.Clear()
        chargeBox.Clear()
        creditBox.Clear()
        limitBox.Clear()
        rCreditBox.Clear()
        newbalanceBox.Clear()
    End Sub
End Class
