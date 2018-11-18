Imports System.Data
Imports System.Data.SqlClient
Public Class frmreportBookCate

    Private Sub reportBookCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Dim TbCtr As New DataTable
        Dim currentReport As New ctrBookCate
        Module1.Connect()
        sql = "SELECT C_ID,C_Na FROM Category ORDER BY C_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "cate")
        If ds.Tables("cate").Rows.Count <> 0 Then
            cmbPa.DataSource = ds.Tables("cate")
            cmbPa.ValueMember = "C_ID"
            cmbPa.DisplayMember = "C_Na"
        End If

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrBookCate
        sql = "select b.B_ISBN,b.B_Na,b.B_Amount,b.B_Cost,c.C_Na from Book b,Category c where b.C_ID = '" & cmbPa.SelectedValue & "' and c.C_ID = '" & cmbPa.SelectedValue & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
    End Sub
End Class