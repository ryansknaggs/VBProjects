<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinToss
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
        Me.coinPictureBox = New System.Windows.Forms.PictureBox()
        Me.tossButton = New System.Windows.Forms.Button()
        Me.headsL = New System.Windows.Forms.Label()
        Me.tailL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.coinPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'coinPictureBox
        '
        Me.coinPictureBox.Image = Global.CoinToss.My.Resources.Resources.heads
        Me.coinPictureBox.Location = New System.Drawing.Point(33, 12)
        Me.coinPictureBox.Name = "coinPictureBox"
        Me.coinPictureBox.Size = New System.Drawing.Size(168, 178)
        Me.coinPictureBox.TabIndex = 0
        Me.coinPictureBox.TabStop = False
        '
        'tossButton
        '
        Me.tossButton.Location = New System.Drawing.Point(75, 196)
        Me.tossButton.Name = "tossButton"
        Me.tossButton.Size = New System.Drawing.Size(87, 27)
        Me.tossButton.TabIndex = 1
        Me.tossButton.Text = "Toss Coin"
        Me.tossButton.UseVisualStyleBackColor = True
        '
        'headsL
        '
        Me.headsL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.headsL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.headsL.Location = New System.Drawing.Point(33, 238)
        Me.headsL.Name = "headsL"
        Me.headsL.Size = New System.Drawing.Size(79, 27)
        Me.headsL.TabIndex = 2
        '
        'tailL
        '
        Me.tailL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tailL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tailL.Location = New System.Drawing.Point(118, 238)
        Me.tailL.Name = "tailL"
        Me.tailL.Size = New System.Drawing.Size(83, 27)
        Me.tailL.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tails:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Heads:"
        '
        'CoinToss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 277)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tailL)
        Me.Controls.Add(Me.headsL)
        Me.Controls.Add(Me.tossButton)
        Me.Controls.Add(Me.coinPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CoinToss"
        Me.Text = "Coin Toss"
        CType(Me.coinPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coinPictureBox As PictureBox
    Friend WithEvents tossButton As Button
    Friend WithEvents headsL As Label
    Friend WithEvents tailL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
