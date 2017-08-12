Public Class Form1
    Dim header = ""
    Private Sub txtBoxOutPut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBoxOutPut.AppendText("Decimal" & vbTab & vbTab & "Octal" & vbTab & vbTab & "Hexadecimal" & vbTab & "Binary" & vbNewLine)
        For i As Integer = 1 To 255
            txtBoxOutPut.AppendText(i & vbTab & vbTab & Convert.ToString(i, 8) & vbTab & vbTab &
            Convert.ToString(i, 16) & vbTab & vbTab & Convert.ToString(i, 2) & vbNewLine)
        Next
    End Sub
End Class


