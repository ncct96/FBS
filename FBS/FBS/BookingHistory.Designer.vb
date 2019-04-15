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
        Me.FBSMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BookingHistGrid = New System.Windows.Forms.DataGridView()
        Me.filterGrpBox = New System.Windows.Forms.GroupBox()
        Me.UsagesFilter = New System.Windows.Forms.RadioButton()
        Me.FacilitiesFilter = New System.Windows.Forms.RadioButton()
        Me.DateFilter = New System.Windows.Forms.RadioButton()
        Me.advanceGrpBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.BookingTableAdapter = New FBS.FBSDataSetTableAdapters.BookingTableAdapter()
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterGrpBox.SuspendLayout()
        Me.advanceGrpBox.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FBSMenuStrip
        '
        Me.FBSMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FBSMenuStrip.Name = "FBSMenuStrip"
        Me.FBSMenuStrip.Size = New System.Drawing.Size(603, 24)
        Me.FBSMenuStrip.TabIndex = 0
        '
        'BookingHistGrid
        '
        Me.BookingHistGrid.AllowUserToAddRows = False
        Me.BookingHistGrid.AllowUserToDeleteRows = False
        Me.BookingHistGrid.AutoGenerateColumns = False
        Me.BookingHistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingHistGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn, Me.BookingTimeDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.BookingChargesDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn})
        Me.BookingHistGrid.DataSource = Me.BookingBindingSource
        Me.BookingHistGrid.Location = New System.Drawing.Point(230, 42)
        Me.BookingHistGrid.Name = "BookingHistGrid"
        Me.BookingHistGrid.ReadOnly = True
        Me.BookingHistGrid.Size = New System.Drawing.Size(353, 302)
        Me.BookingHistGrid.TabIndex = 1
        '
        'filterGrpBox
        '
        Me.filterGrpBox.Controls.Add(Me.UsagesFilter)
        Me.filterGrpBox.Controls.Add(Me.FacilitiesFilter)
        Me.filterGrpBox.Controls.Add(Me.DateFilter)
        Me.filterGrpBox.Location = New System.Drawing.Point(12, 42)
        Me.filterGrpBox.Name = "filterGrpBox"
        Me.filterGrpBox.Size = New System.Drawing.Size(168, 111)
        Me.filterGrpBox.TabIndex = 2
        Me.filterGrpBox.TabStop = False
        Me.filterGrpBox.Text = "Filter By : "
        '
        'UsagesFilter
        '
        Me.UsagesFilter.AutoSize = True
        Me.UsagesFilter.Location = New System.Drawing.Point(20, 75)
        Me.UsagesFilter.Name = "UsagesFilter"
        Me.UsagesFilter.Size = New System.Drawing.Size(91, 17)
        Me.UsagesFilter.TabIndex = 2
        Me.UsagesFilter.TabStop = True
        Me.UsagesFilter.Text = "Facility Usage"
        Me.UsagesFilter.UseVisualStyleBackColor = True
        '
        'FacilitiesFilter
        '
        Me.FacilitiesFilter.AutoSize = True
        Me.FacilitiesFilter.Location = New System.Drawing.Point(20, 52)
        Me.FacilitiesFilter.Name = "FacilitiesFilter"
        Me.FacilitiesFilter.Size = New System.Drawing.Size(65, 17)
        Me.FacilitiesFilter.TabIndex = 1
        Me.FacilitiesFilter.TabStop = True
        Me.FacilitiesFilter.Text = "Facilities"
        Me.FacilitiesFilter.UseVisualStyleBackColor = True
        '
        'DateFilter
        '
        Me.DateFilter.AutoSize = True
        Me.DateFilter.Location = New System.Drawing.Point(20, 29)
        Me.DateFilter.Name = "DateFilter"
        Me.DateFilter.Size = New System.Drawing.Size(48, 17)
        Me.DateFilter.TabIndex = 0
        Me.DateFilter.TabStop = True
        Me.DateFilter.Text = "Date"
        Me.DateFilter.UseVisualStyleBackColor = True
        '
        'advanceGrpBox
        '
        Me.advanceGrpBox.Controls.Add(Me.Label1)
        Me.advanceGrpBox.Controls.Add(Me.searchTxt)
        Me.advanceGrpBox.Location = New System.Drawing.Point(12, 189)
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
        Me.searchTxt.Location = New System.Drawing.Point(20, 40)
        Me.searchTxt.Multiline = True
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(158, 45)
        Me.searchTxt.TabIndex = 0
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        Me.BookingIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "Duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "Duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        Me.DurationDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ClientSize = New System.Drawing.Size(603, 364)
        Me.Controls.Add(Me.advanceGrpBox)
        Me.Controls.Add(Me.filterGrpBox)
        Me.Controls.Add(Me.BookingHistGrid)
        Me.Controls.Add(Me.FBSMenuStrip)
        Me.MainMenuStrip = Me.FBSMenuStrip
        Me.Name = "BookingHistory"
        Me.Text = "Booking History"
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filterGrpBox.ResumeLayout(False)
        Me.filterGrpBox.PerformLayout()
        Me.advanceGrpBox.ResumeLayout(False)
        Me.advanceGrpBox.PerformLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FBSMenuStrip As MenuStrip
    Friend WithEvents BookingHistGrid As DataGridView
    Friend WithEvents filterGrpBox As GroupBox
    Friend WithEvents DateFilter As RadioButton
    Friend WithEvents FacilitiesFilter As RadioButton
    Friend WithEvents UsagesFilter As RadioButton
    Friend WithEvents advanceGrpBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents FBSDataSet As FBSDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As FBSDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
