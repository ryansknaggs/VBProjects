Public Class CheckingAccount
    Inherits Account
    Private tranFee As Decimal

    Sub New(ByVal balance As Decimal, ByVal tFee As Decimal)
        MyBase.New(balance)
        fee() = tFee
    End Sub

    Public Property fee()
        Get
            Return tranFee
        End Get
        Set(value)
            tranFee = value
        End Set
    End Property

    Public Overrides Sub credit(currentCredit As Decimal)
        yourBalance() = currentCredit - tranFee
    End Sub

    Public Overrides Function debit(currentDebit As Decimal) As Decimal
        If currentDebit > 0 Then
            Return MyBase.debit(currentDebit - tranFee)
        End If
        Return 0
    End Function

End Class
