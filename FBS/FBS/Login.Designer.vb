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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.pwlbl = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.passwordCheck = New System.Windows.Forms.CheckBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(166, 68)
        Me.usernamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(130, 29)
        Me.usernamelbl.TabIndex = 1
        Me.usernamelbl.Text = "Username:"
        '
        'pwlbl
        '
        Me.pwlbl.AutoSize = True
        Me.pwlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwlbl.Location = New System.Drawing.Point(170, 117)
        Me.pwlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwlbl.Name = "pwlbl"
        Me.pwlbl.Size = New System.Drawing.Size(126, 29)
        Me.pwlbl.TabIndex = 2
        Me.pwlbl.Text = "Password:"
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(304, 69)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(207, 29)
        Me.usernametxt.TabIndex = 3
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(304, 118)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(4, 16, 4, 4)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(207, 29)
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
        Me.GroupBox1.Location = New System.Drawing.Point(340, 250)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(600, 300)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'passwordCheck
        '
        Me.passwordCheck.AutoSize = True
        Me.passwordCheck.Location = New System.Drawing.Point(304, 154)
        Me.passwordCheck.Name = "passwordCheck"
        Me.passwordCheck.Size = New System.Drawing.Size(167, 28)
        Me.passwordCheck.TabIndex = 7
        Me.passwordCheck.Text = "Show Password"
        Me.passwordCheck.UseVisualStyleBackColor = True
        '
        'registerbtn
        '
        Me.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn.Location = New System.Drawing.Point(304, 238)
        Me.registerbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(200, 50)
        Me.registerbtn.TabIndex = 6
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'loginbtn
        '
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.Location = New System.Drawing.Point(92, 238)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(8)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(200, 50)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.FBS.My.Resources.Resources.FBS
        Me.picLogo.Location = New System.Drawing.Point(532, 43)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(200, 200)
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usernamelbl As Label
    Friend WithEvents pwlbl As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents registerbtn As Button
    Friend WithEvents loginbtn As Button
    Friend WithEvents passwordCheck As CheckBox
    Friend WithEvents picLogo As PictureBox
End Class
