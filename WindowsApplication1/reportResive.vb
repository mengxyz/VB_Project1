Imports System.Data
Imports System.Data.SqlClient
Public Class reportResive
    Private Sub reportResive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()
        sql = "SELECT R_ID FROM Recive ORDER BY R_ID"

        da = New SqlDataAdapter(sql, Conn) 'ประมวลผลคำสั่ง sql ด้วย sqlDataAdapter
        da.Fill(ds, "Recive")  'เอาข้อมูลใส่ใน dataset โดยใส่ไว้ใน datatable ที่ชื่อว่า Category
        If ds.Tables("Recive").Rows.Count <> 0 Then  'ตรวจสอบ จำนวนแถวใน Category ไม่เท่ากับ 0 ให้เข้าไปทำในตาราง Category
            cmdText.DataSource = ds.Tables("Recive") 'ผูก dataset กับ cmbCate
            cmdText.ValueMember = "R_ID"    'กำหนดค่าที่เก็บจากการเลือก
            'cmdText.DisplayMember = "C_Na"  'กำหนดค่าที่แสดง
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim currentReport As New ctrReportRecive
        Module1.Connect()
        sql = "select p.P_Net,pa.Pa_Na ,pd.P_Num,pa.Pa_Add ,Pa_Tel ,p.P_ID,p.P_Date as P_Date,r.R_Date,e.E_Name,b.B_ISBN,b.B_Na,pd.P_Price ,pd.P_Total from Partner pa, Purchase p,Purchase_Detail pd,Book b,Recive r,Employee e where r.R_ID = '" & cmdText.SelectedValue & "' and r.P_ID = p.P_ID and r.E_Username = e.E_Username and p.Pa_ID = pa.Pa_ID and p.P_ID = pd.P_ID and b.B_ISBN = pd.B_ISBN "
        'sql &= "from Partner pa, Purchase p,Purchase_Detail pd,Book b,Recive r,Employee e"
        'sql &= "where r.R_ID = '" & cmdText.SelectedValue & "' and r.P_ID = p.P_ID and r.E_Username = e.E_Username and p.Pa_ID = pa.Pa_ID and p.P_ID = pd.P_ID and b.B_ISBN = pd.B_ISBN "
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        Dim TbCra As DataTable
        TbCra = New DataTable
        TbCra.Load(sqlDr)
        currentReport.SetDataSource(TbCra)
        ctrv1.ReportSource = currentReport 'ctrv1 คือ ชื่อของ CrystalReportViewer
    End Sub
End Class