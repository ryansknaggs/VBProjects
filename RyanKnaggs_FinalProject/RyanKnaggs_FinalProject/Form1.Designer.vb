<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gradeCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gradeCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fNameBox = New System.Windows.Forms.TextBox()
        Me.mNameBox = New System.Windows.Forms.TextBox()
        Me.lNameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ssnBox = New System.Windows.Forms.TextBox()
        Me.recordButton = New System.Windows.Forms.Button()
        Me.gradeViewGroupBox = New System.Windows.Forms.GroupBox()
        Me.letterRadioButton = New System.Windows.Forms.RadioButton()
        Me.numericRadioButton = New System.Windows.Forms.RadioButton()
        Me.e1Box = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.e2Box = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.q4Box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.q3Box = New System.Windows.Forms.TextBox()
        Me.q2Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.q1Box = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.finalBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.a6Box = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.a5Box = New System.Windows.Forms.TextBox()
        Me.a4Box = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.a3Box = New System.Windows.Forms.TextBox()
        Me.a2Box = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.a1Box = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.attBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.displayBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenStudentGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.options = New System.Windows.Forms.Button()
        Me.gradeViewGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Exam 1:"
        '
        'fNameBox
        '
        Me.fNameBox.BackColor = System.Drawing.Color.SeaShell
        Me.fNameBox.Location = New System.Drawing.Point(13, 52)
        Me.fNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.fNameBox.Name = "fNameBox"
        Me.fNameBox.Size = New System.Drawing.Size(140, 25)
        Me.fNameBox.TabIndex = 0
        '
        'mNameBox
        '
        Me.mNameBox.BackColor = System.Drawing.Color.SeaShell
        Me.mNameBox.Location = New System.Drawing.Point(160, 52)
        Me.mNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.mNameBox.Name = "mNameBox"
        Me.mNameBox.Size = New System.Drawing.Size(140, 25)
        Me.mNameBox.TabIndex = 1
        '
        'lNameBox
        '
        Me.lNameBox.BackColor = System.Drawing.Color.SeaShell
        Me.lNameBox.Location = New System.Drawing.Point(309, 52)
        Me.lNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.lNameBox.Name = "lNameBox"
        Me.lNameBox.Size = New System.Drawing.Size(155, 25)
        Me.lNameBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "First name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(157, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Middle name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(306, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Last name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(475, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "SSN:"
        '
        'ssnBox
        '
        Me.ssnBox.BackColor = System.Drawing.Color.SeaShell
        Me.ssnBox.Location = New System.Drawing.Point(475, 52)
        Me.ssnBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ssnBox.Name = "ssnBox"
        Me.ssnBox.Size = New System.Drawing.Size(140, 25)
        Me.ssnBox.TabIndex = 3
        '
        'recordButton
        '
        Me.recordButton.Location = New System.Drawing.Point(9, 385)
        Me.recordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.recordButton.Name = "recordButton"
        Me.recordButton.Size = New System.Drawing.Size(147, 30)
        Me.recordButton.TabIndex = 10
        Me.recordButton.Text = "Record Grade"
        Me.recordButton.UseVisualStyleBackColor = True
        '
        'gradeViewGroupBox
        '
        Me.gradeViewGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.gradeViewGroupBox.Controls.Add(Me.letterRadioButton)
        Me.gradeViewGroupBox.Controls.Add(Me.numericRadioButton)
        Me.gradeViewGroupBox.Location = New System.Drawing.Point(11, 285)
        Me.gradeViewGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.gradeViewGroupBox.Name = "gradeViewGroupBox"
        Me.gradeViewGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.gradeViewGroupBox.Size = New System.Drawing.Size(141, 92)
        Me.gradeViewGroupBox.TabIndex = 9
        Me.gradeViewGroupBox.TabStop = False
        Me.gradeViewGroupBox.Text = "Grade View"
        '
        'letterRadioButton
        '
        Me.letterRadioButton.AutoSize = True
        Me.letterRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.letterRadioButton.Location = New System.Drawing.Point(10, 59)
        Me.letterRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.letterRadioButton.Name = "letterRadioButton"
        Me.letterRadioButton.Size = New System.Drawing.Size(66, 23)
        Me.letterRadioButton.TabIndex = 0
        Me.letterRadioButton.Text = "Letter"
        Me.letterRadioButton.UseVisualStyleBackColor = False
        '
        'numericRadioButton
        '
        Me.numericRadioButton.AutoSize = True
        Me.numericRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.numericRadioButton.Checked = True
        Me.numericRadioButton.Location = New System.Drawing.Point(10, 26)
        Me.numericRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.numericRadioButton.Name = "numericRadioButton"
        Me.numericRadioButton.Size = New System.Drawing.Size(81, 23)
        Me.numericRadioButton.TabIndex = 0
        Me.numericRadioButton.TabStop = True
        Me.numericRadioButton.Text = "Numeric"
        Me.numericRadioButton.UseVisualStyleBackColor = False
        '
        'e1Box
        '
        Me.e1Box.BackColor = System.Drawing.Color.SeaShell
        Me.e1Box.Location = New System.Drawing.Point(15, 55)
        Me.e1Box.Margin = New System.Windows.Forms.Padding(4)
        Me.e1Box.MaxLength = 3
        Me.e1Box.Name = "e1Box"
        Me.e1Box.Size = New System.Drawing.Size(56, 25)
        Me.e1Box.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.e2Box)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.e1Box)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 185)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(155, 92)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exams"
        '
        'e2Box
        '
        Me.e2Box.BackColor = System.Drawing.Color.SeaShell
        Me.e2Box.Location = New System.Drawing.Point(83, 55)
        Me.e2Box.Margin = New System.Windows.Forms.Padding(4)
        Me.e2Box.MaxLength = 3
        Me.e2Box.Name = "e2Box"
        Me.e2Box.Size = New System.Drawing.Size(56, 25)
        Me.e2Box.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(80, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Exam 2:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.q4Box)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.q3Box)
        Me.GroupBox2.Controls.Add(Me.q2Box)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.q1Box)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 185)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(294, 92)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quizzes"
        '
        'q4Box
        '
        Me.q4Box.BackColor = System.Drawing.Color.SeaShell
        Me.q4Box.Location = New System.Drawing.Point(218, 55)
        Me.q4Box.Margin = New System.Windows.Forms.Padding(4)
        Me.q4Box.MaxLength = 3
        Me.q4Box.Name = "q4Box"
        Me.q4Box.Size = New System.Drawing.Size(56, 25)
        Me.q4Box.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(147, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Quizz 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(214, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Quizz 4:"
        '
        'q3Box
        '
        Me.q3Box.BackColor = System.Drawing.Color.SeaShell
        Me.q3Box.Location = New System.Drawing.Point(150, 55)
        Me.q3Box.Margin = New System.Windows.Forms.Padding(4)
        Me.q3Box.MaxLength = 3
        Me.q3Box.Name = "q3Box"
        Me.q3Box.Size = New System.Drawing.Size(56, 25)
        Me.q3Box.TabIndex = 2
        '
        'q2Box
        '
        Me.q2Box.BackColor = System.Drawing.Color.SeaShell
        Me.q2Box.Location = New System.Drawing.Point(83, 55)
        Me.q2Box.Margin = New System.Windows.Forms.Padding(4)
        Me.q2Box.MaxLength = 3
        Me.q2Box.Name = "q2Box"
        Me.q2Box.Size = New System.Drawing.Size(56, 25)
        Me.q2Box.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(11, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 19)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Quizz 1:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(80, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 19)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Quizz 2:"
        '
        'q1Box
        '
        Me.q1Box.BackColor = System.Drawing.Color.SeaShell
        Me.q1Box.Location = New System.Drawing.Point(15, 55)
        Me.q1Box.Margin = New System.Windows.Forms.Padding(4)
        Me.q1Box.MaxLength = 3
        Me.q1Box.Name = "q1Box"
        Me.q1Box.Size = New System.Drawing.Size(56, 25)
        Me.q1Box.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.finalBox)
        Me.GroupBox3.Location = New System.Drawing.Point(475, 185)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(143, 92)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Final Project"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(11, 26)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 19)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Project:"
        '
        'finalBox
        '
        Me.finalBox.BackColor = System.Drawing.Color.SeaShell
        Me.finalBox.Location = New System.Drawing.Point(15, 55)
        Me.finalBox.Margin = New System.Windows.Forms.Padding(4)
        Me.finalBox.MaxLength = 3
        Me.finalBox.Name = "finalBox"
        Me.finalBox.Size = New System.Drawing.Size(56, 25)
        Me.finalBox.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.a6Box)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.a5Box)
        Me.GroupBox4.Controls.Add(Me.a4Box)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.a3Box)
        Me.GroupBox4.Controls.Add(Me.a2Box)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.a1Box)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 86)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(452, 92)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Assignments"
        '
        'a6Box
        '
        Me.a6Box.BackColor = System.Drawing.Color.SeaShell
        Me.a6Box.Location = New System.Drawing.Point(349, 55)
        Me.a6Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a6Box.MaxLength = 3
        Me.a6Box.Name = "a6Box"
        Me.a6Box.Size = New System.Drawing.Size(56, 25)
        Me.a6Box.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(277, 26)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Ass 5:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(345, 26)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 19)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Ass 6:"
        '
        'a5Box
        '
        Me.a5Box.BackColor = System.Drawing.Color.SeaShell
        Me.a5Box.Location = New System.Drawing.Point(280, 55)
        Me.a5Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a5Box.MaxLength = 3
        Me.a5Box.Name = "a5Box"
        Me.a5Box.Size = New System.Drawing.Size(56, 25)
        Me.a5Box.TabIndex = 4
        '
        'a4Box
        '
        Me.a4Box.BackColor = System.Drawing.Color.SeaShell
        Me.a4Box.Location = New System.Drawing.Point(214, 55)
        Me.a4Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a4Box.MaxLength = 3
        Me.a4Box.Name = "a4Box"
        Me.a4Box.Size = New System.Drawing.Size(56, 25)
        Me.a4Box.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(143, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Ass 3:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(210, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 19)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Ass 4:"
        '
        'a3Box
        '
        Me.a3Box.BackColor = System.Drawing.Color.SeaShell
        Me.a3Box.Location = New System.Drawing.Point(146, 55)
        Me.a3Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a3Box.MaxLength = 3
        Me.a3Box.Name = "a3Box"
        Me.a3Box.Size = New System.Drawing.Size(56, 25)
        Me.a3Box.TabIndex = 2
        '
        'a2Box
        '
        Me.a2Box.BackColor = System.Drawing.Color.SeaShell
        Me.a2Box.Location = New System.Drawing.Point(79, 55)
        Me.a2Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a2Box.MaxLength = 3
        Me.a2Box.Name = "a2Box"
        Me.a2Box.Size = New System.Drawing.Size(56, 25)
        Me.a2Box.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(7, 26)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Ass: 1:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(76, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 19)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Ass 2:"
        '
        'a1Box
        '
        Me.a1Box.BackColor = System.Drawing.Color.SeaShell
        Me.a1Box.Location = New System.Drawing.Point(11, 55)
        Me.a1Box.Margin = New System.Windows.Forms.Padding(4)
        Me.a1Box.MaxLength = 3
        Me.a1Box.Name = "a1Box"
        Me.a1Box.Size = New System.Drawing.Size(56, 25)
        Me.a1Box.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.attBox)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Location = New System.Drawing.Point(475, 86)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(143, 91)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Attendance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 19)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Att:"
        '
        'attBox
        '
        Me.attBox.BackColor = System.Drawing.Color.SeaShell
        Me.attBox.Location = New System.Drawing.Point(15, 55)
        Me.attBox.Margin = New System.Windows.Forms.Padding(4)
        Me.attBox.Name = "attBox"
        Me.attBox.Size = New System.Drawing.Size(56, 25)
        Me.attBox.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 21)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 19)
        Me.Label18.TabIndex = 27
        '
        'displayBox
        '
        Me.displayBox.BackColor = System.Drawing.Color.SeaShell
        Me.displayBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBox.FormattingEnabled = True
        Me.displayBox.ItemHeight = 20
        Me.displayBox.Location = New System.Drawing.Point(163, 285)
        Me.displayBox.Margin = New System.Windows.Forms.Padding(4)
        Me.displayBox.Name = "displayBox"
        Me.displayBox.Size = New System.Drawing.Size(453, 184)
        Me.displayBox.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenStudentGradesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.RyanKnaggs_FinalProject.My.Resources.Resources.floppy
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenStudentGradesToolStripMenuItem
        '
        Me.OpenStudentGradesToolStripMenuItem.Image = Global.RyanKnaggs_FinalProject.My.Resources.Resources.open_file_icon
        Me.OpenStudentGradesToolStripMenuItem.Name = "OpenStudentGradesToolStripMenuItem"
        Me.OpenStudentGradesToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.OpenStudentGradesToolStripMenuItem.Text = "Open Student Grades"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(489, 473)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 19)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Label20"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'options
        '
        Me.options.Location = New System.Drawing.Point(9, 429)
        Me.options.Margin = New System.Windows.Forms.Padding(4)
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(147, 30)
        Me.options.TabIndex = 14
        Me.options.Text = "Optional Stuff"
        Me.options.UseVisualStyleBackColor = True
        '
        'gradeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.RyanKnaggs_FinalProject.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 495)
        Me.Controls.Add(Me.options)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.displayBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gradeViewGroupBox)
        Me.Controls.Add(Me.recordButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ssnBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lNameBox)
        Me.Controls.Add(Me.mNameBox)
        Me.Controls.Add(Me.fNameBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "gradeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Calculator"
        Me.gradeViewGroupBox.ResumeLayout(False)
        Me.gradeViewGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents fNameBox As TextBox
    Friend WithEvents mNameBox As TextBox
    Friend WithEvents lNameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ssnBox As TextBox
    Friend WithEvents recordButton As Button
    Friend WithEvents gradeViewGroupBox As GroupBox
    Friend WithEvents letterRadioButton As RadioButton
    Friend WithEvents numericRadioButton As RadioButton
    Friend WithEvents e1Box As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents e2Box As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents q4Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents q3Box As TextBox
    Friend WithEvents q2Box As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents q1Box As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents finalBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents a6Box As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents a5Box As TextBox
    Friend WithEvents a4Box As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents a3Box As TextBox
    Friend WithEvents a2Box As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents a1Box As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents attBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents displayBox As ListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenStudentGradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents options As Button
End Class
