<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSale
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
        Me.ctrv3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ctrv3
        '
        Me.ctrv3.ActiveViewIndex = -1
        Me.ctrv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctrv3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ctrv3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrv3.Location = New System.Drawing.Point(0, 0)
        Me.ctrv3.Name = "ctrv3"
        Me.ctrv3.Size = New System.Drawing.Size(635, 451)
        Me.ctrv3.TabIndex = 0
        '
        'frmPrintSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 451)
        Me.Controls.Add(Me.ctrv3)
        Me.Name = "frmPrintSale"
        Me.Text = "พิมพ์ใบซื้อขายสินค้า"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrv3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
