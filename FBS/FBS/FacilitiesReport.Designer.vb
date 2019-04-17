<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacilitiesReport
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
        Me.FacilitiesReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'FacilitiesReportViewer
        '
        Me.FacilitiesReportViewer.ActiveViewIndex = -1
        Me.FacilitiesReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FacilitiesReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.FacilitiesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacilitiesReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.FacilitiesReportViewer.Name = "FacilitiesReportViewer"
        Me.FacilitiesReportViewer.Size = New System.Drawing.Size(800, 450)
        Me.FacilitiesReportViewer.TabIndex = 0
        '
        'FacilitiesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FacilitiesReportViewer)
        Me.Name = "FacilitiesReport"
        Me.Text = "FacilitiesReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FacilitiesReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
