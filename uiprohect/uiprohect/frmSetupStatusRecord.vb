Imports System.Data.OleDb
Public Class frmSetupStatusRecord
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim sql As String



    Private Sub frmSetupStatusRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblStatus"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        'To Add new Status record
        If (txtStatus.Text = "") Then
            MsgBox("Please enter status value")
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure want to add a new record?", MsgBoxStyle.YesNo, "New Entry")
        If (response = vbYes) Then
            sql = "INSERT INTO tblStatus(Status) VALUES('" & txtStatus.Text & "')"
            ExecuteNonQuery(sql)
            frmSetupStatusRecord_Load(sender, e)
        End If

    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        'To Delete Status Records
        Dim response As Object
        response = MsgBox("Are you sure want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Entry")
        If (response = vbYes) Then
            sql = "DELETE FROM tblStatus WHERE StatusID=" & StatusIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupStatusRecord_Load(sender, e)
        End If
    End Sub


    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        'To Update Status Records
        Dim response As Object
        response = MsgBox("Are you sure want to update the selected record?", MsgBoxStyle.YesNo, "Update Entry")
        If (response = vbYes) Then
            sql = "UPDATE tblStatus SET Status='" + txtStatus.Text + "' WHERE StatusId=" & StatusIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupStatusRecord_Load(sender, e)
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error GoTo 0
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                If (row.Selected = True) Then
                    StatusIDTextBox.Text = row.Cells(0).Value.ToString()
                    txtStatus.Text = row.Cells(1).Value.ToString()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        On Error GoTo 0
        sql = "SELECT * FROM tblStatus WHERE StatusID LIKE '%" + txtSearch.Text + "%' OR Status LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
        If (DataGridView1.RowCount > 0) Then
            If (DataGridView1.Rows(0).Selected = True) Then
                StatusIDTextBox.Text = DataGridView1.Rows(0).Cells(0).Value.ToString()
                txtStatus.Text = DataGridView1.Rows(0).Cells(1).Value.ToString()
            End If
        End If
    End Sub
End Class