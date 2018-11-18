Imports System.Data.SqlClient
Public Class frmMember
    Public pk As String
    Dim Save_status As String
    Sub clear()
        txtID.Text = ""
        txtNa.Text = ""
        txtAdd.Text = ""
        txtTel.Text = ""
        txtNa.Text = ""
        txtEmail.Text = ""
    End Sub
    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT * FROM Member"
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Member")
        dgvMem.ReadOnly = True
        dgvMem.DataSource = ds.Tables("Member")
        dgvMem.Columns(0).HeaderText = "รหัสลูกค้า"
        dgvMem.Columns(0).Width = 60
        dgvMem.Columns(1).HeaderText = "ชื่อลูกค้า"
        dgvMem.Columns(1).Width = 100
        dgvMem.Columns(2).HeaderText = "ที่อยู่"
        dgvMem.Columns(2).Width = 100
        dgvMem.Columns(3).HeaderText = "เบอร์โทรศัพท์"
        dgvMem.Columns(3).Width = 100
        dgvMem.Columns(4).HeaderText = "Email"
        dgvMem.Columns(4).Width = 100
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtNa.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        If txtNa.TextLength = 0 Or txtAdd.TextLength = 0 Or txtEmail.TextLength = 0 Or txtTel.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtNa.Focus()
            Exit Sub
        End If
        If Save_status = "Add" Or Save_status = "Edit" Then
            If txtNa.Text <> pk Then
                sql = "SELECT M_Na FROM Member WHERE M_Na ='" & txtNa.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlDr = sqlCmd.ExecuteReader
                If sqlDr.Read() Then
                    MessageBox.Show("ชื่อพนังงานซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNa.Focus()
                    sqlDr.Close()
                    Exit Sub
                End If
                sqlDr.Close()
            End If
        End If
        If Save_status = "Add" Then
            sql = "INSERT INTO Member (M_ID,M_Na,M_Add,M_Tel,M_Email) VALUES ('" & txtID.Text & "','" & txtNa.Text & "','" & txtAdd.Text & "','" & txtTel.Text & "','" & txtEmail.Text & "')"
        End If
        If Save_status = "Edit" Then
            sql = "UPDATE Member set M_ID = '" & txtID.Text & "',M_Na = '" & txtNa.Text & "',M_Add = '" & txtAdd.Text & "',M_Tel = '" & txtTel.Text & "',M_Email = '" & txtEmail.Text & "'"
            sql &= "WHERE M_ID = '" & txtID.Text & "' "
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        Conn.Close()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        clear()
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtNa.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Module1.Connect()
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Sql = "SELECT MAX (M_ID) FROM Member"
        sqlCmd = New SqlCommand(Sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            If sqlDr.IsDBNull(0) Then
                key_Gen = "M001"
            Else
                key_Gen = sqlDr.Item(0)
                key_Gen = Trim(key_Gen)
                key_Gen = Strings.Right(key_Gen, 3)
                key_Gen = CInt(key_Gen) + 1
                key_Gen = Strings.Right(("00" & key_Gen), 3)
                key_Gen = "M" & key_Gen
            End If
        End If
        sqlDr.Close()
        txtID.Text = key_Gen
        txtNa.Enabled = True
        txtAdd.Enabled = True
        txtTel.Enabled = True
        txtNa.Enabled = True
        txtEmail.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Add"
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        clear()
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtNa.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub dgvMem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMem.CellContentDoubleClick
        pk = dgvMem.Rows(e.RowIndex).Cells(1).Value.ToString
        txtID.Text = dgvMem.Rows(e.RowIndex).Cells(0).Value.ToString
        txtNa.Text = dgvMem.Rows(e.RowIndex).Cells(1).Value.ToString
        txtAdd.Text = dgvMem.Rows(e.RowIndex).Cells(2).Value.ToString
        txtTel.Text = dgvMem.Rows(e.RowIndex).Cells(3).Value.ToString
        txtEmail.Text = dgvMem.Rows(e.RowIndex).Cells(4).Value.ToString
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtNa.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtNa.Enabled = True
        txtAdd.Enabled = True
        txtTel.Enabled = True
        txtNa.Enabled = True
        txtEmail.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Edit"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE FROM Member WHERE M_ID = '" & txtID.Text & "' "
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtNa.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNa.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13
                e.Handled = False
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True

        End Select
    End Sub
End Class