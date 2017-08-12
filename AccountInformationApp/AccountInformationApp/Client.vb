Public Class Client
    Private firstName, lastName, accountNumber As String
    Private accountBalance As Double

    Sub New(fName As String, lName As String, accNum As String, accBal As Double)
        firstName = fName
        lastName = lName
        accountNumber = accNum
        accountBalance = accBal
    End Sub

    ReadOnly Property firstN()
        Get
            Return firstName
        End Get
    End Property

    ReadOnly Property lastN()
        Get
            Return LastName
        End Get
    End Property

    ReadOnly Property accN()
        Get
            Return accountNumber
        End Get
    End Property

    ReadOnly Property bal()
        Get
            Return accountBalance
        End Get
    End Property

End Class
