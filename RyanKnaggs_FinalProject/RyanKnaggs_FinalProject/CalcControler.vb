Public Class CalcControler
    Private assignments(5) As Double
    Private quizzes(3) As Double
    Private exams(2) As Double
    Private saveTime As String
    Private attendance, final, assTotal, quizzTotal, examTotal, attTotal, finalTotal, totalGrade As Double

    'Calculate assignment grade
    Public Sub assingnCalc(a1 As Double, a2 As Double, a3 As Double, a4 As Double, a5 As Double, a6 As Double)
        assignments(0) = a1
        assignments(1) = a2
        assignments(2) = a3
        assignments(3) = a4
        assignments(4) = a5
        assignments(5) = a6
        For column = 0 To assignments.Length - 1
            assTotal += assignments(column)
        Next
        assTotal = assTotal / 6
    End Sub

    'Calculate quizz grade
    Public Sub quizzCalc(q1 As Double, q2 As Double, q3 As Double, q4 As Double)
        quizzes(0) = q1
        quizzes(1) = q2
        quizzes(2) = q3
        quizzes(3) = q4
        For column = 0 To quizzes.Length - 1
            quizzTotal += quizzes(column)
        Next
        quizzTotal = quizzTotal / 4
    End Sub

    'Calculate exam grades
    Public Sub examCalc(e1 As Double, e2 As Double)
        exams(0) = e1
        exams(1) = e2
        For column = 0 To exams.Length - 1
            examTotal += exams(column)
        Next
        examTotal = examTotal / 2
    End Sub

    'Calculate attendance grade
    Public Sub attendenceCalc(att As Double)
        attTotal = (att * 5.2631578947368425)
    End Sub

    'Calculate final grade
    Public Sub finalCalc(fin As Double)
        finalTotal = fin
    End Sub

    'Determine letter grade
    Function LetterGrade(grade As Double) As String
        Dim output As String
        Select Case grade
            Case Is >= 90
                output = "A = Excellent!"
            Case Is >= 80
                output = "B = Very Good!"
            Case Is >= 70
                output = "C = Good!"
            Case Is >= 60
                output = "D = Poor!"
            Case Else
                output = "F = Failing!"
        End Select
        Return output
    End Function


    'Calculate total geade
    Public Function TotalGradeCalc()
        totalGrade = (assTotal * 0.2) + (quizzTotal * 0.15) + (examTotal * 0.3) + (attTotal * 0.1) + (finalTotal * 0.25)
        Return totalGrade
    End Function

    'Get quizz total
    Public ReadOnly Property qTotal()
        Get
            Return quizzTotal
        End Get
    End Property

    'Get exam total
    Public ReadOnly Property eTotal()
        Get
            Return examTotal
        End Get
    End Property

    'Get attendance total
    Public ReadOnly Property aTotal()
        Get
            Return assTotal
        End Get
    End Property

    'Get attendance total
    Public ReadOnly Property atTotal()
        Get
            Return attTotal
        End Get
    End Property

    'Get assignments array
    Public ReadOnly Property aArray()
        Get
            Return assignments
        End Get
    End Property

    'Get exam array
    Public ReadOnly Property eArray()
        Get
            Return exams
        End Get
    End Property

    'Get quiz array
    Public ReadOnly Property qArray()
        Get
            Return quizzes
        End Get
    End Property

    'Get final project
    Public ReadOnly Property finalProject()
        Get
            Return finalTotal
        End Get
    End Property

    'Get attendence
    Public ReadOnly Property totalAttendence()
        Get
            Return attendance
        End Get
    End Property

End Class
