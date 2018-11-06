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
        frmReportMember.Show()
    End Sub

    Private Sub รายงานขอมลการสงซอสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลการสงซอสนคาToolStripMenuItem.Click
        frmReportMember.Show()
    End Sub

    Private Sub รายงานขอมลการรบสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลการรบสนคาToolStripMenuItem.Click
        frmReportBook1.Show()
    End Sub

    Private Sub รายงานขอมลลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลลกคาToolStripMenuItem.Click
        frmReportPaBook.Show()
    End Sub
End Class