<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChange
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oldpasswTxt = New System.Windows.Forms.TextBox()
        Me.newpasswTxt = New System.Windows.Forms.TextBox()
        Me.repasswTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cancelBtn)
        Me.GroupBox1.Controls.Add(Me.confirmBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.repasswTxt)
        Me.GroupBox1.Controls.Add(Me.newpasswTxt)
        Me.GroupBox1.Controls.Add(Me.oldpasswTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'oldpasswTxt
        '
        Me.oldpasswTxt.Location = New System.Drawing.Point(115, 36)
        Me.oldpasswTxt.Name = "oldpasswTxt"
        Me.oldpasswTxt.Size = New System.Drawing.Size(100, 20)
        Me.oldpasswTxt.TabIndex = 0
        '
        'newpasswTxt
        '
        Me.newpasswTxt.Location = New System.Drawing.Point(115, 71)
        Me.newpasswTxt.Name = "newpasswTxt"
        Me.newpasswTxt.Size = New System.Drawing.Size(100, 20)
        Me.newpasswTxt.TabIndex = 1
        '
        'repasswTxt
        '
        Me.repasswTxt.Location = New System.Drawing.Point(115, 102)
        Me.repasswTxt.Name = "repasswTxt"
        Me.repasswTxt.Size = New System.Drawing.Size(100, 20)
        Me.repasswTxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Old Password : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Retype Password :"
        '
        'confirmBtn
        '
        Me.confirmBtn.Location = New System.Drawing.Point(43, 137)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(75, 23)
        Me.confirmBtn.TabIndex = 6
        Me.confirmBtn.Text = "Confirm"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(124, 137)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 7
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PasswordChange"
        Me.Text = "PasswordChange"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents repasswTxt As TextBox
    Friend WithEvents newpasswTxt As TextBox
    Friend WithEvents oldpasswTxt As TextBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents confirmBtn As Button
End Class
