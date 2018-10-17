<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalse
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Colummn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMemID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtSale = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtMemNa = New System.Windows.Forms.TextBox()
        Me.txtBookNa = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.cmbEmp = New System.Windows.Forms.ComboBox()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(755, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 31)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "บาท"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.Color.Blue
        Me.lblSum.Location = New System.Drawing.Point(661, 444)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(67, 31)
        Me.lblSum.TabIndex = 45
        Me.lblSum.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(492, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 31)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "รวมยอด"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(318, 454)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 23)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "พิมพ์ใบสั่งซื้อ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(169, 452)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(59, 25)
        Me.btnCancle.TabIndex = 41
        Me.btnCancle.Text = "ยกเลิก"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 454)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 23)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(88, 452)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 25)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 452)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 25)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(348, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 38
        '
        'dgvSale
        '
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colummn1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSale.Location = New System.Drawing.Point(10, 268)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.Size = New System.Drawing.Size(802, 167)
        Me.dgvSale.TabIndex = 37
        '
        'Colummn1
        '
        Me.Colummn1.HeaderText = "รหัสหนังสือ"
        Me.Colummn1.Name = "Colummn1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อหนังสือ"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ราคาขาย"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวนที่ขาย"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "รวมเงิน"
        Me.Column5.Name = "Column5"
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(498, 12)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.Size = New System.Drawing.Size(314, 225)
        Me.dgvBook.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtMemID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtSale)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btRemove)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtNum)
        Me.GroupBox1.Controls.Add(Me.txtMemNa)
        Me.GroupBox1.Controls.Add(Me.txtBookNa)
        Me.GroupBox1.Controls.Add(Me.txtBookID)
        Me.GroupBox1.Controls.Add(Me.cmbEmp)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 225)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอีดการสั่งซื่อ"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(220, 85)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 27)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "รหัสลูกค้า"
        '
        'txtMemID
        '
        Me.txtMemID.Location = New System.Drawing.Point(103, 88)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.Size = New System.Drawing.Size(100, 20)
        Me.txtMemID.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "วันที่ขาย"
        '
        'dtSale
        '
        Me.dtSale.Location = New System.Drawing.Point(103, 59)
        Me.dtSale.Name = "dtSale"
        Me.dtSale.Size = New System.Drawing.Size(187, 20)
        Me.dtSale.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "จำนวนคงเหลือ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ราคาขาย"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ชื่อหนังสือ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวนที่ขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ชื่อ-สกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 121)
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
        Me.txtPrice.Location = New System.Drawing.Point(103, 149)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 8
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(348, 152)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 7
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(103, 181)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 6
        '
        'txtMemNa
        '
        Me.txtMemNa.Location = New System.Drawing.Point(348, 88)
        Me.txtMemNa.Name = "txtMemNa"
        Me.txtMemNa.Size = New System.Drawing.Size(100, 20)
        Me.txtMemNa.TabIndex = 4
        '
        'txtBookNa
        '
        Me.txtBookNa.Location = New System.Drawing.Point(348, 121)
        Me.txtBookNa.Name = "txtBookNa"
        Me.txtBookNa.Size = New System.Drawing.Size(100, 20)
        Me.txtBookNa.TabIndex = 5
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(103, 118)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookID.TabIndex = 2
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
        'frmSalse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 489)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvSale)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSalse"
        Me.Text = "frmSalse"
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMemID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btRemove As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents txtMemNa As System.Windows.Forms.TextBox
    Friend WithEvents txtBookNa As System.Windows.Forms.TextBox
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents cmbEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Colummn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
