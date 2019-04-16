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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.showGrpBox = New System.Windows.Forms.GroupBox()
        Me.CompletedFilter = New System.Windows.Forms.RadioButton()
        Me.OngoingFilter = New System.Windows.Forms.RadioButton()
        Me.advanceGrpBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New FBS.FBSDataSetTableAdapters.BookingTableAdapter()
        Me.VenueTableAdapter = New FBS.FBSDataSetTableAdapters.VenueTableAdapter()
        Me.BookingHistGrid = New System.Windows.Forms.DataGridView()
        Me.BookingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesChargedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.showGrpBox.SuspendLayout()
        Me.advanceGrpBox.SuspendLayout()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.advanceGrpBox.Controls.Add(Me.ComboBox1)
        Me.advanceGrpBox.Controls.Add(Me.Label1)
        Me.advanceGrpBox.Location = New System.Drawing.Point(12, 25)
        Me.advanceGrpBox.Name = "advanceGrpBox"
        Me.advanceGrpBox.Size = New System.Drawing.Size(192, 100)
        Me.advanceGrpBox.TabIndex = 3
        Me.advanceGrpBox.TabStop = False
        Me.advanceGrpBox.Text = "Search : "
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.VenueBindingSource
        Me.ComboBox1.DisplayMember = "VenueType"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(20, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 26)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "VenueType"
        '
        'VenueBindingSource
        '
        Me.VenueBindingSource.DataMember = "Venue"
        Me.VenueBindingSource.DataSource = Me.FBSDataSet
        '
        'FBSDataSet
        '
        Me.FBSDataSet.DataSetName = "FBSDataSet"
        Me.FBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the Venue for Searching : "
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(52, 265)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(100, 50)
        Me.deleteBtn.TabIndex = 4
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.FBSDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'VenueTableAdapter
        '
        Me.VenueTableAdapter.ClearBeforeFill = True
        '
        'BookingHistGrid
        '
        Me.BookingHistGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.BookingHistGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookingHistGrid.AutoGenerateColumns = False
        Me.BookingHistGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookingHistGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookingHistGrid.ColumnHeadersHeight = 30
        Me.BookingHistGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingID, Me.VenueDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn, Me.FeesChargedDataGridViewTextBoxColumn})
        Me.BookingHistGrid.DataSource = Me.BookingBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookingHistGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.BookingHistGrid.Location = New System.Drawing.Point(210, 25)
        Me.BookingHistGrid.Name = "BookingHistGrid"
        Me.BookingHistGrid.ReadOnly = True
        Me.BookingHistGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookingHistGrid.RowHeadersVisible = False
        Me.BookingHistGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookingHistGrid.Size = New System.Drawing.Size(438, 319)
        Me.BookingHistGrid.TabIndex = 1
        '
        'BookingID
        '
        Me.BookingID.DataPropertyName = "BookingID"
        Me.BookingID.HeaderText = "BookingID"
        Me.BookingID.Name = "BookingID"
        Me.BookingID.ReadOnly = True
        '
        'VenueDataGridViewTextBoxColumn
        '
        Me.VenueDataGridViewTextBoxColumn.DataPropertyName = "Venue"
        Me.VenueDataGridViewTextBoxColumn.HeaderText = "Venue"
        Me.VenueDataGridViewTextBoxColumn.Name = "VenueDataGridViewTextBoxColumn"
        Me.VenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        Me.BookingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FeesChargedDataGridViewTextBoxColumn
        '
        Me.FeesChargedDataGridViewTextBoxColumn.DataPropertyName = "Fees Charged"
        Me.FeesChargedDataGridViewTextBoxColumn.HeaderText = "Fees Charged"
        Me.FeesChargedDataGridViewTextBoxColumn.Name = "FeesChargedDataGridViewTextBoxColumn"
        Me.FeesChargedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 353)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.advanceGrpBox)
        Me.Controls.Add(Me.showGrpBox)
        Me.Controls.Add(Me.BookingHistGrid)
        Me.Name = "BookingHistory"
        Me.Text = "Booking History"
        Me.showGrpBox.ResumeLayout(False)
        Me.showGrpBox.PerformLayout()
        Me.advanceGrpBox.ResumeLayout(False)
        Me.advanceGrpBox.PerformLayout()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents showGrpBox As GroupBox
    Friend WithEvents OngoingFilter As RadioButton
    Friend WithEvents CompletedFilter As RadioButton
    Friend WithEvents advanceGrpBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FBSDataSet As FBSDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As FBSDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents deleteBtn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents VenueBindingSource As BindingSource
    Friend WithEvents VenueTableAdapter As FBSDataSetTableAdapters.VenueTableAdapter
    Friend WithEvents BookingHistGrid As DataGridView
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingID As DataGridViewTextBoxColumn
    Friend WithEvents VenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeesChargedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
