Imports System.Data.OleDb
Public Class frmSetupDepartmentRecords

    Dim sql As String


    Private Sub frmSetupDepartmentRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT * FROM tblDepartment"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        'To add new Department
        'To Add new Status record
        If (DepartmentTextBox.Text = "") Then
            MsgBox("Please enter status value")
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure want to add a new record?", MsgBoxStyle.YesNo, "New Entry")
        If (response = vbYes) Then
            sql = "INSERT INTO tblDepartment(Department) VALUES('" & DepartmentTextBox.Text & "')"
            ExecuteNonQuery(sql)
            frmSetupDepartmentRecords_Load(sender, e)
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        'To Delete records
        'To Delete Status Records
        Dim response As Object
        response = MsgBox("Are you sure want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Entry")
        If (response = vbYes) Then
            sql = "DELETE FROM tblDepartment WHERE DepartmentID=" & DepartmentIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupDepartmentRecords_Load(sender, e)
        End If
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        Me.Close()
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Dim response As Object
        response = MsgBox("Are you sure want to update the selected record?", MsgBoxStyle.YesNo, "Update Entry")
        If (response = vbYes) Then
            sql = "UPDATE tblDepartment SET Department='" + DepartmentTextBox.Text + "' WHERE DepartmentId=" & DepartmentIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupDepartmentRecords_Load(sender, e)
        End If
    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error GoTo 0
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                If (row.Selected = True) Then
                    DepartmentIDTextBox.Text = row.Cells(0).Value.ToString()
                    DepartmentTextBox.Text = row.Cells(1).Value.ToString()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        On Error GoTo 0
        sql = "SELECT * FROM tblDepartment WHERE DepartmentID LIKE '%" + txtSearch.Text + "%' OR [Department] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
        If (DataGridView1.RowCount > 0) Then
            If (DataGridView1.Rows(0).Selected = True) Then
                DepartmentIDTextBox.Text = DataGridView1.Rows(0).Cells(0).Value.ToString()
                DepartmentTextBox.Text = DataGridView1.Rows(0).Cells(1).Value.ToString()
            End If
        End If
    End Sub
End Class