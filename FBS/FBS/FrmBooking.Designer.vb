<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBooking))
        Me.VenueDSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueDataSet = New FBS.VenueDataSet()
        Me.VenueDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lstTimeslot = New System.Windows.Forms.ListBox()
        Me.lblTotalPayment = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.VenueBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbActivityType = New System.Windows.Forms.ComboBox()
        Me.VenueBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VenueBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueTableAdapter1 = New FBS.VenueDataSetTableAdapters.VenueTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.VenueDSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VenueBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VenueDSBindingSource1
        '
        Me.VenueDSBindingSource1.DataSource = Me.VenueDataSet
        Me.VenueDSBindingSource1.Position = 0
        '
        'VenueDataSet
        '
        Me.VenueDataSet.DataSetName = "VenueDataSet"
        Me.VenueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VenueDSBindingSource
        '
        Me.VenueDSBindingSource.DataSource = Me.VenueDataSet
        Me.VenueDSBindingSource.Position = 0
        '
        'lstTimeslot
        '
        Me.lstTimeslot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTimeslot.FormattingEnabled = True
        Me.lstTimeslot.ItemHeight = 29
        Me.lstTimeslot.Location = New System.Drawing.Point(187, 345)
        Me.lstTimeslot.Margin = New System.Windows.Forms.Padding(8)
        Me.lstTimeslot.Name = "lstTimeslot"
        Me.lstTimeslot.Size = New System.Drawing.Size(449, 33)
        Me.lstTimeslot.TabIndex = 38
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPayment.Location = New System.Drawing.Point(204, 89)
        Me.lblTotalPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(190, 31)
        Me.lblTotalPayment.TabIndex = 22
        Me.lblTotalPayment.Text = "RM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 89)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 29)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "x"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalPayment)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lblHour)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(187, 432)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(527, 133)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price Summary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 29)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(204, 44)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(190, 31)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "RM"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(420, 44)
        Me.lblHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(89, 29)
        Me.lblHour.TabIndex = 17
        Me.lblHour.Text = "hour(s)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(533, 247)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 29)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "per hour"
        '
        'lblRate
        '
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(187, 246)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(8)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(334, 33)
        Me.lblRate.TabIndex = 35
        Me.lblRate.Text = "RM"
        '
        'VenueBindingSource1
        '
        Me.VenueBindingSource1.DataMember = "Venue"
        Me.VenueBindingSource1.DataSource = Me.VenueDSBindingSource
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(644, 610)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 50)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(486, 610)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(150, 50)
        Me.btnBook.TabIndex = 31
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 29)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Activity:"
        '
        'lblPicture
        '
        Me.lblPicture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VenueBindingSource, "VenuePicture", True))
        Me.lblPicture.Location = New System.Drawing.Point(672, 124)
        Me.lblPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(480, 300)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 30
        Me.lblPicture.TabStop = False
        '
        'VenueBindingSource
        '
        Me.VenueBindingSource.DataMember = "Venue"
        Me.VenueBindingSource.DataSource = Me.VenueDataSet
        '
        'cbActivityType
        '
        Me.cbActivityType.DataSource = Me.VenueBindingSource3
        Me.cbActivityType.DisplayMember = "VenueType"
        Me.cbActivityType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActivityType.FormattingEnabled = True
        Me.cbActivityType.Location = New System.Drawing.Point(187, 140)
        Me.cbActivityType.Margin = New System.Windows.Forms.Padding(8)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(449, 37)
        Me.cbActivityType.TabIndex = 34
        Me.cbActivityType.ValueMember = "VenueType"
        '
        'VenueBindingSource3
        '
        Me.VenueBindingSource3.DataMember = "Venue"
        Me.VenueBindingSource3.DataSource = Me.VenueDataSet
        '
        'cbVenue
        '
        Me.cbVenue.DataSource = Me.VenueBindingSource3
        Me.cbVenue.DisplayMember = "VenueName"
        Me.cbVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVenue.FormattingEnabled = True
        Me.cbVenue.Location = New System.Drawing.Point(187, 193)
        Me.cbVenue.Margin = New System.Windows.Forms.Padding(8)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(449, 37)
        Me.cbVenue.TabIndex = 29
        Me.cbVenue.ValueMember = "VenueID"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(87, 196)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(88, 29)
        Me.lblVenue.TabIndex = 28
        Me.lblVenue.Text = "Venue:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(106, 300)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(69, 29)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 345)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 29)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Time:"
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBooking.Location = New System.Drawing.Point(187, 295)
        Me.dtpBooking.Margin = New System.Windows.Forms.Padding(8)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(449, 34)
        Me.dtpBooking.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 69)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Make a Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VenueBindingSource2
        '
        Me.VenueBindingSource2.DataMember = "Venue"
        Me.VenueBindingSource2.DataSource = Me.VenueDSBindingSource
        '
        'VenueTableAdapter1
        '
        Me.VenueTableAdapter1.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 40)
        Me.btnBack.TabIndex = 62
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstTimeslot)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.cbActivityType)
        Me.Controls.Add(Me.cbVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBooking)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.VenueDSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VenueBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VenueDSBindingSource1 As BindingSource
    Friend WithEvents VenueDSBindingSource As BindingSource
    Friend WithEvents lstTimeslot As ListBox
    Friend WithEvents lblTotalPayment As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents VenueBindingSource1 As BindingSource
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents VenueBindingSource As BindingSource
    Friend WithEvents cbActivityType As ComboBox
    Friend WithEvents cbVenue As ComboBox
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBooking As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents VenueBindingSource2 As BindingSource
    Friend WithEvents VenueDataSet As VenueDataSet
    Friend WithEvents VenueBindingSource3 As BindingSource
    Friend WithEvents VenueTableAdapter1 As VenueDataSetTableAdapters.VenueTableAdapter
    Friend WithEvents lblPicture As PictureBox
    Friend WithEvents btnBack As Button
End Class
