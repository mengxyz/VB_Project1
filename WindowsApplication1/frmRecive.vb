Imports System.Data
Imports System.Data.SqlClient
Public Class frmRecieve
    Dim ds As New DataSet 'ประกาศ Dataset ไว้นอก Sub เนื่องจาก ต้องการให้ Dataset สามารถเรียกใช้งานได้ทุก Sub'
    Private Sub frmRecieve_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim com As New SqlCommand
        Dim da As SqlDataAdapter

        dtReceive.Text = Today.Date
        Module1.Connect()
        sql = "SELECT E_Username,E_Name FROM Employee where E_Username = '" & User_Na & "'"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Employee")
        If ds.Tables("Employee").Rows.Count <> 0 Then
            cmbEmp.DataSource = ds.Tables("Employee")
            cmbEmp.ValueMember = "E_Username"
            cmbEmp.DisplayMember = "E_Name"
        End If
        cmbEmp.Enabled = True
        dgvPurchase.Enabled = True
        txtPurchaseID.Enabled = False
        txtPartner.Enabled = False
        txtEmp.Enabled = False
        dgvDetail.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        ShowData()
    End Sub

    Sub ShowData()
        Dim sql As String
        Dim da As SqlDataAdapter

        sql = " SELECT p.P_ID, t.Pa_Na, e.E_Name, p.P_Date "
        sql &= " FROM Purchase p, Partner t, Employee e "
        sql &= " WHERE P.Pa_ID = t.Pa_ID and p.E_Username = e.E_Username and p.P_Status = '0' "

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Purchase")
        dgvPurchase.ReadOnly = True
        dgvPurchase.DataSource = ds.Tables("Purchase")

        dgvPurchase.Columns(0).HeaderText = "เลขที่ใบสั่งซื้อ"
        dgvPurchase.Columns(0).Width = 100
        dgvPurchase.Columns(1).HeaderText = "บริษัท"
        dgvPurchase.Columns(1).Width = 80
        dgvPurchase.Columns(2).HeaderText = "ผู้ออกใบสั่งซื้อ"
        dgvPurchase.Columns(2).Width = 100
        dgvPurchase.Columns(3).HeaderText = "วันที่ออกใบสั่งซื้อ"
        dgvPurchase.Columns(3).DefaultCellStyle.Format = "dd MMM yyyy"
        dgvPurchase.Columns(3).Width = 120


    End Sub

    Private Sub dgvPurchase_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellContentDoubleClick
        Dim sql As String
        Dim da As SqlDataAdapter

        txtPurchaseID.Text = dgvPurchase.Rows(e.RowIndex).Cells(0).Value
        txtPartner.Text = dgvPurchase.Rows(e.RowIndex).Cells(1).Value
        txtEmp.Text = dgvPurchase.Rows(e.RowIndex).Cells(2).Value
        'ไปเลือกรายการในใบสั่งซื้อที่เลือกมาแสดง'
        sql = " SELECT B.B_ISBN,B.B_Na,B.B_Cost,B.B_Price,p.P_Num "
        sql &= " FROM Book b, Purchase_Detail p WHERE b.B_ISBN = p.B_ISBN "
        sql &= " AND p.P_ID = '" & txtPurchaseID.Text & "' "
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Detail")
        dgvDetail.ReadOnly = True
        dgvDetail.DataSource = ds.Tables("Detail")
        dgvDetail.Columns(0).HeaderText = "รหัสสินค้า"
        dgvDetail.Columns(0).Width = 100
        dgvDetail.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvDetail.Columns(1).Width = 100
        dgvDetail.Columns(2).HeaderText = "ราคาต้นทุน"
        dgvDetail.Columns(2).Width = 100
        dgvDetail.Columns(3).HeaderText = "ราคาขาย"
        dgvDetail.Columns(3).Width = 100
        dgvDetail.Columns(4).HeaderText = "จำนวนที่สั่งซื้อ"
        dgvDetail.Columns(4).Width = 100
        cmbEmp.Enabled = True
        dgvPurchase.Enabled = False
        txtPurchaseID.Enabled = False
        txtPartner.Enabled = False
        txtEmp.Enabled = False
        dgvDetail.Enabled = False
        btnSave.Enabled = True
        btnCancle.Enabled = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnCancle_Click(sender As System.Object, e As System.EventArgs) Handles btnCancle.Click
        txtPurchaseID.Text = ""
        txtPartner.Text = ""
        txtEmp.Text = ""
        cmbEmp.Enabled = True
        dgvPurchase.Enabled = True
        txtPurchaseID.Enabled = False
        txtPartner.Enabled = False
        txtEmp.Enabled = False
        dgvDetail.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = True
        btnExit.Enabled = True
        ds.Tables("Purchase").Clear() 'ลบข้อมูลใน Table Purchase ที่อยู่ใน Dataset
        ds.Tables("Detail").Clear() 'ลบข้อมูลใน Table Dataset ที่อยู่ใน Dataset
        ShowData()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlcmd As SqlCommand
        Dim bookID As String
        Dim i, k, amount As Integer

        sql = "INSERT INTO Recive (R_Date, P_ID, E_Username) "
        sql &= "VALUES ('" & dtReceive.Value.ToString("s") & "' ,'" & txtPurchaseID.Text & "','" & cmbEmp.SelectedValue & "' ) "
        sqlcmd = New SqlCommand(sql, Conn)
        sqlcmd.ExecuteNonQuery() 'ประมวลคำสั่ง SQL

        sql = "UPDATE Purchase SET P_Status = 1 "
        sql &= "WHERE P_ID = '" & txtPurchaseID.Text & "' "
        sqlcmd = New SqlCommand(sql, Conn)
        sqlcmd.ExecuteNonQuery()  'ประมวลคำสั่ง SQL

        k = dgvDetail.Rows.Count - 2
        For i = 0 To k
            bookID = dgvDetail.Rows(i).Cells(0).Value
            amount = dgvDetail.Rows(i).Cells(4).Value
            sql = "UPDATE Book SET B_Amount = B_Amount + '" & amount & "' WHERE B_ISBN = '" & bookID & "' "
            sqlcmd = New SqlCommand(sql, Conn)
            sqlcmd.ExecuteNonQuery()  'ประมวลคำสั่ง SQL

        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtPurchaseID.Text = ""
        txtPartner.Text = ""
        txtEmp.Text = ""
        cmbEmp.Enabled = True
        dgvPurchase.Enabled = True
        txtPurchaseID.Enabled = False
        txtPartner.Enabled = False
        txtEmp.Enabled = False
        dgvDetail.Enabled = False
        btnSave.Enabled = False
        btnCancle.Enabled = False
        btnExit.Enabled = True
        ds.Tables("Purchase").Clear() 'ลบข้อมูลใน Table Purchase ที่อยู่ใน Dataset
        ds.Tables("Detail").Clear() 'ลบข้อมูลใน Table Dataset ที่อยู่ใน Dataset
        ShowData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class