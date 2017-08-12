Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saver1 As New SavingsAccount()
        Dim saver2 As New SavingsAccount()
        saver1.ModifiedInterestRate = 0.04
        saver1.newSavingsBalance = 2000.0
        saver2.newSavingsBalance = 3000.0
        ListBox1.Items.Add("Saver 1: " & saver1.CalculateMonthlyInterest)
        ListBox1.Items.Add("Saver 2: " & saver2.CalculateMonthlyInterest)
        saver1.ModifiedInterestRate = 0.05
        saver1.newSavingsBalance = 2000.0
        saver2.newSavingsBalance = 3000.0
        ListBox1.Items.Add("Saver 1: " & saver1.CalculateMonthlyInterest)
        ListBox1.Items.Add("Saver 2: " & saver2.CalculateMonthlyInterest)
    End Sub
End Class
