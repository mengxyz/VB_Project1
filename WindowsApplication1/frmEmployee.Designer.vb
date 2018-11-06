<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepotrEmp
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
        Me.ctrvEmp = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ctrvEmp
        '
        Me.ctrvEmp.ActiveViewIndex = -1
        Me.ctrvEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctrvEmp.Cursor = System.Windows.Forms.Cursors.Default
        Me.ctrvEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrvEmp.Location = New System.Drawing.Point(0, 0)
        Me.ctrvEmp.Name = "ctrvEmp"
        Me.ctrvEmp.Size = New System.Drawing.Size(832, 547)
        Me.ctrvEmp.TabIndex = 0
        '
        'frmRepotrEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 547)
        Me.Controls.Add(Me.ctrvEmp)
        Me.Name = "frmRepotrEmp"
        Me.Text = "รายงานข้อมูลพนักงงาน"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrvEmp As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
