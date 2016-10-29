Public Class FrmMDI

    Private Sub CONSULTAPORIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAPORIDToolStripMenuItem.Click
        Dim FRM As New FrmConsulta01
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub CONSULTAPORMARCAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAPORMARCAToolStripMenuItem.Click
        Dim FRM As New FrmConsulta02
        FRM.MdiParent = Me
        FRM.Show()
    End Sub
End Class