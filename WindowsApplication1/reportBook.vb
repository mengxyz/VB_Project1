Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportPaBook

    Private Sub reportBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Dim TbCtr As DataTable
        Dim currentReport As New ctrBook
        Module1.Connect()
        sql = "SELECT Pa_ID,Pa_NA FROM Partner ORDER BY Pa_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Partner")
        If ds.Tables("Partner").Rows.Count <> 0 Then
            cmbPa.DataSource = ds.Tables("Partner")
            cmbPa.ValueMember = "Pa_ID"
            cmbPa.DisplayMember = "Pa_NA"
        End If
        
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrBook
        Sql = "select b.B_ISBN,b.B_Na,b.B_Amount,b.B_Cost,p.Pa_Na from Book b,Partner p where b.Pa_ID = '" & cmbPa.SelectedValue & "' and p.Pa_ID = '" & cmbPa.SelectedValue & "'"
        sqlCmd = New SqlCommand(Sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv6.ReportSource = currentReport
    End Sub
End Class