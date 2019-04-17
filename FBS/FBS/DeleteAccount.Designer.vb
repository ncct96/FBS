<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AccountGrid = New System.Windows.Forms.DataGridView()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New FBS.FBSDataSetTableAdapters.CustomerTableAdapter()
        CType(Me.AccountGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountGrid
        '
        Me.AccountGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.AccountGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AccountGrid.AutoGenerateColumns = False
        Me.AccountGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccountGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.CustPassDataGridViewTextBoxColumn, Me.CustNumberDataGridViewTextBoxColumn})
        Me.AccountGrid.DataSource = Me.CustomerBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.AccountGrid.Location = New System.Drawing.Point(16, 22)
        Me.AccountGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountGrid.Name = "AccountGrid"
        Me.AccountGrid.RowHeadersVisible = False
        Me.AccountGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccountGrid.Size = New System.Drawing.Size(403, 208)
        Me.AccountGrid.TabIndex = 0
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "CustID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "CustID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        Me.CustIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "CustName"
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "CustName"
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
        '
        'CustPassDataGridViewTextBoxColumn
        '
        Me.CustPassDataGridViewTextBoxColumn.DataPropertyName = "CustPass"
        Me.CustPassDataGridViewTextBoxColumn.HeaderText = "CustPass"
        Me.CustPassDataGridViewTextBoxColumn.Name = "CustPassDataGridViewTextBoxColumn"
        '
        'CustNumberDataGridViewTextBoxColumn
        '
        Me.CustNumberDataGridViewTextBoxColumn.DataPropertyName = "CustNumber"
        Me.CustNumberDataGridViewTextBoxColumn.HeaderText = "CustNumber"
        Me.CustNumberDataGridViewTextBoxColumn.Name = "CustNumberDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.FBSDataSet
        '
        'FBSDataSet
        '
        Me.FBSDataSet.DataSetName = "FBSDataSet"
        Me.FBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(319, 238)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 31)
        Me.deleteBtn.TabIndex = 1
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'DeleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 276)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.AccountGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DeleteAccount"
        Me.Text = "Delete User Account"
        CType(Me.AccountGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccountGrid As DataGridView
    Friend WithEvents FBSDataSet As FBSDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As FBSDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents deleteBtn As Button
End Class
