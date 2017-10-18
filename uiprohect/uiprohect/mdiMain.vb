Public Class mdiMain

    Private Sub HomeScreenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        miscModule.LoadForm(frmHomePage, Me)
    End Sub

    Private Sub SetupStatusRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmSetupStatusRecord.Show()
        miscModule.LoadForm(frmSetupStatusRecord, Me)
    End Sub


    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub AssetReportByDepartmentToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        miscModule.LoadForm(frmAssetsByDepartment, Me)
    End Sub

    Private Sub AssetReportByCategoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AssetReportByCategoryToolStripMenuItem.Click
        miscModule.LoadForm(frmAssetsByCategory, Me)
    End Sub

    Private Sub AssetReportByPurchaseDateToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        miscModule.LoadForm(frmAssetsByPurchaseDate, Me)
    End Sub

    Private Sub AssetReportBySupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        miscModule.LoadForm(frmAssetsBySuppliers, Me)
    End Sub

    Private Sub FullAssetReportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FullAssetReportToolStripMenuItem.Click
        miscModule.LoadForm(frmFullAssetReport, Me)
    End Sub

    Private Sub SetupAssetRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupAssetRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupAssetRecords, Me)
    End Sub

    Private Sub SetupDepreciationRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupDepreciationRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupDepreciationRecords, Me)
    End Sub

    Private Sub SetupCategoryRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupCategoryRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupCategoryRecords, Me)
    End Sub

    Private Sub SetupAssetMaintenanceRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupAssetMaintenanceRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupMaintenanceRecords, Me)
    End Sub

    Private Sub SetupAssetDepartmentRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupAssetDepartmentRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupDepartmentRecords, Me)
    End Sub

    Private Sub SetupSuppliersRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupSuppliersRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupSupplierRecords, Me)
    End Sub

    Private Sub SetupStatusRecordsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetupStatusRecordsToolStripMenuItem.Click
        miscModule.LoadForm(frmSetupStatusRecord, Me)
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        'miscModule.LoadForm(frmAbout, Me)
    End Sub

    Private Sub HomeScreenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeScreenToolStripMenuItem.Click
        miscModule.LoadForm(frmHomePage, Me)
        'frmHomePage.Show()
    End Sub

    Private Sub mdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm(frmHomePage, Me)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        LoadForm(AboutBox1, Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Me.Close()
        frmLogin.Show()
        frmLogin.txtUserId.Text = ""
        frmLogin.txtPassword.Text = ""
        Me.Hide()

    End Sub
End Class