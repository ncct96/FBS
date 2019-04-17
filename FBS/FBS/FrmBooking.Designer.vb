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
        Me.lstTimeslot.ItemHeight = 24
        Me.lstTimeslot.Location = New System.Drawing.Point(140, 280)
        Me.lstTimeslot.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstTimeslot.Name = "lstTimeslot"
        Me.lstTimeslot.Size = New System.Drawing.Size(338, 100)
        Me.lstTimeslot.TabIndex = 38
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPayment.Location = New System.Drawing.Point(153, 72)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(143, 26)
        Me.lblTotalPayment.TabIndex = 22
        Me.lblTotalPayment.Text = "RM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 24)
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
        Me.GroupBox2.Location = New System.Drawing.Point(140, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 108)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price Summary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(153, 36)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(143, 26)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "RM"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(315, 36)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(70, 24)
        Me.lblHour.TabIndex = 17
        Me.lblHour.Text = "hour(s)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 24)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "per hour"
        '
        'lblRate
        '
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(140, 200)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(251, 27)
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
        Me.btnCancel.Location = New System.Drawing.Point(483, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 41)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(365, 505)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(112, 41)
        Me.btnBook.TabIndex = 31
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Activity:"
        '
        'lblPicture
        '
        Me.lblPicture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VenueBindingSource, "VenuePicture", True))
        Me.lblPicture.Location = New System.Drawing.Point(504, 101)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(360, 244)
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
        Me.cbActivityType.Location = New System.Drawing.Point(140, 114)
        Me.cbActivityType.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(338, 32)
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
        Me.cbVenue.Location = New System.Drawing.Point(140, 157)
        Me.cbVenue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(338, 32)
        Me.cbVenue.TabIndex = 29
        Me.cbVenue.ValueMember = "VenueID"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(65, 159)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(72, 24)
        Me.lblVenue.TabIndex = 28
        Me.lblVenue.Text = "Venue:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(80, 244)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 24)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Time:"
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBooking.Location = New System.Drawing.Point(140, 240)
        Me.dtpBooking.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(338, 29)
        Me.dtpBooking.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 55)
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
        Me.btnBack.Location = New System.Drawing.Point(9, 10)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 32)
        Me.btnBack.TabIndex = 62
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(946, 558)
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
