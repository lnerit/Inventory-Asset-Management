Imports System.Data.OleDb
Public Class frmSetupAssetRecords
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim dbConn As New dbConnectionClass
    Dim sql As String

    Private Sub BackToHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmHomePage.Show()
    End Sub

    Private Sub frmSetupAssetRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''myConnection.ConnectionString = dbConn.dbConnectionString
        'myConnection.Open()
        'myConnection.
        sql = "SELECT * FROM tblAsset"
        PopulateDataGridView(DataGridView1, sql)
        Dim c As Control
        For Each c In Panel2.Controls
            If (TypeOf c Is TextBox) Then
                Dim txt As TextBox = TryCast(c, TextBox)
                c.Enabled = False
            End If

            If (TypeOf c Is ComboBox) Then
                Dim txt As ComboBox = TryCast(c, ComboBox)
                c.Enabled = False
            End If
            If (TypeOf c Is MaskedTextBox) Then
                Dim txt As MaskedTextBox = TryCast(c, MaskedTextBox)
                c.Enabled = False
            End If
        Next
        Me.btnADD.Enabled = False
        Me.btnDELETE.Enabled = False
        Me.btnEDIT.Enabled = False
        Me.btnUPDATE.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error GoTo 0
        If (DataGridView1.RowCount > 0) Then
            Dim dv As DataGridViewRow
            For Each dv In DataGridView1.Rows
                If (dv.Selected = True) Then
                    'If (dv.Cells(0).Value <> DBNull.Value) Then
                    Me.Asset_NameTextBox.Text = dv.Cells(0).Value
                    Me.Asset_BrandTextBox.Text = IIf(IsDBNull(dv.Cells(1).Value), "", dv.Cells(1).Value)
                    Me.Asset_DescriptionTextBox.Text = IIf(IsDBNull(dv.Cells(2).Value), "", dv.Cells(2).Value)
                    Me.txtCategory.Text = IIf(IsDBNull(dv.Cells(3).Value), "", dv.Cells(3).Value)
                    Me.StatusTextBox.Text = IIf(IsDBNull(dv.Cells(4).Value), "", dv.Cells(4).Value)
                    Me.Age_in_YearsTextBox.Text = IIf(IsDBNull(dv.Cells(5).Value), "", dv.Cells(5).Value)
                    Me.DepartmentTextBox.Text = IIf(IsDBNull(dv.Cells(6).Value), "", dv.Cells(6).Value)
                    Me.Room_LocationTextBox.Text = IIf(IsDBNull(dv.Cells(7).Value), "", dv.Cells(7).Value)
                    Me.Name_of_UserTextBox.Text = IIf(IsDBNull(dv.Cells(8).Value), "", dv.Cells(8).Value)
                    Me.Serial_Reg_NoTextBox.Text = IIf(IsDBNull(dv.Cells(9).Value), "", dv.Cells(9).Value)
                    Me.Model_Engine_NoTextBox.Text = IIf(IsDBNull(dv.Cells(10).Value), "", dv.Cells(10).Value)
                    Me.Supplier_NameTextBox.Text = IIf(IsDBNull(dv.Cells(11).Value), "", dv.Cells(11).Value)
                    Me.Funded_ByTextBox.Text = IIf(IsDBNull(dv.Cells(12).Value), "", dv.Cells(12).Value)
                    Me.Invoice_NoTextBox.Text = IIf(IsDBNull(dv.Cells(13).Value), "", dv.Cells(13).Value)
                    Me.Cheque_NoTextBox.Text = IIf(IsDBNull(dv.Cells(14).Value), "", dv.Cells(14).Value)
                    Me.mskPurchaseDate.Text = IIf(IsDBNull(dv.Cells(15).Value), "", dv.Cells(15).Value)
                    Me.Purchase_PriceTextBox.Text = IIf(IsDBNull(dv.Cells(16).Value), "", dv.Cells(16).Value)
                    Me.Depreciable_Life__in_years_TextBox.Text = IIf(IsDBNull(dv.Cells(17).Value), "0", dv.Cells(17).Value)
                    Me.Depreciable_Value__in___TextBox.Text = IIf(IsDBNull(dv.Cells(18).Value), "0", dv.Cells(18).Value)
                    Me.mskNextSchedule.Text = IIf(IsDBNull(dv.Cells(19).Value), "", dv.Cells(19).Value)
                    Me.btnEDIT.Enabled = True
                    Me.btnDELETE.Enabled = True
                    cmdClear.Enabled = True
                    Exit For
                    'End If
                End If
            Next
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT * FROM tblAsset WHERE [Asset Name] LIKE '%" + txtSearch.Text + "%' OR  [Asset Brand] LIKE '%" + txtSearch.Text + "%' OR  [Asset Description] LIKE '%" + txtSearch.Text + "%' OR  [Asset Category] LIKE '%" + txtSearch.Text + "%' OR  [Status] LIKE '%" + txtSearch.Text + "%' OR  [Department] LIKE '%" + txtSearch.Text + "%' OR  [Room Location] LIKE '%" + txtSearch.Text + "%' OR  [Name of User] LIKE '%" + txtSearch.Text + "%' OR  [Serial/Reg No] LIKE '%" + txtSearch.Text + "%' OR  [Model/Engine No] LIKE '%" + txtSearch.Text + "%' OR  [Supplier Name] LIKE '%" + txtSearch.Text + "%' OR  [Purchase Date] LIKE '%" + txtSearch.Text + "%'"
        PopulateDataGridView(DataGridView1, sql)
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim Response As VariantType
        Response = MsgBox("Are you sure you want to save the record?", MsgBoxStyle.YesNo, "New Record Entry")
        If (Response = vbYes) Then
            sql = "INSERT INTO tblAsset VALUES('" + Me.Asset_NameTextBox.Text + "'," _
                    + "'" + Me.Asset_BrandTextBox.Text + "'," _
                    + "'" + Me.Asset_DescriptionTextBox.Text + "'," _
                    + "'" + Me.txtCategory.Text + "'," _
                    + "'" + Me.StatusTextBox.Text + "'," _
                    + "" + Me.Age_in_YearsTextBox.Text + "," _
                    + "'" + Me.DepartmentTextBox.Text + "'," _
                    + "'" + Me.Room_LocationTextBox.Text + "'," _
                    + "'" + Me.Name_of_UserTextBox.Text + "'," _
                    + "'" + Me.Serial_Reg_NoTextBox.Text + "'," _
                    + "'" + Me.Model_Engine_NoTextBox.Text + "'," _
                    + "'" + Me.Supplier_NameTextBox.Text + "'," _
                    + "'" + Me.Funded_ByTextBox.Text + "'," _
                    + "'" + Me.Invoice_NoTextBox.Text + "'," _
                    + "'" + Me.Cheque_NoTextBox.Text + "'," _
                    + "'" + CDate(Me.mskPurchaseDate.Text) + "'," _
                    + "'" + Me.Purchase_PriceTextBox.Text + "'," _
                    + "" + Me.Depreciable_Life__in_years_TextBox.Text + "," _
                    + "'" + Me.Depreciable_Value__in___TextBox.Text + "'," _
                    + "'" + CDate(Me.mskNextSchedule.Text) + "'" _
                    + ")"
            ExecuteNonQuery(sql)
            Call frmSetupAssetRecords_Load(sender, e)
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Dim c As Control
        For Each c In Panel2.Controls
            If (TypeOf c Is TextBox) Then
                Dim txt As TextBox = TryCast(c, TextBox)
                c.Text = ""
                c.Enabled = True
            End If

            If (TypeOf c Is ComboBox) Then
                Dim txt As ComboBox = TryCast(c, ComboBox)
                c.Text = ""
                c.Enabled = True
            End If
            If (TypeOf c Is MaskedTextBox) Then
                Dim txt As MaskedTextBox = TryCast(c, MaskedTextBox)
                c.Text = ""
                c.Enabled = True
            End If
        Next
        btnADD.Enabled = True
        btnDELETE.Enabled = False
        btnEDIT.Enabled = True
        btnUPDATE.Enabled = False
        DataGridView1.Enabled = False
        cmdClear.Enabled = False
        sql = "SELECT [Asset Category] FROM tblCategory"
        DepartmentTextBox.Items.Clear()
        txtCategory.Items.Clear()
        LoadDataToControl(txtCategory, sql)

        sql = "SELECT Department FROM tblDepartment"
        LoadDataToControl(DepartmentTextBox, sql)

        sql = "SELECT [Supplier Name] FROM tblSupplier"
        LoadDataToControl(Supplier_NameTextBox, sql)

        'sql = "SELECT Status FROM tblStatus"
        StatusTextBox.Items.Clear()
        StatusTextBox.Items.Add("Brand New")
        StatusTextBox.Items.Add("Disposed")
        StatusTextBox.Items.Add("Out of Service")
        StatusTextBox.Items.Add("Under maintenance")
        StatusTextBox.Items.Add("Working")
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Dim c As Control
        For Each c In Panel2.Controls
            If (TypeOf c Is TextBox) Then
                Dim txt As TextBox = TryCast(c, TextBox)
                c.Enabled = True
            End If

            If (TypeOf c Is ComboBox) Then
                Dim txt As ComboBox = TryCast(c, ComboBox)
                c.Enabled = True
            End If
            If (TypeOf c Is MaskedTextBox) Then
                Dim txt As MaskedTextBox = TryCast(c, MaskedTextBox)
                c.Enabled = True
            End If
        Next
        btnADD.Enabled = False
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = True
        btnEDIT.Enabled = False
        DataGridView1.Enabled = False
        cmdClear.Enabled = False
    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        Dim Response As Object
        Response = MsgBox("Are you sure you want to update the record?", MsgBoxStyle.YesNo, "Update Record ")
        If (Response = vbYes) Then
            Dim sqlx As String
            sqlx = "UPDATE tblAsset SET [Asset Name]='" + Asset_NameTextBox.Text + "'," +
                " [Asset Brand]='" + Asset_BrandTextBox.Text + "'," +
                " [Asset Description]='" + Asset_DescriptionTextBox.Text + "'," +
                " [Asset Category]='" + txtCategory.Text + "'," +
                " Status='" + StatusTextBox.Text + "'," +
                " [Age in years]=" & Age_in_YearsTextBox.Text & "," +
                " Department='" + DepartmentTextBox.Text + "'," +
                " [Room Location]='" + Room_LocationTextBox.Text + "'," +
                "[Name of User]='" + Name_of_UserTextBox.Text + "'," +
                " [Model/Engine No]='" + Model_Engine_NoTextBox.Text + "'," +
                " [Supplier Name]='" + Supplier_NameTextBox.Text + "'," +
                " [Funded By]='" + Funded_ByTextBox.Text + "'," +
                " [Invoice No]='" + Invoice_NoTextBox.Text + "'," +
                " [Cheque No]='" + Cheque_NoTextBox.Text + "'," +
                " [Purchase Date]='" + mskPurchaseDate.Text + "'," +
                " [Purchase Price]='" + Purchase_PriceTextBox.Text + "'," +
                " [Depreciable Life (in years)]=" & Depreciable_Life__in_years_TextBox.Text & "," +
                " [Depreciable Value (in %)]=" & Depreciable_Value__in___TextBox.Text & "," +
                " [Next Scheduled Maintenance]='" + mskNextSchedule.Text + "'" +
                " WHERE  [Serial/Reg No]='" + Serial_Reg_NoTextBox.Text + "'"

            ExecuteNonQuery(sqlx)
            Call frmSetupAssetRecords_Load(sender, e)
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        If (Serial_Reg_NoTextBox.Text = "") Then
            MsgBox("Please select a record from the grid to delete", MsgBoxStyle.OkOnly, "Error Deleting record")
            Exit Sub
        End If
        Dim Response As VariantType
        Response = MsgBox("Are you sure you want to delete the record?", MsgBoxStyle.YesNo, "Delete Record ")
        If (Response = vbYes) Then
            sql = "DELETE FROM tblAsset WHERE [Serial/Reg No]='" + Serial_Reg_NoTextBox.Text + "'"
            ExecuteNonQuery(sql)
            Call frmSetupAssetRecords_Load(sender, e)
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub DepartmentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DepartmentTextBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub DepartmentTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentTextBox.SelectedIndexChanged

    End Sub

    Private Sub Supplier_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Supplier_NameTextBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub Supplier_NameTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Supplier_NameTextBox.SelectedIndexChanged

    End Sub

    Private Sub StatusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StatusTextBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub StatusTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusTextBox.SelectedIndexChanged

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
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
            If (TypeOf c Is MaskedTextBox) Then
                Dim txt As MaskedTextBox = TryCast(c, MaskedTextBox)
                c.Text = ""
                c.Enabled = False
            End If
        Next
        btnADD.Enabled = False
        btnDELETE.Enabled = False
        btnUPDATE.Enabled = False
        btnEDIT.Enabled = False
        cmdClear.Enabled = False
        DataGridView1.Enabled = True

    End Sub



    Private Sub Purchase_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Purchase_DateDateTimePicker.ValueChanged
        mskPurchaseDate.Text = Purchase_DateDateTimePicker.Value.ToShortDateString()
    End Sub

    Private Sub Next_Scheduled_MaintenanceDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Next_Scheduled_MaintenanceDateTimePicker.ValueChanged
        mskNextSchedule.Text = Next_Scheduled_MaintenanceDateTimePicker.Value.ToShortDateString()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class