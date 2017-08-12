Public Class SavingsAccount
    Inherits Account
    Private intrest As Decimal

    Sub New(ByVal balance As Decimal, ByVal newIntrest As Decimal)
        MyBase.New(balance)
        intrestAmount() = newIntrest
    End Sub

    Public Property intrestAmount()
        Get
            Return intrest
        End Get
        Set(value)
            intrest = value
        End Set
    End Property

    Public Function calculateIntrest()
        Dim totalIntrest As Decimal = yourBalance * intrest
        Return totalIntrest
    End Function

    Public Overrides Sub credit(currentCredit As Decimal)
        yourBalance() = currentCredit
    End Sub

    Public Overrides Function debit(currentDebit As Decimal) As Decimal
        Return MyBase.debit(currentDebit)
    End Function
End Class
