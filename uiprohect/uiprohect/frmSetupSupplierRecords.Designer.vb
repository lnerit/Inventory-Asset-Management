

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupSupplierRecords
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
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupSupplierRecords))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(3, 21)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(62, 13)
        SupplierIDLabel.TabIndex = 1
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Location = New System.Drawing.Point(3, 47)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(79, 13)
        Supplier_NameLabel.TabIndex = 3
        Supplier_NameLabel.Text = "Supplier Name:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(SupplierIDLabel)
        Me.Panel2.Controls.Add(Me.SupplierIDTextBox)
        Me.Panel2.Controls.Add(Supplier_NameLabel)
        Me.Panel2.Controls.Add(Me.Supplier_NameTextBox)
        Me.Panel2.Location = New System.Drawing.Point(3, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 137)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 54)
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
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(237, 19)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(66, 23)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
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
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SupplierIDTextBox.Enabled = False
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(88, 18)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(272, 20)
        Me.SupplierIDTextBox.TabIndex = 2
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(88, 44)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Supplier_NameTextBox.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(3, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 133)
        Me.Panel3.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(392, 125)
        Me.DataGridView1.TabIndex = 0
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(-3, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(406, 32)
        Me.lblHeading3.TabIndex = 4
        Me.lblHeading3.Text = "Setup Suppliers Records"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(69, 326)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(333, 20)
        Me.txtSearch.TabIndex = 60
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(22, 329)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 59
        Me.Search.Text = "Search"
        '
        'frmSetupSupplierRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(418, 358)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupSupplierRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupSupplierRecords"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Label
End Class
