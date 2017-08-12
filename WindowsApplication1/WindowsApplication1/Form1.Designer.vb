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
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wageBox = New System.Windows.Forms.TextBox()
        Me.hoursBox = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.fwtBox = New System.Windows.Forms.TextBox()
        Me.gEarningsBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nEarningsBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.Location = New System.Drawing.Point(21, 18)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(77, 15)
        Me.ageLabel.TabIndex = 0
        Me.ageLabel.Text = "Hourly wage:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weekly hours:"
        '
        'wageBox
        '
        Me.wageBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wageBox.Location = New System.Drawing.Point(140, 15)
        Me.wageBox.Name = "wageBox"
        Me.wageBox.Size = New System.Drawing.Size(100, 23)
        Me.wageBox.TabIndex = 3
        '
        'hoursBox
        '
        Me.hoursBox.BackColor = System.Drawing.Color.White
        Me.hoursBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursBox.Location = New System.Drawing.Point(140, 44)
        Me.hoursBox.Name = "hoursBox"
        Me.hoursBox.Size = New System.Drawing.Size(100, 23)
        Me.hoursBox.TabIndex = 4
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(21, 182)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(99, 25)
        Me.clear.TabIndex = 5
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'fwtBox
        '
        Me.fwtBox.BackColor = System.Drawing.Color.LightGray
        Me.fwtBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fwtBox.Location = New System.Drawing.Point(140, 109)
        Me.fwtBox.Name = "fwtBox"
        Me.fwtBox.Size = New System.Drawing.Size(100, 23)
        Me.fwtBox.TabIndex = 9
        '
        'gEarningsBox
        '
        Me.gEarningsBox.BackColor = System.Drawing.Color.LightGray
        Me.gEarningsBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gEarningsBox.Location = New System.Drawing.Point(140, 80)
        Me.gEarningsBox.Name = "gEarningsBox"
        Me.gEarningsBox.Size = New System.Drawing.Size(100, 23)
        Me.gEarningsBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Less FWT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gross earnings:"
        '
        'nEarningsBox
        '
        Me.nEarningsBox.BackColor = System.Drawing.Color.LightGray
        Me.nEarningsBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEarningsBox.Location = New System.Drawing.Point(140, 141)
        Me.nEarningsBox.Name = "nEarningsBox"
        Me.nEarningsBox.Size = New System.Drawing.Size(100, 23)
        Me.nEarningsBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Net earnings:"
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(140, 182)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(100, 25)
        Me.calculate.TabIndex = 12
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 219)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.nEarningsBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fwtBox)
        Me.Controls.Add(Me.gEarningsBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.hoursBox)
        Me.Controls.Add(Me.wageBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ageLabel)
        Me.Name = "Form1"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ageLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents wageBox As TextBox
    Friend WithEvents hoursBox As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents fwtBox As TextBox
    Friend WithEvents gEarningsBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nEarningsBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents calculate As Button
End Class
