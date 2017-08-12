Imports System.IO
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As StreamReader = Nothing
        Dim result As DialogResult
        Dim fileName As String
        Try
            Dim allLines As List(Of String) = New List(Of String)
            Using fileChooser As New OpenFileDialog()
                result = fileChooser.ShowDialog()
                fileName = fileChooser.FileName
            End Using

            Dim lines() As String = IO.File.ReadAllLines(fileName)
            databaseList.Items.AddRange(lines)
        Catch ex As Exception
            MsgBox("File Not Found")
        End Try
    End Sub
End Class