<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingHistory
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
        Me.FBSMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodaysHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookingHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FBSMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FBSMenuStrip
        '
        Me.FBSMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.FBSMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FBSMenuStrip.Name = "FBSMenuStrip"
        Me.FBSMenuStrip.Size = New System.Drawing.Size(824, 24)
        Me.FBSMenuStrip.TabIndex = 0
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodaysHistoryToolStripMenuItem, Me.ViewBookingHistoryToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ViewToolStripMenuItem.Text = "Navigate"
        '
        'TodaysHistoryToolStripMenuItem
        '
        Me.TodaysHistoryToolStripMenuItem.Name = "TodaysHistoryToolStripMenuItem"
        Me.TodaysHistoryToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TodaysHistoryToolStripMenuItem.Text = "Make A Booking"
        '
        'ViewBookingHistoryToolStripMenuItem
        '
        Me.ViewBookingHistoryToolStripMenuItem.Name = "ViewBookingHistoryToolStripMenuItem"
        Me.ViewBookingHistoryToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ViewBookingHistoryToolStripMenuItem.Text = "View Booking History"
        '
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 473)
        Me.Controls.Add(Me.FBSMenuStrip)
        Me.MainMenuStrip = Me.FBSMenuStrip
        Me.Name = "BookingHistory"
        Me.Text = "Booking History"
        Me.FBSMenuStrip.ResumeLayout(False)
        Me.FBSMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FBSMenuStrip As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodaysHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBookingHistoryToolStripMenuItem As ToolStripMenuItem
End Class
