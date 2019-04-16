<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStatus
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UpdatePayGrid = New System.Windows.Forms.DataGridView()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesChargedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FBSDataSet = New FBS.FBSDataSet()
        Me.PaymentTableAdapter = New FBS.FBSDataSetTableAdapters.Booking1TableAdapter()
        Me.updateBtn = New System.Windows.Forms.Button()
        CType(Me.UpdatePayGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdatePayGrid
        '
        Me.UpdatePayGrid.AllowUserToAddRows = False
        Me.UpdatePayGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.UpdatePayGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UpdatePayGrid.AutoGenerateColumns = False
        Me.UpdatePayGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UpdatePayGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UpdatePayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UpdatePayGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn, Me.FeesChargedDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.VenueDataGridViewTextBoxColumn})
        Me.UpdatePayGrid.DataSource = Me.PaymentBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UpdatePayGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.UpdatePayGrid.Location = New System.Drawing.Point(13, 13)
        Me.UpdatePayGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdatePayGrid.Name = "UpdatePayGrid"
        Me.UpdatePayGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UpdatePayGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.UpdatePayGrid.RowHeadersVisible = False
        Me.UpdatePayGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UpdatePayGrid.Size = New System.Drawing.Size(503, 282)
        Me.UpdatePayGrid.TabIndex = 0
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking ID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        Me.BookingIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        '
        'FeesChargedDataGridViewTextBoxColumn
        '
        Me.FeesChargedDataGridViewTextBoxColumn.DataPropertyName = "Fees Charged"
        Me.FeesChargedDataGridViewTextBoxColumn.HeaderText = "Fees Charged"
        Me.FeesChargedDataGridViewTextBoxColumn.Name = "FeesChargedDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'VenueDataGridViewTextBoxColumn
        '
        Me.VenueDataGridViewTextBoxColumn.DataPropertyName = "Venue"
        Me.VenueDataGridViewTextBoxColumn.HeaderText = "Venue"
        Me.VenueDataGridViewTextBoxColumn.Name = "VenueDataGridViewTextBoxColumn"
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Booking1"
        Me.PaymentBindingSource.DataSource = Me.FBSDataSet
        '
        'FBSDataSet
        '
        Me.FBSDataSet.DataSetName = "FBSDataSet"
        Me.FBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(426, 302)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(90, 32)
        Me.updateBtn.TabIndex = 2
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'UpdateStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 338)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.UpdatePayGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateStatus"
        Me.Text = "UpdateStatus"
        CType(Me.UpdatePayGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdatePayGrid As DataGridView
    Friend WithEvents FBSDataSet As FBSDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As FBSDataSetTableAdapters.Booking1TableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlotIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeesChargedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents updateBtn As Button
End Class
