Public Class Form1
    Private Sub txtBoxOutPut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This is A
        For y As Integer = 1 To 10
            Dim aStar As String = ""
            For x As Integer = 1 To 10
                If x >= 1 + y Then
                    aStar &= " "
                Else
                    aStar &= "*"
                End If
            Next
            txtBoxOutPut.AppendText(aStar & Environment.NewLine)
        Next

        'This is B
        For y As Integer = 1 To 10
            Dim bStar As String = ""
            For x As Integer = 1 To 10
                If x <= 10 - y Then
                    bStar &= "*"
                Else
                    bStar &= " "
                End If
            Next
            txtBoxOutPut.AppendText(bStar & Environment.NewLine)
        Next

        'This is C
        For y As Integer = 1 To 10
            Dim cStar As String = ""
            For x As Integer = 1 To 10
                If x >= 1 + y Then
                    cStar &= "*"
                Else
                    cStar &= " "
                End If
            Next
            txtBoxOutPut.AppendText(cStar & Environment.NewLine)
        Next

        'This is D
        For y As Integer = 1 To 10
            Dim dStar As String = ""
            For x As Integer = 1 To 10
                If x <= 10 - y Then
                    dStar &= " "
                Else
                    dStar &= "*"
                End If
            Next
            txtBoxOutPut.AppendText(dStar & Environment.NewLine)
        Next
    End Sub
End Class
