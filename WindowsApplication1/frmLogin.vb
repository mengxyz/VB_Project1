Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Module1.Connect()
        sql = "select E_Username,E_Status from Employee where E_Username = '" & TextBox1.Text & "' and E_Pass = '" & TextBox2.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read Then
            User_Na = sqlDr.Item(0)
            User_Status = sqlDr.Item(1)
        Else
            MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlDr.Close()
            Exit Sub
        End If
        sqlDr.Close()
        Conn.Close()
        If User_Status = "0" Then
            Me.Hide()
            frmAdminMenu.Show()
        End If
        If User_Status = "1" Then
            Me.Hide()
            frmUserMenu.Show()
        End If
    End Sub
End Class