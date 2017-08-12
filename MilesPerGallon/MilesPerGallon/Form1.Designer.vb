<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.milesBox = New System.Windows.Forms.TextBox()
        Me.gallonsBox = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mBox = New System.Windows.Forms.ListBox()
        Me.gBox = New System.Windows.Forms.ListBox()
        Me.mpgBox = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter miles driven:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter gallons used:"
        '
        'milesBox
        '
        Me.milesBox.Location = New System.Drawing.Point(129, 9)
        Me.milesBox.Name = "milesBox"
        Me.milesBox.Size = New System.Drawing.Size(114, 23)
        Me.milesBox.TabIndex = 2
        '
        'gallonsBox
        '
        Me.gallonsBox.Location = New System.Drawing.Point(129, 40)
        Me.gallonsBox.Name = "gallonsBox"
        Me.gallonsBox.Size = New System.Drawing.Size(114, 23)
        Me.gallonsBox.TabIndex = 3
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(127, 69)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(116, 23)
        Me.calculate.TabIndex = 7
        Me.calculate.Text = "Calculate MPG"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Miles:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gallons:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "MPG:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Totals:"
        '
        'mBox
        '
        Me.mBox.FormattingEnabled = True
        Me.mBox.ItemHeight = 15
        Me.mBox.Location = New System.Drawing.Point(9, 130)
        Me.mBox.Name = "mBox"
        Me.mBox.Size = New System.Drawing.Size(71, 109)
        Me.mBox.TabIndex = 15
        '
        'gBox
        '
        Me.gBox.FormattingEnabled = True
        Me.gBox.ItemHeight = 15
        Me.gBox.Location = New System.Drawing.Point(89, 130)
        Me.gBox.Name = "gBox"
        Me.gBox.Size = New System.Drawing.Size(71, 109)
        Me.gBox.TabIndex = 16
        '
        'mpgBox
        '
        Me.mpgBox.FormattingEnabled = True
        Me.mpgBox.ItemHeight = 15
        Me.mpgBox.Location = New System.Drawing.Point(169, 130)
        Me.mpgBox.Name = "mpgBox"
        Me.mpgBox.Size = New System.Drawing.Size(74, 109)
        Me.mpgBox.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Location = New System.Drawing.Point(9, 280)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 68)
        Me.TextBox1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 360)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.mpgBox)
        Me.Controls.Add(Me.gBox)
        Me.Controls.Add(Me.mBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.gallonsBox)
        Me.Controls.Add(Me.milesBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents milesBox As TextBox
    Friend WithEvents gallonsBox As TextBox
    Friend WithEvents calculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mBox As ListBox
    Friend WithEvents gBox As ListBox
    Friend WithEvents mpgBox As ListBox
    Friend WithEvents TextBox1 As TextBox
End Class
