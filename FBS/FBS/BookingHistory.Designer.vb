<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingHistory
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
        Me.BookingHistGrid = New System.Windows.Forms.DataGridView()
        Me.showGrpBox = New System.Windows.Forms.GroupBox()
        Me.CompletedFilter = New System.Windows.Forms.RadioButton()
        Me.OngoingFilter = New System.Windows.Forms.RadioButton()
        Me.advanceGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.BookingTableAdapter = New FBS.FBSDataSetTableAdapters.BookingTableAdapter()
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.showGrpBox.SuspendLayout()
        Me.advanceGrpBox.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingHistGrid
        '
        Me.BookingHistGrid.AllowUserToAddRows = False
        Me.BookingHistGrid.AllowUserToDeleteRows = False
        Me.BookingHistGrid.AutoGenerateColumns = False
        Me.BookingHistGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookingHistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingHistGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingDateDataGridViewTextBoxColumn, Me.BookingTimeDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.BookingChargesDataGridViewTextBoxColumn})
        Me.BookingHistGrid.DataSource = Me.BookingBindingSource
        Me.BookingHistGrid.Location = New System.Drawing.Point(218, 25)
        Me.BookingHistGrid.Name = "BookingHistGrid"
        Me.BookingHistGrid.ReadOnly = True
        Me.BookingHistGrid.Size = New System.Drawing.Size(417, 319)
        Me.BookingHistGrid.TabIndex = 1
        '
        'showGrpBox
        '
        Me.showGrpBox.Controls.Add(Me.CompletedFilter)
        Me.showGrpBox.Controls.Add(Me.OngoingFilter)
        Me.showGrpBox.Location = New System.Drawing.Point(12, 131)
        Me.showGrpBox.Name = "showGrpBox"
        Me.showGrpBox.Size = New System.Drawing.Size(168, 86)
        Me.showGrpBox.TabIndex = 2
        Me.showGrpBox.TabStop = False
        Me.showGrpBox.Text = "Show Booking :"
        '
        'CompletedFilter
        '
        Me.CompletedFilter.AutoSize = True
        Me.CompletedFilter.Location = New System.Drawing.Point(20, 52)
        Me.CompletedFilter.Name = "CompletedFilter"
        Me.CompletedFilter.Size = New System.Drawing.Size(75, 17)
        Me.CompletedFilter.TabIndex = 1
        Me.CompletedFilter.Text = "Completed"
        Me.CompletedFilter.UseVisualStyleBackColor = True
        '
        'OngoingFilter
        '
        Me.OngoingFilter.AutoSize = True
        Me.OngoingFilter.Checked = True
        Me.OngoingFilter.Location = New System.Drawing.Point(20, 29)
        Me.OngoingFilter.Name = "OngoingFilter"
        Me.OngoingFilter.Size = New System.Drawing.Size(65, 17)
        Me.OngoingFilter.TabIndex = 0
        Me.OngoingFilter.TabStop = True
        Me.OngoingFilter.Text = "Ongoing"
        Me.OngoingFilter.UseVisualStyleBackColor = True
        '
        'advanceGrpBox
        '
        Me.advanceGrpBox.Controls.Add(Me.Label1)
        Me.advanceGrpBox.Controls.Add(Me.searchTxt)
        Me.advanceGrpBox.Location = New System.Drawing.Point(12, 25)
        Me.advanceGrpBox.Name = "advanceGrpBox"
        Me.advanceGrpBox.Size = New System.Drawing.Size(200, 100)
        Me.advanceGrpBox.TabIndex = 3
        Me.advanceGrpBox.TabStop = False
        Me.advanceGrpBox.Text = "Search : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input details for search : "
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(20, 51)
        Me.searchTxt.Multiline = True
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(158, 24)
        Me.searchTxt.TabIndex = 0
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        Me.BookingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingTimeDataGridViewTextBoxColumn
        '
        Me.BookingTimeDataGridViewTextBoxColumn.DataPropertyName = "BookingTime"
        Me.BookingTimeDataGridViewTextBoxColumn.HeaderText = "BookingTime"
        Me.BookingTimeDataGridViewTextBoxColumn.Name = "BookingTimeDataGridViewTextBoxColumn"
        Me.BookingTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VisitDateDataGridViewTextBoxColumn
        '
        Me.VisitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.Name = "VisitDateDataGridViewTextBoxColumn"
        Me.VisitDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingChargesDataGridViewTextBoxColumn
        '
        Me.BookingChargesDataGridViewTextBoxColumn.DataPropertyName = "BookingCharges"
        Me.BookingChargesDataGridViewTextBoxColumn.HeaderText = "BookingCharges"
        Me.BookingChargesDataGridViewTextBoxColumn.Name = "BookingChargesDataGridViewTextBoxColumn"
        Me.BookingChargesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.FBSDataSet
        '
        'FBSDataSet
        '
        Me.FBSDataSet.DataSetName = "FBSDataSet"
        Me.FBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 364)
        Me.Controls.Add(Me.advanceGrpBox)
        Me.Controls.Add(Me.showGrpBox)
        Me.Controls.Add(Me.BookingHistGrid)
        Me.Name = "BookingHistory"
        Me.Text = "Booking History"
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.showGrpBox.ResumeLayout(False)
        Me.showGrpBox.PerformLayout()
        Me.advanceGrpBox.ResumeLayout(False)
        Me.advanceGrpBox.PerformLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BookingHistGrid As DataGridView
    Friend WithEvents showGrpBox As GroupBox
    Friend WithEvents OngoingFilter As RadioButton
    Friend WithEvents CompletedFilter As RadioButton
    Friend WithEvents advanceGrpBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents FBSDataSet As FBSDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As FBSDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
