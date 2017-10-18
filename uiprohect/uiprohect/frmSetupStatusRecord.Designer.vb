<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupStatusRecord
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
        Dim StatusIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupStatusRecord))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.StatusIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblStatusDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        StatusIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblStatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusIDLabel
        '
        StatusIDLabel.AutoSize = True
        StatusIDLabel.Location = New System.Drawing.Point(11, 13)
        StatusIDLabel.Name = "StatusIDLabel"
        StatusIDLabel.Size = New System.Drawing.Size(54, 13)
        StatusIDLabel.TabIndex = 0
        StatusIDLabel.Text = "Status ID:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(11, 39)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Status:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtStatus)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(StatusIDLabel)
        Me.Panel2.Controls.Add(Me.StatusIDTextBox)
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Location = New System.Drawing.Point(3, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 130)
        Me.Panel2.TabIndex = 3
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(71, 39)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(266, 20)
        Me.txtStatus.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 56)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup Task"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(340, 20)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 22)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
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
        Me.btnUPDATE.Location = New System.Drawing.Point(158, 20)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'StatusIDTextBox
        '
        Me.StatusIDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.StatusIDTextBox.Enabled = False
        Me.StatusIDTextBox.Location = New System.Drawing.Point(71, 10)
        Me.StatusIDTextBox.Name = "StatusIDTextBox"
        Me.StatusIDTextBox.Size = New System.Drawing.Size(266, 20)
        Me.StatusIDTextBox.TabIndex = 1
        '
        'TblStatusDataGridView
        '
        Me.TblStatusDataGridView.AllowUserToOrderColumns = True
        Me.TblStatusDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblStatusDataGridView.AutoGenerateColumns = False
        Me.TblStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStatusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TblStatusDataGridView.Location = New System.Drawing.Point(8, 15)
        Me.TblStatusDataGridView.Name = "TblStatusDataGridView"
        Me.TblStatusDataGridView.Size = New System.Drawing.Size(630, 200)
        Me.TblStatusDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StatusID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StatusID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(6, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(364, 32)
        Me.lblHeading3.TabIndex = 5
        Me.lblHeading3.Text = "Setup Status Records"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(441, 130)
        Me.DataGridView1.TabIndex = 6
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(9, 319)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 7
        Me.Search.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(56, 316)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 20)
        Me.txtSearch.TabIndex = 58
        '
        'frmSetupStatusRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(456, 344)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupStatusRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupStatusRecord"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TblStatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    ' Friend WithEvents UnitechAMSDataSet As UAMS.UnitechAMSDataSet
    ' Friend WithEvents TblStatusTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblStatusTableAdapter
    'Friend WithEvents TableAdapterManager As UAMS.UnitechAMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StatusIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TblStatusDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Search As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
