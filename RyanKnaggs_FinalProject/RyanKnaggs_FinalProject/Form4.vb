Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AppendText("I gave the program the ability to save and open the grade database " & vbCrLf &
        "from the menu. You can view the saved database as soon as the program" & vbCrLf &
        "opens. When you view the database it opens in a new form. I also added" & vbCrLf &
        "the ability to save the student creation date time to the students grade" & vbCrLf &
        "object. There is a student class and a grade calculation class. I also" & vbCrLf &
        "created a loading bar that uses a time. The program also limits the grades" & vbCrLf &
        "to three characters and checks to see if they are in range. If they are not " & vbCrLf &
        "in range they will make you correct them without throwing an exception." & vbCrLf &
        "I also ensure that you cant leave the grade text boxes empty or use anything thas not" & vbCrLf &
        "An integer. If you do leave it empty or enter a string it will tell you to correct them" & vbCrLf &
        "and not show the grades untill you do. I also added icons to the menu items as well " & vbCrLf &
        "as the forms. I also added icons to the message boxes.")
    End Sub
End Class