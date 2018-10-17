Imports System.Data.SqlClient
Public Class frmPart
    Public pk As String
    Dim Save_status As String
    Sub clear()
        txtAdd.Text = ""
        txtContect.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtNa.Text = ""
        txtTel.Text = ""
        txtID.Text = ""
    End Sub
    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT * FROM Partner"
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Part")
        dgvPart.ReadOnly = True
        dgvPart.DataSource = ds.Tables("Part")
        dgvPart.Columns(0).HeaderText = "รหัสบริษัท"
        dgvPart.Columns(0).Width = 40
        dgvPart.Columns(1).HeaderText = "ชื่อบริษัท"
        dgvPart.Columns(1).Width = 100
        dgvPart.Columns(2).HeaderText = "ที่อยู่"
        dgvPart.Columns(2).Width = 80
        dgvPart.Columns(3).HeaderText = "เบอร์โทร"
        dgvPart.Columns(3).Width = 50
        dgvPart.Columns(4).HeaderText = "เบอร์ FAx"
        dgvPart.Columns(4).Width = 50
        dgvPart.Columns(5).HeaderText = "ชื่อนามสกุลผู้ติดต่อ"
        dgvPart.Columns(5).Width = 100
        dgvPart.Columns(6).HeaderText = "Email"
        dgvPart.Columns(6).Width = 50
    End Sub
    Private Sub frmPart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtFax.Enabled = False
        txtContect.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtNa.Enabled = True
        txtAdd.Enabled = True
        txtTel.Enabled = True
        txtFax.Enabled = True
        txtContect.Enabled = True
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
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtFax.Enabled = False
        txtContect.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        If txtNa.TextLength = 0 Or txtAdd.TextLength = 0 Or txtContect.TextLength = 0 Or txtEmail.TextLength = 0 Or txtFax.TextLength = 0 Or txtTel.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtNa.Focus()
            Exit Sub
        End If
       If Save_status = "Add" Or Save_status = "Edit" Then
            If txtNa.Text <> pk Then
                sql = "SELECT Pa_Na FROM Partner WHERE Pa_Na ='" & txtNa.Text & "'"
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
            sql = "INSERT INTO Partner (Pa_Na,Pa_Add,Pa_Tel,Pa_Fax,Pa_Contact,Pa_Email) VALUES ('" & txtNa.Text & "','" & txtAdd.Text & "','" & txtTel.Text & "','" & txtFax.Text & "','" & txtContect.Text & "','" & txtEmail.Text & "')"
        End If
        If Save_status = "Edit" Then
            sql = "UPDATE Partner set Pa_Na = '" & txtNa.Text & "',Pa_Add = '" & txtAdd.Text & "',Pa_Tel = '" & txtTel.Text & "',Pa_Fax = '" & txtFax.Text & "',Pa_Contact = '" & txtContect.Text & "',Pa_Email = '" & txtEmail.Text & "'"
            sql &= "WHERE Pa_ID = '" & txtID.Text & "' "
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
        txtFax.Enabled = False
        txtContect.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub dgvPart_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPart.CellContentDoubleClick
        pk = dgvPart.Rows(e.RowIndex).Cells(1).Value.ToString
        txtID.Text = dgvPart.Rows(e.RowIndex).Cells(0).Value.ToString
        txtNa.Text = dgvPart.Rows(e.RowIndex).Cells(1).Value.ToString
        txtAdd.Text = dgvPart.Rows(e.RowIndex).Cells(2).Value.ToString
        txtTel.Text = dgvPart.Rows(e.RowIndex).Cells(3).Value.ToString
        txtFax.Text = dgvPart.Rows(e.RowIndex).Cells(4).Value.ToString
        txtContect.Text = dgvPart.Rows(e.RowIndex).Cells(5).Value.ToString
        txtEmail.Text = dgvPart.Rows(e.RowIndex).Cells(6).Value.ToString
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtFax.Enabled = False
        txtContect.Enabled = False
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
        txtFax.Enabled = True
        txtContect.Enabled = True
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
            sql = "DELETE FROM Partner WHERE Pa_ID = '" & txtID.Text & "' "
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        txtID.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        txtFax.Enabled = False
        txtContect.Enabled = False
        txtEmail.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub txtFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFax.KeyPress
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

    Private Sub txtContect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContect.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122
                e.Handled = False
            Case 8, 13, 32
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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