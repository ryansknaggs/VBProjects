Public Class Form1
    Dim array(10) As Client
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        array(0) = New Client("Ryan", "Knaggs", "121122", 2000)
        array(1) = New Client("Austin", "Knaggs", "1244444", 3000)
        array(2) = New Client("Ashley", "Knaggs", "2233323", 15000)
        array(3) = New Client("Mike", "Jones", "A32233", 5400)
        array(4) = New Client("Lost", "Guy", "23E33", 20)
        array(5) = New Client("Getts", "Monies", "533233", 112000)
        array(6) = New Client("George", "Washington", "177616", 1)
        array(7) = New Client("Hapy", "Golucky", "23222", 230)
        array(8) = New Client("Jeff", "Knaggs", "233216", 3000)
        array(9) = New Client("Wish", "Ihadsome", "988887", 6000)
    End Sub

    Sub previousButton_click(sender As Object, e As EventArgs) Handles previousButton.Click
        i = i - 1
        If i >= 0 AndAlso i <= 9 Then
            previousClient()
        ElseIf i < 0 Then
            i = 9
            previousClient()
        End If
    End Sub

    Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If i >= 0 AndAlso i <= 9 Then
            nextClient()
            i = i + 1
        ElseIf i > 9 Then
            i = 0
            nextClient()
        End If
    End Sub

    Sub previousClient()
        TextBox1.Text = array(i).firstN
        TextBox2.Text = array(i).lastN
        TextBox3.Text = array(i).accN
        TextBox4.Text = array(i).bal
    End Sub

    Sub nextClient()
        TextBox1.Text = array(i).firstN
        TextBox2.Text = array(i).lastN
        TextBox3.Text = array(i).accN
        TextBox4.Text = array(i).bal
    End Sub
End Class
