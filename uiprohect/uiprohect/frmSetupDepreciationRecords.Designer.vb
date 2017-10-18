<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupDepreciationRecords
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
        Dim DepreciationIDLabel As System.Windows.Forms.Label
        Dim Depreciation_DateLabel As System.Windows.Forms.Label
        Dim Serial_Reg_NoLabel As System.Windows.Forms.Label
        Dim Depreciation_AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupDepreciationRecords))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.DepreciationIDTextBox = New System.Windows.Forms.TextBox()
        Me.Depreciation_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Depreciation_AmountTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.mskDepreciationDate = New System.Windows.Forms.MaskedTextBox()
        Me.Serial_Reg_NoTextBox = New System.Windows.Forms.ComboBox()
        DepreciationIDLabel = New System.Windows.Forms.Label()
        Depreciation_DateLabel = New System.Windows.Forms.Label()
        Serial_Reg_NoLabel = New System.Windows.Forms.Label()
        Depreciation_AmountLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DepreciationIDLabel
        '
        DepreciationIDLabel.AutoSize = True
        DepreciationIDLabel.Location = New System.Drawing.Point(12, 18)
        DepreciationIDLabel.Name = "DepreciationIDLabel"
        DepreciationIDLabel.Size = New System.Drawing.Size(84, 13)
        DepreciationIDLabel.TabIndex = 4
        DepreciationIDLabel.Text = "Depreciation ID:"
        '
        'Depreciation_DateLabel
        '
        Depreciation_DateLabel.AutoSize = True
        Depreciation_DateLabel.Location = New System.Drawing.Point(12, 45)
        Depreciation_DateLabel.Name = "Depreciation_DateLabel"
        Depreciation_DateLabel.Size = New System.Drawing.Size(96, 13)
        Depreciation_DateLabel.TabIndex = 6
        Depreciation_DateLabel.Text = "Depreciation Date:"
        '
        'Serial_Reg_NoLabel
        '
        Serial_Reg_NoLabel.AutoSize = True
        Serial_Reg_NoLabel.Location = New System.Drawing.Point(13, 75)
        Serial_Reg_NoLabel.Name = "Serial_Reg_NoLabel"
        Serial_Reg_NoLabel.Size = New System.Drawing.Size(78, 13)
        Serial_Reg_NoLabel.TabIndex = 8
        Serial_Reg_NoLabel.Text = "Serial/Reg No:"
        '
        'Depreciation_AmountLabel
        '
        Depreciation_AmountLabel.AutoSize = True
        Depreciation_AmountLabel.Location = New System.Drawing.Point(13, 98)
        Depreciation_AmountLabel.Name = "Depreciation_AmountLabel"
        Depreciation_AmountLabel.Size = New System.Drawing.Size(109, 13)
        Depreciation_AmountLabel.TabIndex = 10
        Depreciation_AmountLabel.Text = "Depreciation Amount:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(12, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(511, 184)
        Me.Panel3.TabIndex = 2
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(503, 176)
        Me.dataGridView1.TabIndex = 0
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(6, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(445, 32)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Depreciation Record Setup"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Serial_Reg_NoTextBox)
        Me.Panel2.Controls.Add(Me.mskDepreciationDate)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(DepreciationIDLabel)
        Me.Panel2.Controls.Add(Me.DepreciationIDTextBox)
        Me.Panel2.Controls.Add(Depreciation_DateLabel)
        Me.Panel2.Controls.Add(Me.Depreciation_DateDateTimePicker)
        Me.Panel2.Controls.Add(Serial_Reg_NoLabel)
        Me.Panel2.Controls.Add(Depreciation_AmountLabel)
        Me.Panel2.Controls.Add(Me.Depreciation_AmountTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 180)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnEDIT)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 48)
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
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(399, 19)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(66, 23)
        Me.btnEDIT.TabIndex = 10
        Me.btnEDIT.Text = "Close"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(82, 19)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(61, 23)
        Me.btnDELETE.TabIndex = 7
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Location = New System.Drawing.Point(161, 19)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'DepreciationIDTextBox
        '
        Me.DepreciationIDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DepreciationIDTextBox.Enabled = False
        Me.DepreciationIDTextBox.Location = New System.Drawing.Point(127, 15)
        Me.DepreciationIDTextBox.Name = "DepreciationIDTextBox"
        Me.DepreciationIDTextBox.Size = New System.Drawing.Size(267, 20)
        Me.DepreciationIDTextBox.TabIndex = 5
        '
        'Depreciation_DateDateTimePicker
        '
        Me.Depreciation_DateDateTimePicker.Location = New System.Drawing.Point(214, 41)
        Me.Depreciation_DateDateTimePicker.Name = "Depreciation_DateDateTimePicker"
        Me.Depreciation_DateDateTimePicker.Size = New System.Drawing.Size(180, 20)
        Me.Depreciation_DateDateTimePicker.TabIndex = 7
        '
        'Depreciation_AmountTextBox
        '
        Me.Depreciation_AmountTextBox.Location = New System.Drawing.Point(127, 100)
        Me.Depreciation_AmountTextBox.Name = "Depreciation_AmountTextBox"
        Me.Depreciation_AmountTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Depreciation_AmountTextBox.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(62, 420)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 20)
        Me.txtSearch.TabIndex = 62
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(15, 423)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 61
        Me.Search.Text = "Search"
        '
        'mskDepreciationDate
        '
        Me.mskDepreciationDate.Location = New System.Drawing.Point(129, 40)
        Me.mskDepreciationDate.Mask = "00/00/0000"
        Me.mskDepreciationDate.Name = "mskDepreciationDate"
        Me.mskDepreciationDate.Size = New System.Drawing.Size(79, 20)
        Me.mskDepreciationDate.TabIndex = 55
        Me.mskDepreciationDate.ValidatingType = GetType(Date)
        '
        'Serial_Reg_NoTextBox
        '
        Me.Serial_Reg_NoTextBox.FormattingEnabled = True
        Me.Serial_Reg_NoTextBox.Location = New System.Drawing.Point(125, 67)
        Me.Serial_Reg_NoTextBox.Name = "Serial_Reg_NoTextBox"
        Me.Serial_Reg_NoTextBox.Size = New System.Drawing.Size(268, 21)
        Me.Serial_Reg_NoTextBox.TabIndex = 56
        '
        'frmSetupDepreciationRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(535, 449)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupDepreciationRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupDepreciationRecords"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    'Friend WithEvents UnitechAMSDataSet As UAMS.UnitechAMSDataSet
    'Friend WithEvents TblDepreciationTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblDepreciationTableAdapter
    'Friend WithEvents TableAdapterManager As UAMS.UnitechAMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepreciationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Depreciation_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Depreciation_AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Label
    Friend WithEvents mskDepreciationDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Serial_Reg_NoTextBox As System.Windows.Forms.ComboBox
End Class
