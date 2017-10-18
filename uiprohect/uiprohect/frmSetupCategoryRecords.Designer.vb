<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupCategoryRecords
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
        Dim Asset_CategoryIDLabel As System.Windows.Forms.Label
        Dim Asset_CategoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupCategoryRecords))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Asset_CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.Asset_CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.TblCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Asset_CategoryIDLabel = New System.Windows.Forms.Label()
        Asset_CategoryLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Asset_CategoryIDLabel
        '
        Asset_CategoryIDLabel.AutoSize = True
        Asset_CategoryIDLabel.Location = New System.Drawing.Point(12, 6)
        Asset_CategoryIDLabel.Name = "Asset_CategoryIDLabel"
        Asset_CategoryIDLabel.Size = New System.Drawing.Size(95, 13)
        Asset_CategoryIDLabel.TabIndex = 53
        Asset_CategoryIDLabel.Text = "Asset Category ID:"
        '
        'Asset_CategoryLabel
        '
        Asset_CategoryLabel.AutoSize = True
        Asset_CategoryLabel.Location = New System.Drawing.Point(12, 33)
        Asset_CategoryLabel.Name = "Asset_CategoryLabel"
        Asset_CategoryLabel.Size = New System.Drawing.Size(81, 13)
        Asset_CategoryLabel.TabIndex = 55
        Asset_CategoryLabel.Text = "Asset Category:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Asset_CategoryIDLabel)
        Me.Panel2.Controls.Add(Me.Asset_CategoryIDTextBox)
        Me.Panel2.Controls.Add(Asset_CategoryLabel)
        Me.Panel2.Controls.Add(Me.Asset_CategoryTextBox)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 119)
        Me.Panel2.TabIndex = 1
        '
        'Asset_CategoryIDTextBox
        '
        Me.Asset_CategoryIDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Asset_CategoryIDTextBox.Enabled = False
        Me.Asset_CategoryIDTextBox.Location = New System.Drawing.Point(113, 3)
        Me.Asset_CategoryIDTextBox.Name = "Asset_CategoryIDTextBox"
        Me.Asset_CategoryIDTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Asset_CategoryIDTextBox.TabIndex = 54
        '
        'Asset_CategoryTextBox
        '
        Me.Asset_CategoryTextBox.Location = New System.Drawing.Point(113, 30)
        Me.Asset_CategoryTextBox.Name = "Asset_CategoryTextBox"
        Me.Asset_CategoryTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Asset_CategoryTextBox.TabIndex = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnEDIT)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 50)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
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
        Me.btnEDIT.Location = New System.Drawing.Point(291, 19)
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
        Me.btnUPDATE.Location = New System.Drawing.Point(149, 19)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'TblCategoryBindingSource
        '
        Me.TblCategoryBindingSource.DataMember = "tblCategory"
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(6, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(392, 32)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Category Record Setup"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(60, 333)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 20)
        Me.txtSearch.TabIndex = 62
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(13, 336)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 61
        Me.Search.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(408, 158)
        Me.DataGridView1.TabIndex = 63
        '
        'frmSetupCategoryRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(428, 359)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupCategoryRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupCategoryRecords"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button

    Friend WithEvents TblCategoryBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Asset_CategoryIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asset_CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
