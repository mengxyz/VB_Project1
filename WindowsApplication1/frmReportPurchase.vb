Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportPurchase

    Private Sub frmReportPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.Connect()
        Dim sql As String = "select p.P_ID ,p.P_Date,pa.Pa_Na,e.E_Name,p.P_Status ,pu.P_Num,pu.P_Total from Purchase p,Employee e,Partner pa,Purchase_Detail pu where p.P_ID = pu.P_ID And p.Pa_ID = pa.Pa_ID And p.E_Username = e.E_Username"
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Dim TbCtr As New DataTable
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "purchase")
        For i As Integer = 0 To ds.Tables("purchase").Rows.Count - 1
            If ds.Tables("purchase").Rows(i).Item(4) = 0 Then
                ds.Tables("purchase").Rows(i).Item(4) = "ยังไม่ได้รับ"
            Else
                ds.Tables("purchase").Rows(i).Item(4) = "ได้รับแล้ว"
            End If
        Next
        Dim currentreport As New ctrReportPurchase
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(ds.Tables("purchase"))
        ctrv1.ReportSource = currentreport

    End Sub
End Class