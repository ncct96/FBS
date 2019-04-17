<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblView = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblBooking = New System.Windows.Forms.Label()
        Me.picBooking = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picView = New System.Windows.Forms.PictureBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picVenue = New System.Windows.Forms.PictureBox()
        CType(Me.picBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblName.Location = New System.Drawing.Point(57, 66)
        Me.lblName.Margin = New System.Windows.Forms.Padding(48, 0, 48, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(1148, 62)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Welcome back [Name]!"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(48, 0, 48, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1148, 49)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What would you like to do today?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVenue
        '
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(185, 481)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(200, 62)
        Me.lblVenue.TabIndex = 14
        Me.lblVenue.Text = "View Facilities"
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblView
        '
        Me.lblView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(647, 481)
        Me.lblView.Margin = New System.Windows.Forms.Padding(0)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(200, 62)
        Me.lblView.TabIndex = 15
        Me.lblView.Text = "Booking History"
        Me.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(878, 481)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(200, 62)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "picManagement"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBooking
        '
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.Location = New System.Drawing.Point(416, 481)
        Me.lblBooking.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(200, 62)
        Me.lblBooking.TabIndex = 22
        Me.lblBooking.Text = "Make Booking"
        Me.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBooking
        '
        Me.picBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBooking.Image = Global.FBS.My.Resources.Resources.Book
        Me.picBooking.Location = New System.Drawing.Point(417, 280)
        Me.picBooking.Margin = New System.Windows.Forms.Padding(16)
        Me.picBooking.Name = "picBooking"
        Me.picBooking.Size = New System.Drawing.Size(199, 200)
        Me.picBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBooking.TabIndex = 21
        Me.picBooking.TabStop = False
        '
        'picUser
        '
        Me.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser.Image = Global.FBS.My.Resources.Resources.User
        Me.picUser.Location = New System.Drawing.Point(879, 281)
        Me.picUser.Margin = New System.Windows.Forms.Padding(16)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(199, 200)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picUser.TabIndex = 19
        Me.picUser.TabStop = False
        '
        'picView
        '
        Me.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picView.Image = Global.FBS.My.Resources.Resources.Time
        Me.picView.Location = New System.Drawing.Point(648, 280)
        Me.picView.Margin = New System.Windows.Forms.Padding(16)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(199, 200)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picView.TabIndex = 12
        Me.picView.TabStop = False
        '
        'picExit
        '
        Me.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExit.Image = Global.FBS.My.Resources.Resources._Exit
        Me.picExit.Location = New System.Drawing.Point(1187, 25)
        Me.picExit.Margin = New System.Windows.Forms.Padding(16)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(50, 50)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 7
        Me.picExit.TabStop = False
        '
        'picVenue
        '
        Me.picVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVenue.Image = Global.FBS.My.Resources.Resources.Home
        Me.picVenue.Location = New System.Drawing.Point(186, 280)
        Me.picVenue.Margin = New System.Windows.Forms.Padding(16)
        Me.picVenue.Name = "picVenue"
        Me.picVenue.Size = New System.Drawing.Size(199, 200)
        Me.picVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picVenue.TabIndex = 13
        Me.picVenue.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lblBooking)
        Me.Controls.Add(Me.picBooking)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.picView)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picVenue)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.picBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picExit As PictureBox
    Friend WithEvents picVenue As PictureBox
    Friend WithEvents lblVenue As Label
    Friend WithEvents picView As PictureBox
    Friend WithEvents lblView As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents lblBooking As Label
    Friend WithEvents picBooking As PictureBox
End Class
