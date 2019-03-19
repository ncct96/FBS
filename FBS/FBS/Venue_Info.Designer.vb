<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venue_Info
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
        Me.lbl_item1 = New System.Windows.Forms.Label()
        Me.lbl_item2 = New System.Windows.Forms.Label()
        Me.btn_reserve = New System.Windows.Forms.Button()
        Me.lbl_item3 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_people = New System.Windows.Forms.Label()
        Me.lbl_recommend = New System.Windows.Forms.Label()
        Me.picture_venue = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.picture_venue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_item1
        '
        Me.lbl_item1.AutoSize = True
        Me.lbl_item1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item1.Location = New System.Drawing.Point(334, 453)
        Me.lbl_item1.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_item1.Name = "lbl_item1"
        Me.lbl_item1.Size = New System.Drawing.Size(155, 29)
        Me.lbl_item1.TabIndex = 2
        Me.lbl_item1.Text = "Available On:"
        '
        'lbl_item2
        '
        Me.lbl_item2.AutoSize = True
        Me.lbl_item2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item2.Location = New System.Drawing.Point(334, 498)
        Me.lbl_item2.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_item2.Name = "lbl_item2"
        Me.lbl_item2.Size = New System.Drawing.Size(220, 29)
        Me.lbl_item2.TabIndex = 3
        Me.lbl_item2.Text = "Maximum Capacity:"
        '
        'btn_reserve
        '
        Me.btn_reserve.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_reserve.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btn_reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reserve.Location = New System.Drawing.Point(515, 621)
        Me.btn_reserve.Name = "btn_reserve"
        Me.btn_reserve.Size = New System.Drawing.Size(250, 40)
        Me.btn_reserve.TabIndex = 4
        Me.btn_reserve.Text = "Reserve Now!"
        Me.btn_reserve.UseVisualStyleBackColor = False
        '
        'lbl_item3
        '
        Me.lbl_item3.AutoSize = True
        Me.lbl_item3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item3.Location = New System.Drawing.Point(334, 543)
        Me.lbl_item3.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_item3.Name = "lbl_item3"
        Me.lbl_item3.Size = New System.Drawing.Size(257, 29)
        Me.lbl_item3.TabIndex = 10
        Me.lbl_item3.Text = "Recommended Events"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(607, 453)
        Me.lbl_time.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(322, 29)
        Me.lbl_time.TabIndex = 11
        Me.lbl_time.Text = ": Monday - Friday, 6am - 6pm"
        '
        'lbl_people
        '
        Me.lbl_people.AutoSize = True
        Me.lbl_people.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_people.Location = New System.Drawing.Point(607, 498)
        Me.lbl_people.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_people.Name = "lbl_people"
        Me.lbl_people.Size = New System.Drawing.Size(133, 29)
        Me.lbl_people.TabIndex = 12
        Me.lbl_people.Text = ": 64 people"
        '
        'lbl_recommend
        '
        Me.lbl_recommend.AutoSize = True
        Me.lbl_recommend.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recommend.Location = New System.Drawing.Point(607, 543)
        Me.lbl_recommend.Margin = New System.Windows.Forms.Padding(8)
        Me.lbl_recommend.Name = "lbl_recommend"
        Me.lbl_recommend.Size = New System.Drawing.Size(162, 29)
        Me.lbl_recommend.TabIndex = 13
        Me.lbl_recommend.Text = ": Burger frying"
        '
        'picture_venue
        '
        Me.picture_venue.Image = Global.FBS.My.Resources.Resources._1200px_Donald_Trump_official_portrait
        Me.picture_venue.Location = New System.Drawing.Point(340, 24)
        Me.picture_venue.Name = "picture_venue"
        Me.picture_venue.Size = New System.Drawing.Size(600, 400)
        Me.picture_venue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picture_venue.TabIndex = 6
        Me.picture_venue.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_back.FlatAppearance.BorderSize = 2
        Me.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(13, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(50, 50)
        Me.btn_back.TabIndex = 14
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Venue_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_recommend)
        Me.Controls.Add(Me.lbl_people)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_item3)
        Me.Controls.Add(Me.picture_venue)
        Me.Controls.Add(Me.btn_reserve)
        Me.Controls.Add(Me.lbl_item2)
        Me.Controls.Add(Me.lbl_item1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Venue_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venue_Info"
        CType(Me.picture_venue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_item1 As Label
    Friend WithEvents lbl_item2 As Label
    Friend WithEvents btn_reserve As Button
    Friend WithEvents picture_venue As PictureBox
    Friend WithEvents lbl_item3 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_people As Label
    Friend WithEvents lbl_recommend As Label
    Friend WithEvents btn_back As Button
End Class
