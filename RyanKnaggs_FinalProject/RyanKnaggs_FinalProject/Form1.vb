
Public Class gradeCalculator
    Dim student As Student
    Dim save As SaveControler
    Dim grades As CalcControler
    Private Sub recordButton_Click(sender As Object, e As EventArgs) Handles recordButton.Click
        Dim first As String = fNameBox.Text
        Dim middle As String = mNameBox.Text
        Dim last As String = lNameBox.Text
        Dim ssn As String = ssnBox.Text
        Dim aBox() As String = {a1Box.Text, a2Box.Text, a3Box.Text, a4Box.Text, a5Box.Text, a6Box.Text}
        Dim qBox() As String = {q1Box.Text, q2Box.Text, q3Box.Text, q4Box.Text}
        Dim eBox() As String = {e1Box.Text, e2Box.Text}
        Dim atBox As String = attBox.Text
        Dim fBox As String = finalBox.Text
        Dim a As Boolean = True
        Dim b As Boolean = True
        Dim c As Boolean = True
        Dim d As Boolean = True
        Dim f As Boolean = True
        Dim g As Boolean = True
        displayBox.Items.Clear()
        student = New Student(first, middle, last, ssn)
        grades = New CalcControler()

        'Check to see if textBox is empty
        If first = "" Then
            MsgBox("First name box is empty.", vbExclamation, "ERROR")
            g = False
        End If

        'Check to see if textBox is empty
        If middle = "" Then
            MsgBox("Middle name box is empty.", vbExclamation, "ERROR")
            g = False
        End If

        'Check to see if textBox is empty
        If last = "" Then
            MsgBox("Last name box is empty.", vbExclamation, "ERROR")
            g = False
        End If

        'Check to see if textBox is empty
        If ssn = "" Then
            MsgBox("SSN box is empty.", vbExclamation, "ERROR")
            g = False
        End If

        'Check to see if textBox is empty
        For k As Integer = 0 To aBox.Length - 1
            If IsNumeric(aBox(k)) = False Then
                MsgBox("Assignment box " & k + 1 & " is empty or you entered an invalid character.", vbExclamation, "ERROR")
                aBox(k) = 0
                g = False
            End If
        Next

        'Check to see if textBox is empty
        For k As Integer = 0 To qBox.Length - 1
            If IsNumeric(qBox(k)) = False Then
                MsgBox("Quizz box " & k + 1 & " is empty is empty or you entered an invalid character.", vbExclamation, "ERROR")
                qBox(k) = 0
                g = False
            End If
        Next

        'Check to see if textBox is empty
        For k As Integer = 0 To eBox.Length - 1
            If IsNumeric(eBox(k)) = False Then
                MsgBox("Exam box " & k + 1 & " is empty is empty or you entered an invalid character.", vbExclamation, "ERROR")
                eBox(k) = 0
                g = False
            End If
        Next

        'Check to see if textBox is empty
        If IsNumeric(atBox) = False Then
            MsgBox("Attendance box is empty is empty or you entered an invalid character.", vbExclamation, "ERROR")
            atBox = 0
            g = False
        End If

        'Check to see if textBox is empty
        If IsNumeric(fBox) = False Then
            MsgBox("Final box is empty is empty or you entered an invalid character.", vbExclamation, "ERROR")
            fBox = 0
            g = False
        End If

        'Check to see if imput in in the right range
        If aBox(0) > 100 Or aBox(0) < 0 Or aBox(1) > 100 Or aBox(1) < 0 Or aBox(2) > 100 Or aBox(2) < 0 Or aBox(3) > 100 Or aBox(3) < 0 Or aBox(4) > 100 Or aBox(4) < 0 Or aBox(5) > 100 Or aBox(5) < 0 Then
            MsgBox("Inproper assignment range (0 - 100)!", vbExclamation, "ERROR")
            a = False
        Else grades.assingnCalc(aBox(0), aBox(1), aBox(2), aBox(3), aBox(4), aBox(5))
        End If

        'Check to see if imput in in the right range
        If qBox(0) > 100 Or qBox(0) < 0 Or qBox(1) > 100 Or qBox(1) < 0 Or qBox(2) > 100 Or qBox(2) < 0 Or qBox(3) > 100 Or qBox(3) < 0 Then
            MsgBox("Inproper quiz range (0 - 100)!", vbExclamation, "ERROR")
            b = False
        Else grades.quizzCalc(qBox(0), qBox(1), qBox(2), qBox(3))
        End If

        'Check to see if imput in in the right range
        If eBox(0) > 100 Or eBox(0) < 0 Or eBox(1) > 100 Or eBox(1) < 0 Then
            MsgBox("Inproper exam range (0 - 100)!", vbExclamation, "ERROR")
            c = False
        Else grades.examCalc(eBox(0), eBox(1))
        End If

        'Check to see if imput in in the right range
        If fBox > 100 Or fBox < 0 Then
            MsgBox("Inproper final range (0 - 100)!", vbExclamation, "ERROR")
            d = False
        Else grades.finalCalc(fBox)
        End If

        'Check to see if imput in in the right range
        If atBox > 19 Or atBox < 0 Then
            MsgBox("Inproper attendance range (0 - 19)!", vbExclamation, "ERROR")
            f = False
        Else grades.attendenceCalc(atBox)
        End If

        'Calculates the over all grade for all the assignments
        grades.TotalGradeCalc()

        'Check if all input is ok before trying to display it.
        If (a) And (b) And (c) And (d) And (f) And (g) Then
            If (numericRadioButton.Checked) Then
                displayBox.Items.Add("First Name: " & student.firstN())
                displayBox.Items.Add("Middle Name: " & student.middleN())
                displayBox.Items.Add("Last Name: " & student.lastN())
                displayBox.Items.Add("SSN: " & student.socialNumber())
                displayBox.Items.Add("Assignments: " & FormatNumber(grades.aTotal, 1))
                displayBox.Items.Add("Quizzes: " & FormatNumber(grades.qTotal, 1))
                displayBox.Items.Add("Exams: " & FormatNumber(grades.eTotal, 1))
                displayBox.Items.Add("Attendance: " & FormatNumber(grades.atTotal, 1))
                displayBox.Items.Add("Final Project: " & FormatNumber(grades.finalProject, 2))
                displayBox.Items.Add("Total Grade: " & FormatNumber(grades.TotalGradeCalc, 2))
            ElseIf (letterRadioButton.Checked) Then
                displayBox.Items.Add("First Name: " & student.firstN)
                displayBox.Items.Add("Middle Name: " & student.middleN)
                displayBox.Items.Add("Last Name: " & student.lastN)
                displayBox.Items.Add("SSN: " & student.socialNumber)
                displayBox.Items.Add("Assignments: " & grades.LetterGrade(grades.aTotal))
                displayBox.Items.Add("Quizzes: " & grades.LetterGrade(grades.qTotal))
                displayBox.Items.Add("Exams: " & grades.LetterGrade(grades.eTotal))
                displayBox.Items.Add("Attendance: " & grades.LetterGrade(grades.atTotal))
                displayBox.Items.Add("Final Project: " & grades.LetterGrade(grades.finalProject))
                displayBox.Items.Add("Total Grade: " & grades.LetterGrade(grades.TotalGradeCalc))
            End If
            'Give the students their grades
            student.grade = grades
            'Send the time to cTime
            save = New SaveControler(student)
            save.cTime = DateAndTime.Now
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Dim s As Form3
        s = New Form3()
        s.ShowDialog(Me)
        System.Threading.Thread.Sleep(2600)
        s.Close()
        s = Nothing
        Me.Visible = True
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        save.Save()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub OpenStudentGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenStudentGradesToolStripMenuItem.Click
        Dim databaseForm As Form2
        databaseForm = New Form2()
        databaseForm.Show()
        databaseForm = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label20.Text = DateAndTime.Now
    End Sub

    Private Sub options_Click(sender As Object, e As EventArgs) Handles options.Click
        Dim optionForm As Form4
        optionForm = New Form4()
        optionForm.Show()
        optionForm = Nothing
    End Sub
End Class
