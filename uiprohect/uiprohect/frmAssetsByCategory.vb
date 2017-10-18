Imports CrystalDecisions.CrystalReports.Engine
Public Class frmAssetsByCategory
    Dim sql As String
    Private Sub frmAssetsByCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT [Asset Category] FROM tblCategory ORDER by [Asset Category] ASC"
        LoadDataToControl(cmbCategory, sql)
        cmbCategory.Items.Add("All")

    End Sub

    Private Sub cmbCategory_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        On Error GoTo er
        Dim rpt As New ReportByCategory
        'cryReport.Load(My.Application.Info.DirectoryPath + "\ReportByCategory.rpt")
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

        If (TabControl1.SelectedTab Is TabPage1) Then
            If (DataGridView1.RowCount > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView1.Rows
                    dt.Rows.Add(row.Cells("Asset Category").Value, row.Cells("Asset Name").Value, row.Cells("Asset Brand").Value, row.Cells("Asset Description").Value, row.Cells("Status").Value, row.Cells("Department").Value, row.Cells("Room Location").Value, row.Cells("Name of User").Value)
                Next

                'Now we define a dataset
                Dim ds As New DataSet()
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ReportByCategory.xml")

                'TextObject1.Text = cmbCategory.Text
                rpt.SetDataSource(ds)

            End If

        End If
        If (TabControl1.SelectedTab Is TabPage2) Then
            If (DataGridView2.RowCount > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView2.Rows
                    dt.Rows.Add(row.Cells("Asset Category").Value, row.Cells("Asset Name").Value, row.Cells("Asset Brand").Value, row.Cells("Asset Description").Value, row.Cells("Status").Value, row.Cells("Department").Value, row.Cells("Room Location").Value, row.Cells("Name of User").Value)
                Next

                'Now we define a dataset
                Dim ds As New DataSet()
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ReportByCategory.xml")

                rpt.SetDataSource(ds)
            End If
        End If
        If (TabControl1.SelectedTab Is TabPage3) Then
            If (DataGridView4.RowCount > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView4.Rows
                    dt.Rows.Add(row.Cells("Asset Category").Value, row.Cells("Asset Name").Value, row.Cells("Asset Brand").Value, row.Cells("Asset Description").Value, row.Cells("Status").Value, row.Cells("Department").Value, row.Cells("Room Location").Value, row.Cells("Name of User").Value)
                Next

                'Now we define a dataset
                Dim ds As New DataSet()
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ReportByCategory.xml")

                rpt.SetDataSource(ds)
            End If
        End If
        If (TabControl1.SelectedTab Is TabPage4) Then
            If (DataGridView3.RowCount > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView3.Rows
                    dt.Rows.Add(row.Cells("Asset Category").Value, row.Cells("Asset Name").Value, row.Cells("Asset Brand").Value, row.Cells("Asset Description").Value, row.Cells("Status").Value, row.Cells("Department").Value, row.Cells("Room Location").Value, row.Cells("Name of User").Value)
                Next

                'Now we define a dataset
                Dim ds As New DataSet()
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ReportByCategory.xml")

                rpt.SetDataSource(ds)
            End If
        End If
        Dim fName As TextObject
        fName = TryCast(rpt.ReportDefinition.ReportObjects("Text2"), TextObject)
        If (TabControl1.SelectedTab Is TabPage1) Then
            If (cmbCategory.Text = "All") Then
                fName.Text = "Asset by Category:All"
            Else
                fName.Text = "Asset by Category:" + cmbCategory.Text
            End If
        End If
        If (TabControl1.SelectedTab Is TabPage2) Then
            fName.Text = "Asset by Department:" + cmbDepartment.Text
        End If
        If (TabControl1.SelectedTab Is TabPage3) Then
            fName.Text = "Asset by Purchase Date:" + cmbPurchaseDate.Text
        End If
        If (TabControl1.SelectedTab Is TabPage4) Then
            fName.Text = "Asset by Supplier:" + cmbSupplier.Text
        End If

        ReportViewer.CrystalReportViewer1.ReportSource = rpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.CrystalReportViewer1.ShowGroupTreeButton = False
        miscModule.LoadForm(ReportViewer, mdiMain)
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        On Error GoTo er
        Dim cryReport As New ReportDocument
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
            ReportViewer.CrystalReportViewer1.Refresh()
            ReportViewer.CrystalReportViewer1.ShowGroupTreeButton = False
            ReportViewer.CrystalReportViewer1.PrintReport()
            'miscModule.LoadForm(ReportViewer, mdiMain)
        End If
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical)
    End Sub

    Private Sub cmbCategory_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles cmbCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        If (cmbCategory.Text = "All") Then
            sql = "SELECT * FROM tblAsset"
            PopulateDataGridView(DataGridView1, sql)
        Else
            sql = "SELECT * FROM tblAsset WHERE [Asset Category]='" & cmbCategory.Text & "'"
            PopulateDataGridView(DataGridView1, sql)
        End If

    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        sql = "SELECT * FROM tblAsset WHERE Department='" & cmbDepartment.Text & "'"
        PopulateDataGridView(DataGridView2, sql)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedTab Is TabPage1) Then
            cmbCategory.Items.Clear()
            sql = "SELECT [Asset Category] FROM tblCategory ORDER by [Asset Category] ASC"
            LoadDataToControl(cmbCategory, sql)
            cmbCategory.Items.Add("All")
        End If
        If (TabControl1.SelectedTab Is TabPage2) Then
            sql = "SELECT Department FROM tblDepartment ORDER BY Department ASC"
            cmbDepartment.Items.Clear()
            LoadDataToControl(cmbDepartment, sql)
        End If
        If (TabControl1.SelectedTab Is TabPage3) Then
            cmbPurchaseDate.Items.Clear()
            sql = "SELECT DISTINCT [Purchase Date] FROM tblAsset ORDER BY [Purchase Date] DESC"
            LoadDateTimeDataIntoControl(cmbPurchaseDate, sql)
        End If
       
        If (TabControl1.SelectedTab Is TabPage4) Then
            Dim sql As String
            sql = "SELECT [Supplier Name] FROM tblSupplier"
            cmbSupplier.Items.Clear()
            LoadDataToControl(cmbSupplier, sql)
        End If
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Dim sql As String
        sql = "SELECT * FROM tblAsset WHERE [Supplier Name]='" & cmbSupplier.Text & "'"
        PopulateDataGridView(DataGridView3, sql)
    End Sub

    Private Sub cmbPurchaseDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurchaseDate.SelectedIndexChanged
        sql = "SELECT  * FROM tblAsset WHERE [Purchase Date]=#" & cmbPurchaseDate.Text & "#;"
        PopulateDataGridView(DataGridView4, sql)
    End Sub
End Class