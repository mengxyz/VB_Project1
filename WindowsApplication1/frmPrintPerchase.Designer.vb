<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPerchase
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
        Me.ctrv2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ctrv2
        '
        Me.ctrv2.ActiveViewIndex = -1
        Me.ctrv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctrv2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ctrv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrv2.Location = New System.Drawing.Point(0, 0)
        Me.ctrv2.Name = "ctrv2"
        Me.ctrv2.Size = New System.Drawing.Size(506, 367)
        Me.ctrv2.TabIndex = 0
        '
        'frmPrintPerchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 367)
        Me.Controls.Add(Me.ctrv2)
        Me.Name = "frmPrintPerchase"
        Me.Text = "พิมพ์ใบสั่งซื้อ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrv2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
