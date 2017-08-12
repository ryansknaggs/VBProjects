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
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hoursBox = New System.Windows.Forms.TextBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(141, 27)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(87, 27)
        Me.calculate.TabIndex = 0
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hours Parked:"
        '
        'hoursBox
        '
        Me.hoursBox.Location = New System.Drawing.Point(17, 29)
        Me.hoursBox.Name = "hoursBox"
        Me.hoursBox.Size = New System.Drawing.Size(116, 23)
        Me.hoursBox.TabIndex = 2
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(17, 81)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(117, 27)
        Me.totalLabel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Cost:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 121)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.hoursBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculate)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Parking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents hoursBox As TextBox
    Friend WithEvents totalLabel As Label
    Friend WithEvents Label3 As Label
End Class
