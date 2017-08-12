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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.aBox = New System.Windows.Forms.TextBox()
        Me.limitBox = New System.Windows.Forms.TextBox()
        Me.newbalanceBox = New System.Windows.Forms.TextBox()
        Me.creditBox = New System.Windows.Forms.TextBox()
        Me.chargeBox = New System.Windows.Forms.TextBox()
        Me.sBox = New System.Windows.Forms.TextBox()
        Me.rCreditBox = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Account number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starting balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total charges:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total credits:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Credit limit:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "New balance:"
        '
        'aBox
        '
        Me.aBox.Location = New System.Drawing.Point(126, 24)
        Me.aBox.Name = "aBox"
        Me.aBox.Size = New System.Drawing.Size(100, 23)
        Me.aBox.TabIndex = 6
        '
        'limitBox
        '
        Me.limitBox.Location = New System.Drawing.Point(126, 138)
        Me.limitBox.Name = "limitBox"
        Me.limitBox.Size = New System.Drawing.Size(100, 23)
        Me.limitBox.TabIndex = 7
        '
        'newbalanceBox
        '
        Me.newbalanceBox.BackColor = System.Drawing.Color.LightGray
        Me.newbalanceBox.Location = New System.Drawing.Point(126, 168)
        Me.newbalanceBox.Name = "newbalanceBox"
        Me.newbalanceBox.Size = New System.Drawing.Size(100, 23)
        Me.newbalanceBox.TabIndex = 8
        '
        'creditBox
        '
        Me.creditBox.Location = New System.Drawing.Point(126, 108)
        Me.creditBox.Name = "creditBox"
        Me.creditBox.Size = New System.Drawing.Size(100, 23)
        Me.creditBox.TabIndex = 9
        '
        'chargeBox
        '
        Me.chargeBox.Location = New System.Drawing.Point(126, 80)
        Me.chargeBox.Name = "chargeBox"
        Me.chargeBox.Size = New System.Drawing.Size(100, 23)
        Me.chargeBox.TabIndex = 10
        '
        'sBox
        '
        Me.sBox.Location = New System.Drawing.Point(126, 51)
        Me.sBox.Name = "sBox"
        Me.sBox.Size = New System.Drawing.Size(100, 23)
        Me.sBox.TabIndex = 11
        '
        'rCreditBox
        '
        Me.rCreditBox.BackColor = System.Drawing.Color.LightGray
        Me.rCreditBox.Location = New System.Drawing.Point(23, 201)
        Me.rCreditBox.Name = "rCreditBox"
        Me.rCreditBox.Size = New System.Drawing.Size(203, 23)
        Me.rCreditBox.TabIndex = 12
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(23, 230)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 13
        Me.clear.Text = "Clear Fields"
        Me.clear.UseVisualStyleBackColor = True
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(104, 230)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(122, 23)
        Me.calculate.TabIndex = 14
        Me.calculate.Text = "Calculate Balance"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 271)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.rCreditBox)
        Me.Controls.Add(Me.sBox)
        Me.Controls.Add(Me.chargeBox)
        Me.Controls.Add(Me.creditBox)
        Me.Controls.Add(Me.newbalanceBox)
        Me.Controls.Add(Me.limitBox)
        Me.Controls.Add(Me.aBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Credit Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents aBox As TextBox
    Friend WithEvents limitBox As TextBox
    Friend WithEvents newbalanceBox As TextBox
    Friend WithEvents creditBox As TextBox
    Friend WithEvents chargeBox As TextBox
    Friend WithEvents sBox As TextBox
    Friend WithEvents rCreditBox As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents calculate As Button
End Class
