Public Class frmAssetsBySuppliers

    Private Sub frmAssetsBySuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT [Supplier Name] FROM tblSupplier"
        LoadDataToControl(cmbSupplier, sql)
    End Sub

    Private Sub cmbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSupplier.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Dim sql As String
        sql = "SELECT * FROM tblAsset WHERE [Supplier Name]='" & cmbSupplier.Text & "'"
        PopulateDataGridView(DataGridView1, Sql)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs)

    End Sub
End Class