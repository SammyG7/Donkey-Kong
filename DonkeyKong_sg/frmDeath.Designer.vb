<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeath
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
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.Death = New System.Windows.Forms.PictureBox()
        Me.exit1 = New System.Windows.Forms.Button()
        CType(Me.Death, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayAgain
        '
        Me.PlayAgain.Location = New System.Drawing.Point(99, 275)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(573, 155)
        Me.PlayAgain.TabIndex = 1
        Me.PlayAgain.Text = " Play Again?"
        Me.PlayAgain.UseVisualStyleBackColor = True
        '
        'Death
        '
        Me.Death.Image = Global.WindowsApplication1.My.Resources.Resources.Game_Over__1_
        Me.Death.Location = New System.Drawing.Point(255, 189)
        Me.Death.Name = "Death"
        Me.Death.Size = New System.Drawing.Size(211, 62)
        Me.Death.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Death.TabIndex = 0
        Me.Death.TabStop = False
        '
        'exit1
        '
        Me.exit1.Location = New System.Drawing.Point(210, 436)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(347, 73)
        Me.exit1.TabIndex = 2
        Me.exit1.Text = "Exit"
        Me.exit1.UseVisualStyleBackColor = True
        '
        'frmDeath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(782, 561)
        Me.Controls.Add(Me.exit1)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.Death)
        Me.Name = "frmDeath"
        CType(Me.Death, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Death As System.Windows.Forms.PictureBox
    Friend WithEvents PlayAgain As System.Windows.Forms.Button
    Friend WithEvents exit1 As System.Windows.Forms.Button
End Class
