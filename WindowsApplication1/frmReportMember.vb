Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportMember
    Private Sub frmReportMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim TbCtr As DataTable
        Dim currentReport As New ctrMember
        Module1.Connect()
        sql = "select M_ID,M_Na,M_Add,M_Tel,M_Email from Member order by M_ID"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
    End Sub
End Class