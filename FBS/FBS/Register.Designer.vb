<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.RegisterForm = New System.Windows.Forms.GroupBox()
        Me.passwShow = New System.Windows.Forms.CheckBox()
        Me.retypetxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phonetxt = New System.Windows.Forms.MaskedTextBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.phonelbl = New System.Windows.Forms.Label()
        Me.pwtxt = New System.Windows.Forms.TextBox()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.pwlbl = New System.Windows.Forms.Label()
        Me.unlbl = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.RegisterForm.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterForm
        '
        Me.RegisterForm.Controls.Add(Me.passwShow)
        Me.RegisterForm.Controls.Add(Me.retypetxt)
        Me.RegisterForm.Controls.Add(Me.Label1)
        Me.RegisterForm.Controls.Add(Me.phonetxt)
        Me.RegisterForm.Controls.Add(Me.registerbtn)
        Me.RegisterForm.Controls.Add(Me.cancelbtn)
        Me.RegisterForm.Controls.Add(Me.phonelbl)
        Me.RegisterForm.Controls.Add(Me.pwtxt)
        Me.RegisterForm.Controls.Add(Me.untxt)
        Me.RegisterForm.Controls.Add(Me.pwlbl)
        Me.RegisterForm.Controls.Add(Me.unlbl)
        Me.RegisterForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterForm.Location = New System.Drawing.Point(390, 250)
        Me.RegisterForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RegisterForm.Name = "RegisterForm"
        Me.RegisterForm.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RegisterForm.Size = New System.Drawing.Size(500, 390)
        Me.RegisterForm.TabIndex = 0
        Me.RegisterForm.TabStop = False
        '
        'passwShow
        '
        Me.passwShow.AutoSize = True
        Me.passwShow.Location = New System.Drawing.Point(254, 209)
        Me.passwShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwShow.Name = "passwShow"
        Me.passwShow.Size = New System.Drawing.Size(151, 24)
        Me.passwShow.TabIndex = 9
        Me.passwShow.Text = "Show Password"
        Me.passwShow.UseVisualStyleBackColor = True
        '
        'retypetxt
        '
        Me.retypetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypetxt.Location = New System.Drawing.Point(254, 167)
        Me.retypetxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.retypetxt.Name = "retypetxt"
        Me.retypetxt.Size = New System.Drawing.Size(180, 34)
        Me.retypetxt.TabIndex = 8
        Me.retypetxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Retype Password : "
        '
        'phonetxt
        '
        Me.phonetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonetxt.Location = New System.Drawing.Point(254, 249)
        Me.phonetxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.phonetxt.Mask = "000-0000000"
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(180, 34)
        Me.phonetxt.TabIndex = 6
        '
        'registerbtn
        '
        Me.registerbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerbtn.Location = New System.Drawing.Point(42, 314)
        Me.registerbtn.Margin = New System.Windows.Forms.Padding(4, 4, 8, 4)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(200, 50)
        Me.registerbtn.TabIndex = 1
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Location = New System.Drawing.Point(254, 314)
        Me.cancelbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(200, 50)
        Me.cancelbtn.TabIndex = 2
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonelbl.Location = New System.Drawing.Point(47, 252)
        Me.phonelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(205, 29)
        Me.phonelbl.TabIndex = 5
        Me.phonelbl.Text = "Contact Number : "
        '
        'pwtxt
        '
        Me.pwtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwtxt.Location = New System.Drawing.Point(254, 124)
        Me.pwtxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pwtxt.Name = "pwtxt"
        Me.pwtxt.Size = New System.Drawing.Size(180, 34)
        Me.pwtxt.TabIndex = 3
        Me.pwtxt.UseSystemPasswordChar = True
        '
        'untxt
        '
        Me.untxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.untxt.Location = New System.Drawing.Point(254, 82)
        Me.untxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(180, 34)
        Me.untxt.TabIndex = 2
        '
        'pwlbl
        '
        Me.pwlbl.AutoSize = True
        Me.pwlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwlbl.Location = New System.Drawing.Point(114, 127)
        Me.pwlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwlbl.Name = "pwlbl"
        Me.pwlbl.Size = New System.Drawing.Size(138, 29)
        Me.pwlbl.TabIndex = 1
        Me.pwlbl.Text = "Password : "
        '
        'unlbl
        '
        Me.unlbl.AutoSize = True
        Me.unlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unlbl.Location = New System.Drawing.Point(110, 85)
        Me.unlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.unlbl.Name = "unlbl"
        Me.unlbl.Size = New System.Drawing.Size(142, 29)
        Me.unlbl.TabIndex = 0
        Me.unlbl.Text = "Username : "
        '
        'picLogo
        '
        Me.picLogo.Image = Global.FBS.My.Resources.Resources.FBS
        Me.picLogo.Location = New System.Drawing.Point(532, 43)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(200, 200)
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'Register
        '
        Me.AcceptButton = Me.registerbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.cancelbtn
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.RegisterForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.RegisterForm.ResumeLayout(False)
        Me.RegisterForm.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterForm As GroupBox
    Friend WithEvents registerbtn As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents phonelbl As Label
    Friend WithEvents pwtxt As TextBox
    Friend WithEvents untxt As TextBox
    Friend WithEvents pwlbl As Label
    Friend WithEvents unlbl As Label
    Friend WithEvents phonetxt As MaskedTextBox
    Friend WithEvents passwShow As CheckBox
    Friend WithEvents retypetxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picLogo As PictureBox
End Class
