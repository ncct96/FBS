<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VenueInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VenueInfo))
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.picVenue = New System.Windows.Forms.PictureBox()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReserve
        '
        Me.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.Location = New System.Drawing.Point(714, 448)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(462, 50)
        Me.btnReserve.TabIndex = 46
        Me.btnReserve.Text = "Make a reservation now!"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 29)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Recommended Event:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Rate Per Hour:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(122, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Maximum Capacity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(370, 195)
        Me.lblName.Margin = New System.Windows.Forms.Padding(8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(315, 30)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "Name"
        '
        'lblType
        '
        Me.lblType.AutoEllipsis = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(370, 241)
        Me.lblType.Margin = New System.Windows.Forms.Padding(8)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(315, 30)
        Me.lblType.TabIndex = 55
        Me.lblType.Text = "Type"
        '
        'lblRate
        '
        Me.lblRate.AutoEllipsis = True
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(370, 287)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(8)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(315, 30)
        Me.lblRate.TabIndex = 58
        Me.lblRate.Text = "Rate"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoEllipsis = True
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Location = New System.Drawing.Point(370, 333)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(8)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(315, 30)
        Me.lblCapacity.TabIndex = 59
        Me.lblCapacity.Text = "Capacity"
        '
        'lblEvent
        '
        Me.lblEvent.AutoEllipsis = True
        Me.lblEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(370, 379)
        Me.lblEvent.Margin = New System.Windows.Forms.Padding(8)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(315, 30)
        Me.lblEvent.TabIndex = 60
        Me.lblEvent.Text = "Event"
        '
        'picVenue
        '
        Me.picVenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVenue.Image = Global.FBS.My.Resources.Resources._66938284_p0
        Me.picVenue.Location = New System.Drawing.Point(714, 172)
        Me.picVenue.Name = "picVenue"
        Me.picVenue.Size = New System.Drawing.Size(462, 260)
        Me.picVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVenue.TabIndex = 45
        Me.picVenue.TabStop = False
        '
        'VenueInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.picVenue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VenueInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VenueInfo"
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReserve As Button
    Friend WithEvents picVenue As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblEvent As Label
End Class
