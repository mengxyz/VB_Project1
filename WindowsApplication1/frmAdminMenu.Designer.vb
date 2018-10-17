<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ขอลลพนฐานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.สงซอรบสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขายสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จบการทำงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ขอลลพนฐานToolStripMenuItem, Me.ขอมลสนคาToolStripMenuItem, Me.สงซอรบสนคาToolStripMenuItem, Me.ขายสนคาToolStripMenuItem, Me.รายงานToolStripMenuItem, Me.จบการทำงานToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ขอลลพนฐานToolStripMenuItem
        '
        Me.ขอลลพนฐานToolStripMenuItem.Name = "ขอลลพนฐานToolStripMenuItem"
        Me.ขอลลพนฐานToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ขอลลพนฐานToolStripMenuItem.Text = "ข้อลูลพื้นฐาน"
        '
        'ขอมลสนคาToolStripMenuItem
        '
        Me.ขอมลสนคาToolStripMenuItem.Name = "ขอมลสนคาToolStripMenuItem"
        Me.ขอมลสนคาToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ขอมลสนคาToolStripMenuItem.Text = "ข้อมูลสินค้า"
        '
        'สงซอรบสนคาToolStripMenuItem
        '
        Me.สงซอรบสนคาToolStripMenuItem.Name = "สงซอรบสนคาToolStripMenuItem"
        Me.สงซอรบสนคาToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.สงซอรบสนคาToolStripMenuItem.Text = "สั่งซื้อ - รับสินค้า"
        '
        'ขายสนคาToolStripMenuItem
        '
        Me.ขายสนคาToolStripMenuItem.Name = "ขายสนคาToolStripMenuItem"
        Me.ขายสนคาToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ขายสนคาToolStripMenuItem.Text = "ขายสินค้า"
        '
        'รายงานToolStripMenuItem
        '
        Me.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem"
        Me.รายงานToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.รายงานToolStripMenuItem.Text = "รายงาน"
        '
        'จบการทำงานToolStripMenuItem
        '
        Me.จบการทำงานToolStripMenuItem.Name = "จบการทำงานToolStripMenuItem"
        Me.จบการทำงานToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.จบการทำงานToolStripMenuItem.Text = "จบการทำงาน"
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 275)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdminMenu"
        Me.Text = "เมนูผู้ดูเเลระบบ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ขอลลพนฐานToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ขอมลสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents สงซอรบสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ขายสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จบการทำงานToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
