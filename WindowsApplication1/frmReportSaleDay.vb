Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmReportSaleDay

    Private Sub frmReportSaleDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT distinct S_Date, ((cast(day(S_Date) as varchar) +' - '+ cast(month(S_Date) as varchar)+' - '+cast(year(S_Date)+543 as varchar))) as S_Date1 FROM Sale ORDER BY S_Date"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            cmbDate.DataSource = ds.Tables("Sale")
            cmbDate.ValueMember = "S_Date"
            cmbDate.DisplayMember = "S_Date"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim currentReport As New ctrSaleDay
        Module1.Connect()
        sql = "select S_ID,S_date,S_Net,Employee .E_Name,(select distinct SUM(S_Net) from Sale where S_Date = '" & cmbDate.SelectedValue & "' ) as S_Total from Sale , Employee where S_date = '" & cmbDate.SelectedValue & "' and Sale .E_Username = Employee .E_Username"
        'sql = "select (select distinct(cast(day(S_Date) as varchar) +' - '+ cast(month(S_Date) as varchar)+' - '+cast(year(S_Date)+543 as varchar)) from Sale where S_date = '" & cmbDate.SelectedValue & "' ) as S_date,S_Net,Employee .E_Name,(select distinct SUM(S_Net) from Sale where S_Date = '" & cmbDate.SelectedValue & "' ) as S_Net from Sale , Employee where S_date = '" & cmbDate.SelectedValue & "' and Sale .E_Username = Employee .E_Username"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        Dim TbCra As DataTable
        TbCra = New DataTable
        TbCra.Load(sqlDr)
        currentReport.SetDataSource(TbCra)
        ctrv1.ReportSource = currentReport 'ctrv1 คือ ชื่อของ CrystalReportViewer
        currentReport.SetParameterValue("Date", CStr(cmbDate.SelectedValue))
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(cmbDate.SelectedValue)
    End Sub
End Class