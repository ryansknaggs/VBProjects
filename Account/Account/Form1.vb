Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim savings As New SavingsAccount(1000, 0.7 / 100)
        Dim checking As New CheckingAccount(2000, 3)
        savings.credit(savings.calculateIntrest)
        ListBox1.Items.Add("ACCOUNT INHERITANCE HIERACHY")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Savings Balance with added intrest: " & FormatCurrency(savings.yourBalance))
        savings.debit(400)
        ListBox1.Items.Add("Savings Balance After Debit: " & FormatCurrency(savings.yourBalance))
        savings.credit(savings.calculateIntrest + 600)
        ListBox1.Items.Add("Savings Balance After Credit: " & FormatCurrency(savings.yourBalance))
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Checking Balance: " & FormatCurrency(checking.yourBalance))
        checking.credit(100)
        ListBox1.Items.Add("Checking Balance Credit " & FormatCurrency(checking.yourBalance))
        checking.debit(200)
        ListBox1.Items.Add("Checking Balance Debit Minus $3.00 tranFee" & FormatCurrency(checking.yourBalance))
    End Sub
End Class
