<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupAssetRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupAssetRecords))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Supplier_NameTextBox = New System.Windows.Forms.ComboBox()
        Me.StatusTextBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentTextBox = New System.Windows.Forms.ComboBox()
        Me.mskNextSchedule = New System.Windows.Forms.MaskedTextBox()
        Me.mskPurchaseDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.Asset_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_BrandTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Age_in_YearsTextBox = New System.Windows.Forms.TextBox()
        Me.Room_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_UserTextBox = New System.Windows.Forms.TextBox()
        Me.Serial_Reg_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Model_Engine_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Funded_ByTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Cheque_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Purchase_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Depreciable_Life__in_years_TextBox = New System.Windows.Forms.TextBox()
        Me.Depreciable_Value__in___TextBox = New System.Windows.Forms.TextBox()
        Me.Next_Scheduled_MaintenanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Asset_NameLabel
        '
        Asset_NameLabel.AutoSize = True
        Asset_NameLabel.Location = New System.Drawing.Point(7, 9)
        Asset_NameLabel.Name = "Asset_NameLabel"
        Asset_NameLabel.Size = New System.Drawing.Size(67, 13)
        Asset_NameLabel.TabIndex = 10
        Asset_NameLabel.Text = "Asset Name:"
        '
        'Asset_BrandLabel
        '
        Asset_BrandLabel.AutoSize = True
        Asset_BrandLabel.Location = New System.Drawing.Point(7, 35)
        Asset_BrandLabel.Name = "Asset_BrandLabel"
        Asset_BrandLabel.Size = New System.Drawing.Size(67, 13)
        Asset_BrandLabel.TabIndex = 12
        Asset_BrandLabel.Text = "Asset Brand:"
        '
        'Asset_DescriptionLabel
        '
        Asset_DescriptionLabel.AutoSize = True
        Asset_DescriptionLabel.Location = New System.Drawing.Point(7, 61)
        Asset_DescriptionLabel.Name = "Asset_DescriptionLabel"
        Asset_DescriptionLabel.Size = New System.Drawing.Size(92, 13)
        Asset_DescriptionLabel.TabIndex = 14
        Asset_DescriptionLabel.Text = "Asset Description:"
        '
        'Asset_CategoryLabel
        '
        Asset_CategoryLabel.AutoSize = True
        Asset_CategoryLabel.Location = New System.Drawing.Point(7, 87)
        Asset_CategoryLabel.Name = "Asset_CategoryLabel"
        Asset_CategoryLabel.Size = New System.Drawing.Size(81, 13)
        Asset_CategoryLabel.TabIndex = 16
        Asset_CategoryLabel.Text = "Asset Category:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(7, 113)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "Status:"
        '
        'Age_in_YearsLabel
        '
        Age_in_YearsLabel.AutoSize = True
        Age_in_YearsLabel.Location = New System.Drawing.Point(7, 139)
        Age_in_YearsLabel.Name = "Age_in_YearsLabel"
        Age_in_YearsLabel.Size = New System.Drawing.Size(70, 13)
        Age_in_YearsLabel.TabIndex = 20
        Age_in_YearsLabel.Text = "Age in Years:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(7, 165)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 22
        DepartmentLabel.Text = "Department:"
        '
        'Room_LocationLabel
        '
        Room_LocationLabel.AutoSize = True
        Room_LocationLabel.Location = New System.Drawing.Point(7, 191)
        Room_LocationLabel.Name = "Room_LocationLabel"
        Room_LocationLabel.Size = New System.Drawing.Size(82, 13)
        Room_LocationLabel.TabIndex = 24
        Room_LocationLabel.Text = "Room Location:"
        '
        'Name_of_UserLabel
        '
        Name_of_UserLabel.AutoSize = True
        Name_of_UserLabel.Location = New System.Drawing.Point(7, 217)
        Name_of_UserLabel.Name = "Name_of_UserLabel"
        Name_of_UserLabel.Size = New System.Drawing.Size(75, 13)
        Name_of_UserLabel.TabIndex = 26
        Name_of_UserLabel.Text = "Name of User:"
        '
        'Serial_Reg_NoLabel
        '
        Serial_Reg_NoLabel.AutoSize = True
        Serial_Reg_NoLabel.Location = New System.Drawing.Point(7, 243)
        Serial_Reg_NoLabel.Name = "Serial_Reg_NoLabel"
        Serial_Reg_NoLabel.Size = New System.Drawing.Size(78, 13)
        Serial_Reg_NoLabel.TabIndex = 28
        Serial_Reg_NoLabel.Text = "Serial/Reg No:"
        '
        'Model_Engine_NoLabel
        '
        Model_Engine_NoLabel.AutoSize = True
        Model_Engine_NoLabel.Location = New System.Drawing.Point(335, 9)
        Model_Engine_NoLabel.Name = "Model_Engine_NoLabel"
        Model_Engine_NoLabel.Size = New System.Drawing.Size(94, 13)
        Model_Engine_NoLabel.TabIndex = 30
        Model_Engine_NoLabel.Text = "Model/Engine No:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Location = New System.Drawing.Point(338, 37)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(79, 13)
        Supplier_NameLabel.TabIndex = 32
        Supplier_NameLabel.Text = "Supplier Name:"
        '
        'Funded_ByLabel
        '
        Funded_ByLabel.AutoSize = True
        Funded_ByLabel.Location = New System.Drawing.Point(335, 61)
        Funded_ByLabel.Name = "Funded_ByLabel"
        Funded_ByLabel.Size = New System.Drawing.Size(61, 13)
        Funded_ByLabel.TabIndex = 34
        Funded_ByLabel.Text = "Funded By:"
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Location = New System.Drawing.Point(335, 87)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(62, 13)
        Invoice_NoLabel.TabIndex = 36
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Cheque_NoLabel
        '
        Cheque_NoLabel.AutoSize = True
        Cheque_NoLabel.Location = New System.Drawing.Point(335, 113)
        Cheque_NoLabel.Name = "Cheque_NoLabel"
        Cheque_NoLabel.Size = New System.Drawing.Size(64, 13)
        Cheque_NoLabel.TabIndex = 38
        Cheque_NoLabel.Text = "Cheque No:"
        '
        'Purchase_DateLabel
        '
        Purchase_DateLabel.AutoSize = True
        Purchase_DateLabel.Location = New System.Drawing.Point(335, 140)
        Purchase_DateLabel.Name = "Purchase_DateLabel"
        Purchase_DateLabel.Size = New System.Drawing.Size(81, 13)
        Purchase_DateLabel.TabIndex = 40
        Purchase_DateLabel.Text = "Purchase Date:"
        '
        'Purchase_PriceLabel
        '
        Purchase_PriceLabel.AutoSize = True
        Purchase_PriceLabel.Location = New System.Drawing.Point(335, 165)
        Purchase_PriceLabel.Name = "Purchase_PriceLabel"
        Purchase_PriceLabel.Size = New System.Drawing.Size(82, 13)
        Purchase_PriceLabel.TabIndex = 42
        Purchase_PriceLabel.Text = "Purchase Price:"
        '
        'Depreciable_Life__in_years_Label
        '
        Depreciable_Life__in_years_Label.AutoSize = True
        Depreciable_Life__in_years_Label.Location = New System.Drawing.Point(335, 191)
        Depreciable_Life__in_years_Label.Name = "Depreciable_Life__in_years_Label"
        Depreciable_Life__in_years_Label.Size = New System.Drawing.Size(132, 13)
        Depreciable_Life__in_years_Label.TabIndex = 44
        Depreciable_Life__in_years_Label.Text = "Depreciable Life (in years):"
        '
        'Depreciable_Value__in___Label
        '
        Depreciable_Value__in___Label.AutoSize = True
        Depreciable_Value__in___Label.Location = New System.Drawing.Point(335, 217)
        Depreciable_Value__in___Label.Name = "Depreciable_Value__in___Label"
        Depreciable_Value__in___Label.Size = New System.Drawing.Size(125, 13)
        Depreciable_Value__in___Label.TabIndex = 46
        Depreciable_Value__in___Label.Text = "Depreciable Value (in %):"
        '
        'Next_Scheduled_MaintenanceLabel
        '
        Next_Scheduled_MaintenanceLabel.AutoSize = True
        Next_Scheduled_MaintenanceLabel.Location = New System.Drawing.Point(335, 244)
        Next_Scheduled_MaintenanceLabel.Name = "Next_Scheduled_MaintenanceLabel"
        Next_Scheduled_MaintenanceLabel.Size = New System.Drawing.Size(151, 13)
        Next_Scheduled_MaintenanceLabel.TabIndex = 48
        Next_Scheduled_MaintenanceLabel.Text = "Next Scheduled Maintenance:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Supplier_NameTextBox)
        Me.Panel2.Controls.Add(Me.StatusTextBox)
        Me.Panel2.Controls.Add(Me.DepartmentTextBox)
        Me.Panel2.Controls.Add(Me.mskNextSchedule)
        Me.Panel2.Controls.Add(Me.mskPurchaseDate)
        Me.Panel2.Controls.Add(Me.txtCategory)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Asset_NameLabel)
        Me.Panel2.Controls.Add(Me.Asset_NameTextBox)
        Me.Panel2.Controls.Add(Asset_BrandLabel)
        Me.Panel2.Controls.Add(Me.Asset_BrandTextBox)
        Me.Panel2.Controls.Add(Asset_DescriptionLabel)
        Me.Panel2.Controls.Add(Me.Asset_DescriptionTextBox)
        Me.Panel2.Controls.Add(Asset_CategoryLabel)
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Controls.Add(Age_in_YearsLabel)
        Me.Panel2.Controls.Add(Me.Age_in_YearsTextBox)
        Me.Panel2.Controls.Add(DepartmentLabel)
        Me.Panel2.Controls.Add(Room_LocationLabel)
        Me.Panel2.Controls.Add(Me.Room_LocationTextBox)
        Me.Panel2.Controls.Add(Name_of_UserLabel)
        Me.Panel2.Controls.Add(Me.Name_of_UserTextBox)
        Me.Panel2.Controls.Add(Serial_Reg_NoLabel)
        Me.Panel2.Controls.Add(Me.Serial_Reg_NoTextBox)
        Me.Panel2.Controls.Add(Model_Engine_NoLabel)
        Me.Panel2.Controls.Add(Me.Model_Engine_NoTextBox)
        Me.Panel2.Controls.Add(Supplier_NameLabel)
        Me.Panel2.Controls.Add(Funded_ByLabel)
        Me.Panel2.Controls.Add(Me.Funded_ByTextBox)
        Me.Panel2.Controls.Add(Invoice_NoLabel)
        Me.Panel2.Controls.Add(Me.Invoice_NoTextBox)
        Me.Panel2.Controls.Add(Cheque_NoLabel)
        Me.Panel2.Controls.Add(Me.Cheque_NoTextBox)
        Me.Panel2.Controls.Add(Purchase_DateLabel)
        Me.Panel2.Controls.Add(Me.Purchase_DateDateTimePicker)
        Me.Panel2.Controls.Add(Purchase_PriceLabel)
        Me.Panel2.Controls.Add(Me.Purchase_PriceTextBox)
        Me.Panel2.Controls.Add(Depreciable_Life__in_years_Label)
        Me.Panel2.Controls.Add(Me.Depreciable_Life__in_years_TextBox)
        Me.Panel2.Controls.Add(Depreciable_Value__in___Label)
        Me.Panel2.Controls.Add(Me.Depreciable_Value__in___TextBox)
        Me.Panel2.Controls.Add(Next_Scheduled_MaintenanceLabel)
        Me.Panel2.Controls.Add(Me.Next_Scheduled_MaintenanceDateTimePicker)
        Me.Panel2.Location = New System.Drawing.Point(12, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1244, 269)
        Me.Panel2.TabIndex = 1
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.FormattingEnabled = True
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(494, 29)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(197, 21)
        Me.Supplier_NameTextBox.TabIndex = 57
        '
        'StatusTextBox
        '
        Me.StatusTextBox.FormattingEnabled = True
        Me.StatusTextBox.Location = New System.Drawing.Point(119, 108)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(197, 21)
        Me.StatusTextBox.TabIndex = 56
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.FormattingEnabled = True
        Me.DepartmentTextBox.Location = New System.Drawing.Point(118, 162)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(199, 21)
        Me.DepartmentTextBox.TabIndex = 55
        '
        'mskNextSchedule
        '
        Me.mskNextSchedule.Location = New System.Drawing.Point(492, 241)
        Me.mskNextSchedule.Mask = "00/00/0000"
        Me.mskNextSchedule.Name = "mskNextSchedule"
        Me.mskNextSchedule.Size = New System.Drawing.Size(93, 20)
        Me.mskNextSchedule.TabIndex = 54
        Me.mskNextSchedule.ValidatingType = GetType(Date)
        '
        'mskPurchaseDate
        '
        Me.mskPurchaseDate.Location = New System.Drawing.Point(497, 135)
        Me.mskPurchaseDate.Mask = "00/00/0000"
        Me.mskPurchaseDate.Name = "mskPurchaseDate"
        Me.mskPurchaseDate.Size = New System.Drawing.Size(93, 20)
        Me.mskPurchaseDate.TabIndex = 53
        Me.mskPurchaseDate.ValidatingType = GetType(Date)
        '
        'txtCategory
        '
        Me.txtCategory.DisplayMember = "Asset Category"
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(118, 83)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 21)
        Me.txtCategory.TabIndex = 52
        Me.txtCategory.ValueMember = "Asset Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdClear)
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnEDIT)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(706, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 103)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup Task"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(244, 58)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(71, 24)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(10, 25)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(183, 23)
        Me.cmdClear.TabIndex = 11
        Me.cmdClear.Text = "CLEAR FIELDS"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(199, 25)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(116, 23)
        Me.btnADD.TabIndex = 6
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(10, 60)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(71, 23)
        Me.btnEDIT.TabIndex = 10
        Me.btnEDIT.Text = "EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(158, 60)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(80, 23)
        Me.btnDELETE.TabIndex = 7
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(87, 60)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'Asset_NameTextBox
        '
        Me.Asset_NameTextBox.Location = New System.Drawing.Point(118, 6)
        Me.Asset_NameTextBox.Name = "Asset_NameTextBox"
        Me.Asset_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_NameTextBox.TabIndex = 11
        '
        'Asset_BrandTextBox
        '
        Me.Asset_BrandTextBox.Location = New System.Drawing.Point(118, 32)
        Me.Asset_BrandTextBox.Name = "Asset_BrandTextBox"
        Me.Asset_BrandTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_BrandTextBox.TabIndex = 13
        '
        'Asset_DescriptionTextBox
        '
        Me.Asset_DescriptionTextBox.Location = New System.Drawing.Point(118, 58)
        Me.Asset_DescriptionTextBox.Name = "Asset_DescriptionTextBox"
        Me.Asset_DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Asset_DescriptionTextBox.TabIndex = 15
        '
        'Age_in_YearsTextBox
        '
        Me.Age_in_YearsTextBox.Location = New System.Drawing.Point(118, 136)
        Me.Age_in_YearsTextBox.Name = "Age_in_YearsTextBox"
        Me.Age_in_YearsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Age_in_YearsTextBox.TabIndex = 21
        '
        'Room_LocationTextBox
        '
        Me.Room_LocationTextBox.Location = New System.Drawing.Point(118, 188)
        Me.Room_LocationTextBox.Name = "Room_LocationTextBox"
        Me.Room_LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Room_LocationTextBox.TabIndex = 25
        '
        'Name_of_UserTextBox
        '
        Me.Name_of_UserTextBox.Location = New System.Drawing.Point(118, 214)
        Me.Name_of_UserTextBox.Name = "Name_of_UserTextBox"
        Me.Name_of_UserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_of_UserTextBox.TabIndex = 27
        '
        'Serial_Reg_NoTextBox
        '
        Me.Serial_Reg_NoTextBox.Location = New System.Drawing.Point(118, 240)
        Me.Serial_Reg_NoTextBox.Name = "Serial_Reg_NoTextBox"
        Me.Serial_Reg_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Serial_Reg_NoTextBox.TabIndex = 29
        '
        'Model_Engine_NoTextBox
        '
        Me.Model_Engine_NoTextBox.Location = New System.Drawing.Point(492, 6)
        Me.Model_Engine_NoTextBox.Name = "Model_Engine_NoTextBox"
        Me.Model_Engine_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Model_Engine_NoTextBox.TabIndex = 31
        '
        'Funded_ByTextBox
        '
        Me.Funded_ByTextBox.Location = New System.Drawing.Point(492, 58)
        Me.Funded_ByTextBox.Name = "Funded_ByTextBox"
        Me.Funded_ByTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Funded_ByTextBox.TabIndex = 35
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(492, 84)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Invoice_NoTextBox.TabIndex = 37
        '
        'Cheque_NoTextBox
        '
        Me.Cheque_NoTextBox.Location = New System.Drawing.Point(492, 110)
        Me.Cheque_NoTextBox.Name = "Cheque_NoTextBox"
        Me.Cheque_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cheque_NoTextBox.TabIndex = 39
        '
        'Purchase_DateDateTimePicker
        '
        Me.Purchase_DateDateTimePicker.Location = New System.Drawing.Point(602, 136)
        Me.Purchase_DateDateTimePicker.Name = "Purchase_DateDateTimePicker"
        Me.Purchase_DateDateTimePicker.Size = New System.Drawing.Size(90, 20)
        Me.Purchase_DateDateTimePicker.TabIndex = 41
        '
        'Purchase_PriceTextBox
        '
        Me.Purchase_PriceTextBox.Location = New System.Drawing.Point(492, 162)
        Me.Purchase_PriceTextBox.Name = "Purchase_PriceTextBox"
        Me.Purchase_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Purchase_PriceTextBox.TabIndex = 43
        '
        'Depreciable_Life__in_years_TextBox
        '
        Me.Depreciable_Life__in_years_TextBox.Location = New System.Drawing.Point(492, 188)
        Me.Depreciable_Life__in_years_TextBox.Name = "Depreciable_Life__in_years_TextBox"
        Me.Depreciable_Life__in_years_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depreciable_Life__in_years_TextBox.TabIndex = 45
        '
        'Depreciable_Value__in___TextBox
        '
        Me.Depreciable_Value__in___TextBox.Location = New System.Drawing.Point(492, 214)
        Me.Depreciable_Value__in___TextBox.Name = "Depreciable_Value__in___TextBox"
        Me.Depreciable_Value__in___TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depreciable_Value__in___TextBox.TabIndex = 47
        '
        'Next_Scheduled_MaintenanceDateTimePicker
        '
        Me.Next_Scheduled_MaintenanceDateTimePicker.Location = New System.Drawing.Point(602, 240)
        Me.Next_Scheduled_MaintenanceDateTimePicker.Name = "Next_Scheduled_MaintenanceDateTimePicker"
        Me.Next_Scheduled_MaintenanceDateTimePicker.Size = New System.Drawing.Size(90, 20)
        Me.Next_Scheduled_MaintenanceDateTimePicker.TabIndex = 49
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(7, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(308, 30)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Asset Record Setup"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1244, 342)
        Me.Panel3.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1230, 293)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(2, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Updated Asset Table"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(763, 667)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 20)
        Me.txtSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(716, 670)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1181, 663)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSetupAssetRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1268, 699)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetupAssetRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupAssetRecords"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    ' Friend WithEvents UnitechAMSDataSet As UAMS.UnitechAMSDataSet
    'Friend WithEvents TblAssetBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents TblAssetTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblAssetTableAdapter
    'Friend WithEvents TableAdapterManager As UAMS.UnitechAMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Asset_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Age_in_YearsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Serial_Reg_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Model_Engine_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Funded_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoice_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cheque_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purchase_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Purchase_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Depreciable_Life__in_years_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Depreciable_Value__in___TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Next_Scheduled_MaintenanceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    ' Friend WithEvents TblCategoryTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblCategoryTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents mskNextSchedule As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskPurchaseDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Supplier_NameTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
