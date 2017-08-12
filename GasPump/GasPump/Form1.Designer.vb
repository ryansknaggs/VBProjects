<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GasPump
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
        Me.regBox = New System.Windows.Forms.TextBox()
        Me.specialBox = New System.Windows.Forms.TextBox()
        Me.superBox = New System.Windows.Forms.TextBox()
        Me.regButton = New System.Windows.Forms.Button()
        Me.specialButton = New System.Windows.Forms.Button()
        Me.superButton = New System.Windows.Forms.Button()
        Me.totalBox = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'regBox
        '
        Me.regBox.Location = New System.Drawing.Point(12, 26)
        Me.regBox.Name = "regBox"
        Me.regBox.Size = New System.Drawing.Size(100, 20)
        Me.regBox.TabIndex = 0
        '
        'specialBox
        '
        Me.specialBox.Location = New System.Drawing.Point(12, 52)
        Me.specialBox.Name = "specialBox"
        Me.specialBox.Size = New System.Drawing.Size(100, 20)
        Me.specialBox.TabIndex = 1
        '
        'superBox
        '
        Me.superBox.Location = New System.Drawing.Point(12, 78)
        Me.superBox.Name = "superBox"
        Me.superBox.Size = New System.Drawing.Size(100, 20)
        Me.superBox.TabIndex = 2
        '
        'regButton
        '
        Me.regButton.Location = New System.Drawing.Point(118, 24)
        Me.regButton.Name = "regButton"
        Me.regButton.Size = New System.Drawing.Size(75, 23)
        Me.regButton.TabIndex = 3
        Me.regButton.Text = "Regular"
        Me.regButton.UseVisualStyleBackColor = True
        '
        'specialButton
        '
        Me.specialButton.Location = New System.Drawing.Point(118, 50)
        Me.specialButton.Name = "specialButton"
        Me.specialButton.Size = New System.Drawing.Size(75, 23)
        Me.specialButton.TabIndex = 4
        Me.specialButton.Text = "Special"
        Me.specialButton.UseVisualStyleBackColor = True
        '
        'superButton
        '
        Me.superButton.Location = New System.Drawing.Point(118, 76)
        Me.superButton.Name = "superButton"
        Me.superButton.Size = New System.Drawing.Size(75, 23)
        Me.superButton.TabIndex = 5
        Me.superButton.Text = "Super"
        Me.superButton.UseVisualStyleBackColor = True
        '
        'totalBox
        '
        Me.totalBox.BackColor = System.Drawing.Color.Gainsboro
        Me.totalBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalBox.Location = New System.Drawing.Point(12, 116)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.Size = New System.Drawing.Size(103, 23)
        Me.totalBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Gallons"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total"
        '
        'GasPump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 144)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.superButton)
        Me.Controls.Add(Me.specialButton)
        Me.Controls.Add(Me.regButton)
        Me.Controls.Add(Me.superBox)
        Me.Controls.Add(Me.specialBox)
        Me.Controls.Add(Me.regBox)
        Me.Name = "GasPump"
        Me.Text = "GAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents regBox As TextBox
    Friend WithEvents specialBox As TextBox
    Friend WithEvents superBox As TextBox
    Friend WithEvents regButton As Button
    Friend WithEvents specialButton As Button
    Friend WithEvents superButton As Button
    Friend WithEvents totalBox As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
