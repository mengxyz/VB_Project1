Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportPurchase

    Private Sub frmReportPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()
        sql = "SELECT P_ID FROM Purchase ORDER BY P_ID"

        da = New SqlDataAdapter(sql, Conn) 'ประมวลผลคำสั่ง sql ด้วย sqlDataAdapter
        da.Fill(ds, "Recive")  'เอาข้อมูลใส่ใน dataset โดยใส่ไว้ใน datatable ที่ชื่อว่า Category
        If ds.Tables("Recive").Rows.Count <> 0 Then  'ตรวจสอบ จำนวนแถวใน Category ไม่เท่ากับ 0 ให้เข้าไปทำในตาราง Category
            cmbPurchase.DataSource = ds.Tables("Recive") 'ผูก dataset กับ cmbCate
            cmbPurchase.ValueMember = "P_ID"    'กำหนดค่าที่เก็บจากการเลือก
            'cmdText.DisplayMember = "C_Na"  'กำหนดค่าที่แสดง
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim TbCtr As DataTable
        Dim currentReport As New ctrReportPurchase
        Module1.Connect()
        sql = "select Purchase.P_ID, Purchase.P_Date ,Partner.Pa_Na ,Partner.Pa_Add ,Partner.Pa_Tel ,Purchase.P_Net,Employee.E_Name,Book.B_ISBN,Book.B_Na,Purchase_Detail.P_Price,Purchase_Detail.P_Num,Purchase_Detail.P_Total from Purchase,Partner,Employee,Book,Purchase_Detail where Purchase.P_ID = '" & cmbPurchase.SelectedValue & "' and Purchase.P_ID = Purchase_Detail.P_ID and Book.B_ISBN = Purchase_Detail.B_ISBN and Purchase.Pa_ID = Partner.Pa_ID and Purchase.E_Username = Employee.E_Username"
        ' sql &= "from Perchase,Partner,Employee,Book,Purchase_Detail"
        '  sql &= "where Perchase.P_ID = '" & frmPurchase.txtID.Text & "'"
        ' sql &= "and Perchase.P_ID = Purchase_Detail.P_ID "
        '  sql &= "and Book.B_ISBN = Purchase_Detail.B_ISBN "
        '  sql &= "and Perchase.Pa_ID = Partner.Pa_ID "
        '  sql &= "and Perchase.E_Username = Employee.E_Username"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
    End Sub
End Class