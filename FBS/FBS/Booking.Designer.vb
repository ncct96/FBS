<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenueDS = New FBS.VenueDS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWeekendPrice = New System.Windows.Forms.Label()
        Me.lblWeekDayPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbActivityType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VenueTableAdapter = New FBS.VenueDSTableAdapters.VenueTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make a Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Location = New System.Drawing.Point(242, 235)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(200, 20)
        Me.dtpBooking.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(160, 241)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(160, 173)
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
        Me.cbVenue.Location = New System.Drawing.Point(242, 170)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWeekendPrice)
        Me.GroupBox1.Controls.Add(Me.lblWeekDayPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(834, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricing Details"
        '
        'lblWeekendPrice
        '
        Me.lblWeekendPrice.AutoSize = True
        Me.lblWeekendPrice.Location = New System.Drawing.Point(142, 69)
        Me.lblWeekendPrice.Name = "lblWeekendPrice"
        Me.lblWeekendPrice.Size = New System.Drawing.Size(38, 13)
        Me.lblWeekendPrice.TabIndex = 3
        Me.lblWeekendPrice.Text = "Rm 10"
        '
        'lblWeekDayPrice
        '
        Me.lblWeekDayPrice.AutoSize = True
        Me.lblWeekDayPrice.Location = New System.Drawing.Point(142, 32)
        Me.lblWeekDayPrice.Name = "lblWeekDayPrice"
        Me.lblWeekDayPrice.Size = New System.Drawing.Size(38, 13)
        Me.lblWeekDayPrice.TabIndex = 2
        Me.lblWeekDayPrice.Text = "Rm 10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Weekend (Sat&&Sun):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Weekdays (Mon-Fri):"
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(311, 553)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 11
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(425, 553)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(481, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 120)
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
        Me.cbActivityType.Location = New System.Drawing.Point(242, 117)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(121, 21)
        Me.cbActivityType.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "hour(s)"
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
        Me.lblPrice.Location = New System.Drawing.Point(95, 31)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(26, 15)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "RM"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Location = New System.Drawing.Point(369, 173)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(26, 15)
        Me.lblRate.TabIndex = 20
        Me.lblRate.Text = "RM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(429, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "per hour"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 401)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 122)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Summary"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.888889!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.777778!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.07407!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.957416!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.076358!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.370044!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.076358!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.929515!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.076358!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.223201!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.240224!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.379889!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox7, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox8, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox9, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox10, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox11, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox12, 10, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox13, 11, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox12, 11, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(242, 305)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.50794!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.49206!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 63)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(600, 3)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(51, 20)
        Me.TextBox11.TabIndex = 22
        Me.TextBox11.Text = "7pm-8pm"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(543, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(50, 20)
        Me.TextBox10.TabIndex = 21
        Me.TextBox10.Text = "6pm-7pm"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(487, 3)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(50, 20)
        Me.TextBox9.TabIndex = 20
        Me.TextBox9.Text = "5pm-6pm"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(432, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(49, 20)
        Me.TextBox8.TabIndex = 19
        Me.TextBox8.Text = "4pm-5pm"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(376, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(50, 20)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.Text = "3pm-4pm"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(318, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(49, 20)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.Text = "2pm-3pm"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(262, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(50, 20)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Text = "1pm-2pm"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(200, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.TabIndex = 15
        Me.TextBox4.Text = "12pm-1pm"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(131, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 20)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "11am-12pm"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(64, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 20)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "10am-11am"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(3, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 34)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(64, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 34)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(131, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 34)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(200, 26)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(55, 34)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(262, 26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 34)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(318, 26)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(49, 34)
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(432, 26)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(49, 34)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(376, 26)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 34)
        Me.PictureBox9.TabIndex = 7
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(543, 26)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(50, 34)
        Me.PictureBox10.TabIndex = 8
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(487, 26)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(50, 34)
        Me.PictureBox11.TabIndex = 9
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(600, 26)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(51, 34)
        Me.PictureBox12.TabIndex = 10
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Location = New System.Drawing.Point(657, 26)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(56, 34)
        Me.PictureBox13.TabIndex = 11
        Me.PictureBox13.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(55, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "9am-10am"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(657, 3)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(49, 20)
        Me.TextBox12.TabIndex = 23
        Me.TextBox12.Text = "8pm-9pm"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 595)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbActivityType)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWeekendPrice As Label
    Friend WithEvents lblWeekDayPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbActivityType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VenueDS As VenueDS
    Friend WithEvents VenueBindingSource As BindingSource
    Friend WithEvents VenueTableAdapter As VenueDSTableAdapters.VenueTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox12 As TextBox
End Class
