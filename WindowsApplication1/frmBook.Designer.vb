<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtAmout = New System.Windows.Forms.TextBox()
        Me.txtPoint = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPub = New System.Windows.Forms.TextBox()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.cmbCate = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPart = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(112, 19)
        Me.txtISBN.MaxLength = 20
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(138, 20)
        Me.txtISBN.TabIndex = 0
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(112, 45)
        Me.txtAuthor.MaxLength = 100
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(138, 20)
        Me.txtAuthor.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(112, 71)
        Me.txtCost.MaxLength = 9
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 2
        '
        'txtAmout
        '
        Me.txtAmout.Location = New System.Drawing.Point(112, 101)
        Me.txtAmout.MaxLength = 10
        Me.txtAmout.Name = "txtAmout"
        Me.txtAmout.Size = New System.Drawing.Size(100, 20)
        Me.txtAmout.TabIndex = 3
        '
        'txtPoint
        '
        Me.txtPoint.Location = New System.Drawing.Point(350, 97)
        Me.txtPoint.MaxLength = 5
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.Size = New System.Drawing.Size(100, 20)
        Me.txtPoint.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(350, 71)
        Me.txtPrice.MaxLength = 9
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 6
        '
        'txtPub
        '
        Me.txtPub.Location = New System.Drawing.Point(350, 45)
        Me.txtPub.MaxLength = 100
        Me.txtPub.Name = "txtPub"
        Me.txtPub.Size = New System.Drawing.Size(134, 20)
        Me.txtPub.TabIndex = 5
        '
        'txtNa
        '
        Me.txtNa.Location = New System.Drawing.Point(350, 19)
        Me.txtNa.MaxLength = 100
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(134, 20)
        Me.txtNa.TabIndex = 4
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(68, 168)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(349, 123)
        Me.txtComment.TabIndex = 8
        '
        'cmbCate
        '
        Me.cmbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCate.Enabled = False
        Me.cmbCate.FormattingEnabled = True
        Me.cmbCate.Location = New System.Drawing.Point(68, 313)
        Me.cmbCate.Name = "cmbCate"
        Me.cmbCate.Size = New System.Drawing.Size(121, 21)
        Me.cmbCate.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(422, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(350, 357)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(59, 25)
        Me.btnCancle.TabIndex = 23
        Me.btnCancle.Text = "ยกเลิก"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(269, 357)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 25)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(188, 358)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(99, 357)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 25)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 357)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 25)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbPart)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCancle)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.cmbCate)
        Me.GroupBox1.Controls.Add(Me.txtComment)
        Me.GroupBox1.Controls.Add(Me.txtPoint)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtPub)
        Me.GroupBox1.Controls.Add(Me.txtNa)
        Me.GroupBox1.Controls.Add(Me.txtAmout)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 418)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลหนังสือ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "บริษัท"
        '
        'cmbPart
        '
        Me.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPart.FormattingEnabled = True
        Me.cmbPart.Location = New System.Drawing.Point(296, 313)
        Me.cmbPart.Name = "cmbPart"
        Me.cmbPart.Size = New System.Drawing.Size(121, 21)
        Me.cmbPart.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(273, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "จุดสั่งซื้อ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "ราคาขาย"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "สำนักพิมพ์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ชื่อหนังสือ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "หมวด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "เรื่องย่อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "จำนวนคงเหลือ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "ราคาทุน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ผู้แต่ง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "รหัส ISBN"
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(17, 448)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.Size = New System.Drawing.Size(501, 229)
        Me.dgvBook.TabIndex = 26
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 689)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBook"
        Me.Text = "ข้อมูลหนังสือ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtAmout As TextBox
    Friend WithEvents txtPoint As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPub As TextBox
    Friend WithEvents txtNa As TextBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancle As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBook As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbPart As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCate As System.Windows.Forms.ComboBox
End Class
