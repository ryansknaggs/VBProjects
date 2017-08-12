Public Class SavingsAccount
    Private Shared annualInterestRate As Double
    Private savingsBalance As Double

    Function CalculateMonthlyInterest()
        savingsBalance = (annualInterestRate * savingsBalance) / (12)
        Return Math.Floor(100 * savingsBalance)
    End Function

    Public WriteOnly Property ModifiedInterestRate() As Double
        Set(Rate As Double)
            annualInterestRate = Rate
        End Set
    End Property

    Property newSavingsBalance() As Double
        Get
            Return savingsBalance
        End Get
        Set(newSavingsBalance As Double)
            savingsBalance = newSavingsBalance
        End Set
    End Property
End Class
