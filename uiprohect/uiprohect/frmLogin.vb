Imports System.Data.OleDb
Public Class frmLogin
    Dim sql As String
    Dim dbConnection As New dbConnectionClass
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim sqlCommnd As New OleDbCommand
    Dim dataReader As OleDbDataReader

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        On Error GoTo er
        If (txtUserId.Text = "") Then
            MsgBox("Please enter User ID")
            Exit Sub
        End If
        sql = "SELECT UserId  FROM tblUser WHERE (((tblUser.[UserId])='" + txtUserId.Text + "') AND ((tblUser.[Password])='" + txtPassword.Text + "'));"
        Dim dataTable As New DataTable

        myConnection.ConnectionString = dbConnection.dbConnectionString
        myConnection.Open()
        sqlCommnd = myConnection.CreateCommand()
        sqlCommnd.CommandText = sql
        dataTable.Load(sqlCommnd.ExecuteReader())
        If (dataTable.Rows.Count > 0) Then
            mdiMain.Show()
            Me.Hide()
        Else
            MsgBox("Please provide a valid login credentials", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
        myConnection.Close()
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical)
        If (myConnection.State = ConnectionState.Open) Then
            myConnection.Close()
        End If
    End Sub
End Class