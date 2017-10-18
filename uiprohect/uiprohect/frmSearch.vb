Public Class frmSearch
    Dim sql As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim dbConnection As New dbConnectionClass

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT [Serial/Reg No],[Asset Name],[Asset Brand],[Asset Category],Status,Department,[Room Location],[Name of User] From tblAsset"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT  [Serial/Reg No],[Asset Name],[Asset Brand],[Asset Category],Status,Department,[Room Location],[Name of User] FROM tblAsset WHERE [Asset Name] LIKE '%" + txtSearch.Text + "%' OR [Asset Brand] LIKE '%" + txtSearch.Text + "%' OR [Asset Category] LIKE '%" + txtSearch.Text + "%'" +
     " OR Status LIKE '%" + txtSearch.Text + "%' OR Department LIKE '%" + txtSearch.Text + "%' " +
     " OR [Serial/Reg No] LIKE '%" + txtSearch.Text + "%' OR [Supplier Name] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        On Error GoTo er
        If (DataGridView1.RowCount > 0) Then
            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                If (row.Selected = True) Then
                    frmHomePage.Serial_Reg_NoTextBox.Text = row.Cells(0).Value
                    If (frmHomePage.Serial_Reg_NoTextBox.Text <> "") Then
                        Dim sqlx As String
                        Dim dataTable As New DataTable
                        Dim sqlCommand As New OleDb.OleDbCommand
                        sqlx = "SELECT * FROM tblAsset WHERE [Serial/Reg No]='" + row.Cells(0).Value + "'"
                        myConnection.ConnectionString = dbConnection.dbConnectionString
                        myConnection.Open()
                        sqlCommand = myConnection.CreateCommand
                        sqlCommand.CommandText = sqlx
                        dataTable.Load(sqlCommand.ExecuteReader())
                        If (dataTable.Rows.Count > 0) Then
                            Dim dv As DataRow
                            For Each dv In dataTable.Rows
                                frmHomePage.Asset_NameTextBox.Text = dv.Item(0)
                                frmHomePage.Asset_BrandTextBox.Text = IIf(IsDBNull(dv.Item(1)), "", dv.Item(1))
                                frmHomePage.Asset_DescriptionTextBox.Text = IIf(IsDBNull(dv.Item(2)), "", dv.Item(2))
                                frmHomePage.Asset_CategoryTextBox.Text = IIf(IsDBNull(dv.Item(3)), "", dv.Item(3))
                                frmHomePage.StatusTextBox.Text = IIf(IsDBNull(dv.Item(4)), "", dv.Item(4))
                                frmHomePage.Age_in_YearsTextBox.Text = IIf(IsDBNull(dv.Item(5)), "", dv.Item(5))
                                frmHomePage.DepartmentTextBox.Text = IIf(IsDBNull(dv.Item(6)), "", dv.Item(6))
                                frmHomePage.Room_LocationTextBox.Text = IIf(IsDBNull(dv.Item(7)), "", dv.Item(7))
                                frmHomePage.Name_of_UserTextBox.Text = IIf(IsDBNull(dv.Item(8)), "", dv.Item(8))

                                ' frmHomePage.Serial_Reg_NoTextBox.Text = IIf(IsDBNull(dv.Item(9)), "", dv.Item(9))
                                frmHomePage.Model_Engine_NoTextBox.Text = IIf(IsDBNull(dv.Item(10)), "", dv.Item(10))
                                frmHomePage.Supplier_NameTextBox.Text = IIf(IsDBNull(dv.Item(11)), "", dv.Item(11))
                                frmHomePage.Funded_ByTextBox.Text = IIf(IsDBNull(dv.Item(12)), "", dv.Item(12))
                                frmHomePage.Invoice_NoTextBox.Text = IIf(IsDBNull(dv.Item(13)), "", dv.Item(13))
                                frmHomePage.Cheque_NoTextBox.Text = IIf(IsDBNull(dv.Item(14)), "", dv.Item(14))
                                frmHomePage.mskPurchaseDate.Text = IIf(IsDBNull(dv.Item(15)), "", dv.Item(15))
                                frmHomePage.Purchase_PriceTextBox.Text = IIf(IsDBNull(dv.Item(16)), "", dv.Item(16))
                                frmHomePage.Depreciable_Life__in_years_TextBox.Text = IIf(IsDBNull(dv.Item(17)), "0", dv.Item(17))
                                frmHomePage.Depreciable_Value__in___TextBox.Text = IIf(IsDBNull(dv.Item(18)), "0", dv.Item(18))
                                frmHomePage.mskNextScheduleDate.Text = IIf(IsDBNull(dv.Item(19)), "", dv.Item(19))
                                If (frmHomePage.TabControl1.SelectedTab Is frmHomePage.TabPage1) Then
                                    Dim s As String
                                    s = "SELECT * FROM tblMaintenance WHERE [Serial/Reg No]='" + frmHomePage.Serial_Reg_NoTextBox.Text + "'"
                                    PopulateDataGridView(frmHomePage.DataGridView1, s)
                                End If
                                If (frmHomePage.TabControl1.SelectedTab Is frmHomePage.TabPage2) Then
                                    Dim s As String
                                    s = "SELECT * FROM tblDepreciation  WHERE [Serial/Reg No]='" + frmHomePage.Serial_Reg_NoTextBox.Text + "'"
                                    PopulateDataGridView(frmHomePage.DataGridView2, s)
                                End If
                                Exit For
                            Next
                        End If
                        myConnection.Close()
                    End If
                    Close()
                    Exit Sub
                End If
            Next
        End If
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical)
    End Sub
End Class