Imports System.Data.OleDb
Public Class frmSetupSupplierRecords
    Dim Provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim sql As String


    Private Sub frmSetupSupplierRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT * FROM tblSupplier"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If (Supplier_NameTextBox.Text = "") Then
            MsgBox("Please enter supplier name")
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure want to add a new record?", MsgBoxStyle.YesNo, "New Entry")
        If (response = vbYes) Then
            sql = "INSERT INTO tblSupplier([Supplier Name]) VALUES('" & Supplier_NameTextBox.Text & "')"
            ExecuteNonQuery(Sql)
            frmSetupSupplierRecords_Load(sender, e)
        End If




    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        'To Delete Supplier records
        'To Delete Status Records
        Dim response As Object
        response = MsgBox("Are you sure want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Entry")
        If (response = vbYes) Then
            sql = "DELETE FROM tblSupplier WHERE SupplierID=" & SupplierIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupSupplierRecords_Load(sender, e)
        End If

    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        'To Update Status Records
        Me.Validate()
        Dim response As Object
        response = MsgBox("Are you sure want to update the selected record?", MsgBoxStyle.YesNo, "Update Entry")
        If (response = vbYes) Then
            sql = "UPDATE tblSupplier SET [Supplier Name]='" + Supplier_NameTextBox.Text + "' WHERE SupplierId=" & SupplierIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupSupplierRecords_Load(sender, e)
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub





    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT * FROM tblSupplier WHERE SupplierID LIKE '%" + txtSearch.Text + "%' OR [Supplier Name] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
        If (DataGridView1.RowCount > 0) Then
            If (DataGridView1.Rows(0).Selected = True) Then
                SupplierIDTextBox.Text = DataGridView1.Rows(0).Cells(0).Value.ToString()
                Supplier_NameTextBox.Text = DataGridView1.Rows(0).Cells(1).Value.ToString()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                If (row.Selected = True) Then
                    SupplierIDTextBox.Text = row.Cells(0).Value.ToString()
                    Supplier_NameTextBox.Text = row.Cells(1).Value.ToString()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class