<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.pwlbl = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.passwordCheck = New System.Windows.Forms.CheckBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Page"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(73, 59)
        Me.usernamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(81, 18)
        Me.usernamelbl.TabIndex = 1
        Me.usernamelbl.Text = "Username:"
        '
        'pwlbl
        '
        Me.pwlbl.AutoSize = True
        Me.pwlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwlbl.Location = New System.Drawing.Point(73, 143)
        Me.pwlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwlbl.Name = "pwlbl"
        Me.pwlbl.Size = New System.Drawing.Size(79, 18)
        Me.pwlbl.TabIndex = 2
        Me.pwlbl.Text = "Password:"
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(189, 59)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(207, 24)
        Me.usernametxt.TabIndex = 3
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(189, 140)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(207, 24)
        Me.passwordtxt.TabIndex = 4
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.passwordCheck)
        Me.GroupBox1.Controls.Add(Me.registerbtn)
        Me.GroupBox1.Controls.Add(Me.loginbtn)
        Me.GroupBox1.Controls.Add(Me.passwordtxt)
        Me.GroupBox1.Controls.Add(Me.usernamelbl)
        Me.GroupBox1.Controls.Add(Me.usernametxt)
        Me.GroupBox1.Controls.Add(Me.pwlbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 67)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(471, 289)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'passwordCheck
        '
        Me.passwordCheck.AutoSize = True
        Me.passwordCheck.Location = New System.Drawing.Point(189, 171)
        Me.passwordCheck.Name = "passwordCheck"
        Me.passwordCheck.Size = New System.Drawing.Size(136, 22)
        Me.passwordCheck.TabIndex = 7
        Me.passwordCheck.Text = "Show Password"
        Me.passwordCheck.UseVisualStyleBackColor = True
        '
        'registerbtn
        '
        Me.registerbtn.Location = New System.Drawing.Point(270, 215)
        Me.registerbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(100, 28)
        Me.registerbtn.TabIndex = 6
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(87, 215)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(100, 28)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents pwlbl As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents registerbtn As Button
    Friend WithEvents loginbtn As Button
    Friend WithEvents passwordCheck As CheckBox
End Class
