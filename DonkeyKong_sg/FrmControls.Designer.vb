<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControls
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Jump = New System.Windows.Forms.PictureBox()
        Me.ClimbUp = New System.Windows.Forms.PictureBox()
        Me.ClimbDown = New System.Windows.Forms.PictureBox()
        Me.RunLeft = New System.Windows.Forms.PictureBox()
        Me.RRight = New System.Windows.Forms.PictureBox()
        Me.WalkLeft = New System.Windows.Forms.PictureBox()
        Me.WalkRight = New System.Windows.Forms.PictureBox()
        Me.LadderTitle1 = New System.Windows.Forms.PictureBox()
        Me.LadderT = New System.Windows.Forms.PictureBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.Jump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClimbUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClimbDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LadderTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LadderT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Left Arrow Key  = Walk Left"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(39, 301)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Down Arrow Key = Climb down Ladder"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(434, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "UP Arrow Key = Climb Up Ladder"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(39, 155)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Space = Jump"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(434, 29)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(187, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Right Arrow Key = Walk Right"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(39, 425)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(187, 20)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Text = "D = Run Right"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(434, 301)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(187, 20)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "A = Run Left"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(434, 425)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(187, 20)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Text = "C = Cheat Window"
        '
        'Jump
        '
        Me.Jump.Image = Global.WindowsApplication1.My.Resources.Resources.marioRightFloat
        Me.Jump.Location = New System.Drawing.Point(64, 195)
        Me.Jump.Name = "Jump"
        Me.Jump.Size = New System.Drawing.Size(134, 73)
        Me.Jump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Jump.TabIndex = 14
        Me.Jump.TabStop = False
        '
        'ClimbUp
        '
        Me.ClimbUp.Image = Global.WindowsApplication1.My.Resources.Resources.marioClimb2
        Me.ClimbUp.Location = New System.Drawing.Point(465, 195)
        Me.ClimbUp.Name = "ClimbUp"
        Me.ClimbUp.Size = New System.Drawing.Size(134, 73)
        Me.ClimbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClimbUp.TabIndex = 13
        Me.ClimbUp.TabStop = False
        '
        'ClimbDown
        '
        Me.ClimbDown.Image = Global.WindowsApplication1.My.Resources.Resources.marioClimb3
        Me.ClimbDown.Location = New System.Drawing.Point(64, 336)
        Me.ClimbDown.Name = "ClimbDown"
        Me.ClimbDown.Size = New System.Drawing.Size(134, 73)
        Me.ClimbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClimbDown.TabIndex = 12
        Me.ClimbDown.TabStop = False
        '
        'RunLeft
        '
        Me.RunLeft.Image = Global.WindowsApplication1.My.Resources.Resources.marioLeftMove2
        Me.RunLeft.Location = New System.Drawing.Point(465, 336)
        Me.RunLeft.Name = "RunLeft"
        Me.RunLeft.Size = New System.Drawing.Size(134, 73)
        Me.RunLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RunLeft.TabIndex = 11
        Me.RunLeft.TabStop = False
        '
        'RRight
        '
        Me.RRight.Image = Global.WindowsApplication1.My.Resources.Resources.marioRightMove2
        Me.RRight.Location = New System.Drawing.Point(64, 466)
        Me.RRight.Name = "RRight"
        Me.RRight.Size = New System.Drawing.Size(134, 73)
        Me.RRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RRight.TabIndex = 10
        Me.RRight.TabStop = False
        '
        'WalkLeft
        '
        Me.WalkLeft.Image = Global.WindowsApplication1.My.Resources.Resources.marioLeftMove1
        Me.WalkLeft.Location = New System.Drawing.Point(64, 67)
        Me.WalkLeft.Name = "WalkLeft"
        Me.WalkLeft.Size = New System.Drawing.Size(134, 73)
        Me.WalkLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WalkLeft.TabIndex = 9
        Me.WalkLeft.TabStop = False
        '
        'WalkRight
        '
        Me.WalkRight.Image = Global.WindowsApplication1.My.Resources.Resources.marioRightMove11
        Me.WalkRight.Location = New System.Drawing.Point(458, 67)
        Me.WalkRight.Name = "WalkRight"
        Me.WalkRight.Size = New System.Drawing.Size(134, 73)
        Me.WalkRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WalkRight.TabIndex = 8
        Me.WalkRight.TabStop = False
        '
        'LadderTitle1
        '
        Me.LadderTitle1.Image = Global.WindowsApplication1.My.Resources.Resources.ladder
        Me.LadderTitle1.Location = New System.Drawing.Point(508, 169)
        Me.LadderTitle1.Name = "LadderTitle1"
        Me.LadderTitle1.Size = New System.Drawing.Size(46, 126)
        Me.LadderTitle1.TabIndex = 15
        Me.LadderTitle1.TabStop = False
        '
        'LadderT
        '
        Me.LadderT.Image = Global.WindowsApplication1.My.Resources.Resources.ladder
        Me.LadderT.Location = New System.Drawing.Point(112, 319)
        Me.LadderT.Name = "LadderT"
        Me.LadderT.Size = New System.Drawing.Size(46, 100)
        Me.LadderT.TabIndex = 16
        Me.LadderT.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(433, 465)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(280, 20)
        Me.TextBox9.TabIndex = 17
        Me.TextBox9.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die (Die)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(433, 447)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(280, 20)
        Me.TextBox10.TabIndex = 18
        Me.TextBox10.Text = "Hammer (Become the hammer)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(433, 505)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(280, 20)
        Me.TextBox12.TabIndex = 20
        Me.TextBox12.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Floor (1) (TP to floor)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(433, 485)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(280, 20)
        Me.TextBox13.TabIndex = 17
        Me.TextBox13.Text = "BarrelDeath (Destroy barrels)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(258, 195)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(149, 146)
        Me.Back.TabIndex = 21
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'FrmControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(769, 551)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Jump)
        Me.Controls.Add(Me.ClimbUp)
        Me.Controls.Add(Me.ClimbDown)
        Me.Controls.Add(Me.RunLeft)
        Me.Controls.Add(Me.RRight)
        Me.Controls.Add(Me.WalkLeft)
        Me.Controls.Add(Me.WalkRight)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LadderTitle1)
        Me.Controls.Add(Me.LadderT)
        Me.Name = "FrmControls"
        Me.Text = "FrmControls"
        CType(Me.Jump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClimbUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClimbDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LadderTitle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LadderT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents WalkRight As System.Windows.Forms.PictureBox
    Friend WithEvents WalkLeft As System.Windows.Forms.PictureBox
    Friend WithEvents RRight As System.Windows.Forms.PictureBox
    Friend WithEvents RunLeft As System.Windows.Forms.PictureBox
    Friend WithEvents ClimbDown As System.Windows.Forms.PictureBox
    Friend WithEvents ClimbUp As System.Windows.Forms.PictureBox
    Friend WithEvents Jump As System.Windows.Forms.PictureBox
    Friend WithEvents LadderTitle1 As System.Windows.Forms.PictureBox
    Friend WithEvents LadderT As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
