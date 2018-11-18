Public Class frmAdminMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmBook.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmCate.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frmPart.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmMember.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmEmp.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        frmPurchase.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        frmRecieve.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        frmSalse.Show()
    End Sub

    Private Sub รายงานขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลสนคาToolStripMenuItem.Click
        frmRepotrEmp.Show()
    End Sub

    Private Sub รายงานขอมลการสงซอสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลการสงซอสนคาToolStripMenuItem.Click
        frmReportMember.Show()
    End Sub

    Private Sub รายงานขอมลการรบสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลการรบสนคาToolStripMenuItem.Click
        frmReportBook1.Show()
    End Sub

    Private Sub รายงานขอมลลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลลกคาToolStripMenuItem.Click
        frmreportBookCate.Show()
    End Sub

    Private Sub จบการทำงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จบการทำงานToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub รายงานขอมลสนคาตำกวาจดสงซอToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลสนคาตำกวาจดสงซอToolStripMenuItem.Click
        frmReportLowAmount.Show()
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

    Private Sub ขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลสนคาToolStripMenuItem.Click
        frmBook.Show()
    End Sub

    Private Sub สงซอสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สงซอสนคาToolStripMenuItem.Click
        frmPurchase.Show()
    End Sub

    Private Sub รบสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รบสนคาToolStripMenuItem.Click
        frmRecieve.Show()
    End Sub

    Private Sub จดการขอมลสวนตวToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จดการขอมลสวนตวToolStripMenuItem.Click
        Ed = "0"
        frmEmp.Show()
    End Sub

    Private Sub ขายสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขายสนคาToolStripMenuItem.Click
        frmSalse.Show()
    End Sub

    Private Sub ขอมลผใชระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลผใชระบบToolStripMenuItem.Click
        Ed = "1"
        frmEmp.Show()
    End Sub

    Private Sub รายงานขอมลสนคาทงหมดตามบรษทคคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลสนคาทงหมดตามบรษทคคาToolStripMenuItem.Click
        frmReportPaBook.Show()
    End Sub
End Class