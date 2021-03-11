Public Class Mainform
    Dim MarioCh As Character
    Dim ladders(8) As PictureBox
    Dim floors(7) As floor
    Dim barrelch(3) As Character
    Dim barrel(3) As PictureBox
    Dim deathform As New frmDeath
    Dim P1name As String
    Dim throwcount As Integer
    Dim winform As New frmWin
    Dim hammer1 As Boolean
    Dim collode2(3) As Boolean
    Dim hammer2 As Integer
    Dim godmode As Boolean = False
    Dim titleform As New frmtiltle


    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim input As String
        Dim command As String
        Dim FloorString As String
        If e.KeyCode = Keys.Right And MarioCh.onLadder = False Then
            MarioCh.speed.X = 5
        End If
        If e.KeyCode = Keys.Left And MarioCh.onLadder = False Then
            MarioCh.speed.X = -5
        End If
        If e.KeyCode = Keys.Space And hammer1 = False Then
            MarioCh.speed.Y = -5
            MarioCh.floating = True
        End If
        If e.KeyCode = Keys.Up Then
            MarioCh.speed.Y = -5
        End If
        If e.KeyCode = Keys.Down Then
            MarioCh.speed.Y = 5
        End If
        If e.KeyCode = Keys.A Then
            MarioCh.speed.X = -10
        End If
        If e.KeyCode = Keys.D Then
            MarioCh.speed.X = 10
        End If
        If e.KeyCode = Keys.G Then
            Call godmode2()
        End If
        If e.KeyCode = Keys.R Then
            Call ResetSam()
        End If
        If e.KeyCode = Keys.C Then
            input = InputBox("Console")
            If input.IndexOf(" ") - 1 Then
                command = input
            Else
                command = input.Substring(0, input.IndexOf(" ") - 1)
            End If
            If command = "hammer" Then
                hammer1 = True
            ElseIf command = "die" Then
                Call DEATH()
            ElseIf command = "barreldeath" Then
                For index = 0 To 2
                    barrelch(index).picNum = 1
                    collode2(index) = True
                    barrelch(index).speed.X = 0
                    Call BarrelDeath(index)

                Next
            ElseIf command = "floor" Then
                FloorString = input.Substring(input.IndexOf(" ") + 1, 1)
                If FloorString = 1 Then
                    Mario.Left = 109
                    Mario.Top = 428
                End If
            End If
        End If

    End Sub

    Private Sub MainForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Then
            MarioCh.speed.X = 0
        End If
        If e.KeyCode = Keys.Up Then
            MarioCh.speed.Y = 0

        End If
        If e.KeyCode = Keys.A Or Keys.D Then
            MarioCh.speed.X = 0
        End If


    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        titleform.ShowDialog()

            Call Timer1.Start()


            ladders(0) = Ladder0
            ladders(1) = Ladder1
            ladders(2) = Ladder2
            ladders(3) = Ladder3
            ladders(4) = Ladder4
            ladders(5) = Ladder5
            ladders(6) = Ladder6
            ladders(7) = Ladder7
            barrel(0) = Barrel0
            barrel(1) = Barrel1
            barrel(2) = barrel2

            Call SetFloors()
        Call ResetSam()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call MoveMario()
        Call AnimateMario()
        Dim collode As Boolean
        For index = 0 To 2
            Call MoveBarrel(index)
            Call AnimateBarrel(index)

            collode = Collision(Mario, barrel(index)) Or collode

            Call teleport(index)

            If hammer1 = False Then
                MarioCh.Death = collode
            End If
            If hammer1 = True Then
                Call CBD(index)
            End If
            If collode = True Then
                Call BarrelDeath(index)
            End If
        Next
        If MarioCh.Death = True Then
            Call DEATH()
        End If
        Call throwbarrel()
        Call AnimateDK()
        If Mario.Bottom < floors(6).low Then
            Call Victory()
        End If
        If Collision(Mario, Hammer) = True And (hammer1 = False And godmode = False) Then
            Call HammerTime()
        End If
        If hammer1 = True And godmode = False Then
            hammer2 += +1
        End If

        If hammer2 > 100 And godmode = False Then
            hammer1 = False
            hammer2 = 0
        End If
        Call WARNING()

    End Sub


    Private Sub MoveMario()
        If MarioCh.floating = True Then
            If MarioCh.floatTime < 7 Then


                MarioCh.floatTime += 1

            Else

                MarioCh.speed.Y = 5
                MarioCh.floatTime += 1
                If MarioCh.floatTime > 14 Then
                    MarioCh.speed.Y = 0
                    MarioCh.floatTime = 0
                    MarioCh.floating = False
                End If
            End If
        Else


            MarioCh.onLadder = CheckLadder()
            If CheckLadder() = False Then

                MarioCh.speed.Y = 0
                Mario.Top = floors(currentfloor(Mario)).gety(Mario.Left) - Mario.Height
            Else
                MarioCh.speed.X = 0
            End If


        End If
        If Mario.Right > floors(0).finish Then
            MarioCh.speed.X = 0
            Mario.Left = floors(0).finish - Mario.Width
        ElseIf Mario.Left < floors(0).start Then
            MarioCh.speed.X = 0
            Mario.Left = floors(0).start

        End If
        If Mario.Left > floors(currentfloor(Mario)).finish Then
            MarioCh.floating = True
            MarioCh.floatTime = 3
            MarioCh.speed.Y = 5
        End If
        If Mario.Right < floors(currentfloor(Mario)).start Then
            MarioCh.floating = True
            MarioCh.floatTime = 3
            MarioCh.speed.Y = 5
        End If
        Mario.Left = Mario.Left + MarioCh.speed.X
        Mario.Top = Mario.Top + MarioCh.speed.Y
    End Sub

    Private Sub AnimateMario()

        If MarioCh.onLadder = True Then
            If MarioCh.speed.Y <> 0 Then
                Call AnimateOnLadder()
            End If
        ElseIf MarioCh.floatTime <> 0 Then
            If hammer1 = True And godmode = False Then
                Call AHF()
            Else
                Call AnimateFloat()
            End If
        ElseIf MarioCh.speed.X < 0 Then
            MarioCh.facingRight = False
            If hammer1 = True And godmode = False Then
                Call AHL()
            Else
                Call AnimateLeft()

            End If
        ElseIf MarioCh.speed.X > 0 Then
            MarioCh.facingRight = True
            If hammer1 = True And godmode = False Then
                Call AHR()
            Else
                Call AnimateRight()
            End If
        Else
            System.Diagnostics.Debug.WriteLine("2")
            If hammer1 = True And godmode = False Then
                Call AHS()
            Else
                Call AnimateStanding()
            End If
        End If





    End Sub

    Private Sub AnimateRight()
        If MarioCh.picNum = 1 Then
            MarioCh.picNum = 2
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightmove1.jpg")
        ElseIf MarioCh.picNum = 2 Then
            MarioCh.picNum = 3
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightmove2.jpg")
        ElseIf MarioCh.picNum = 3 Then
            MarioCh.picNum = 1
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightmove3.jpg")
        End If
    End Sub

    Private Sub AnimateLeft()
        If MarioCh.picNum = 1 Then
            MarioCh.picNum = 2
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioleftmove1.jpg")
        ElseIf MarioCh.picNum = 2 Then
            MarioCh.picNum = 3
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioleftmove2.jpg")
        ElseIf MarioCh.picNum = 3 Then
            MarioCh.picNum = 1
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioleftmove3.jpg")
        End If
    End Sub

    Private Sub AnimateStanding()
        If MarioCh.facingRight = False Then
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioleftmove1.jpg")
        Else
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightmove1.jpg")
        End If
    End Sub

    Private Sub AnimateFloat()
        If MarioCh.facingRight = False Then
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioleftfloat.jpg")
        Else
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightfloat.jpg")
        End If
    End Sub

    Public Function CheckLadder()
        If hammer1 = False Or godmode = True Then
            Dim ladderOffset As Integer
            For index = 0 To 7

                ladderOffset = 10
                If MarioCh.speed.Y < 0 Then
                    If Mario.Left > ladders(index).Left And Mario.Right < ladders(index).Right Then
                        If Mario.Top > ladders(index).Top - Mario.Height And Mario.Bottom < ladders(index).Bottom + ladderOffset Then

                            Return True
                        End If
                    End If
                ElseIf MarioCh.speed.Y > 0 Then
                    If Mario.Left > ladders(index).Left And Mario.Right < ladders(index).Right Then
                        If Mario.Top > ladders(index).Top - ladderOffset - Mario.Height And Mario.Bottom < ladders(index).Bottom Then

                            Return True
                        End If
                    End If
                Else
                    If Mario.Left > ladders(index).Left And Mario.Right < ladders(index).Right Then
                        If Mario.Top > ladders(index).Top And Mario.Bottom < ladders(index).Bottom Then

                            Return True
                        End If
                    End If
                End If


            Next
            Return False
        End If
    End Function

    Private Sub AnimateOnLadder()
        If MarioCh.picNum = 1 Then
            MarioCh.picNum = 2
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioClimb1.jpg")
        ElseIf MarioCh.picNum = 2 Then
            MarioCh.picNum = 3
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioClimb2.jpg")
        ElseIf MarioCh.picNum = 3 Then
            MarioCh.picNum = 1
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\marioClimb3.jpg")
        End If
    End Sub

    Private Sub SetFloors()
        Dim s As Point
        Dim f As Point
        floors(0).b = 465
        floors(0).slope = -0.000001
        floors(0).finish = 561
        floors(0).start = 75

        s.X = 80
        f.X = 512
        s.Y = 372
        f.Y = 403
        floors(1).low = 406
        floors(1).slope = CalcSlope(s, f)
        floors(1).b = CalcInter(f, floors(1).slope)
        floors(1).finish = f.X
        floors(1).start = s.X

        s.X = 121
        f.X = 556
        s.Y = 330
        f.Y = 299
        floors(2).low = 343
        floors(2).slope = CalcSlope(s, f)
        floors(2).b = CalcInter(f, floors(2).slope)
        floors(2).finish = f.X
        floors(2).start = s.X

        s.X = 79
        f.X = 512
        s.Y = 212
        f.Y = 254
        floors(3).low = 266
        floors(3).slope = CalcSlope(s, f)
        floors(3).b = CalcInter(f, floors(3).slope)
        floors(3).finish = f.X
        floors(3).start = s.X

        s.X = 121
        f.X = 556
        s.Y = 171
        f.Y = 148
        floors(4).low = 190
        floors(4).slope = CalcSlope(s, f)
        floors(4).b = CalcInter(f, floors(4).slope)
        floors(4).finish = f.X
        floors(4).start = s.X

        floors(5).low = 105
        floors(5).b = 92
        floors(5).slope = 0
        floors(5).finish = 503
        floors(5).start = 80

        floors(6).low = 54
        floors(6).b = 39
        floors(6).slope = 0
        floors(6).finish = 323
        floors(6).start = 206
    End Sub

    Private Function CalcSlope(ByVal s As Point, ByVal f As Point)
        Dim M As Double
        M = (f.Y - s.Y) / (f.X - s.X)
        Return M
    End Function
    Private Function CalcInter(ByVal p As Point, ByVal m As Double)
        Dim B As Double
        B = p.Y - (p.X * m)
        Return B
    End Function
    Private Function currentfloor(ByRef sprite As PictureBox)
        If sprite.Bottom > floors(1).low Then
            Return 0
        ElseIf sprite.Bottom > floors(2).low Then
            Return 1
        ElseIf sprite.Bottom > floors(3).low Then
            Return 2
        ElseIf sprite.Bottom > floors(4).low Then
            Return 3
        ElseIf sprite.Bottom > floors(5).low Then
            Return 4
        ElseIf sprite.Bottom > floors(6).low Then
            Return 5
        Else
            Return 6
        End If

    End Function

    Private Sub MoveBarrel(ByVal index As Integer)
        If barrelch(index).floating = True Then
            If barrelch(index).floatTime < 5 Then


                barrelch(index).floatTime += 1

            Else

                barrelch(index).speed.Y = 5
                barrelch(index).floatTime += 1
                If barrelch(index).floatTime > 10 Then
                    barrelch(index).speed.Y = 0
                    barrelch(index).floatTime = 0
                    barrelch(index).floating = False
                End If
            End If

        Else
            If barrelch(index).onLadder = True Then
                barrelch(index).speed.Y = 5
                barrelch(index).speed.X = 0
            Else
                barrelch(index).speed.Y = 0
                If floors(currentfloor(barrel(index))).slope < 0 Then
                    barrelch(index).speed.X = -5
                ElseIf floors(currentfloor(barrel(index))).slope > 0 Then
                    barrelch(index).speed.X = 5
                End If
            End If


        End If
        If barrelch(index).onLadder = True And CheckLadderB(barrel(index)) = True Then
            barrelch(index).onLadder = True
        Else
            If Rnd() < 0.2 Then
                barrelch(index).onLadder = CheckLadderB(barrel(index))
            Else
                barrelch(index).onLadder = False
            End If
        End If
        If barrelch(index).floating = False And barrelch(index).onLadder = False Then

            barrel(index).Top = floors(currentfloor(barrel(index))).gety(barrel(index).Left) - barrel(index).Height
        End If


        If barrel(index).Right > floors(0).finish Then
            barrelch(index).speed.X = 0
            barrel(index).Left = floors(0).finish - barrel(index).Width
        ElseIf barrel(index).Left < floors(0).start Then
            barrelch(index).speed.X = 0
            barrel(index).Left = floors(0).start

        End If
        If barrel(index).Left > floors(currentfloor(barrel(index))).finish Then
            barrelch(index).floating = True
            barrelch(index).floatTime = 3
            barrelch(index).speed.Y = 5
        End If
        If barrel(index).Right < floors(currentfloor(barrel(index))).start Then
            barrelch(index).floating = True
            barrelch(index).floatTime = 3
            barrelch(index).speed.Y = 5
        End If


        barrel(index).Left = barrel(index).Left + barrelch(index).speed.X
        barrel(index).Top = barrel(index).Top + barrelch(index).speed.Y
    End Sub
    Private Sub AnimateBarrel(ByVal index As Integer)
        If collode2(index) = True Then

            Call BarrelDeath(index)
        Else

            If barrelch(index).picNum = 1 Then
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\barrel1.jpg")
                barrelch(index).picNum = 2

            ElseIf barrelch(index).picNum = 2 Then
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\barrel2.jpg")
                barrelch(index).picNum = 3

            ElseIf barrelch(index).picNum = 3 Then
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\barrel3.jpg")
                barrelch(index).picNum = 4

            ElseIf barrelch(index).picNum = 4 Then
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\barrel4.jpg")
                barrelch(index).picNum = 1
            End If
        End If
    End Sub

    Private Sub LoadBarrel(ByVal index As Integer)
        barrelch(index).floating = False
        barrelch(index).speed.X = 0
        barrelch(index).floatTime = 0
        barrelch(index).facingRight = True
        barrelch(index).picNum = 1
        barrelch(index).onLadder = False
        barrelch(index).speed.Y = 0
        barrel(index).Visible = False
        barrel(index).Left = 178
        barrel(index).Top = 71
    End Sub

    Private Function CheckLadderB(ByRef bobthebarrel As PictureBox)
        Dim ladderoffset As Integer
        For index = 0 To 7
            ladderoffset = 10

            If bobthebarrel.Left > ladders(index).Left And bobthebarrel.Right < ladders(index).Right Then
                If bobthebarrel.Top > ladders(index).Top - ladderoffset - bobthebarrel.Height And bobthebarrel.Bottom < ladders(index).Bottom Then
                    Return True
                End If
            End If


        Next
        Return False
    End Function
    Private Function Collision(ByRef Object1 As PictureBox, ByRef Object2 As PictureBox)
        If (Object1.Left >= Object2.Left And Object1.Left <= Object2.Right) Or
            (Object1.Right >= Object2.Left And Object1.Right <= Object2.Right) Then
            If (Object1.Top <= Object2.Bottom And Object1.Top >= Object2.Top) Or
            (Object1.Bottom <= Object2.Bottom And Object1.Bottom >= Object2.Top) Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub DEATH()
        deathform.Show()
        Call ResetSam()
        Timer1.Stop()
        Hide()
    End Sub
    Private Sub AnimateDK()
        If throwcount < 35 Then
            DK.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\bobbstanding.jpg")
        ElseIf throwcount < 40 Then
            DK.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\bobbgettingbarrel.jpg")
        ElseIf throwcount < 45 Then
            DK.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\bobbholdingbarrel.jpg")
        ElseIf throwcount < 47 Then
            DK.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\bobbrollingbarrel.jpg")

        End If
    End Sub

    Private Sub throwbarrel()
        Dim index As Integer = -1
        Dim endloop As Boolean
        Do While endloop = False
            index += 1
            If barrel(index).Visible = False Or index = 2 Then
                endloop = True

            End If

        Loop
        If throwcount > 50 And index > -1 Then
            barrel(index).Visible = True
            throwcount = 0
            barrelch(index).speed.X = 5
        End If
        throwcount += 1

    End Sub
    Private Sub teleport(ByVal index As Integer)
        If barrel(index).Left < 84 And barrel(index).Top > 440 Then
            Call LoadBarrel(index)
        End If
    End Sub
    Private Sub ResetSam()
        MarioCh.picNum = 1
        For index = 0 To 2
            Call LoadBarrel(index)
        Next
        throwcount = 0
        Mario.Left = 82
        Mario.Top = 430
        MarioCh.speed.X = 0
        MarioCh.speed.Y = 0
        Hammer.Left = 379
        warning2.Visible = False
        If godmode = False Then
            GM.Visible = False
        End If
        MarioCh.facingRight = True
        hammer2 = 0
        hammer1 = False
    End Sub
    Private Sub Victory()
        winform.Show()
        Call ResetSam()
        Timer1.Stop()
        Hide()
    End Sub
    Private Sub HammerTime()
        Hammer.Left = 9000
        hammer1 = True
        Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerleftsmasher1.jpg")
    End Sub
    Private Sub AHL()
        If MarioCh.picNum = 1 Then
            MarioCh.picNum = 2
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerleftsmasher1.jpg")
        Else
            MarioCh.picNum = 1
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerleftsmasher2.jpg")

        End If
    End Sub
    Private Sub AHR()
        If MarioCh.picNum = 1 Then
            MarioCh.picNum = 2
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerrightsmasher1.jpg")
        Else
            MarioCh.picNum = 1
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerrightsmasher2.jpg")
        End If

    End Sub
    Private Sub AHS()
        If MarioCh.facingRight = False Then
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerleftsmasher1.jpg")
        Else
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerrightsmasher1.jpg")
        End If
    End Sub
    Private Sub BarrelDeath(ByVal index As Integer)
            If barrelch(index).picNum = 1 Then
                barrelch(index).picNum = 2
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\explode1.jpg")
            ElseIf barrelch(index).picNum = 2 Then
                barrelch(index).picNum = 3
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\explode2.jpg")
            ElseIf barrelch(index).picNum = 3 Then
                barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\explode3.jpg")
                Call LoadBarrel(index)
                collode2(index) = False
            End If


    End Sub
    Private Sub CBD(ByVal index As Integer)
        If Collision(Mario, barrel(index)) = True Then
            If collode2(index) = False Then
                barrelch(index).picNum = 1
                collode2(index) = True
                barrelch(index).speed.X = 0
            End If
        End If
    End Sub
    Private Sub AHF()
        If MarioCh.facingRight = True Then
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerrightsmasher1.jpg")
        ElseIf MarioCh.facingRight = False Then
            Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\hammerleftsmasher1.jpg")
        End If
    End Sub
    Private Sub WARNING()
        If godmode = False Then
            If hammer2 > 90 Then
                warning2.Visible = True
            ElseIf hammer2 > 87 Then
                warning2.Visible = False
            ElseIf hammer2 > 84 Then
                warning2.Visible = True
            ElseIf hammer2 > 81 Then
                warning2.Visible = False
            ElseIf hammer2 > 78 Then
                warning2.Visible = True
            Else
                warning2.Visible = False
            End If
        End If
    End Sub
    Private Sub godmode2()
        godmode = Not godmode
        If godmode = True Then
            GM.Visible = True
            hammer1 = True
        Else
            GM.Visible = False
        End If
    End Sub
End Class