Public Class frmtiltle
    Dim Controls2 As New FrmControls
    Private Sub frmtiltle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Mainform.Show()
        Hide()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keys.Click
        Controls2.Show()
    End Sub
End Class