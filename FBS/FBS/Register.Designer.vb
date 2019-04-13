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
        Me.RegisterForm = New System.Windows.Forms.GroupBox()
        Me.phonetxt = New System.Windows.Forms.MaskedTextBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.phonelbl = New System.Windows.Forms.Label()
        Me.pwtxt = New System.Windows.Forms.TextBox()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.pwlbl = New System.Windows.Forms.Label()
        Me.unlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.retypetxt = New System.Windows.Forms.TextBox()
        Me.passwShow = New System.Windows.Forms.CheckBox()
        Me.RegisterForm.SuspendLayout()
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
        Me.RegisterForm.Location = New System.Drawing.Point(61, 21)
        Me.RegisterForm.Name = "RegisterForm"
        Me.RegisterForm.Size = New System.Drawing.Size(323, 319)
        Me.RegisterForm.TabIndex = 0
        Me.RegisterForm.TabStop = False
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(166, 196)
        Me.phonetxt.Mask = "000-0000000"
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(100, 22)
        Me.phonetxt.TabIndex = 6
        '
        'registerbtn
        '
        Me.registerbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.registerbtn.Location = New System.Drawing.Point(56, 255)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(75, 23)
        Me.registerbtn.TabIndex = 1
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelbtn.Location = New System.Drawing.Point(168, 255)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 2
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.Location = New System.Drawing.Point(35, 199)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(113, 16)
        Me.phonelbl.TabIndex = 5
        Me.phonelbl.Text = "Contact Number : "
        '
        'pwtxt
        '
        Me.pwtxt.Location = New System.Drawing.Point(166, 97)
        Me.pwtxt.Name = "pwtxt"
        Me.pwtxt.Size = New System.Drawing.Size(100, 22)
        Me.pwtxt.TabIndex = 3
        Me.pwtxt.UseSystemPasswordChar = True
        '
        'untxt
        '
        Me.untxt.Location = New System.Drawing.Point(166, 57)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(100, 22)
        Me.untxt.TabIndex = 2
        '
        'pwlbl
        '
        Me.pwlbl.AutoSize = True
        Me.pwlbl.Location = New System.Drawing.Point(54, 103)
        Me.pwlbl.Name = "pwlbl"
        Me.pwlbl.Size = New System.Drawing.Size(77, 16)
        Me.pwlbl.TabIndex = 1
        Me.pwlbl.Text = "Password : "
        '
        'unlbl
        '
        Me.unlbl.AutoSize = True
        Me.unlbl.Location = New System.Drawing.Point(54, 63)
        Me.unlbl.Name = "unlbl"
        Me.unlbl.Size = New System.Drawing.Size(80, 16)
        Me.unlbl.TabIndex = 0
        Me.unlbl.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Retype Password : "
        '
        'retypetxt
        '
        Me.retypetxt.Location = New System.Drawing.Point(166, 136)
        Me.retypetxt.Name = "retypetxt"
        Me.retypetxt.Size = New System.Drawing.Size(100, 22)
        Me.retypetxt.TabIndex = 8
        Me.retypetxt.UseSystemPasswordChar = True
        '
        'passwShow
        '
        Me.passwShow.AutoSize = True
        Me.passwShow.Location = New System.Drawing.Point(166, 164)
        Me.passwShow.Name = "passwShow"
        Me.passwShow.Size = New System.Drawing.Size(123, 20)
        Me.passwShow.TabIndex = 9
        Me.passwShow.Text = "Show Password"
        Me.passwShow.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AcceptButton = Me.registerbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelbtn
        Me.ClientSize = New System.Drawing.Size(448, 365)
        Me.Controls.Add(Me.RegisterForm)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.RegisterForm.ResumeLayout(False)
        Me.RegisterForm.PerformLayout()
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
End Class
