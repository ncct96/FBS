<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Venue
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEvent = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picVenue = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cboFromDay = New System.Windows.Forms.ComboBox()
        Me.cboToDay = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboToTime = New System.Windows.Forms.ComboBox()
        Me.cboFromTime = New System.Windows.Forms.ComboBox()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(314, 184)
        Me.txtName.Margin = New System.Windows.Forms.Padding(8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(315, 34)
        Me.txtName.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(314, 234)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(315, 34)
        Me.TextBox2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Available Days:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Available Time:"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(314, 384)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(8)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(315, 34)
        Me.txtRate.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Maximum Capacity:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Location = New System.Drawing.Point(314, 434)
        Me.txtCapacity.Margin = New System.Windows.Forms.Padding(8)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(315, 34)
        Me.txtCapacity.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Rate Per Hour"
        '
        'txtEvent
        '
        Me.txtEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvent.Location = New System.Drawing.Point(314, 484)
        Me.txtEvent.Margin = New System.Windows.Forms.Padding(8)
        Me.txtEvent.Name = "txtEvent"
        Me.txtEvent.Size = New System.Drawing.Size(315, 34)
        Me.txtEvent.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 29)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Recommended Event:"
        '
        'picVenue
        '
        Me.picVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVenue.Location = New System.Drawing.Point(662, 187)
        Me.picVenue.Name = "picVenue"
        Me.picVenue.Size = New System.Drawing.Size(462, 260)
        Me.picVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVenue.TabIndex = 22
        Me.picVenue.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(662, 463)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(225, 50)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(899, 463)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(225, 50)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "Add As New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(490, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 37)
        Me.ComboBox1.TabIndex = 26
        '
        'cboFromDay
        '
        Me.cboFromDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFromDay.FormattingEnabled = True
        Me.cboFromDay.Location = New System.Drawing.Point(314, 284)
        Me.cboFromDay.Margin = New System.Windows.Forms.Padding(8)
        Me.cboFromDay.Name = "cboFromDay"
        Me.cboFromDay.Size = New System.Drawing.Size(130, 37)
        Me.cboFromDay.TabIndex = 27
        '
        'cboToDay
        '
        Me.cboToDay.Enabled = False
        Me.cboToDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToDay.FormattingEnabled = True
        Me.cboToDay.Location = New System.Drawing.Point(499, 284)
        Me.cboToDay.Margin = New System.Windows.Forms.Padding(8)
        Me.cboToDay.Name = "cboToDay"
        Me.cboToDay.Size = New System.Drawing.Size(130, 37)
        Me.cboToDay.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(455, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "to"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 29)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "to"
        '
        'cboToTime
        '
        Me.cboToTime.Enabled = False
        Me.cboToTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToTime.FormattingEnabled = True
        Me.cboToTime.Location = New System.Drawing.Point(499, 334)
        Me.cboToTime.Margin = New System.Windows.Forms.Padding(8)
        Me.cboToTime.Name = "cboToTime"
        Me.cboToTime.Size = New System.Drawing.Size(130, 37)
        Me.cboToTime.TabIndex = 31
        '
        'cboFromTime
        '
        Me.cboFromTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFromTime.FormattingEnabled = True
        Me.cboFromTime.Location = New System.Drawing.Point(314, 334)
        Me.cboFromTime.Margin = New System.Windows.Forms.Padding(8)
        Me.cboFromTime.Name = "cboFromTime"
        Me.cboFromTime.Size = New System.Drawing.Size(130, 37)
        Me.cboFromTime.TabIndex = 30
        '
        'Admin_Venue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboToTime)
        Me.Controls.Add(Me.cboFromTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboToDay)
        Me.Controls.Add(Me.cboFromDay)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.picVenue)
        Me.Controls.Add(Me.txtEvent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Admin_Venue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Venue"
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEvent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents picVenue As PictureBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cboFromDay As ComboBox
    Friend WithEvents cboToDay As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboToTime As ComboBox
    Friend WithEvents cboFromTime As ComboBox
End Class
