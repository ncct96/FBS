﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueDS = New FBS.VenueDS()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbActivityType = New System.Windows.Forms.ComboBox()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.VenueTableAdapter = New FBS.VenueDSTableAdapters.VenueTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPayment = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make a Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Location = New System.Drawing.Point(148, 232)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(200, 20)
        Me.dtpBooking.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Timeslot:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(66, 238)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(66, 170)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(41, 13)
        Me.lblVenue.TabIndex = 7
        Me.lblVenue.Text = "Venue:"
        '
        'cbVenue
        '
        Me.cbVenue.DataSource = Me.VenueBindingSource
        Me.cbVenue.DisplayMember = "VenueName"
        Me.cbVenue.FormattingEnabled = True
        Me.cbVenue.Location = New System.Drawing.Point(148, 167)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(121, 21)
        Me.cbVenue.TabIndex = 8
        Me.cbVenue.ValueMember = "VenueID"
        '
        'VenueBindingSource
        '
        Me.VenueBindingSource.DataMember = "Venue"
        Me.VenueBindingSource.DataSource = Me.VenueDS
        '
        'VenueDS
        '
        Me.VenueDS.DataSetName = "VenueDS"
        Me.VenueDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(217, 550)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 11
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(331, 550)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(387, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Activity:"
        '
        'cbActivityType
        '
        Me.cbActivityType.DataSource = Me.VenueBindingSource
        Me.cbActivityType.DisplayMember = "VenueType"
        Me.cbActivityType.FormattingEnabled = True
        Me.cbActivityType.Location = New System.Drawing.Point(148, 114)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(121, 21)
        Me.cbActivityType.TabIndex = 14
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(194, 29)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(39, 13)
        Me.lblHour.TabIndex = 17
        Me.lblHour.Text = "hour(s)"
        '
        'VenueTableAdapter
        '
        Me.VenueTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(105, 29)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(26, 15)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "RM"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Location = New System.Drawing.Point(276, 170)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(26, 15)
        Me.lblRate.TabIndex = 20
        Me.lblRate.Text = "RM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(335, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "per hour"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalPayment)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lblHour)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 398)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 122)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Summary"
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = True
        Me.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPayment.Location = New System.Drawing.Point(105, 70)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(26, 15)
        Me.lblTotalPayment.TabIndex = 22
        Me.lblTotalPayment.Text = "RM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Start:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "End:"
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(183, 326)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 25
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 595)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbActivityType)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBooking)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.Text = "LCW Facilities Booking Systen"
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpBooking As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents cbVenue As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbActivityType As ComboBox
    Friend WithEvents lblHour As Label
    Friend WithEvents VenueDS As VenueDS
    Friend WithEvents VenueBindingSource As BindingSource
    Friend WithEvents VenueTableAdapter As VenueDSTableAdapters.VenueTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalPayment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpStart As DateTimePicker
End Class
