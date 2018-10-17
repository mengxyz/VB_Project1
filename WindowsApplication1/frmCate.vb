Imports System.Data.SqlClient
Public Class frmCate
    Dim Save_status As String
    Private Sub frmCate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT C_ID,C_Na FROM Category ORDER BY C_ID"
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Cate")
        dgvCate.ReadOnly = True
        dgvCate.DataSource = ds.Tables("Cate")
        dgvCate.Columns(0).HeaderText = "รหัสหมวดหมู่"
        dgvCate.Columns(0).Width = 100
        dgvCate.Columns(1).HeaderText = "ชื่อหมวดหมู่"
        dgvCate.Columns(1).Width = 150
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtNa.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Add"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        If Save_status = "Add" Or Save_status = "Edit" Then
            sql = "SELECT C_Na FROM Category WHERE C_Na ='" & txtNa.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.Read() Then
                MessageBox.Show("ชื่อหมวดหมู่ซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtNa.Focus()
                sqlDr.Close()
                Exit Sub
            End If
            sqlDr.Close()
        End If
        If txtNa.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtNa.Focus()
            Exit Sub
        End If
        If Save_status = "Add" Then
            sql = "INSERT INTO Category (C_Na) VALUES ('" & txtNa.Text & "')"
        End If
        If Save_status = "Edit" Then
            sql = "UPDATE Category set C_Na = '" & txtNa.Text & "' "
            sql &= "WHERE C_ID = '" & txtID.Text & "' "
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery() 'ประมวลผลคำสั่ง SQL
        Conn.Close()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtID.Text = ""
        txtNa.Text = ""
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtID.Enabled = False
        txtNa.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        Save_status = "Edit"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE Category WHERE C_ID = '" & txtID.Text & "' "
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtID.Text = ""
        txtNa.Text = ""
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancle.Click
        txtNa.Text = ""
        txtID.Text = ""
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvCate_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCate.CellContentDoubleClick
        txtID.Text = dgvCate.Rows(e.RowIndex).Cells(0).Value.ToString
        txtNa.Text = dgvCate.Rows(e.RowIndex).Cells(1).Value.ToString
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub txtNa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNa.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122
                e.Handled = False
            Case 8, 13, 32
                e.Handled = False
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub
End Class
