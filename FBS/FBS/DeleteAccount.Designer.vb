<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAccount
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
        Me.AccountGrid = New System.Windows.Forms.DataGridView()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.CustomerTableAdapter = New FBS.FBSDataSetTableAdapters.CustomerTableAdapter()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        CType(Me.AccountGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountGrid
        '
        Me.AccountGrid.AllowUserToAddRows = False
        Me.AccountGrid.AutoGenerateColumns = False
        Me.AccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.CustPassDataGridViewTextBoxColumn, Me.CustNumberDataGridViewTextBoxColumn})
        Me.AccountGrid.DataSource = Me.CustomerBindingSource
        Me.AccountGrid.Location = New System.Drawing.Point(16, 66)
        Me.AccountGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountGrid.Name = "AccountGrid"
        Me.AccountGrid.Size = New System.Drawing.Size(443, 185)
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
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(361, 259)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 31)
        Me.deleteBtn.TabIndex = 1
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search for Users : "
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(173, 37)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(159, 22)
        Me.searchTxt.TabIndex = 3
        '
        'DeleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 295)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.AccountGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DeleteAccount"
        Me.Text = "DeleteAccount"
        CType(Me.AccountGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTxt As TextBox
End Class
