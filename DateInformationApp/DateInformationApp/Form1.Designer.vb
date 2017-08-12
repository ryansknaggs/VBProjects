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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dBox = New System.Windows.Forms.TextBox()
        Me.mBox = New System.Windows.Forms.TextBox()
        Me.yBox = New System.Windows.Forms.TextBox()
        Me.Day = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(11, 89)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(364, 109)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(364, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Submit Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dBox
        '
        Me.dBox.Location = New System.Drawing.Point(12, 25)
        Me.dBox.Name = "dBox"
        Me.dBox.Size = New System.Drawing.Size(116, 23)
        Me.dBox.TabIndex = 2
        '
        'mBox
        '
        Me.mBox.Location = New System.Drawing.Point(135, 25)
        Me.mBox.Name = "mBox"
        Me.mBox.Size = New System.Drawing.Size(116, 23)
        Me.mBox.TabIndex = 3
        '
        'yBox
        '
        Me.yBox.Location = New System.Drawing.Point(259, 25)
        Me.yBox.Name = "yBox"
        Me.yBox.Size = New System.Drawing.Size(116, 23)
        Me.yBox.TabIndex = 4
        '
        'Day
        '
        Me.Day.AutoSize = True
        Me.Day.Location = New System.Drawing.Point(13, 7)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(59, 15)
        Me.Day.TabIndex = 5
        Me.Day.Text = "Enter day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter year:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 206)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.yBox)
        Me.Controls.Add(Me.mBox)
        Me.Controls.Add(Me.dBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Date App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dBox As TextBox
    Friend WithEvents mBox As TextBox
    Friend WithEvents yBox As TextBox
    Friend WithEvents Day As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
