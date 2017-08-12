Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim employee As New Employee()
        Dim fName As String = fBox.Text
        Dim lName As String = lBox.Text
        Dim employeeSalary As Integer = sBox.Text

        employee.fName = fName
        employee.lName = lName
        employee.salWithout = employeeSalary
        listBox.Items.Add(employee.displayEmployee)
        employee.sal = employeeSalary
        listBox.Items.Add(employee.displayEmployee)
    End Sub
End Class
