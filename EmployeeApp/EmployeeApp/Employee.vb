Public Class Employee
    Public firstName As String
    Public lastName As String
    Public salary As Integer

    Public Sub New()
        firstName = " "
        lastName = " "
        salary = 0
    End Sub

    'first Name
    Public Property fName() As String
        Get
            Return firstName
        End Get
        Set(newFirstName As String)
            firstName = newFirstName
        End Set
    End Property

    'Last Name
    Public Property lName() As String
        Get
            Return lastName
        End Get
        Set(newLastName As String)
            lastName = newLastName
        End Set
    End Property

    'Set Salary
    Public Property sal() As Integer
        Get
            Return salary
        End Get
        Set(newSalary As Integer)
            If newSalary < 0 Then
                Throw New ArgumentOutOfRangeException("Salary must be a positive number!")
            Else salary = (newSalary * 0.1) + newSalary
            End If
        End Set
    End Property

    Public Property salWithout() As Integer
        Get
            Return salary
        End Get
        Set(newSalary As Integer)
            If newSalary < 0 Then
                Throw New ArgumentOutOfRangeException("Salary must be a positive number!")
            Else salary = newSalary
            End If
        End Set
    End Property

    Function displayEmployee()
        Return "First Name: " & firstName & " Last Name: " & lastName & " Salary: " & FormatCurrency(salary)
    End Function

End Class
