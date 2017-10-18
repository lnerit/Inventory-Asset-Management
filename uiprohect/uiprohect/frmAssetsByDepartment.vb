Public Class frmAssetsByDepartment
    Dim sql As String
    Private Sub frmAssetsByDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT Department FROM tblDepartment ORDER BY Department ASC"
        LoadDataToControl(cmbDepartment, sql)
    End Sub

    Private Sub cmbDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDepartment.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        sql = "SELECT * FROM tblAsset WHERE Department='" & cmbDepartment.Text & "'"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class