Imports System.Data
Imports System.Data.SqlClient
Public Class frmPurchase
    Dim sum As Double
    Private Sub Purchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT E_Username, E_Name From Employee where E_Username = '" & User_Na & "'"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Employee")
        If ds.Tables("Employee").Rows.Count <> 0 Then
            cmbEmp.DataSource = ds.Tables("Employee")
            cmbEmp.ValueMember = "E_Username"
            cmbEmp.DisplayMember = "E_Name"
        End If
        sql = "SELECT Pa_ID,Pa_Na FROM Partner ORDER BY Pa_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Partner")
        If ds.Tables("Partner").Rows.Count <> 0 Then
            cmbPart.DataSource = ds.Tables("Partner")
            cmbPart.ValueMember = "Pa_ID"
            cmbPart.DisplayMember = "Pa_Na"
        End If
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = False
        cmbPart.Enabled = False
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = False
        dgvBuy.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
    End Sub

    Private Sub cmbPart_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPart.SelectedIndexChanged
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        sql = "SELECT B_ISBN,B_Na,B_Cost,B_Price,B_Point,B_Amount FROM Book WHERE Pa_ID = '" & Val(cmbPart.SelectedValue.ToString()) & "' "
        Module1.Connect()
        da = New SqlClient.SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Book")
        dgvBook.ReadOnly = True
        dgvBook.DataSource = ds.Tables("Book")
        dgvBook.Columns(0).HeaderText = "รหัสหนังสือ"
        dgvBook.Columns(0).Width = 100
        dgvBook.Columns(1).HeaderText = "ชื่อหนังสือ"
        dgvBook.Columns(1).Width = 150
        dgvBook.Columns(2).HeaderText = "ราคาทุน"
        dgvBook.Columns(2).Width = 100
        dgvBook.Columns(3).HeaderText = "ราคาขาย"
        dgvBook.Columns(3).Width = 100
        dgvBook.Columns(4).HeaderText = "จุดสั่งซื้อ"
        dgvBook.Columns(4).Width = 100
        dgvBook.Columns(5).HeaderText = "จำนวนคงเหลือ"
        dgvBook.Columns(5).Width = 100
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'sum = 0
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = True
        cmbPart.Enabled = True
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = True
        dgvBuy.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = True
        btRemove.Enabled = True
    End Sub

    Private Sub dgvBook_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBook.CellContentDoubleClick
        txtBook.Text = dgvBook.Rows(e.RowIndex).Cells(0).Value
        txtNa.Text = dgvBook.Rows(e.RowIndex).Cells(1).Value
        txtCost.Text = dgvBook.Rows(e.RowIndex).Cells(2).Value
        txtPrice.Text = dgvBook.Rows(e.RowIndex).Cells(3).Value
        txtPoint.Text = dgvBook.Rows(e.RowIndex).Cells(4).Value
        txtAmount.Text = dgvBook.Rows(e.RowIndex).Cells(5).Value
        txtTotal.Enabled = True

    End Sub

    Private Sub btAdd_Click(sender As System.Object, e As System.EventArgs) Handles btAdd.Click
        Dim Gid, Gname As String
        Dim Gnum As Integer
        Dim Gcost, Gtotal As Double
        If txtTotal.Text = "" Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Gid = txtBook.Text
        Gname = txtNa.Text
        Gcost = CDbl(txtCost.Text)
        Gnum = CInt(txtTotal.Text)
        Gtotal = (Gnum * Gcost)
        dgvBuy.Rows.Add(Gid, Gname, Gcost, Gnum, Gtotal)
        sum = sum + Gtotal
        lblSum.Text = sum.ToString("#,##.00")
        txtBook.Text = ""
        txtNa.Text = ""
        txtAmount.Text = ""
        txtPoint.Text = ""
        txtCost.Text = ""
        txtPrice.Text = ""
        txtTotal.Text = ""
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = False
        cmbPart.Enabled = False
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = False
        dgvBuy.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = True
        btAdd.Enabled = True
        btRemove.Enabled = True
    End Sub

    Private Sub btRemove_Click(sender As System.Object, e As System.EventArgs) Handles btRemove.Click
        If dgvBuy.Rows.Count <= 1 Then Exit Sub
        sum = sum - Val(dgvBuy.CurrentRow.Cells(4).Value)
        lblSum.Text = sum.ToString("#,##.00")
        dgvBuy.Rows.Remove(dgvBuy.CurrentRow)
        If dgvBuy.Rows.Count <= 1 Then
            cmbEmp.Enabled = True
            cmbPart.Enabled = True
            btRemove.Enabled = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim bookID, num, Price, Total, orderDate As String
        Dim i, k, orderID As Integer
        k = dgvBuy.Rows.Count - 2
        If k < 0 Then
            MessageBox.Show("กรุณาทำรายหารสั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        orderDate = Today.Date.ToString("s")
        sql = "INSERT INTO Purchase (P_Date, P_Net, P_Status, Pa_ID, E_Username)"
        sql &= "VALUES('" & orderDate & "','" & CDbl(lblSum.Text) & "','0','" & cmbPart.SelectedValue & "','" & cmbEmp.SelectedValue & "')"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        sql = "SELECT MAX(P_ID) From Purchase"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        sqlDr.Read()
        orderID = sqlDr.Item(0)
        sqlDr.Close()
        For i = 0 To k
            bookID = dgvBuy.Rows(i).Cells(0).Value
            Price = dgvBuy.Rows(i).Cells(2).Value
            num = dgvBuy.Rows(i).Cells(3).Value
            Total = dgvBuy.Rows(i).Cells(4).Value
            sql = "INSERT INTO Purchase_Detail(P_ID,B_ISBN,P_Price,P_Num,P_Total)"
            sql &= "VALUES ('" & orderID & "','" & bookID & "','" & CDbl(Price) & "','" & CInt(num) & "','" & CDbl(Total) & "')"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.Text = orderID
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = False
        cmbPart.Enabled = False
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = False
        dgvBuy.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = True
        btAdd.Enabled = False
        btRemove.Enabled = False
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        frmPrintPerchase.Show()
        lblSum.Text = "0.00"
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = False
        cmbPart.Enabled = False
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = False
        dgvBuy.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dgvBuy.Rows.Clear()
    End Sub

    Private Sub btnCancle_Click(sender As System.Object, e As System.EventArgs) Handles btnCancle.Click
        txtBook.Text = ""
        txtNa.Text = ""
        txtAmount.Text = ""
        txtPoint.Text = ""
        txtCost.Text = ""
        txtPrice.Text = ""
        txtTotal.Text = ""
        lblSum.Text = "0.00"
        txtBook.Enabled = False
        txtNa.Enabled = False
        cmbEmp.Enabled = False
        cmbPart.Enabled = False
        txtAmount.Enabled = False
        txtCost.Enabled = False
        txtPrice.Enabled = False
        txtPoint.Enabled = False
        txtTotal.Enabled = False
        dgvBook.Enabled = False
        dgvBuy.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
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
End Class