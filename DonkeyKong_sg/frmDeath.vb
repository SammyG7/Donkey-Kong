Public Class frmDeath


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayAgain.Click
        Mainform.Timer1.Start()
        Mainform.Show()
        Hide()
    End Sub

    Private Sub frmDeath_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit1.Click
        Mainform.Close()
        Close()
    End Sub
End Class