Public Class Account
    Private balance As Decimal

    'Non parameter constructor
    Sub New()
        balance = 0
    End Sub

    'Required constructor
    Sub New(setBalance As Decimal)
        yourBalance() = setBalance
    End Sub

    'Mutator / Accessor Property
    Public Property yourBalance() asDecimal
        Set(value)
            If (value >= 0.0) Then
                balance += value
            Else Throw New ArgumentOutOfRangeException("You must enter a balance greater then zero!")
            End If
        End Set
        Get
            Return balance
        End Get
    End Property

    Public Overridable Sub credit(addCredit As Decimal)
        balance += addCredit
    End Sub

    Public Overridable Function debit(currentDebit As Decimal) As Decimal
        Dim total As Decimal = balance - currentDebit
        balance -= currentDebit
        If (total < 0) Then
            Throw New ArgumentOutOfRangeException("You cant take out that much!")
        End If
        Return currentDebit
    End Function
End Class
