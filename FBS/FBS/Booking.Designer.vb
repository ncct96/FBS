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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.dtpBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWeekDayPrice = New System.Windows.Forms.Label()
        Me.lblWeekendPrice = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbActivityType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make a Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbTime
        '
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Location = New System.Drawing.Point(250, 309)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(121, 21)
        Me.cbTime.TabIndex = 1
        '
        'dtpBooking
        '
        Me.dtpBooking.Checked = False
        Me.dtpBooking.Location = New System.Drawing.Point(250, 272)
        Me.dtpBooking.MinDate = New Date(2019, 3, 18, 0, 0, 0, 0)
        Me.dtpBooking.Name = "dtpBooking"
        Me.dtpBooking.Size = New System.Drawing.Size(200, 20)
        Me.dtpBooking.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(168, 278)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(168, 210)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(41, 13)
        Me.lblVenue.TabIndex = 7
        Me.lblVenue.Text = "Venue:"
        '
        'cbVenue
        '
        Me.cbVenue.FormattingEnabled = True
        Me.cbVenue.Location = New System.Drawing.Point(250, 207)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(121, 21)
        Me.cbVenue.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWeekendPrice)
        Me.GroupBox1.Controls.Add(Me.lblWeekDayPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(682, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricing Details"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Weekend (Sat&&Sun):"
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
        'lblWeekendPrice
        '
        Me.lblWeekendPrice.AutoSize = True
        Me.lblWeekendPrice.Location = New System.Drawing.Point(142, 69)
        Me.lblWeekendPrice.Name = "lblWeekendPrice"
        Me.lblWeekendPrice.Size = New System.Drawing.Size(38, 13)
        Me.lblWeekendPrice.TabIndex = 3
        Me.lblWeekendPrice.Text = "Rm 10"
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(271, 418)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 11
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(405, 418)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(400, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Activity:"
        '
        'cbActivityType
        '
        Me.cbActivityType.FormattingEnabled = True
        Me.cbActivityType.Location = New System.Drawing.Point(250, 154)
        Me.cbActivityType.Name = "cbActivityType"
        Me.cbActivityType.Size = New System.Drawing.Size(121, 21)
        Me.cbActivityType.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Duration:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(250, 358)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(41, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "hour(s)"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 488)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbActivityType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBooking)
        Me.Controls.Add(Me.cbTime)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.Text = "LCW Facilities Booking Systen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbTime As ComboBox
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
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
