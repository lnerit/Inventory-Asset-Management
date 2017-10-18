<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupMaintenanceRecords
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
        Dim MaintenanceIDLabel As System.Windows.Forms.Label
        Dim Maintenance_DateLabel As System.Windows.Forms.Label
        Dim Serial_Reg_NoLabel As System.Windows.Forms.Label
        Dim Maintenance_DescriptionLabel As System.Windows.Forms.Label
        Dim Maintenance_CostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupMaintenanceRecords))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.MaintenanceIDTextBox = New System.Windows.Forms.TextBox()
        Me.Maintenance_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Maintenance_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Maintenance_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TblMaintenanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.mskMaintenanceDate = New System.Windows.Forms.MaskedTextBox()
        Me.Serial_Reg_NoTextBox = New System.Windows.Forms.ComboBox()
        MaintenanceIDLabel = New System.Windows.Forms.Label()
        Maintenance_DateLabel = New System.Windows.Forms.Label()
        Serial_Reg_NoLabel = New System.Windows.Forms.Label()
        Maintenance_DescriptionLabel = New System.Windows.Forms.Label()
        Maintenance_CostLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TblMaintenanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaintenanceIDLabel
        '
        MaintenanceIDLabel.AutoSize = True
        MaintenanceIDLabel.Location = New System.Drawing.Point(17, 13)
        MaintenanceIDLabel.Name = "MaintenanceIDLabel"
        MaintenanceIDLabel.Size = New System.Drawing.Size(86, 13)
        MaintenanceIDLabel.TabIndex = 1
        MaintenanceIDLabel.Text = "Maintenance ID:"
        '
        'Maintenance_DateLabel
        '
        Maintenance_DateLabel.AutoSize = True
        Maintenance_DateLabel.Location = New System.Drawing.Point(17, 40)
        Maintenance_DateLabel.Name = "Maintenance_DateLabel"
        Maintenance_DateLabel.Size = New System.Drawing.Size(98, 13)
        Maintenance_DateLabel.TabIndex = 3
        Maintenance_DateLabel.Text = "Maintenance Date:"
        '
        'Serial_Reg_NoLabel
        '
        Serial_Reg_NoLabel.AutoSize = True
        Serial_Reg_NoLabel.Location = New System.Drawing.Point(17, 65)
        Serial_Reg_NoLabel.Name = "Serial_Reg_NoLabel"
        Serial_Reg_NoLabel.Size = New System.Drawing.Size(78, 13)
        Serial_Reg_NoLabel.TabIndex = 5
        Serial_Reg_NoLabel.Text = "Serial/Reg No:"
        '
        'Maintenance_DescriptionLabel
        '
        Maintenance_DescriptionLabel.AutoSize = True
        Maintenance_DescriptionLabel.Location = New System.Drawing.Point(19, 92)
        Maintenance_DescriptionLabel.Name = "Maintenance_DescriptionLabel"
        Maintenance_DescriptionLabel.Size = New System.Drawing.Size(128, 13)
        Maintenance_DescriptionLabel.TabIndex = 7
        Maintenance_DescriptionLabel.Text = "Maintenance Description:"
        '
        'Maintenance_CostLabel
        '
        Maintenance_CostLabel.AutoSize = True
        Maintenance_CostLabel.Location = New System.Drawing.Point(19, 118)
        Maintenance_CostLabel.Name = "Maintenance_CostLabel"
        Maintenance_CostLabel.Size = New System.Drawing.Size(96, 13)
        Maintenance_CostLabel.TabIndex = 9
        Maintenance_CostLabel.Text = "Maintenance Cost:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Serial_Reg_NoTextBox)
        Me.Panel2.Controls.Add(Me.mskMaintenanceDate)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(MaintenanceIDLabel)
        Me.Panel2.Controls.Add(Me.MaintenanceIDTextBox)
        Me.Panel2.Controls.Add(Maintenance_DateLabel)
        Me.Panel2.Controls.Add(Me.Maintenance_DateDateTimePicker)
        Me.Panel2.Controls.Add(Serial_Reg_NoLabel)
        Me.Panel2.Controls.Add(Maintenance_DescriptionLabel)
        Me.Panel2.Controls.Add(Me.Maintenance_DescriptionTextBox)
        Me.Panel2.Controls.Add(Maintenance_CostLabel)
        Me.Panel2.Controls.Add(Me.Maintenance_CostTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 223)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 54)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup Task"
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(6, 19)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(66, 23)
        Me.btnADD.TabIndex = 6
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(310, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(66, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(171, 19)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(61, 23)
        Me.btnDELETE.TabIndex = 7
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(95, 19)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'MaintenanceIDTextBox
        '
        Me.MaintenanceIDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MaintenanceIDTextBox.Enabled = False
        Me.MaintenanceIDTextBox.Location = New System.Drawing.Point(151, 10)
        Me.MaintenanceIDTextBox.Name = "MaintenanceIDTextBox"
        Me.MaintenanceIDTextBox.Size = New System.Drawing.Size(245, 20)
        Me.MaintenanceIDTextBox.TabIndex = 2
        '
        'Maintenance_DateDateTimePicker
        '
        Me.Maintenance_DateDateTimePicker.Location = New System.Drawing.Point(285, 36)
        Me.Maintenance_DateDateTimePicker.Name = "Maintenance_DateDateTimePicker"
        Me.Maintenance_DateDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.Maintenance_DateDateTimePicker.TabIndex = 4
        '
        'Maintenance_DescriptionTextBox
        '
        Me.Maintenance_DescriptionTextBox.Location = New System.Drawing.Point(153, 89)
        Me.Maintenance_DescriptionTextBox.Name = "Maintenance_DescriptionTextBox"
        Me.Maintenance_DescriptionTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Maintenance_DescriptionTextBox.TabIndex = 8
        '
        'Maintenance_CostTextBox
        '
        Me.Maintenance_CostTextBox.Location = New System.Drawing.Point(153, 115)
        Me.Maintenance_CostTextBox.Name = "Maintenance_CostTextBox"
        Me.Maintenance_CostTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Maintenance_CostTextBox.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TblMaintenanceDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(12, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 157)
        Me.Panel3.TabIndex = 2
        '
        'TblMaintenanceDataGridView
        '
        Me.TblMaintenanceDataGridView.AllowUserToAddRows = False
        Me.TblMaintenanceDataGridView.AllowUserToDeleteRows = False
        Me.TblMaintenanceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblMaintenanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMaintenanceDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TblMaintenanceDataGridView.Name = "TblMaintenanceDataGridView"
        Me.TblMaintenanceDataGridView.ReadOnly = True
        Me.TblMaintenanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblMaintenanceDataGridView.Size = New System.Drawing.Size(448, 149)
        Me.TblMaintenanceDataGridView.TabIndex = 0
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(6, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(441, 32)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Maintenance Record Setup"
        '
        'mskMaintenanceDate
        '
        Me.mskMaintenanceDate.Location = New System.Drawing.Point(151, 37)
        Me.mskMaintenanceDate.Mask = "00/00/0000"
        Me.mskMaintenanceDate.Name = "mskMaintenanceDate"
        Me.mskMaintenanceDate.Size = New System.Drawing.Size(120, 20)
        Me.mskMaintenanceDate.TabIndex = 55
        Me.mskMaintenanceDate.ValidatingType = GetType(Date)
        '
        'Serial_Reg_NoTextBox
        '
        Me.Serial_Reg_NoTextBox.FormattingEnabled = True
        Me.Serial_Reg_NoTextBox.Location = New System.Drawing.Point(154, 62)
        Me.Serial_Reg_NoTextBox.Name = "Serial_Reg_NoTextBox"
        Me.Serial_Reg_NoTextBox.Size = New System.Drawing.Size(241, 21)
        Me.Serial_Reg_NoTextBox.TabIndex = 56
        '
        'frmSetupMaintenanceRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(480, 437)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupMaintenanceRecords"
        Me.Text = "frmSetupMaintenanceRecords"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.TblMaintenanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    ' Friend WithEvents UnitechAMSDataSet As UAMS.UnitechAMSDataSet
    ' Friend WithEvents TblMaintenanceTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblMaintenanceTableAdapter
    ' Friend WithEvents TableAdapterManager As UAMS.UnitechAMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaintenanceIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maintenance_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Maintenance_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maintenance_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents TblMaintenanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mskMaintenanceDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Serial_Reg_NoTextBox As System.Windows.Forms.ComboBox
End Class
