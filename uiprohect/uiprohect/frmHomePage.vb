
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmHomePage
    Dim Provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub frmHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitechAMSDataSet.tblDepreciation' table. You can move, or remove it, as needed.
        'Me.TblDepreciationTableAdapter.Fill(Me.UnitechAMSDataSet.tblDepreciation)
        'TODO: This line of code loads data into the 'UnitechAMSDataSet.tblDepreciation' table. You can move, or remove it, as needed.
        'Me.TblDepreciationTableAdapter.Fill(Me.UnitechAMSDataSet.tblDepreciation)
        'TODO: This line of code loads data into the 'UnitechAMSDataSet.tblMaintenance' table. You can move, or remove it, as needed.
        'Me.TblMaintenanceTableAdapter.Fill(Me.UnitechAMSDataSet.tblMaintenance)
        'TODO: This line of code loads data into the 'UnitechAMSDataSet.tblAsset' table. You can move, or remove it, as needed.
        'Me.TblAssetTableAdapter.Fill(Me.UnitechAMSDataSet.tblAsset)
        'Provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'dataFile = My.Application.Info.DirectoryPath + "\UnitechAMS.accdb " ' Change it to your Access Database location"
        'connString = Provider & dataFile
        'myConnection.ConnectionString = connString
        Dim mClass As New dbConnectionClass
        'myConnection.ConnectionString = mClass.dbConnectionString


        'myConnection.Open()
        Asset_NameTextBox.Clear()
        Asset_BrandTextBox.Clear()
        Asset_DescriptionTextBox.Clear()
        Asset_DescriptionTextBox.Clear()
        StatusTextBox.Clear()
        Age_in_YearsTextBox.Clear()
        DepartmentTextBox.Clear()
        Room_LocationTextBox.Clear()
        Name_of_UserTextBox.Clear()
        Serial_Reg_NoTextBox.Clear()
        Model_Engine_NoTextBox.Clear()
        Supplier_NameTextBox.Clear()
        Funded_ByTextBox.Clear()
        Invoice_NoTextBox.Clear()
        Cheque_NoTextBox.Clear()
        'Purchase_DateDateTimePicker.Clear()
        Purchase_PriceTextBox.Clear()
        Depreciable_Life__in_years_TextBox.Clear()
        Depreciable_Value__in___TextBox.Clear()
        'Next_Scheduled_MaintenanceDateTimePicker.Clear()

        'Dim str As String
        'str = "SELECT * FROM tblAsset "
        'Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        'dr = cmd.ExecuteReader
        '   While dr.Read()
        'Asset_NameTextBox.Text = dr("Asset Name").ToString
        'Asset_BrandTextBox.Text = dr("Asset Brand").ToString
        'Asset_DescriptionTextBox.Text = dr("Asset Description").ToString
        'Asset_CategoryTextBox.Text = dr("Asset Category").ToString
        'StatusTextBox.Text = dr("Status").ToString
        'Age_in_YearsTextBox.Text = dr("Age in Years").ToString
        'DepartmentTextBox.Text = dr("Department").ToString
        'Room_LocationTextBox.Text = dr("Room Location").ToString
        'Name_of_UserTextBox.Text = dr("Name of User").ToString
        'Serial_Reg_NoTextBox.Text = dr("Serial/Reg No").ToString
        'Model_Engine_NoTextBox.Text = dr("Model/Engine No").ToString
        'Supplier_NameTextBox.Text = dr("Supplier Name").ToString
        'Funded_ByTextBox.Text = dr("Funded By").ToString
        'Invoice_NoTextBox.Text = dr("Invoice No").ToString
        'Cheque_NoTextBox.Text = dr("Cheque No").ToString
        'Purchase_DateDateTimePicker.Text = dr("Purchase Date").ToString
        'Purchase_PriceTextBox.Text = dr("Purchase Price").ToString
        'Depreciable_Life__in_years_TextBox.Text = dr("Depreciable Life (in years)").ToString
        'Depreciable_Value__in___TextBox.Text = dr("Depreciable Value (in %)").ToString
        'Next_Scheduled_MaintenanceDateTimePicker.Text = dr("Next Scheduled Maintenance").ToString

        'End While
        'myConnection.Close()
        Dim c As Control
        For Each c In Panel2.Controls
            If (TypeOf c Is TextBox) Then
                Dim txt As TextBox = TryCast(c, TextBox)
                c.Text = ""
                c.Enabled = False
            End If

            If (TypeOf c Is ComboBox) Then
                Dim txt As ComboBox = TryCast(c, ComboBox)
                c.Text = ""
                c.Enabled = False
            End If
        Next
    End Sub



    Private Sub TblAssetBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.TblAssetBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.UnitechAMSDataSet)
    End Sub

    Private Sub btnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.TblAssetBindingSource.MoveFirst()

    End Sub

    Private Sub btnPeviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.TblAssetBindingSource.MovePrevious()

    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.TblAssetBindingSource.MoveNext()

    End Sub

    Private Sub btnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.TblAssetBindingSource.MoveLast()
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        LoadForm(frmSearch, mdiMain)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (Me.TabControl1.SelectedTab Is TabPage1) Then
            Dim s As String
            s = "SELECT * FROM tblMaintenance WHERE [Serial/Reg No]='" + Me.Serial_Reg_NoTextBox.Text + "'"
            PopulateDataGridView(Me.DataGridView1, s)
        End If
        If (Me.TabControl1.SelectedTab Is TabPage2) Then
            Dim sx As String
            ' sx = "SELECT * FROM tblDepreciation  WHERE [Serial/Reg No]='" + Me.Serial_Reg_NoTextBox.Text + "'"
            'PopulateDataGridView(Me.DataGridView2, sx)
            sx = "SELECT * FROM tblDepreciation WHERE [Serial/Reg No]='" + Me.Serial_Reg_NoTextBox.Text + "'"
            PopulateDataGridView(DataGridView2, sx)
        End If
    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        If (Serial_Reg_NoTextBox.Text = "") Then
            MsgBox("Please load asset details first")
            Exit Sub
        End If
        On Error GoTo er
        Dim dt As New DataTable()
        dt.TableName = "IndividualAssetReport"
        dt.Columns.Add("Asset Name", Type.GetType("System.String"))
        dt.Columns.Add("Asset Brand", Type.GetType("System.String"))
        dt.Columns.Add("Description", Type.GetType("System.String"))
        dt.Columns.Add("Asset Category", Type.GetType("System.String"))
        dt.Columns.Add("Status", Type.GetType("System.String"))
        dt.Columns.Add("Age in Years", Type.GetType("System.String"))
        dt.Columns.Add("Department", Type.GetType("System.String"))
        dt.Columns.Add("Location", Type.GetType("System.String"))
        dt.Columns.Add("User", Type.GetType("System.String"))
        dt.Columns.Add("Serial/Reg No", Type.GetType("System.String"))
        dt.Columns.Add("Model/Engine No", Type.GetType("System.String"))
        dt.Columns.Add("Supplier", Type.GetType("System.String"))
        dt.Columns.Add("Funded By", Type.GetType("System.String"))
        dt.Columns.Add("Invoice No", Type.GetType("System.String"))
        dt.Columns.Add("Cheque No", Type.GetType("System.String"))
        dt.Columns.Add("Purchase Date", Type.GetType("System.DateTime"))
        dt.Columns.Add("Purchase Price", Type.GetType("System.Double"))
        dt.Columns.Add("Depreciable Life", Type.GetType("System.Double"))
        dt.Columns.Add("Depreciable Value", Type.GetType("System.String"))
        dt.Columns.Add("Next Scheduled", Type.GetType("System.DateTime"))
        dt.Columns.Add("MaintenanceID", Type.GetType("System.String"))
        dt.Columns.Add("Maintenance Date", Type.GetType("System.DateTime"))
        dt.Columns.Add("Maintenance Description", Type.GetType("System.String"))
        dt.Columns.Add("Maintenance Cost", Type.GetType("System.Double"))

        If TabControl1.SelectedTab Is TabPage1 Then
            If (DataGridView1.Rows.Count > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView1.Rows
                    dt.Rows.Add(Asset_NameTextBox.Text,
                                Asset_BrandTextBox.Text,
                                Asset_DescriptionTextBox.Text,
                                Asset_CategoryTextBox.Text,
                                StatusTextBox.Text,
                                Age_in_YearsTextBox.Text,
                                DepartmentTextBox.Text,
                                Room_LocationTextBox.Text,
                                Name_of_UserTextBox.Text,
                                Serial_Reg_NoTextBox.Text,
                                Model_Engine_NoTextBox.Text,
                                Supplier_NameTextBox.Text,
                                Funded_ByTextBox.Text,
                                Invoice_NoTextBox.Text,
                                Cheque_NoTextBox.Text,
                                mskPurchaseDate.Text, Purchase_PriceTextBox.Text,
                                Depreciable_Life__in_years_TextBox.Text,
                                Depreciable_Value__in___TextBox.Text,
                                mskNextScheduleDate.Text,
                                row.Cells(0).Value,
                                row.Cells(1).Value,
                                row.Cells(3).Value,
                                row.Cells(4).Value
                                )
                Next
            Else
                dt.Rows.Add(Asset_NameTextBox.Text,
                               Asset_BrandTextBox.Text,
                               Asset_DescriptionTextBox.Text,
                               Asset_CategoryTextBox.Text,
                               StatusTextBox.Text,
                               Age_in_YearsTextBox.Text,
                               DepartmentTextBox.Text,
                               Room_LocationTextBox.Text,
                               Name_of_UserTextBox.Text,
                               Serial_Reg_NoTextBox.Text,
                               Model_Engine_NoTextBox.Text,
                               Supplier_NameTextBox.Text,
                               Funded_ByTextBox.Text,
                               Invoice_NoTextBox.Text,
                               Cheque_NoTextBox.Text,
                               mskPurchaseDate.Text, Purchase_PriceTextBox.Text,
                               Depreciable_Life__in_years_TextBox.Text,
                               Depreciable_Value__in___TextBox.Text,
                               mskNextScheduleDate.Text
                               )
            End If
            'Now we define a dataset
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("IndividualAssetReport.xml")
            Dim rpt As New CrystalReport1
            rpt.SetDataSource(ds)
            ReportViewer.CrystalReportViewer1.ReportSource = rpt
        End If
        If TabControl1.SelectedTab Is TabPage2 Then
            If (DataGridView2.Rows.Count > 0) Then
                Dim row As DataGridViewRow
                For Each row In DataGridView2.Rows
                    dt.Rows.Add(Asset_NameTextBox.Text,
                                Asset_BrandTextBox.Text,
                                Asset_DescriptionTextBox.Text,
                                Asset_CategoryTextBox.Text,
                                StatusTextBox.Text,
                                Age_in_YearsTextBox.Text,
                                DepartmentTextBox.Text,
                                Room_LocationTextBox.Text,
                                Name_of_UserTextBox.Text,
                                Serial_Reg_NoTextBox.Text,
                                Model_Engine_NoTextBox.Text,
                                Supplier_NameTextBox.Text, Funded_ByTextBox.Text,
                                Invoice_NoTextBox.Text,
                                Cheque_NoTextBox.Text,
                                mskPurchaseDate.Text, Purchase_PriceTextBox.Text,
                                Depreciable_Life__in_years_TextBox.Text,
                                Depreciable_Value__in___TextBox.Text,
                                mskNextScheduleDate.Text,
                                row.Cells(0).Value,
                                row.Cells(1).Value,
                                row.Cells(2).Value,
                                row.Cells(3).Value
                                )
                Next
            Else
                dt.Rows.Add(Asset_NameTextBox.Text,
                                Asset_BrandTextBox.Text,
                                Asset_DescriptionTextBox.Text,
                                Asset_CategoryTextBox.Text,
                                StatusTextBox.Text,
                                Age_in_YearsTextBox.Text,
                                DepartmentTextBox.Text,
                                Room_LocationTextBox.Text,
                                Name_of_UserTextBox.Text,
                                Serial_Reg_NoTextBox.Text,
                                Model_Engine_NoTextBox.Text,
                                Supplier_NameTextBox.Text, Funded_ByTextBox.Text,
                                Invoice_NoTextBox.Text,
                                Cheque_NoTextBox.Text,
                                mskPurchaseDate.Text, Purchase_PriceTextBox.Text,
                                Depreciable_Life__in_years_TextBox.Text,
                                Depreciable_Value__in___TextBox.Text,
                                mskNextScheduleDate.Text
                                )
            End If
            'Now we define a dataset
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("IndividualAssetDepciationReport.xml")
            Dim rpt As New CrystalReport2
            rpt.SetDataSource(ds)
            ReportViewer.CrystalReportViewer1.ReportSource = rpt
        End If

        'Dim fName As TextObject
        'fName = TryCast(rpt.ReportDefinition.ReportObjects("Text2"), TextObject)
        'fName.Text = "Full Asset Report"
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.CrystalReportViewer1.ShowGroupTreeButton = False
        miscModule.LoadForm(ReportViewer, mdiMain)
        Exit Sub
er:
        MsgBox(Err.Description, vbCritical)
    End Sub
End Class
