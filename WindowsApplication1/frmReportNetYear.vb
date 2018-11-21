Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportNetYear

    Private Sub frmReportNetYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT distinct Year(S_Date) as S_Date From Sale"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Sale")
        If ds.Tables("Sale").Rows.Count <> 0 Then
            cmbYear.DataSource = ds.Tables("Sale")
            cmbYear.ValueMember = "S_Date"
            cmbYear.DisplayMember = "S_Date"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.Connect()
        Dim sql As String = "select cast(month(S_Date) as varchar) as S_Date,SUM(S_Net) as Net,(select SUM(S_Net)from Sale where YEAR(S_Date) = '" & cmbYear.SelectedValue & "') as NetYear from Sale where YEAR(S_Date) = '" & cmbYear.SelectedValue & "' group by MONTH(S_Date )"
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Dim TbCtr As New DataTable
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "emp")
        For i As Integer = 0 To ds.Tables("emp").Rows.Count - 1
            ds.Tables("emp").Rows(i).Item(0) = CStr(MonthName(CInt(ds.Tables("emp").Rows(i).Item(0))))
        Next
        Dim currentreport As New ctrReportNetYear
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(ds.Tables("emp"))
        ctrv1.ReportSource = currentreport
        currentreport.SetParameterValue("year", CStr(cmbYear.SelectedValue))
    End Sub 'ctrv1 คือ ชื่อของ CrystalReportViewer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class