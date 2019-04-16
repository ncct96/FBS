<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.acceptBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.updateDateTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date :"
        '
        'acceptBtn
        '
        Me.acceptBtn.Location = New System.Drawing.Point(47, 94)
        Me.acceptBtn.Name = "acceptBtn"
        Me.acceptBtn.Size = New System.Drawing.Size(75, 23)
        Me.acceptBtn.TabIndex = 4
        Me.acceptBtn.Text = "Accept"
        Me.acceptBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(153, 94)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 5
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'updateDateTime
        '
        Me.updateDateTime.Location = New System.Drawing.Point(59, 41)
        Me.updateDateTime.Name = "updateDateTime"
        Me.updateDateTime.Size = New System.Drawing.Size(200, 20)
        Me.updateDateTime.TabIndex = 6
        '
        'PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 144)
        Me.Controls.Add(Me.updateDateTime)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.acceptBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PopUp"
        Me.Text = "PopUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents acceptBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents updateDateTime As DateTimePicker
End Class
