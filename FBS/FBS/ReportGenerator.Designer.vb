<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGenerator))
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnDetailed = New System.Windows.Forms.Button()
        Me.btnException = New System.Windows.Forms.Button()
        Me.ExceptionReport = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLessMore = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSummary
        '
        Me.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.Location = New System.Drawing.Point(174, 500)
        Me.btnSummary.Margin = New System.Windows.Forms.Padding(8)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(300, 80)
        Me.btnSummary.TabIndex = 0
        Me.btnSummary.Text = "Generate Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnDetailed
        '
        Me.btnDetailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetailed.Location = New System.Drawing.Point(490, 500)
        Me.btnDetailed.Margin = New System.Windows.Forms.Padding(8)
        Me.btnDetailed.Name = "btnDetailed"
        Me.btnDetailed.Size = New System.Drawing.Size(300, 80)
        Me.btnDetailed.TabIndex = 1
        Me.btnDetailed.Text = "Generate Detailed"
        Me.btnDetailed.UseVisualStyleBackColor = True
        '
        'btnException
        '
        Me.btnException.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnException.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnException.Location = New System.Drawing.Point(806, 500)
        Me.btnException.Margin = New System.Windows.Forms.Padding(8)
        Me.btnException.Name = "btnException"
        Me.btnException.Size = New System.Drawing.Size(300, 80)
        Me.btnException.TabIndex = 2
        Me.btnException.Text = "Generate Exception"
        Me.btnException.UseVisualStyleBackColor = True
        '
        'ExceptionReport
        '
        Me.ExceptionReport.OriginAtMargins = True
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.ShowIcon = False
        Me.dlgPrintPreview.UseAntiAlias = True
        Me.dlgPrintPreview.Visible = False
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 40)
        Me.btnBack.TabIndex = 62
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 67)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "List Facilities that have total bookings that are"
        '
        'cboLessMore
        '
        Me.cboLessMore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLessMore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLessMore.FormattingEnabled = True
        Me.cboLessMore.Items.AddRange(New Object() {"Less Than", "More Than"})
        Me.cboLessMore.Location = New System.Drawing.Point(11, 109)
        Me.cboLessMore.Margin = New System.Windows.Forms.Padding(8)
        Me.cboLessMore.Name = "cboLessMore"
        Me.cboLessMore.Size = New System.Drawing.Size(278, 37)
        Me.cboLessMore.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "overall"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(11, 162)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(8)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(182, 34)
        Me.txtAmount.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboLessMore)
        Me.GroupBox1.Location = New System.Drawing.Point(806, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 337)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'ReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnException)
        Me.Controls.Add(Me.btnDetailed)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportGenerator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSummary As Button
    Friend WithEvents btnDetailed As Button
    Friend WithEvents btnException As Button
    Friend WithEvents ExceptionReport As Printing.PrintDocument
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLessMore As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
