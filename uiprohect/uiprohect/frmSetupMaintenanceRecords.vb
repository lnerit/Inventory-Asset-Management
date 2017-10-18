
Public Class frmSetupMaintenanceRecords
    Dim sql As String
    Private Sub frmSetupMaintenanceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblMaintenance"
        PopulateDataGridView(TblMaintenanceDataGridView, sql)
        sql = "SELECT [Serial/Reg No] FROM tblAsset"
        LoadDataToControl(Serial_Reg_NoTextBox, sql)
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If (Serial_Reg_NoTextBox.Text = "") Then
            MsgBox("Please select a serial number for an asset", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure you want to insert the new record?", MsgBoxStyle.YesNo)
        If (response = vbYes) Then
            sql = "INSERT INTO tblMaintenance([Maintenance Date],[Serial/Reg No],[Maintenance Description],[Maintenance Cost]) VALUES(" _
                + "'" + mskMaintenanceDate.Text + " ','" + Serial_Reg_NoTextBox.Text + "','" + Maintenance_DescriptionTextBox.Text + "','" + Maintenance_CostTextBox.Text + "')"
            ExecuteNonQuery(sql)
            sql = "SELECT * FROM tblMaintenance"
            PopulateDataGridView(TblMaintenanceDataGridView, sql)
        End If
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        If (MaintenanceIDTextBox.Text = "") Then
            MsgBox("Please select a maintenance ID", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim response As Object
        response = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo)
        If (response = vbYes) Then
            sql = "DELETE FROM tblMaintenance WHERE [MaintenanceID]=" & MaintenanceIDTextBox.Text & ""
            ExecuteNonQuery(sql)

            sql = "SELECT * FROM tblMaintenance"
            PopulateDataGridView(TblMaintenanceDataGridView, sql)
        End If
    End Sub

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        If (MaintenanceIDTextBox.Text = "") Then
            MsgBox("Please select a maintenance ID", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        sql = "SELECT * FROM tblMaintenance"
        PopulateDataGridView(TblMaintenanceDataGridView, sql)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub Maintenance_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Maintenance_DateDateTimePicker.ValueChanged
        mskMaintenanceDate.Text = Maintenance_DateDateTimePicker.Value.ToShortDateString()
    End Sub

    Private Sub Serial_Reg_NoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Serial_Reg_NoTextBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub TblMaintenanceDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblMaintenanceDataGridView.CellClick
        On Error GoTo 0
        If (TblMaintenanceDataGridView.Rows.Count > 0) Then
            Dim row As DataGridViewRow
            For Each row In TblMaintenanceDataGridView.Rows
                If (row.Selected = True) Then
                    MaintenanceIDTextBox.Text = row.Cells(0).Value
                    mskMaintenanceDate.Text = row.Cells(1).Value
                    Serial_Reg_NoTextBox.Text = row.Cells(2).Value
                    Maintenance_DescriptionTextBox.Text = row.Cells(3).Value
                    Maintenance_CostTextBox.Text = row.Cells(4).Value
                    Exit For
                End If
            Next
        End If
    End Sub
End Class