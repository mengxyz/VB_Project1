<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCate
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
        Me.dgvCate = New System.Windows.Forms.DataGridView()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        CType(Me.dgvCate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCate
        '
        Me.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCate.Location = New System.Drawing.Point(60, 173)
        Me.dgvCate.Name = "dgvCate"
        Me.dgvCate.Size = New System.Drawing.Size(462, 229)
        Me.dgvCate.TabIndex = 3
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.btnExit)
        Me.grb1.Controls.Add(Me.btnCancle)
        Me.grb1.Controls.Add(Me.btnSave)
        Me.grb1.Controls.Add(Me.btnDelete)
        Me.grb1.Controls.Add(Me.btnEdit)
        Me.grb1.Controls.Add(Me.btnAdd)
        Me.grb1.Controls.Add(Me.txtID)
        Me.grb1.Controls.Add(Me.txtNa)
        Me.grb1.Controls.Add(Me.lbl1)
        Me.grb1.Location = New System.Drawing.Point(46, 31)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(495, 124)
        Me.grb1.TabIndex = 2
        Me.grb1.TabStop = False
        Me.grb1.Text = "ข้อมูลหมวดหมู่หนังสือ"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(427, 78)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(348, 77)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(59, 25)
        Me.btnCancle.TabIndex = 7
        Me.btnCancle.Text = "ยกเลิก"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(267, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 25)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(186, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(97, 77)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 25)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 25)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(367, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(109, 20)
        Me.txtID.TabIndex = 2
        '
        'txtNa
        '
        Me.txtNa.Location = New System.Drawing.Point(109, 42)
        Me.txtNa.MaxLength = 50
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(195, 20)
        Me.txtNa.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(17, 40)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(47, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "ชื่อหมวด"
        '
        'frmCate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 433)
        Me.Controls.Add(Me.dgvCate)
        Me.Controls.Add(Me.grb1)
        Me.Name = "frmCate"
        Me.Text = "จัดการหมาดหมู่หนังสือ"
        CType(Me.dgvCate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCate As DataGridView
    Friend WithEvents grb1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancle As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNa As TextBox
    Friend WithEvents lbl1 As Label
End Class
