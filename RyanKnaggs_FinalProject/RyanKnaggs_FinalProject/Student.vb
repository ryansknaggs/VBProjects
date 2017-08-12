Imports System.IO
Public Class Student
    Private firstName, middleName, lastName, SSN As String
    Private grades As CalcControler

    Sub New(ByVal fName As String, ByVal mName As String, ByVal lName As String, ByVal social As String)
        firstName = fName
        middleName = mName
        lastName = lName
        SSN = social
    End Sub

    Public Property firstN() As String
        Get
            Return firstName
        End Get
        Set(value As String)
            firstName = value
        End Set
    End Property

    Public Property middleN() As String
        Get
            Return middleName
        End Get
        Set(value As String)
            middleName = value
        End Set
    End Property

    Public Property lastN() As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property

    Public Property socialNumber() As String
        Get
            Return SSN
        End Get
        Set(value As String)
            SSN = value
        End Set
    End Property

    Public Property grade() As CalcControler
        Get
            Return grades
        End Get
        Set(value As CalcControler)
            grades = value
        End Set
    End Property
End Class
