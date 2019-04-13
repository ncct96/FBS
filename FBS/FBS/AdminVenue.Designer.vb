<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminVenue
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
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEvent = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picVenue = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(314, 199)
        Me.txtName.Margin = New System.Windows.Forms.Padding(8)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(315, 34)
        Me.txtName.TabIndex = 9
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(314, 249)
        Me.txtType.Margin = New System.Windows.Forms.Padding(8)
        Me.txtType.MaxLength = 30
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(315, 34)
        Me.txtType.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Type:"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(314, 299)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(8)
        Me.txtRate.MaxLength = 10
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(315, 34)
        Me.txtRate.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Maximum Capacity:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Location = New System.Drawing.Point(314, 349)
        Me.txtCapacity.Margin = New System.Windows.Forms.Padding(8)
        Me.txtCapacity.MaxLength = 5
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(315, 34)
        Me.txtCapacity.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Rate Per Hour"
        '
        'txtEvent
        '
        Me.txtEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvent.Location = New System.Drawing.Point(314, 399)
        Me.txtEvent.Margin = New System.Windows.Forms.Padding(8)
        Me.txtEvent.Name = "txtEvent"
        Me.txtEvent.Size = New System.Drawing.Size(315, 34)
        Me.txtEvent.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 402)
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
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(662, 463)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(225, 50)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Reset"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboID
        '
        Me.cboID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(490, 33)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(300, 37)
        Me.cboID.TabIndex = 26
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(899, 463)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(225, 50)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Add As New"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'AdminVenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.picVenue)
        Me.Controls.Add(Me.txtEvent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AdminVenue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Venue"
        CType(Me.picVenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEvent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents picVenue As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboID As ComboBox
    Friend WithEvents btnUpdate As Button
End Class
