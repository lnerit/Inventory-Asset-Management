<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupDepartmentRecords
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
        Dim DepartmentIDLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupDepartmentRecords))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.DepartmentIDTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        DepartmentIDLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentIDLabel
        '
        DepartmentIDLabel.AutoSize = True
        DepartmentIDLabel.Location = New System.Drawing.Point(10, 6)
        DepartmentIDLabel.Name = "DepartmentIDLabel"
        DepartmentIDLabel.Size = New System.Drawing.Size(79, 13)
        DepartmentIDLabel.TabIndex = 10
        DepartmentIDLabel.Text = "Department ID:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(10, 32)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 12
        DepartmentLabel.Text = "Department:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(DepartmentIDLabel)
        Me.Panel2.Controls.Add(Me.DepartmentIDTextBox)
        Me.Panel2.Controls.Add(DepartmentLabel)
        Me.Panel2.Controls.Add(Me.DepartmentTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 129)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.btnEDIT)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.btnUPDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 55)
        Me.GroupBox1.TabIndex = 53
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
        Me.btnEDIT.Location = New System.Drawing.Point(313, 19)
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
        Me.btnUPDATE.Location = New System.Drawing.Point(167, 19)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(61, 23)
        Me.btnUPDATE.TabIndex = 8
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'DepartmentIDTextBox
        '
        Me.DepartmentIDTextBox.Enabled = False
        Me.DepartmentIDTextBox.Location = New System.Drawing.Point(95, 3)
        Me.DepartmentIDTextBox.Name = "DepartmentIDTextBox"
        Me.DepartmentIDTextBox.Size = New System.Drawing.Size(277, 20)
        Me.DepartmentIDTextBox.TabIndex = 11
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(95, 29)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(277, 20)
        Me.DepartmentTextBox.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(10, 179)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 190)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(442, 182)
        Me.DataGridView1.TabIndex = 0
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.ForeColor = System.Drawing.Color.Yellow
        Me.lblHeading3.Location = New System.Drawing.Point(6, 9)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(428, 32)
        Me.lblHeading3.TabIndex = 3
        Me.lblHeading3.Text = "Department Record Setup"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(64, 375)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 20)
        Me.txtSearch.TabIndex = 60
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(17, 378)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 59
        Me.Search.Text = "Search"
        '
        'frmSetupDepartmentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(464, 407)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupDepartmentRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetupDepartmentRecords"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    ' Friend WithEvents UnitechAMSDataSet As UAMS.UnitechAMSDataSet
    'Friend WithEvents TblDepartmentTableAdapter As UAMS.UnitechAMSDataSetTableAdapters.tblDepartmentTableAdapter
    ' Friend WithEvents TableAdapterManager As UAMS.UnitechAMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Label
End Class
