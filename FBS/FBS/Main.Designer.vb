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
        Me.lblExit = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picVenue = New System.Windows.Forms.PictureBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.picView = New System.Windows.Forms.PictureBox()
        Me.lblView = New System.Windows.Forms.Label()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblName.Location = New System.Drawing.Point(57, 67)
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
        'lblExit
        '
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(772, 480)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(200, 62)
        Me.lblExit.TabIndex = 10
        Me.lblExit.Text = "Logout"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExit
        '
        Me.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExit.Image = Global.FBS.My.Resources.Resources._Exit
        Me.picExit.Location = New System.Drawing.Point(772, 280)
        Me.picExit.Margin = New System.Windows.Forms.Padding(16)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(200, 200)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picExit.TabIndex = 7
        Me.picExit.TabStop = False
        '
        'picVenue
        '
        Me.picVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVenue.Image = Global.FBS.My.Resources.Resources.Home
        Me.picVenue.Location = New System.Drawing.Point(308, 280)
        Me.picVenue.Margin = New System.Windows.Forms.Padding(16)
        Me.picVenue.Name = "picVenue"
        Me.picVenue.Size = New System.Drawing.Size(200, 200)
        Me.picVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picVenue.TabIndex = 13
        Me.picVenue.TabStop = False
        '
        'lblVenue
        '
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(308, 480)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(200, 62)
        Me.lblVenue.TabIndex = 14
        Me.lblVenue.Text = "View Facilities"
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picView
        '
        Me.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picView.Image = Global.FBS.My.Resources.Resources.Book
        Me.picView.Location = New System.Drawing.Point(540, 280)
        Me.picView.Margin = New System.Windows.Forms.Padding(16)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(200, 200)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picView.TabIndex = 12
        Me.picView.TabStop = False
        '
        'lblView
        '
        Me.lblView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(540, 480)
        Me.lblView.Margin = New System.Windows.Forms.Padding(0)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(200, 62)
        Me.lblView.TabIndex = 15
        Me.lblView.Text = "Make a Booking"
        Me.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.lblExit)
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
        Me.Text = "Main"
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents picVenue As PictureBox
    Friend WithEvents lblVenue As Label
    Friend WithEvents picView As PictureBox
    Friend WithEvents lblView As Label
End Class
