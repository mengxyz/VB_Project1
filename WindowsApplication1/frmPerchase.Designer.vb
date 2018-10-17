<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.txtPoint = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.cmbPart = New System.Windows.Forms.ComboBox()
        Me.cmbEmp = New System.Windows.Forms.ComboBox()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colummn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBuy = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btRemove)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtNa)
        Me.GroupBox1.Controls.Add(Me.txtPoint)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.txtBook)
        Me.GroupBox1.Controls.Add(Me.cmbPart)
        Me.GroupBox1.Controls.Add(Me.cmbEmp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอีดการสั่งซื่อ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "จำนวนคงเหลือ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ราคาขาย"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ชื่อหนังสือ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "บริษัทคู๋ค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวนที่สั่งซื้อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "จุดสั่งซื้อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ราคาต้นทุน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "รหัสหนังสือ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ผู้ออกใบสั่งซื้อ"
        '
        'btRemove
        '
        Me.btRemove.Location = New System.Drawing.Point(355, 181)
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Size = New System.Drawing.Size(93, 27)
        Me.btRemove.TabIndex = 10
        Me.btRemove.Text = "ลบรายการon"
        Me.btRemove.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(241, 181)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(93, 27)
        Me.btAdd.TabIndex = 9
        Me.btAdd.Text = "เพิ่มรายการ"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(327, 105)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 8
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(327, 142)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(103, 181)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 6
        '
        'txtNa
        '
        Me.txtNa.Location = New System.Drawing.Point(327, 62)
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(121, 20)
        Me.txtNa.TabIndex = 5
        '
        'txtPoint
        '
        Me.txtPoint.Location = New System.Drawing.Point(103, 142)
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.Size = New System.Drawing.Size(100, 20)
        Me.txtPoint.TabIndex = 4
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(103, 105)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 3
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(103, 62)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(100, 20)
        Me.txtBook.TabIndex = 2
        '
        'cmbPart
        '
        Me.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPart.FormattingEnabled = True
        Me.cmbPart.Location = New System.Drawing.Point(327, 19)
        Me.cmbPart.Name = "cmbPart"
        Me.cmbPart.Size = New System.Drawing.Size(121, 21)
        Me.cmbPart.TabIndex = 1
        '
        'cmbEmp
        '
        Me.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmp.FormattingEnabled = True
        Me.cmbEmp.Location = New System.Drawing.Point(103, 19)
        Me.cmbEmp.Name = "cmbEmp"
        Me.cmbEmp.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmp.TabIndex = 0
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(500, 12)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.Size = New System.Drawing.Size(314, 225)
        Me.dgvBook.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 453)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 17
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(171, 498)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(59, 25)
        Me.btnCancle.TabIndex = 29
        Me.btnCancle.Text = "ยกเลิก"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(243, 500)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 23)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(90, 498)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 25)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 498)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 25)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(320, 500)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 23)
        Me.btnPrint.TabIndex = 31
        Me.btnPrint.Text = "พิมพ์ใบสั่งซื้อ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(494, 490)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 31)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "รวมยอด"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.Color.Blue
        Me.lblSum.Location = New System.Drawing.Point(663, 490)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(67, 31)
        Me.lblSum.TabIndex = 33
        Me.lblSum.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(757, 492)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 31)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "บาท"
        '
        'Column5
        '
        Me.Column5.HeaderText = "รวมเงิน"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวนที่สั่งซื้อ"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ราคาต้นทุน"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อหนังสือ"
        Me.Column2.Name = "Column2"
        '
        'Colummn1
        '
        Me.Colummn1.HeaderText = "รหัสหนังสือ"
        Me.Colummn1.Name = "Colummn1"
        '
        'dgvBuy
        '
        Me.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colummn1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvBuy.Location = New System.Drawing.Point(12, 268)
        Me.dgvBuy.Name = "dgvBuy"
        Me.dgvBuy.Size = New System.Drawing.Size(802, 167)
        Me.dgvBuy.TabIndex = 2
        '
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 546)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dgvBuy)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPurchase"
        Me.Text = "จัดการการซื้อหนังสือ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btRemove As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNa As System.Windows.Forms.TextBox
    Friend WithEvents txtPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents cmbPart As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEmp As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colummn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvBuy As System.Windows.Forms.DataGridView
End Class
