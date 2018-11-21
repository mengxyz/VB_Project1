Imports System.Data
Imports System.Data.SqlClient
Public Class reportResive

    Private Sub reportResive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.Connect()
        Dim sql As String = "select r.R_ID,r.R_Date,p.P_ID,p.P_Status,e.E_Name from Recive r, Purchase p,Employee e where r.P_ID = p.P_ID and r.E_Username = e.E_Username "
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Dim TbCtr As New DataTable
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "purchase")
        For i As Integer = 0 To ds.Tables("purchase").Rows.Count - 1
            If ds.Tables("purchase").Rows(i).Item(3) = 0 Then
                ds.Tables("purchase").Rows(i).Item(3) = "ยังไม่ได้รับ"
            Else
                ds.Tables("purchase").Rows(i).Item(3) = "ได้รับแล้ว"
            End If
        Next
        Dim currentreport As New ctrReportRecive
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(ds.Tables("purchase"))
        ctrv1.ReportSource = currentreport

        'select p.P_ID ,p.P_Date,pa.Pa_Na,e.E_Name,p.P_Status ,pu.P_Num,pu.P_Total
        'from Purchase p,Employee e,Partner pa,Purchase_Detail pu
        ' where p.P_ID = pu.P_ID And p.Pa_ID = pa.Pa_ID And p.E_Username = e.E_Username

    End Sub
End Class