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
        Me.firstClassBox = New System.Windows.Forms.RadioButton()
        Me.economyBox = New System.Windows.Forms.RadioButton()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.displayBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstClassBox
        '
        Me.firstClassBox.AutoSize = True
        Me.firstClassBox.Location = New System.Drawing.Point(3, 12)
        Me.firstClassBox.Name = "firstClassBox"
        Me.firstClassBox.Size = New System.Drawing.Size(73, 17)
        Me.firstClassBox.TabIndex = 1
        Me.firstClassBox.TabStop = True
        Me.firstClassBox.Text = "FIrst Class"
        Me.firstClassBox.UseVisualStyleBackColor = True
        '
        'economyBox
        '
        Me.economyBox.AutoSize = True
        Me.economyBox.Location = New System.Drawing.Point(82, 12)
        Me.economyBox.Name = "economyBox"
        Me.economyBox.Size = New System.Drawing.Size(69, 17)
        Me.economyBox.TabIndex = 2
        Me.economyBox.TabStop = True
        Me.economyBox.Text = "Economy"
        Me.economyBox.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(157, 9)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 3
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'displayBox
        '
        Me.displayBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.displayBox.Location = New System.Drawing.Point(3, 45)
        Me.displayBox.Name = "displayBox"
        Me.displayBox.Size = New System.Drawing.Size(229, 22)
        Me.displayBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 69)
        Me.Controls.Add(Me.displayBox)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.economyBox)
        Me.Controls.Add(Me.firstClassBox)
        Me.Name = "Form1"
        Me.Text = "Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstClassBox As RadioButton
    Friend WithEvents economyBox As RadioButton
    Friend WithEvents submitButton As Button
    Friend WithEvents displayBox As Label
End Class
