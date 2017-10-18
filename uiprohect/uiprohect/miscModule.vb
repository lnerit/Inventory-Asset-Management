Imports System.Data.OleDb
Module miscModule
    Dim dbConnectionClass As New dbConnectionClass
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim sqlCommnd As New OleDbCommand
    Dim dataReader As New OleDbDataAdapter

    Public Sub LoadForm(ByVal f As Form, ByVal parentForm As Form)
        f.MdiParent = parentForm
        f.Show()
    End Sub
    Public Sub PopulateDataGridView(ByVal dv As DataGridView, ByVal sqlString As String)
        On Error GoTo er

        myConnection.ConnectionString = dbConnectionClass.dbConnectionString
        Dim sql As String
        Dim dataTable As New DataTable
        myConnection.Open()
        sql = sqlString
        sqlCommnd = myConnection.CreateCommand()
        sqlCommnd.CommandText = sql
        dataTable.Load(sqlCommnd.ExecuteReader)
        dv.DataSource = dataTable
        myConnection.Close()
        Exit Sub
er:
        MsgBox(Err.Description)
        If (myConnection.State = ConnectionState.Open) Then
            myConnection.Close()
        End If
    End Sub
    Public Sub ExecuteNonQuery(ByVal sqlString As String)
        On Error GoTo er
        Dim sql As String
        myConnection.ConnectionString = dbConnectionClass.dbConnectionString
        myConnection.Open()
        sql = sqlString
        sqlCommnd = myConnection.CreateCommand()
        sqlCommnd.CommandText = sql
        sqlCommnd.ExecuteNonQuery()
        myConnection.Close()
        Exit Sub
er:
        MsgBox(Err.Description)
        If (myConnection.State = ConnectionState.Open) Then
            myConnection.Close()
        End If
    End Sub
    Public Sub LoadDataToControl(ByVal c As Control, ByVal sqlString As String)
        On Error GoTo er
        Dim sql As String
        Dim dataTable As New DataTable
        myConnection.ConnectionString = dbConnectionClass.dbConnectionString
        myConnection.Open()
        sql = sqlString
        sqlCommnd = myConnection.CreateCommand()
        sqlCommnd.CommandText = sql
        dataTable.Load(sqlCommnd.ExecuteReader)
        Dim d As DataRow
        Dim var As Object
        If (dataTable.Rows.Count > 0) Then
            For Each d In dataTable.Rows
                var = d.Field(Of String)(0)
                If TypeOf c Is ComboBox Then
                    Dim cmb As ComboBox = TryCast(c, ComboBox)
                    cmb.Items.Add(d.Field(Of String)(0))
                End If
                If TypeOf c Is TextBox Then
                    Dim txt As TextBox = TryCast(c, TextBox)
                    txt.Text = d.Field(Of String)(0)
                End If
                If TypeOf c Is Label Then
                    Dim lbl As Label = TryCast(c, Label)
                    lbl.Text = d.Field(Of String)(0)
                End If
            Next
        End If
        myConnection.Close()
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical, "Error Occured")
        If (myConnection.State = ConnectionState.Open) Then
            myConnection.Close()
        End If
    End Sub
    Public Sub LoadDateTimeDataIntoControl(ByVal c As Control, ByVal sqlString As String)
        On Error GoTo er
        Dim sql As String
        Dim dataTable As New DataTable
        myConnection.ConnectionString = dbConnectionClass.dbConnectionString
        myConnection.Open()
        sql = sqlString
        sqlCommnd = myConnection.CreateCommand()
        sqlCommnd.CommandText = sql
        dataTable.Load(sqlCommnd.ExecuteReader)
        Dim d As DataRow
        If (dataTable.Rows.Count > 0) Then
            For Each d In dataTable.Rows
                If TypeOf c Is ComboBox Then
                    Dim cb As ComboBox = TryCast(c, ComboBox) 'c.Items.add(d.Field(Of String)(0))
                    cb.Items.Add(d.Field(Of DateTime)(0))
                End If
                If TypeOf c Is TextBox Then
                    Dim txt As TextBox = TryCast(c, TextBox)
                    txt.Text = d.Field(Of DateTime)(0)
                End If
            Next
        End If
        myConnection.Close()
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical, "Error Occured")
        If (myConnection.State = ConnectionState.Open) Then
            myConnection.Close()
        End If
    End Sub
End Module
