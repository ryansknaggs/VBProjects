Public Class DateInformation
    Public month As Integer
    Public day As Integer
    Public year As Integer

    Public Sub New()
        setDate(theMonth, theDay, theYear)
    End Sub

    Public Sub setDate(m As Integer, d As Integer, y As Integer)
        month = m
        day = d
        year = y
    End Sub

    'Month
    Public Property theMonth() As Integer
        Get
            Return month
        End Get
        Set(newMonth As Integer)
            If newMonth >= 1 AndAlso newMonth <= 12 Then
                month = newMonth
            Else
                MessageBox.Show("You must enter a valid month!")
                Throw New ArgumentOutOfRangeException("You must enter a valid month!")
            End If
        End Set
    End Property

    Public Property theDay() As Integer
        Get
            Return day
        End Get
        Set(newDay As Integer)
            If month = 1 Or month = 3 Or month = 5 Or month = 7 Or month = 8 Or month = 9 Or month = 10 Or month = 12 Then
                If newDay >= 1 AndAlso newDay <= 31 Then
                    day = newDay
                Else MessageBox.Show("This month only has 30 days!")
                    Throw New ArgumentOutOfRangeException("This month only has 30 days!")
                End If
            ElseIf month = 2 Then
                If newDay >= 1 AndAlso newDay <= 28 Then
                    day = newDay
                Else
                    MessageBox.Show("Febuary only has 29 days!")
                    Throw New ArgumentOutOfRangeException("Febuary only has 29 days!")
                End If
            ElseIf month = 4 Or month = 6 Or month = 9 Or month = 11 Then
                If newDay >= 1 AndAlso newDay <= 30 Then
                    day = newDay
                Else
                    MessageBox.Show("September, April, June, and November only have 30 days!")
                    Throw New ArgumentOutOfRangeException("September, April, June, and November only have 30 days!")
                End If
            End If

        End Set
    End Property

    Public Property theYear() As Integer
        Get
            Return year
        End Get
        Set(newYear As Integer)
            If newYear > 0 AndAlso newYear < 9999 Then
                year = newYear
            Else
                Throw New ArgumentOutOfRangeException("You must enter a valid year")
            End If
        End Set
    End Property
End Class
