Imports System.IO
Public Class SaveControler
    Private student As Student
    Private saveTime As String

    'Parameterized constructor
    Sub New(newStudent As Student)
        student = newStudent
    End Sub

    'Get create time
    Public Property cTime() As String
        Get
            Return saveTime
        End Get
        Set(value As String)
            saveTime = value
        End Set
    End Property

    'Save method
    Public Sub Save()
        Dim result As DialogResult
        Dim fileName As String
        'Select file and specify it as .txt
        Using fileChooser As New SaveFileDialog()
            result = fileChooser.ShowDialog()
            fileName = fileChooser.FileName
        End Using
        Dim sw As StreamWriter
        Try
            'Check if file exist
            If (Not File.Exists(fileName)) Then
                sw = File.CreateText(fileName)
                sw.WriteLine("///////////////////////////////////////////////////////////////////")
                sw.WriteLine("Create Time: " & saveTime)
                sw.WriteLine(student.firstN & " " & student.middleN & " " & student.lastN & " " & "Class grades:")
                sw.WriteLine()
                sw.WriteLine("Assignment Grades: ")
                sw.WriteLine("Assignment 1: " & student.grade.aArray(0) & vbCrLf &
                             "Assignment 2: " & student.grade.aArray(1) & vbCrLf &
                             "Assignment 3: " & student.grade.aArray(2) & vbCrLf &
                             "Assignment 4: " & student.grade.aArray(3) & vbCrLf &
                             "Assignment 5: " & student.grade.aArray(4) & vbCrLf &
                             "Assignment 6: " & student.grade.aArray(5))
                sw.WriteLine()
                sw.WriteLine("Quizz Grades: ")
                sw.WriteLine("Quizz 1: " & student.grade.qArray(0) & vbCrLf &
                             "Quizz 2: " & student.grade.qArray(1) & vbCrLf &
                             "Quizz 3: " & student.grade.qArray(2) & vbCrLf &
                             "Quizz 4: " & student.grade.qArray(3))
                sw.WriteLine()
                sw.WriteLine("Exam Grades: ")
                sw.WriteLine("Exam 1: " & student.grade.eArray(0) & vbCrLf &
                             "Exam 2: " & student.grade.eArray(1))
                sw.WriteLine()
                sw.WriteLine("Final Project: " & student.grade.finalProject)
                sw.WriteLine("Attendance: " & FormatNumber(student.grade.atTotal, 1))
                sw.WriteLine()
                sw.WriteLine("Total Assignment Grades: " & FormatNumber(student.grade.aTotal, 1))
                sw.WriteLine("Total Quizz Grades: " & FormatNumber(student.grade.qTotal, 1))
                sw.WriteLine("Total Exam Grades: " & FormatNumber(student.grade.eTotal, 1))
                sw.WriteLine("Final Project Grade: " & student.grade.finalProject)
                sw.WriteLine("Total Attendance Grade: " & FormatNumber(student.grade.atTotal, 1))
                sw.WriteLine("Final Class Grade: " & FormatNumber(student.grade.TotalGradeCalc, 1))
                sw.WriteLine("///////////////////////////////////////////////////////////////////")
                sw.Close()
                'If file exist then append the text
            ElseIf (File.Exists(fileName)) Then
                sw = File.AppendText(fileName)
                sw.WriteLine()
                sw.WriteLine("///////////////////////////////////////////////////////////////////")
                sw.WriteLine("Create Time: " & saveTime)
                sw.WriteLine(student.firstN & " " & student.middleN & " " & student.lastN & " " & "Class grades:")
                sw.WriteLine()
                sw.WriteLine("Assignment Grades: ")
                sw.WriteLine("Assignment 1: " & student.grade.aArray(0) & vbCrLf &
                             "Assignment 2: " & student.grade.aArray(1) & vbCrLf &
                             "Assignment 3: " & student.grade.aArray(2) & vbCrLf &
                             "Assignment 4: " & student.grade.aArray(3) & vbCrLf &
                             "Assignment 5: " & student.grade.aArray(4) & vbCrLf &
                             "Assignment 6: " & student.grade.aArray(5))
                sw.WriteLine()
                sw.WriteLine("Quizz Grades: ")
                sw.WriteLine("Quizz 1: " & student.grade.qArray(0) & vbCrLf &
                             "Quizz 2: " & student.grade.qArray(1) & vbCrLf &
                             "Quizz 3: " & student.grade.qArray(2) & vbCrLf &
                             "Quizz 4: " & student.grade.qArray(3))
                sw.WriteLine()
                sw.WriteLine("Exam Grades: ")
                sw.WriteLine("Exam 1: " & student.grade.eArray(0) & vbCrLf &
                             "Exam 2: " & student.grade.eArray(1))
                sw.WriteLine()
                sw.WriteLine("Final Project: " & student.grade.finalProject)
                sw.WriteLine("Attendance: " & FormatNumber(student.grade.atTotal, 1))
                sw.WriteLine()
                sw.WriteLine("Total Assignment Grades: " & FormatNumber(student.grade.aTotal, 1))
                sw.WriteLine("Total Quizz Grades: " & FormatNumber(student.grade.qTotal, 1))
                sw.WriteLine("Total Exam Grades: " & FormatNumber(student.grade.eTotal, 1))
                sw.WriteLine("Final Project Grade: " & student.grade.finalProject)
                sw.WriteLine("Total Attendance Grade: " & FormatNumber(student.grade.atTotal, 1))
                sw.WriteLine("Final Class Grade: " & FormatNumber(student.grade.TotalGradeCalc, 1))
                sw.WriteLine("///////////////////////////////////////////////////////////////////")
                sw.Close()
            End If
        Catch ex As IOException
            MsgBox("Error writing to log file.")
        End Try
    End Sub
End Class
