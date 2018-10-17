Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportBook1
    Private Sub frmReportBook1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrBook1
        Module1.Connect()
        sql = "select b.B_ISBN,b.B_Na,b.B_Author,b.B_Pub,b.B_Cost,b.B_Price,b.B_Amount,b.B_Point,c.C_Na,p.Pa_Na from Book b,Category c,Partner p where b.C_ID = c.C_ID and b.Pa_ID = p.Pa_ID"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv4.ReportSource = currentReport
    End Sub
End Class