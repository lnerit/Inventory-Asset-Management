<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Asset_NameLabel As System.Windows.Forms.Label
        Dim Asset_BrandLabel As System.Windows.Forms.Label
        Dim Asset_DescriptionLabel As System.Windows.Forms.Label
        Dim Asset_CategoryLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Age_in_YearsLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Room_LocationLabel As System.Windows.Forms.Label
        Dim Name_of_UserLabel As System.Windows.Forms.Label
        Dim Serial_Reg_NoLabel As System.Windows.Forms.Label
        Dim Model_Engine_NoLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim Funded_ByLabel As System.Windows.Forms.Label
        Dim Invoice_NoLabel As System.Windows.Forms.Label
        Dim Cheque_NoLabel As System.Windows.Forms.Label
        Dim Purchase_DateLabel As System.Windows.Forms.Label
        Dim Purchase_PriceLabel As System.Windows.Forms.Label
        Dim Depreciable_Life__in_years_Label As System.Windows.Forms.Label
        Dim Depreciable_Value__in___Label As System.Windows.Forms.Label
        Dim Next_Scheduled_MaintenanceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomePage))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mskNextScheduleDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskPurchaseDate = New System.Windows.Forms.MaskedTextBox()
        Me.Asset_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_BrandTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Age_in_YearsTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Room_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_UserTextBox = New System.Windows.Forms.TextBox()
        Me.Serial_Reg_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Model_Engine_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Funded_ByTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Cheque_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Depreciable_Life__in_years_TextBox = New System.Windows.Forms.TextBox()
        Me.Depreciable_Value__in___TextBox = New System.Windows.Forms.TextBox()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblDepreciationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.TblAssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Asset_NameLabel = New System.Windows.Forms.Label()
        Asset_BrandLabel = New System.Windows.Forms.Label()
        Asset_DescriptionLabel = New System.Windows.Forms.Label()
        Asset_CategoryLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Age_in_YearsLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Room_LocationLabel = New System.Windows.Forms.Label()
        Name_of_UserLabel = New System.Windows.Forms.Label()
        Serial_Reg_NoLabel = New System.Windows.Forms.Label()
        Model_Engine_NoLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        Funded_ByLabel = New System.Windows.Forms.Label()
        Invoice_NoLabel = New System.Windows.Forms.Label()
        Cheque_NoLabel = New System.Windows.Forms.Label()
        Purchase_DateLabel = New System.Windows.Forms.Label()
        Purchase_PriceLabel = New System.Windows.Forms.Label()
        Depreciable_Life__in_years_Label = New System.Windows.Forms.Label()
        Depreciable_Value__in___Label = New System.Windows.Forms.Label()
        Next_Scheduled_MaintenanceLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepreciationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Asset_NameLabel
        '
        Asset_NameLabel.AutoSize = True
        Asset_NameLabel.Location = New System.Drawing.Point(17, 10)
        Asset_NameLabel.Name = "Asset_NameLabel"
        Asset_NameLabel.Size = New System.Drawing.Size(67, 13)
        Asset_NameLabel.TabIndex = 2
        Asset_NameLabel.Text = "Asset Name:"
        '
        'Asset_BrandLabel
        '
        Asset_BrandLabel.AutoSize = True
        Asset_BrandLabel.Location = New System.Drawing.Point(17, 36)
        Asset_BrandLabel.Name = "Asset_BrandLabel"
        Asset_BrandLabel.Size = New System.Drawing.Size(67, 13)
        Asset_BrandLabel.TabIndex = 4
        Asset_BrandLabel.Text = "Asset Brand:"
        '
        'Asset_DescriptionLabel
        '
        Asset_DescriptionLabel.AutoSize = True
        Asset_DescriptionLabel.Location = New System.Drawing.Point(17, 62)
        Asset_DescriptionLabel.Name = "Asset_DescriptionLabel"
        Asset_DescriptionLabel.Size = New System.Drawing.Size(92, 13)
        Asset_DescriptionLabel.TabIndex = 6
        Asset_DescriptionLabel.Text = "Asset Description:"
        '
        'Asset_CategoryLabel
        '
        Asset_CategoryLabel.AutoSize = True
        Asset_CategoryLabel.Location = New System.Drawing.Point(17, 88)
        Asset_CategoryLabel.Name = "Asset_CategoryLabel"
        Asset_CategoryLabel.Size = New System.Drawing.Size(81, 13)
        Asset_CategoryLabel.TabIndex = 8
        Asset_CategoryLabel.Text = "Asset Category:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(17, 114)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Status:"
        '
        'Age_in_YearsLabel
        '
        Age_in_YearsLabel.AutoSize = True
        Age_in_YearsLabel.Location = New System.Drawing.Point(17, 140)
        Age_in_YearsLabel.Name = "Age_in_YearsLabel"
        Age_in_YearsLabel.Size = New System.Drawing.Size(70, 13)
        Age_in_YearsLabel.TabIndex = 12
        Age_in_YearsLabel.Text = "Age in Years:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(17, 166)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 14
        DepartmentLabel.Text = "Department:"
        '
        'Room_LocationLabel
        '
        Room_LocationLabel.AutoSize = True
        Room_LocationLabel.Location = New System.Drawing.Point(17, 192)
        Room_LocationLabel.Name = "Room_LocationLabel"
        Room_LocationLabel.Size = New System.Drawing.Size(82, 13)
        Room_LocationLabel.TabIndex = 16
        Room_LocationLabel.Text = "Room Location:"
        '
        'Name_of_UserLabel
        '
        Name_of_UserLabel.AutoSize = True
        Name_of_UserLabel.Location = New System.Drawing.Point(17, 218)
        Name_of_UserLabel.Name = "Name_of_UserLabel"
        Name_of_UserLabel.Size = New System.Drawing.Size(75, 13)
        Name_of_UserLabel.TabIndex = 18
        Name_of_UserLabel.Text = "Name of User:"
        '
        'Serial_Reg_NoLabel
        '
        Serial_Reg_NoLabel.AutoSize = True
        Serial_Reg_NoLabel.Location = New System.Drawing.Point(17, 244)
        Serial_Reg_NoLabel.Name = "Serial_Reg_NoLabel"
        Serial_Reg_NoLabel.Size = New System.Drawing.Size(78, 13)
        Serial_Reg_NoLabel.TabIndex = 20
        Serial_Reg_NoLabel.Text = "Serial/Reg No:"
        '
        'Model_Engine_NoLabel
        '
        Model_Engine_NoLabel.AutoSize = True
        Model_Engine_NoLabel.Location = New System.Drawing.Point(316, 6)
        Model_Engine_NoLabel.Name = "Model_Engine_NoLabel"
        Model_Engine_NoLabel.Size = New System.Drawing.Size(94, 13)
        Model_Engine_NoLabel.TabIndex = 22
        Model_Engine_NoLabel.Text = "Model/Engine No:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Location = New System.Drawing.Point(316, 32)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(79, 13)
        Supplier_NameLabel.TabIndex = 24
        Supplier_NameLabel.Text = "Supplier Name:"
        '
        'Funded_ByLabel
        '
        Funded_ByLabel.AutoSize = True
        Funded_ByLabel.Location = New System.Drawing.Point(316, 58)
        Funded_ByLabel.Name = "Funded_ByLabel"
        Funded_ByLabel.Size = New System.Drawing.Size(61, 13)
        Funded_ByLabel.TabIndex = 26
        Funded_ByLabel.Text = "Funded By:"
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Location = New System.Drawing.Point(316, 84)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(62, 13)
        Invoice_NoLabel.TabIndex = 28
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Cheque_NoLabel
        '
        Cheque_NoLabel.AutoSize = True
        Cheque_NoLabel.Location = New System.Drawing.Point(316, 110)
        Cheque_NoLabel.Name = "Cheque_NoLabel"
        Cheque_NoLabel.Size = New System.Drawing.Size(64, 13)
        Cheque_NoLabel.TabIndex = 30
        Cheque_NoLabel.Text = "Cheque No:"
        '
        'Purchase_DateLabel
        '
        Purchase_DateLabel.AutoSize = True
        Purchase_DateLabel.Location = New System.Drawing.Point(316, 137)
        Purchase_DateLabel.Name = "Purchase_DateLabel"
        Purchase_DateLabel.Size = New System.Drawing.Size(81, 13)
        Purchase_DateLabel.TabIndex = 32
        Purchase_DateLabel.Text = "Purchase Date:"
        '
        'Purchase_PriceLabel
        '
        Purchase_PriceLabel.AutoSize = True
        Purchase_PriceLabel.Location = New System.Drawing.Point(316, 162)
        Purchase_PriceLabel.Name = "Purchase_PriceLabel"
        Purchase_PriceLabel.Size = New System.Drawing.Size(82, 13)
        Purchase_PriceLabel.TabIndex = 34
        Purchase_PriceLabel.Text = "Purchase Price:"
        '
        'Depreciable_Life__in_years_Label
        '
        Depreciable_Life__in_years_Label.AutoSize = True
        Depreciable_Life__in_years_Label.Location = New System.Drawing.Point(316, 188)
        Depreciable_Life__in_years_Label.Name = "Depreciable_Life__in_years_Label"
        Depreciable_Life__in_years_Label.Size = New System.Drawing.Size(132, 13)
        Depreciable_Life__in_years_Label.TabIndex = 36
        Depreciable_Life__in_years_Label.Text = "Depreciable Life (in years):"
        '
        'Depreciable_Value__in___Label
        '
        Depreciable_Value__in___Label.AutoSize = True
        Depreciable_Value__in___Label.Location = New System.Drawing.Point(316, 214)
        Depreciable_Value__in___Label.Name = "Depreciable_Value__in___Label"
        Depreciable_Value__in___Label.Size = New System.Drawing.Size(125, 13)
        Depreciable_Value__in___Label.TabIndex = 38
        Depreciable_Value__in___Label.Text = "Depreciable Value (in %):"
        '
        'Next_Scheduled_MaintenanceLabel
        '
        Next_Scheduled_MaintenanceLabel.AutoSize = True
        Next_Scheduled_MaintenanceLabel.Location = New System.Drawing.Point(316, 241)
        Next_Scheduled_MaintenanceLabel.Name = "Next_Scheduled_MaintenanceLabel"
        Next_Scheduled_MaintenanceLabel.Size = New System.Drawing.Size(151, 13)
        Next_Scheduled_MaintenanceLabel.TabIndex = 40
        Next_Scheduled_MaintenanceLabel.Text = "Next Scheduled Maintenance:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.mskNextScheduleDate)
        Me.Panel2.Controls.Add(Me.mskPurchaseDate)
        Me.Panel2.Controls.Add(Asset_NameLabel)
        Me.Panel2.Controls.Add(Me.Asset_NameTextBox)
        Me.Panel2.Controls.Add(Asset_BrandLabel)
        Me.Panel2.Controls.Add(Me.Asset_BrandTextBox)
        Me.Panel2.Controls.Add(Asset_DescriptionLabel)
        Me.Panel2.Controls.Add(Me.Asset_DescriptionTextBox)
        Me.Panel2.Controls.Add(Asset_CategoryLabel)
        Me.Panel2.Controls.Add(Me.Asset_CategoryTextBox)
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Controls.Add(Me.StatusTextBox)
        Me.Panel2.Controls.Add(Age_in_YearsLabel)
        Me.Panel2.Controls.Add(Me.Age_in_YearsTextBox)
        Me.Panel2.Controls.Add(DepartmentLabel)
        Me.Panel2.Controls.Add(Me.DepartmentTextBox)
        Me.Panel2.Controls.Add(Room_LocationLabel)
        Me.Panel2.Controls.Add(Me.Room_LocationTextBox)
        Me.Panel2.Controls.Add(Name_of_UserLabel)
        Me.Panel2.Controls.Add(Me.Name_of_UserTextBox)
        Me.Panel2.Controls.Add(Serial_Reg_NoLabel)
        Me.Panel2.Controls.Add(Me.Serial_Reg_NoTextBox)
        Me.Panel2.Controls.Add(Model_Engine_NoLabel)
        Me.Panel2.Controls.Add(Me.Model_Engine_NoTextBox)
        Me.Panel2.Controls.Add(Supplier_NameLabel)
        Me.Panel2.Controls.Add(Me.Supplier_NameTextBox)
        Me.Panel2.Controls.Add(Funded_ByLabel)
        Me.Panel2.Controls.Add(Me.Funded_ByTextBox)
        Me.Panel2.Controls.Add(Invoice_NoLabel)
        Me.Panel2.Controls.Add(Me.Invoice_NoTextBox)
        Me.Panel2.Controls.Add(Cheque_NoLabel)
        Me.Panel2.Controls.Add(Me.Cheque_NoTextBox)
        Me.Panel2.Controls.Add(Purchase_DateLabel)
        Me.Panel2.Controls.Add(Purchase_PriceLabel)
        Me.Panel2.Controls.Add(Me.Purchase_PriceTextBox)
        Me.Panel2.Controls.Add(Depreciable_Life__in_years_Label)
        Me.Panel2.Controls.Add(Me.Depreciable_Life__in_years_TextBox)
        Me.Panel2.Controls.Add(Depreciable_Value__in___Label)
        Me.Panel2.Controls.Add(Me.Depreciable_Value__in___TextBox)
        Me.Panel2.Controls.Add(Next_Scheduled_MaintenanceLabel)
        Me.Panel2.Location = New System.Drawing.Point(5, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(683, 268)
        Me.Panel2.TabIndex = 1
        '
        'mskNextScheduleDate
        '
        Me.mskNextScheduleDate.Location = New System.Drawing.Point(473, 237)
        Me.mskNextScheduleDate.Mask = "00/00/0000"
        Me.mskNextScheduleDate.Name = "mskNextScheduleDate"
        Me.mskNextScheduleDate.Size = New System.Drawing.Size(197, 20)
        Me.mskNextScheduleDate.TabIndex = 43
        Me.mskNextScheduleDate.ValidatingType = GetType(Date)
        '
        'mskPurchaseDate
        '
        Me.mskPurchaseDate.Location = New System.Drawing.Point(475, 133)
        Me.mskPurchaseDate.Mask = "00/00/0000"
        Me.mskPurchaseDate.Name = "mskPurchaseDate"
        Me.mskPurchaseDate.Size = New System.Drawing.Size(197, 20)
        Me.mskPurchaseDate.TabIndex = 42
        Me.mskPurchaseDate.ValidatingType = GetType(Date)
        '
        'Asset_NameTextBox
        '
        Me.Asset_NameTextBox.Location = New System.Drawing.Point(110, 7)
        Me.Asset_NameTextBox.Name = "Asset_NameTextBox"
        Me.Asset_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_NameTextBox.TabIndex = 3
        '
        'Asset_BrandTextBox
        '
        Me.Asset_BrandTextBox.Location = New System.Drawing.Point(110, 33)
        Me.Asset_BrandTextBox.Name = "Asset_BrandTextBox"
        Me.Asset_BrandTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_BrandTextBox.TabIndex = 5
        '
        'Asset_DescriptionTextBox
        '
        Me.Asset_DescriptionTextBox.Location = New System.Drawing.Point(110, 59)
        Me.Asset_DescriptionTextBox.Name = "Asset_DescriptionTextBox"
        Me.Asset_DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_DescriptionTextBox.TabIndex = 7
        '
        'Asset_CategoryTextBox
        '
        Me.Asset_CategoryTextBox.Location = New System.Drawing.Point(110, 85)
        Me.Asset_CategoryTextBox.Name = "Asset_CategoryTextBox"
        Me.Asset_CategoryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_CategoryTextBox.TabIndex = 9
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(110, 111)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 11
        '
        'Age_in_YearsTextBox
        '
        Me.Age_in_YearsTextBox.Location = New System.Drawing.Point(110, 137)
        Me.Age_in_YearsTextBox.Name = "Age_in_YearsTextBox"
        Me.Age_in_YearsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Age_in_YearsTextBox.TabIndex = 13
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(110, 163)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartmentTextBox.TabIndex = 15
        '
        'Room_LocationTextBox
        '
        Me.Room_LocationTextBox.Location = New System.Drawing.Point(110, 189)
        Me.Room_LocationTextBox.Name = "Room_LocationTextBox"
        Me.Room_LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Room_LocationTextBox.TabIndex = 17
        '
        'Name_of_UserTextBox
        '
        Me.Name_of_UserTextBox.Location = New System.Drawing.Point(110, 215)
        Me.Name_of_UserTextBox.Name = "Name_of_UserTextBox"
        Me.Name_of_UserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_of_UserTextBox.TabIndex = 19
        '
        'Serial_Reg_NoTextBox
        '
        Me.Serial_Reg_NoTextBox.Location = New System.Drawing.Point(110, 241)
        Me.Serial_Reg_NoTextBox.Name = "Serial_Reg_NoTextBox"
        Me.Serial_Reg_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Serial_Reg_NoTextBox.TabIndex = 21
        '
        'Model_Engine_NoTextBox
        '
        Me.Model_Engine_NoTextBox.Location = New System.Drawing.Point(473, 3)
        Me.Model_Engine_NoTextBox.Name = "Model_Engine_NoTextBox"
        Me.Model_Engine_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Model_Engine_NoTextBox.TabIndex = 23
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(473, 29)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Supplier_NameTextBox.TabIndex = 25
        '
        'Funded_ByTextBox
        '
        Me.Funded_ByTextBox.Location = New System.Drawing.Point(473, 55)
        Me.Funded_ByTextBox.Name = "Funded_ByTextBox"
        Me.Funded_ByTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Funded_ByTextBox.TabIndex = 27
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(473, 81)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Invoice_NoTextBox.TabIndex = 29
        '
        'Cheque_NoTextBox
        '
        Me.Cheque_NoTextBox.Location = New System.Drawing.Point(473, 107)
        Me.Cheque_NoTextBox.Name = "Cheque_NoTextBox"
        Me.Cheque_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cheque_NoTextBox.TabIndex = 31
        '
        'Purchase_PriceTextBox
        '
        Me.Purchase_PriceTextBox.Location = New System.Drawing.Point(473, 159)
        Me.Purchase_PriceTextBox.Name = "Purchase_PriceTextBox"
        Me.Purchase_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Purchase_PriceTextBox.TabIndex = 35
        '
        'Depreciable_Life__in_years_TextBox
        '
        Me.Depreciable_Life__in_years_TextBox.Location = New System.Drawing.Point(473, 185)
        Me.Depreciable_Life__in_years_TextBox.Name = "Depreciable_Life__in_years_TextBox"
        Me.Depreciable_Life__in_years_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depreciable_Life__in_years_TextBox.TabIndex = 37
        '
        'Depreciable_Value__in___TextBox
        '
        Me.Depreciable_Value__in___TextBox.Location = New System.Drawing.Point(473, 211)
        Me.Depreciable_Value__in___TextBox.Name = "Depreciable_Value__in___TextBox"
        Me.Depreciable_Value__in___TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depreciable_Value__in___TextBox.TabIndex = 39
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(281, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(105, 18)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Home Page"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Location = New System.Drawing.Point(5, 304)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(683, 193)
        Me.Panel3.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(671, 172)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(663, 146)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Maintenance"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(651, 137)
        Me.DataGridView1.TabIndex = 0
        '
        'TblDepreciationBindingSource
        '
        Me.TblDepreciationBindingSource.DataMember = "tblDepreciation"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(600, 503)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(70, 28)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(524, 503)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(70, 28)
        Me.cmdFind.TabIndex = 6
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(426, 503)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(70, 28)
        Me.cmdPreview.TabIndex = 7
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(663, 146)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Depreciation"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(651, 137)
        Me.DataGridView2.TabIndex = 1
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(695, 535)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepreciationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents TblAssetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Asset_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age_in_YearsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Serial_Reg_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Model_Engine_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Funded_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoice_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cheque_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purchase_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Depreciable_Life__in_years_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Depreciable_Value__in___TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MaintenanceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaintenanceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialRegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaintenanceDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaintenanceCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TblDepreciationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepreciationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepreciationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialRegNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepreciationAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents mskNextScheduleDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskPurchaseDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdPreview As System.Windows.Forms.Button

End Class
