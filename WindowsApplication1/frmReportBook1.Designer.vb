<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportBook1
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
        Me.ctrv4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ctrv4
        '
        Me.ctrv4.ActiveViewIndex = -1
        Me.ctrv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctrv4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ctrv4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrv4.Location = New System.Drawing.Point(0, 0)
        Me.ctrv4.Name = "ctrv4"
        Me.ctrv4.Size = New System.Drawing.Size(509, 366)
        Me.ctrv4.TabIndex = 0
        '
        'frmReportBook1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 366)
        Me.Controls.Add(Me.ctrv4)
        Me.Name = "frmReportBook1"
        Me.Text = "รายงานข้อมูลสินค้าทั้งหมด"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrv4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
