<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBooking
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
        Me.VenueDSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbActivityType = New System.Windows.Forms.ComboBox()
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VenueBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueDataSet = New FBS.VenueDataSet()
        Me.VenueBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueTableAdapter1 = New FBS.VenueDataSetTableAdapters.VenueTableAdapter()
        CType(Me.VenueDSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VenueBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VenueDSBindingSource1
        '
        Me.VenueDSBindingSource1.DataSource = Me.VenueDataSet
        Me.VenueDSBindingSource1.Position = 0
        '
        'VenueDS
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
        Me.lstTimeslot.FormattingEnabled = True
        Me.lstTimeslot.Items.AddRange(New Object() {"10:00 am - 12:00 pm", "12:00 pm - 2:00 pm", "2:00 pm - 4:00 pm", "4:00 pm - 6:00 pm", "6:00 pm - 8:00 pm", "8:00 pm - 10:00 pm"})
        Me.lstTimeslot.Location = New System.Drawing.Point(219, 282)
        Me.lstTimeslot.Name = "lstTimeslot"
        Me.lstTimeslot.Size = New System.Drawing.Size(144, 43)
        Me.lstTimeslot.TabIndex = 38
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = True
        Me.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPayment.Location = New System.Drawing.Point(106, 70)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(26, 15)
        Me.lblTotalPayment.TabIndex = 22
        Me.lblTotalPayment.Text = "RM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(140, 351)
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
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(106, 34)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(26, 15)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "RM"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(195, 34)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(39, 13)
        Me.lblHour.TabIndex = 17
        Me.lblHour.Text = "hour(s)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "per hour"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Location = New System.Drawing.Point(347, 165)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(26, 15)
        Me.lblRate.TabIndex = 35
        Me.lblRate.Text = "RM"
        '
        'VenueTableAdapter
        '
        Me.VenueTableAdapter1.ClearBeforeFill = True
        '
        'VenueBindingSource1
        '
        Me.VenueBindingSource1.DataMember = "Venue"
        Me.VenueBindingSource1.DataSource = Me.VenueDSBindingSource
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(411, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(307, 513)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 31
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Activity:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(486, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
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
        Me.cbActivityType.FormattingEnabled = True
        Me.cbActivityType.Location = New System.Drawing.Point(219, 109)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(121, 21)
        Me.cbActivityType.TabIndex = 34
        Me.cbActivityType.ValueMember = "VenueType"
        '
        'cbVenue
        '
        Me.cbVenue.DataSource = Me.VenueBindingSource3
        Me.cbVenue.DisplayMember = "VenueName"
        Me.cbVenue.FormattingEnabled = True
        Me.cbVenue.Location = New System.Drawing.Point(219, 162)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(121, 21)
        Me.cbVenue.TabIndex = 29
        Me.cbVenue.ValueMember = "VenueID"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(137, 165)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(41, 13)
        Me.lblVenue.TabIndex = 28
        Me.lblVenue.Text = "Venue:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(137, 233)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Time:"
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Location = New System.Drawing.Point(219, 227)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(200, 20)
        Me.dtpBooking.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
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
        'VenueDataSet
        '
        Me.VenueDataSet.DataSetName = "VenueDataSet"
        Me.VenueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VenueBindingSource3
        '
        Me.VenueBindingSource3.DataMember = "Venue"
        Me.VenueBindingSource3.DataSource = Me.VenueDataSet
        '
        'VenueTableAdapter1
        '
        Me.VenueTableAdapter1.ClearBeforeFill = True
        '
        'FrmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 555)
        Me.Controls.Add(Me.lstTimeslot)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbActivityType)
        Me.Controls.Add(Me.cbVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBooking)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBooking"
        Me.Text = "FrmBooking"
        CType(Me.VenueDSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VenueBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
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
End Class
