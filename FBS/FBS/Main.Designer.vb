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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblName.Location = New System.Drawing.Point(43, 54)
        Me.lblName.Margin = New System.Windows.Forms.Padding(36, 0, 36, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(861, 50)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Welcome back [Name]!"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(36, 0, 36, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(861, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What would you like to do today?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(579, 390)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(150, 50)
        Me.lblExit.TabIndex = 10
        Me.lblExit.Text = "Logout"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExit
        '
        Me.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picExit.Image = Global.FBS.My.Resources.Resources._Exit
        Me.picExit.Location = New System.Drawing.Point(579, 228)
        Me.picExit.Margin = New System.Windows.Forms.Padding(12, 13, 12, 13)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(150, 163)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picExit.TabIndex = 7
        Me.picExit.TabStop = False
        '
        'picVenue
        '
        Me.picVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVenue.Image = Global.FBS.My.Resources.Resources.Home
        Me.picVenue.Location = New System.Drawing.Point(231, 228)
        Me.picVenue.Margin = New System.Windows.Forms.Padding(12, 13, 12, 13)
        Me.picVenue.Name = "picVenue"
        Me.picVenue.Size = New System.Drawing.Size(150, 163)
        Me.picVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picVenue.TabIndex = 13
        Me.picVenue.TabStop = False
        '
        'lblVenue
        '
        Me.lblVenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(231, 390)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(150, 50)
        Me.lblVenue.TabIndex = 14
        Me.lblVenue.Text = "View Facilities"
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picView
        '
        Me.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picView.Image = Global.FBS.My.Resources.Resources.Book
        Me.picView.Location = New System.Drawing.Point(405, 228)
        Me.picView.Margin = New System.Windows.Forms.Padding(12, 13, 12, 13)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(150, 163)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picView.TabIndex = 12
        Me.picView.TabStop = False
        '
        'lblView
        '
        Me.lblView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(405, 390)
        Me.lblView.Margin = New System.Windows.Forms.Padding(0)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(150, 50)
        Me.lblView.TabIndex = 15
        Me.lblView.Text = "Make a Booking"
        Me.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Booking Management"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "User Management"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Update Payment Status"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
