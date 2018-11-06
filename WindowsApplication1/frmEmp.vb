Imports System.Data.SqlClient
Public Class frmEmp
    Public pk As String
    Dim Save_status As String
    Sub clear()
        txtAdd.Text = ""
        txtNa.Text = ""
        txtPass.Text = ""
        txtTel.Text = ""
        txtUser.Text = ""
        rbtStatus1.Checked = False
        rbtStatus2.Checked = False
        rbtStatus1.Enabled = False
        rbtStatus2.Enabled = False
    End Sub
    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT E_Username,E_Name,E_status FROM Employee"
        Module1.Connect()
        Dim ds As New DataSet
        da.Fill(ds, "Emp")
        dgvEmp.ReadOnly = True
        dgvEmp.DataSource = ds.Tables("Emp")
        For r As Integer = 0 To dgvEmp.Rows.Count - 2
            If dgvEmp.Rows(r).Cells(2).Value.ToString = "0" Then
                dgvEmp.Rows(r).Cells(2).Value = "ผู้ดูเเลระบบ"
            Else
                dgvEmp.Rows(r).Cells(2).Value = "พนักงาน"
            End If
        Next
        dgvEmp.Columns(0).HeaderText = "Username"
        dgvEmp.Columns(0).Width = 100
        dgvEmp.Columns(1).HeaderText = "ชื่อ-นามสกุล"
        dgvEmp.Columns(1).Width = 100
        dgvEmp.Columns(2).HeaderText = "ระดับ"
        dgvEmp.Columns(2).Width = 100
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Module1.Connect()
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Sql = "SELECT MAX (E_Username) FROM Employee"
        sqlCmd = New SqlCommand(Sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            If sqlDr.IsDBNull(0) Then
                key_Gen = "E001"
            Else
                key_Gen = sqlDr.Item(0)
                key_Gen = Trim(key_Gen)
                key_Gen = Strings.Right(key_Gen, 3)
                key_Gen = CInt(key_Gen) + 1
                key_Gen = Strings.Right(("00" & key_Gen), 3)
                key_Gen = "E" & key_Gen
            End If
        End If
        sqlDr.Close()
        txtUser.Text = key_Gen
        txtAdd.Enabled = True
        txtNa.Enabled = True
        txtPass.Enabled = True
        txtTel.Enabled = True
        txtAdd.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        rbtStatus1.Enabled = True
        rbtStatus2.Enabled = True
        Save_status = "Add"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        txtUser.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        rbtStatus1.Enabled = False
        rbtStatus2.Enabled = False
        showData()
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        clear()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        txtUser.Enabled = False
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
        Dim level As String
        Dim sqlDr As SqlDataReader
        If txtAdd.TextLength = 0 Or txtNa.TextLength = 0 Or txtPass.TextLength = 0 Or txtTel.TextLength = 0 Or rbtStatus1.Checked = False And rbtStatus2.Checked = False Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Save_status = "Add" Or Save_status = "Edit" Then
            If txtNa.Text <> pk Then
                sql = "SELECT E_Name FROM Employee WHERE E_Name ='" & txtNa.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlDr = sqlCmd.ExecuteReader
                If sqlDr.Read() Then
                    MessageBox.Show("ชื่อบริษัทซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNa.Focus()
                    sqlDr.Close()
                    Exit Sub
                End If
                sqlDr.Close()
            End If
        End If
        If rbtStatus1.Checked = True Then
            level = "0"
        End If
        If rbtStatus2.Checked = True Then
            level = "1"
        End If
        If Save_status = "Add" Then
            sql = "INSERT INTO Employee(E_Username, E_Pass, E_Name, E_Add, E_Tel, E_Status)"
            sql &= "VALUES ('" & txtUser.Text & "','" & txtPass.Text & "','" & txtNa.Text & "','" & txtAdd.Text & "','" & txtTel.Text & "','" & level & "')"
        End If
        If Save_status = "Edit" Then
            sql = "UPDATE Employee set E_Username = '" & txtUser.Text & "', E_Pass = '" & txtPass.Text & "', E_Name = '" & txtNa.Text & "', E_Add = '" & txtAdd.Text & "', E_Tel = '" & txtTel.Text & "', E_Status = '" & level & "'"
            sql &= "WHERE E_Username = '" & txtUser.Text & "'"
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        Conn.Close()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        clear()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub dgvEmp_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellContentDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        txtUser.Text = dgvEmp.Rows(e.RowIndex).Cells(0).Value
        pk = dgvEmp.Rows(e.RowIndex).Cells(1).Value
        txtNa.Text = dgvEmp.Rows(e.RowIndex).Cells(1).Value
        If dgvEmp.Rows(e.RowIndex).Cells(2).Value = "ผู้ดูเเลระบบ" Then
            rbtStatus1.Checked = True
        Else
            rbtStatus2.Checked = True
        End If
        sql = "Select E_Pass,E_Add,E_Tel FROM Employee WHERE E_Username = '" & txtUser.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            txtPass.Text = sqlDr.Item(0)
            txtAdd.Text = sqlDr.Item(1)
            txtTel.Text = sqlDr.Item(2)
        End If
        sqlDr.Close()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtAdd.Enabled = True
        txtNa.Enabled = True
        txtPass.Enabled = True
        txtTel.Enabled = True
        txtAdd.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        rbtStatus1.Enabled = True
        rbtStatus2.Enabled = True
        Save_status = "Edit"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
            sql = "DELETE FROM Employee WHERE E_Username ='" & txtUser.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        showData()
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

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 58 To 122
                e.Handled = False
            Case 8, 13, 32
                e.Handled = False
            Case 161 To 240
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class