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
        Me.fBox = New System.Windows.Forms.TextBox()
        Me.lBox = New System.Windows.Forms.TextBox()
        Me.sBox = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'fBox
        '
        Me.fBox.Location = New System.Drawing.Point(14, 42)
        Me.fBox.Name = "fBox"
        Me.fBox.Size = New System.Drawing.Size(116, 23)
        Me.fBox.TabIndex = 0
        '
        'lBox
        '
        Me.lBox.Location = New System.Drawing.Point(138, 42)
        Me.lBox.Name = "lBox"
        Me.lBox.Size = New System.Drawing.Size(116, 23)
        Me.lBox.TabIndex = 1
        '
        'sBox
        '
        Me.sBox.Location = New System.Drawing.Point(261, 42)
        Me.sBox.Name = "sBox"
        Me.sBox.Size = New System.Drawing.Size(116, 23)
        Me.sBox.TabIndex = 2
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(14, 72)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(364, 27)
        Me.submit.TabIndex = 3
        Me.submit.Text = "Display Salary"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Salary:"
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.ItemHeight = 15
        Me.listBox.Location = New System.Drawing.Point(14, 105)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(364, 184)
        Me.listBox.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 301)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.sBox)
        Me.Controls.Add(Me.lBox)
        Me.Controls.Add(Me.fBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Display Salary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fBox As TextBox
    Friend WithEvents lBox As TextBox
    Friend WithEvents sBox As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listBox As ListBox
End Class
