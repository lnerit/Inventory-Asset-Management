Imports System.Data.OleDb
Public Class frmSetupCategoryRecords
    Dim sql As String

    Private Sub frmSetupCategoryRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblCategory ORDER by [Asset Category] ASC"
        PopulateDataGridView(DataGridView1, sql)

    End Sub


    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click

        If (Asset_CategoryTextBox.Text = "") Then
            MsgBox("Please enter Category value")
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure want to add a new record?", MsgBoxStyle.YesNo, "New Entry")
        If (response = vbYes) Then
            sql = "INSERT INTO tblCategory([Asset Category]) VALUES('" & Asset_CategoryTextBox.Text & "')"
            ExecuteNonQuery(sql)
            frmSetupCategoryRecords_Load(sender, e)
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Dim response As Object
        response = MsgBox("Are you sure want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Entry")
        If (response = vbYes) Then
            sql = "DELETE FROM tblCategory WHERE [Asset CategoryID]=" & Asset_CategoryIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupCategoryRecords_Load(sender, e)
        End If

    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        Me.Close()
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Dim response As Object
        response = MsgBox("Are you sure want to update the selected record?", MsgBoxStyle.YesNo, "Update Entry")
        If (response = vbYes) Then
            sql = "UPDATE tblCategory SET [Asset Category]='" + Asset_CategoryTextBox.Text + "' WHERE [Asset CategoryId]=" & Asset_CategoryIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupCategoryRecords_Load(sender, e)
        End If

    End Sub

  

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub





    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        On Error GoTo 0
        sql = "SELECT * FROM tblCategory WHERE [Asset CategoryID] LIKE '%" + txtSearch.Text + "%' OR [Asset Category] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
        If (DataGridView1.RowCount > 0) Then
            If (DataGridView1.Rows(0).Selected = True) Then
                Asset_CategoryIDTextBox.Text = DataGridView1.Rows(0).Cells(0).Value.ToString()
                Asset_CategoryTextBox.Text = DataGridView1.Rows(0).Cells(1).Value.ToString()
            End If
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error GoTo 0
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                If (row.Selected = True) Then
                    Asset_CategoryIDTextBox.Text = row.Cells(0).Value.ToString()
                    Asset_CategoryTextBox.Text = row.Cells(1).Value.ToString()
                    Exit For
                End If
            Next
        End If
    End Sub
End Class