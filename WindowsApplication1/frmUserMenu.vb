Public Class frmUserMenu

    Private Sub จบการทำงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จบการทำงานToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub รายงานขอมลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลกคาToolStripMenuItem.Click
        frmReportMember.Show()
    End Sub

    Private Sub รายงานขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลสนคาToolStripMenuItem.Click
        frmReportBook1.Show()
    End Sub

    Private Sub รายงานขอมลการสงซอสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลการสงซอสนคาToolStripMenuItem.Click

    End Sub

    Private Sub ขายสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขายสนคาToolStripMenuItem.Click
        frmSalse.Show()
    End Sub

    Private Sub ขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลสนคาToolStripMenuItem.Click
        frmBook.Show()
    End Sub

    Private Sub จะดการขอมลสวนตวToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จะดการขอมลสวนตวToolStripMenuItem.Click
        Ed = "0"
        frmEmp.Show()
    End Sub

    Private Sub ขอมลหมวดหมสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลหมวดหมสนคาToolStripMenuItem.Click
        frmCate.Show()
    End Sub

    Private Sub ขอมลบรษทคคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลบรษทคคาToolStripMenuItem.Click
        frmPart.Show()
    End Sub

    Private Sub ขอมลลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลลกคาToolStripMenuItem.Click
        frmMember.Show()
    End Sub
End Class