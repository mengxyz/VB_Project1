Imports System.Data
Imports System.Data.SqlClient
Public Class frmSalse
    Dim sum As Double
    Dim sa As String
    Public j, h, amount As Integer
    Sub clear()
        'lblSum.Text = ""
        txtAmount.Text = ""
        txtBookID.Text = ""
        txtBookNa.Text = ""
        txtID.Text = ""
        txtNum.Text = ""
        txtPrice.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmLoadMember.Show()
    End Sub
    Sub showdata()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT B_ISBN,B_Na,B_Amount FROM Book "
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "B")
        dgvBook.ReadOnly = True
        dgvBook.DataSource = ds.Tables("B")
        dgvBook.Columns(0).HeaderText = "รหัสสินค้า"
        dgvBook.Columns(0).Width = 60
        dgvBook.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvBook.Columns(1).Width = 150
        dgvBook.Columns(2).HeaderText = "จำนวนคงเหลือ"
        dgvBook.Columns(2).Width = 60
    End Sub
    Private Sub frmSalse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()

        sql = "SELECT E_Username, E_Name From Employee"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Employee")
        If ds.Tables("Employee").Rows.Count <> 0 Then
            cmbEmp.DataSource = ds.Tables("Employee")
            cmbEmp.ValueMember = "E_Username"
            cmbEmp.DisplayMember = "E_Name"
        End If
        sql = "SELECT B_ISBN,B_Na,B_Amount FROM Book "
        Module1.Connect()
        ' Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "B")
        dgvBook.ReadOnly = True
        dgvBook.DataSource = ds.Tables("B")
        dgvBook.Columns(0).HeaderText = "รหัสสินค้า"
        dgvBook.Columns(0).Width = 60
        dgvBook.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvBook.Columns(1).Width = 150
        dgvBook.Columns(2).HeaderText = "จำนวนคงเหลือ"
        dgvBook.Columns(2).Width = 60
        'MessageBox.Show(dgvBook.Rows(0).Cells(0).Value & vbCrLf & dgvBook.Rows(0).Cells(2).Value)
        btnSearch.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        txtMemID.Enabled = False
        dtSale.Enabled = False
        txtID.Enabled = False
        cmbEmp.Enabled = False
        txtMemNa.Enabled = False
        txtBookID.Enabled = False
        txtBookNa.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtNum.Enabled = False
        btnSave.Enabled = False
        dgvBook.Enabled = False
        'showdata()
    End Sub

    Private Sub dgvBook_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBook.CellDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        j = e.RowIndex
        txtBookID.Text = dgvBook.Rows(e.RowIndex).Cells(0).Value
        txtBookNa.Text = dgvBook.Rows(e.RowIndex).Cells(1).Value
        txtAmount.Text = dgvBook.Rows(e.RowIndex).Cells(2).Value
        amount = dgvBook.Rows(e.RowIndex).Cells(2).Value
            sql = "Select B_Price FROM Book WHERE B_ISBN = '" & txtBookID.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.Read() Then
                txtPrice.Text = sqlDr.Item(0)
            End If
            sqlDr.Close()
            txtNum.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSearch.Enabled = True
        btnAdd.Enabled = False
        btAdd.Enabled = True
        btRemove.Enabled = True
        cmbEmp.Enabled = True
        dtSale.Enabled = True
        btnSave.Enabled = True
        dgvBook.Enabled = True

    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        clear()
        txtNum.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        cmbEmp.Enabled = False
        dtSale.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim Gid, Gname As String
        Dim Gnum, Gamount As Integer
        Dim Gprice, Gtotal As Double
        If CInt(amount) < CInt(txtNum.Text) Then
            MessageBox.Show("จำนวนที่ซื้อมากกว่าจำนวนคงเหลือ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtNum.Text = "" Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Gamount = CInt(txtAmount.Text)
        Gid = txtBookID.Text
        Gname = txtBookNa.Text
        GPrice = CDbl(txtPrice.Text)
        Gnum = CInt(txtNum.Text)
        h = Gamount - Gnum
        Gtotal = Gnum * Gprice
        dgvSale.Rows.Add(Gid, Gname, Gprice, Gnum, Gtotal)
        sum = sum + Gtotal
        lblSum.Text = sum.ToString("#,##.00")
        dgvBook.Rows(j).Cells(2).Value = h
        clear()
        btnAdd.Enabled = True
        btnSave.Enabled = True
        btnSearch.Enabled = False
        btAdd.Enabled = True
        btRemove.Enabled = False
        txtMemID.Enabled = False
        dtSale.Enabled = False
        txtID.Enabled = False
        cmbEmp.Enabled = False
        txtMemNa.Enabled = False
        txtBookID.Enabled = False
        txtBookNa.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtNum.Enabled = False
        dgvBook.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim M_ID, saleID, Num, Price, ISBN, orderDate, Total As String
        Dim i, k, orderID As Integer
        k = dgvSale.RowCount - 2
        If k < 0 Then
            MessageBox.Show("กรุณาทำรายหารสั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        orderDate = Today.Date.ToString("s")
        sql = "insert into Sale (S_Date,S_Net,M_ID,E_Username)"
        sql &= "values('" & orderDate & "','" & CDbl(lblSum.Text) & "','" & CStr(txtMemID.Text) & "','" & cmbEmp.SelectedValue & "')"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        sql = "select max (S_ID)from Sale"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        sqlDr.Read()
        saleID = sqlDr.Item(0)
        sqlDr.Close()
        For i = 0 To k
            ISBN = dgvSale.Rows(i).Cells(0).Value
            Num = dgvSale.Rows(i).Cells(3).Value
            Price = dgvSale.Rows(i).Cells(2).Value
            Total = dgvSale.Rows(i).Cells(4).Value
            sql = "insert into Sale_Detail (S_ID,B_ISBN,S_Num,S_Price,S_Total)"
            sql &= "values ('" & saleID & "','" & ISBN & "','" & Num & "','" & Price & "','" & Total & "')"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        k = dgvBook.RowCount - 2
        For i = 0 To k
            sql = "update book set B_Amount = '" & dgvBook.Rows(i).Cells(2).Value & "' where B_ISBN = '" & dgvBook.Rows(i).Cells(0).Value & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.Text = saleID
        showdata()
    End Sub

End Class