Public Class frmAssetsByPurchaseDate
    Dim sql As String

    Private Sub cmbPurchaseDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPurchaseDate.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbPurchaseDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurchaseDate.SelectedIndexChanged
        'sql = "SELECT * FROM tblAsset WHERE [Supplier Name]=#" & CDate(cmbPurchaseDate.Text) & "#"
        sql = "SELECT  * FROM tblAsset WHERE [Purchase Date]=#" & cmbPurchaseDate.Text & "#;"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub frmAssetsByPurchaseDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT DISTINCT [Purchase Date] FROM tblAsset ORDER BY [Purchase Date] DESC"
        LoadDateTimeDataIntoControl(cmbPurchaseDate, sql)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class