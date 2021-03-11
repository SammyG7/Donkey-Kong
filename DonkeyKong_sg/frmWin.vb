Public Class frmWin

    Private Sub frmWin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinButton.Click
        Mainform.Timer1.Start()
        Mainform.Show()
        Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit2.Click
        Mainform.Close()
        Close()
    End Sub
End Class