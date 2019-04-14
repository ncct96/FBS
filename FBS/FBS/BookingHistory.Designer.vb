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
        Me.FBSMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BookingHistGrid = New System.Windows.Forms.DataGridView()
        Me.filterGrpBox = New System.Windows.Forms.GroupBox()
        Me.DateFilter = New System.Windows.Forms.RadioButton()
        Me.FacilitiesFilter = New System.Windows.Forms.RadioButton()
        Me.UsagesFilter = New System.Windows.Forms.RadioButton()
        Me.advanceGrpBox = New System.Windows.Forms.GroupBox()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BookingHistGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterGrpBox.SuspendLayout()
        Me.advanceGrpBox.SuspendLayout()
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
        Me.BookingHistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingHistGrid.Location = New System.Drawing.Point(260, 42)
        Me.BookingHistGrid.Name = "BookingHistGrid"
        Me.BookingHistGrid.Size = New System.Drawing.Size(294, 302)
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
        'UsagesFilter
        '
        Me.UsagesFilter.AutoSize = True
        Me.UsagesFilter.Location = New System.Drawing.Point(20, 75)
        Me.UsagesFilter.Name = "UsagesFilter"
        Me.UsagesFilter.Size = New System.Drawing.Size(61, 17)
        Me.UsagesFilter.TabIndex = 2
        Me.UsagesFilter.TabStop = True
        Me.UsagesFilter.Text = "Usages"
        Me.UsagesFilter.UseVisualStyleBackColor = True
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
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(20, 40)
        Me.searchTxt.Multiline = True
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(158, 45)
        Me.searchTxt.TabIndex = 0
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
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 361)
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
End Class
