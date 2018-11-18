Imports System.Data
Imports System.Data.SqlClient

Public Class frmReportLowAmount

    Private Sub frmReportLowAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrLowAmount
        Module1.Connect()
        sql = "select B_ISBN,B_Na,B_Pub,B_Amount,B_Point,B_Cost from Book where B_Amount < B_Point "
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
    End Sub
End Class