Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmFullAssetReport
    Dim sql As String

    Private Sub frmFullAssetReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblAsset"
        PopulateDataGridView(DataGridView1, sql)
        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        Dim dt As New DataTable()
        dt.TableName = "ReportByCategory"
        dt.Columns.Add("Category", Type.GetType("System.String"))
        dt.Columns.Add("AssetName", Type.GetType("System.String"))
        dt.Columns.Add("AssetBrand", Type.GetType("System.String"))
        dt.Columns.Add("Description", Type.GetType("System.String"))
        dt.Columns.Add("Status", Type.GetType("System.String"))
        dt.Columns.Add("Department", Type.GetType("System.String"))
        dt.Columns.Add("Location", Type.GetType("System.String"))
        dt.Columns.Add("User", Type.GetType("System.String"))
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                dt.Rows.Add(row.Cells("Asset Category").Value, row.Cells("Asset Name").Value, row.Cells("Asset Brand").Value, row.Cells("Asset Description").Value, row.Cells("Status").Value, row.Cells("Department").Value, row.Cells("Room Location").Value, row.Cells("Name of User").Value)
            Next

            'Now we define a dataset
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("ReportByCategory.xml")
            Dim rpt As New ReportByCategory
            rpt.SetDataSource(ds)
            ReportViewer.CrystalReportViewer1.ReportSource = rpt
            Dim fName As TextObject
            fName = TryCast(rpt.ReportDefinition.ReportObjects("Text2"), TextObject)
            fName.Text = "Full Asset Report"
            ReportViewer.CrystalReportViewer1.Refresh()
            ReportViewer.CrystalReportViewer1.ShowGroupTreeButton = False
            miscModule.LoadForm(ReportViewer, mdiMain)
        End If
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT * FROM tblAsset WHERE [Asset Name] LIKE '%" + txtSearch.Text + "%' OR [Asset Brand] LIKE '%" + txtSearch.Text + "%' OR [Asset Category] LIKE '%" + txtSearch.Text + "%'" +
             " OR Status LIKE '%" + txtSearch.Text + "%' OR Department LIKE '%" + txtSearch.Text + "%' " +
             " OR [Serial/Reg No] LIKE '%" + txtSearch.Text + "%' OR [Supplier Name] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
    End Sub
End Class