Imports System.Data.OleDb
Public Class frmSetupDepreciationRecords
    Dim sql As String


    Private Sub frmSetupDepreciationRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitechAMSDataSet.tblDepreciation' table. You can move, or remove it, as needed.
        sql = "SELECT * FROM tblDepreciation"
        PopulateDataGridView(dataGridView1, sql)

        sql = "SELECT DISTINCT [Serial/Reg No] FROM tblAsset"
        LoadDataToControl(Serial_Reg_NoTextBox, sql)
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        'To Add new Depreciation records
        If (Serial_Reg_NoTextBox.Text = "") Then
            MsgBox("Please enter serial number")
            Exit Sub
        End If
        If (Depreciation_AmountTextBox.Text = "") Then
            MsgBox("Please enter status value")
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure want to add a new record?", MsgBoxStyle.YesNo, "New Entry")
        If (response = vbYes) Then
            sql = "INSERT INTO tblDepreciation([Depreciation Date],[Serial/Reg No],[Depreciation Amount]) VALUES('" & mskDepreciationDate.Text & "','" & Serial_Reg_NoTextBox.Text & "'," & Depreciation_AmountTextBox.Text & ")"
            ExecuteNonQuery(sql)
            frmSetupDepreciationRecords_Load(sender, e)
        End If

    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        'To Delete depreciation records
        Dim response As Object
        response = MsgBox("Are you sure want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Entry")
        If (response = vbYes) Then
            Sql = "DELETE FROM tblDepreciation WHERE DepreciationID=" & DepreciationIDTextBox.Text & ""
            ExecuteNonQuery(Sql)
            frmSetupDepreciationRecords_Load(sender, e)
        End If

    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        Close()

    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        'To update depreciation records
        Dim response As Object
        response = MsgBox("Are you sure want to update the selected record?", MsgBoxStyle.YesNo, "Update Entry")
        If (response = vbYes) Then
            sql = "UPDATE tblDepreciation SET [Depreciation Date]=#" + mskDepreciationDate.Text + "#,[Serial/Reg No]='" + Serial_Reg_NoTextBox.Text + "',[Depreciation Amount]='" + Depreciation_AmountTextBox.Text + "' WHERE DepreciationID=" & DepreciationIDTextBox.Text & ""
            ExecuteNonQuery(sql)
            frmSetupDepreciationRecords_Load(sender, e)
        End If

    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub Depreciation_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Depreciation_DateDateTimePicker.ValueChanged
        Me.mskDepreciationDate.Text = Depreciation_DateDateTimePicker.Value.ToShortDateString()
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        On Error GoTo 0
        If (dataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In dataGridView1.Rows
                If (row.Selected = True) Then
                    DepreciationIDTextBox.Text = row.Cells(0).Value.ToString()
                    mskDepreciationDate.Text = row.Cells(1).Value.ToString()
                    Serial_Reg_NoTextBox.Text = row.Cells(2).Value.ToString()
                    Depreciation_AmountTextBox.Text = row.Cells(3).Value.ToString()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        On Error GoTo 0
        sql = "SELECT * FROM tblDepreciation WHERE DepreciationID LIKE '%" + txtSearch.Text + "%' OR [Depreciation Date] LIKE '%" + txtSearch.Text + "%' OR [Serial/Reg No] LIKE '%" + txtSearch.Text + "%' OR [Depreciation Amount] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(dataGridView1, sql)
        If (dataGridView1.RowCount > 0) Then
            If (dataGridView1.Rows(0).Selected = True) Then
                DepreciationIDTextBox.Text = dataGridView1.Rows(0).Cells(0).Value.ToString()
                mskDepreciationDate.Text = dataGridView1.Rows(0).Cells(1).Value.ToString()
                Serial_Reg_NoTextBox.Text = dataGridView1.Rows(0).Cells(2).Value.ToString()
                Depreciation_AmountTextBox.Text = dataGridView1.Rows(0).Cells(2).Value.ToString()
            End If
        End If
    End Sub

    Private Sub Serial_Reg_NoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Serial_Reg_NoTextBox.KeyPress
        e.Handled = True
    End Sub
End Class