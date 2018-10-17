Imports System.Data.SqlClient
Public Class frmBook
    Public pk As String
    Sub clear()
        txtISBN.Text = ""
        txtAmout.Text = ""
        txtComment.Text = ""
        txtCost.Text = ""
        txtNa.Text = ""
        txtPoint.Text = ""
        txtPrice.Text = ""
        txtPub.Text = ""
        txtAuthor.Text = ""
        cmbCate.SelectedIndex = -1
        cmbPart.SelectedIndex = -1
    End Sub
    Sub showData()
        Dim Sql As String
        Dim da As SqlDataAdapter
        Sql = "SELECT Book.B_ISBN,Book.B_Na,Book.B_Amount,Book.B_Price, Category.C_Na FROM Book ,Category where Book.C_ID = Category.C_ID"
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(Sql, Conn)
        da.Fill(ds, "book")
        dgvBook.ReadOnly = True
        dgvBook.DataSource = ds.Tables("book")
        dgvBook.Columns(0).HeaderText = "ISBN"
        dgvBook.Columns(0).Width = 100
        dgvBook.Columns(1).HeaderText = "ชื่อหนังสือ"
        dgvBook.Columns(1).Width = 100
        dgvBook.Columns(2).HeaderText = "จำนวนคงเหลือ"
        dgvBook.Columns(2).Width = 100
        dgvBook.Columns(3).HeaderText = "ราคา"
        dgvBook.Columns(3).Width = 50
        dgvBook.Columns(4).HeaderText = "ชื่อหมวดหมู่"
        dgvBook.Columns(4).Width = 100
    End Sub
    Dim Save_status As String = ""
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT C_ID,C_NA FROM Category ORDER BY C_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Category")
        If ds.Tables("Category").Rows.Count <> 0 Then
            cmbCate.DataSource = ds.Tables("Category")
            cmbCate.ValueMember = "C_ID"
            cmbCate.DisplayMember = "C_NA"
        End If
        sql = "SELECT Pa_ID,Pa_NA FROM Partner ORDER BY Pa_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Partner")
        If ds.Tables("Partner").Rows.Count <> 0 Then
            cmbPart.DataSource = ds.Tables("Partner")
            cmbPart.ValueMember = "Pa_ID"
            cmbPart.DisplayMember = "Pa_NA"
        End If
        showData()
        txtISBN.Enabled = False
        txtAmout.Enabled = False
        txtComment.Enabled = False
        txtCost.Enabled = False
        txtNa.Enabled = False
        txtPoint.Enabled = False
        txtPrice.Enabled = False
        txtPub.Enabled = False
        txtAuthor.Enabled = False
        cmbCate.Enabled = False
        cmbPart.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        cmbCate.SelectedIndex = -1
        cmbPart.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtISBN.Enabled = True
        txtAmout.Enabled = True
        txtComment.Enabled = True
        txtCost.Enabled = True
        txtNa.Enabled = True
        txtPoint.Enabled = True
        txtPrice.Enabled = True
        txtPub.Enabled = True
        txtAuthor.Enabled = True
        cmbCate.Enabled = True
        cmbPart.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Add"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        If txtAmout.TextLength = 0 Or txtAuthor.TextLength = 0 Or txtComment.TextLength = 0 Or txtCost.TextLength = 0 Or txtISBN.TextLength = 0 Or txtNa.TextLength = 0 Or txtPoint.TextLength = 0 Or txtPrice.TextLength = 0 Or txtPub.TextLength = 0 Or cmbCate.SelectedIndex = -1 Or cmbPart.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาระบุข้อมูลให้ครบ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Save_status = "Add" Then
            sql = "SELECT B_ISBN FROM Book WHERE B_ISBN ='" & txtISBN.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.Read() Then
                MessageBox.Show("รหัส ISBN ช้ำ กรุณากรอกใหม่ม", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtISBN.Focus()
                sqlDr.Close()
                Exit Sub
            End If
            sqlDr.Close()
            If Save_status = "Add" Then
                sql = "INSERT INTO Book(B_ISBN, B_Na, B_Author, B_Pub, B_Cost, B_Price, B_Amount, B_Point, B_Comment,C_ID,Pa_ID)"
                sql &= "VALUES ('" & txtISBN.Text & "','" & txtNa.Text & "','" & txtAuthor.Text & "','" & txtPub.Text & "','" & txtCost.Text & "','" & txtPrice.Text & "','" & txtAmout.Text & "','" & txtPoint.Text & "','" & txtComment.Text & "','" & cmbCate.SelectedValue & "','" & cmbPart.SelectedValue & "')"
            End If
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            clear()
            txtISBN.Enabled = False
            txtAmout.Enabled = False
            txtComment.Enabled = False
            txtCost.Enabled = False
            txtNa.Enabled = False
            txtPoint.Enabled = False
            txtPrice.Enabled = False
            txtPub.Enabled = False
            txtAuthor.Enabled = False
            cmbCate.Enabled = False
            cmbPart.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnCancle.Enabled = False
            btnExit.Enabled = True
            showData()
        End If
        If Save_status = "Edit" Then
            'If txtISBN.Text <> pk Then
            'sql = "SELECT B_ISBN FROM Book WHERE B_ISBN ='" & txtISBN.Text & "'"
            'sqlCmd = New SqlCommand(sql, Conn)
            'sqlDr = sqlCmd.ExecuteReader
            'If sqlDr.Read() Then
            'MessageBox.Show("รหัส ISBN ช้ำ กรุณากรอกใหม่ม", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' txtISBN.Focus()
            ' sqlDr.Close()
            ' Exit Sub
            ' End If
            'sqlDr.Close()
            ' End If
            sql = "UPDATE Book set B_Na = '" & txtNa.Text & "', B_Author = '" & txtAuthor.Text & "', B_Pub = '" & txtPub.Text & "', B_Cost = '" & txtCost.Text & "', B_Price = '" & txtPrice.Text & "', B_Amount = '" & txtAmout.Text & "', B_Point = '" & txtPoint.Text & "', B_Comment = '" & txtComment.Text & "',C_ID = '" & cmbCate.SelectedValue & "',Pa_ID = '" & cmbPart.SelectedValue & "'"
            sql &= "where B_ISBN = '" & txtISBN.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            clear()
            txtISBN.Enabled = False
            txtAmout.Enabled = False
            txtComment.Enabled = False
            txtCost.Enabled = False
            txtNa.Enabled = False
            txtPoint.Enabled = False
            txtPrice.Enabled = False
            txtPub.Enabled = False
            txtAuthor.Enabled = False
            cmbCate.Enabled = False
            cmbPart.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnCancle.Enabled = False
            btnExit.Enabled = True
            showData()
        End If
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        clear()
        txtISBN.Enabled = False
        txtAmout.Enabled = False
        txtComment.Enabled = False
        txtCost.Enabled = False
        txtNa.Enabled = False
        txtPoint.Enabled = False
        txtPrice.Enabled = False
        txtPub.Enabled = False
        txtAuthor.Enabled = False
        cmbCate.Enabled = False
        cmbPart.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub dgvBook_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBook.CellContentDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        pk = dgvBook.Rows(e.RowIndex).Cells(0).Value
        txtISBN.Text = dgvBook.Rows(e.RowIndex).Cells(0).Value
        sql = "select Book.B_Na, Book.B_Author, Book.B_Pub, Book.B_Cost, Book.B_Price, Book.B_Amount, Book.B_Point, Book.B_Comment, Category.C_ID, Partner.Pa_ID from Book, Category, Partner where Book.C_ID = Category.C_ID and Book.Pa_ID = Partner.Pa_ID and Book.B_ISBN ='" & txtISBN.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read Then
            txtNa.Text = sqlDr.Item(0)
            txtAuthor.Text = sqlDr.Item(1)
            txtPub.Text = sqlDr.Item(2)
            txtCost.Text = sqlDr.Item(3)
            txtPrice.Text = sqlDr.Item(4)
            txtAmout.Text = sqlDr.Item(5)
            txtPoint.Text = sqlDr.Item(6)
            txtComment.Text = sqlDr.Item(7)
            cmbCate.SelectedValue = sqlDr.Item(8)
            cmbPart.SelectedValue = sqlDr.Item(9)
        End If
        sqlDr.Close()
        txtISBN.Enabled = False
        txtAmout.Enabled = False
        txtComment.Enabled = False
        txtCost.Enabled = False
        txtNa.Enabled = False
        txtPoint.Enabled = False
        txtPrice.Enabled = False
        txtPub.Enabled = False
        txtAuthor.Enabled = False
        cmbCate.Enabled = False
        cmbPart.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(cmbCate.SelectedValue & vbCrLf & cmbPart.SelectedValue)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
            sql = "DELETE FROM Book WHERE B_ISBN ='" & txtISBN.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        showData()
        txtISBN.Enabled = False
        txtAmout.Enabled = False
        txtComment.Enabled = False
        txtCost.Enabled = False
        txtNa.Enabled = False
        txtPoint.Enabled = False
        txtPrice.Enabled = False
        txtPub.Enabled = False
        txtAuthor.Enabled = False
        cmbCate.Enabled = False
        cmbPart.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        cmbCate.SelectedIndex = -1
        cmbPart.SelectedIndex = -1
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtISBN.Enabled = False
        txtAmout.Enabled = True
        txtComment.Enabled = True
        txtCost.Enabled = True
        txtNa.Enabled = True
        txtPoint.Enabled = True
        txtPrice.Enabled = True
        txtPub.Enabled = True
        txtAuthor.Enabled = True
        cmbCate.Enabled = True
        cmbPart.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Edit"
    End Sub

    Private Sub txtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 45
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtAuthor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthor.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122
                e.Handled = False
            Case 8, 13, 32, 46
                e.Handled = False
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtPub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPub.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122
                e.Handled = False
            Case 8, 13, 32, 46
                e.Handled = False
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        Select Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtAmout_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmout.KeyPress
        Select Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นจำนวนเต็ม")
        End Select
    End Sub

    Private Sub txtPoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoint.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นจำนวนเต็ม")
        End Select
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class