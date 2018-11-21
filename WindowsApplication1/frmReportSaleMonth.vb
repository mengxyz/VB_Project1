Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportSaleMonth

    Private Sub frmReportSaleMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT Distinct year(S_Date) as  D1 ,cast(month(S_Date) as varchar)+' - '+cast(year(S_Date) as varchar) as S_Date ,CONVERT(char(4), S_Date, 100) + CONVERT(CHAR(4), S_Date, 120) as S_ID FROM Sale Order by D1 asc"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            cmbmonth.DataSource = ds.Tables("Sale")
            cmbmonth.ValueMember = "S_Date"
            cmbmonth.DisplayMember = "S_ID"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim currentReport As New ctrReportMonth
        Module1.Connect()
        sql = "select Distinct (select Distinct  CONVERT(CHAR(4), S_Date, 100) +' - '+ CONVERT(CHAR(4), S_Date, 120) from Sale where (select Distinct  cast(month(S_Date) as varchar)+' - '+cast(year(S_Date) as varchar)) = '" & cmbmonth.SelectedValue & "') as S_ID,Day(S_Date) as S_Date ,SUM(S_Net) as S_Net ,(select SUM(S_Net) "
        sql &= "from Sale Where (select Distinct  cast(month(S_Date) as varchar)+' - '+cast(year(S_Date) as varchar)) = '" & cmbmonth.SelectedValue & "') as S_Total from Sale where (select Distinct  cast(month(S_Date) as varchar)+' - '+cast(year(S_Date) as varchar)) = '" & cmbmonth.SelectedValue & "' group by Day(S_Date)"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        Dim TbCra As DataTable
        TbCra = New DataTable
        TbCra.Load(sqlDr)
        currentReport.SetDataSource(TbCra)
        ctrv1.ReportSource = currentReport 'ctrv1 คือ ชื่อของ CrystalReportViewer
    End Sub
End Class