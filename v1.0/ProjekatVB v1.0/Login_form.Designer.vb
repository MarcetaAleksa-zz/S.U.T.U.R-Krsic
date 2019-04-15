<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_form))
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Username_Form_Box = New System.Windows.Forms.TextBox()
        Me.Password_Form_Box = New System.Windows.Forms.TextBox()
        Me.Label1_User = New System.Windows.Forms.Label()
        Me.Label2_Pass = New System.Windows.Forms.Label()
        Me.Guest_Login = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.ID_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(76, 108)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(185, 44)
        Me.Login_Button.TabIndex = 0
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Username_Form_Box
        '
        Me.Username_Form_Box.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Username_Form_Box.Location = New System.Drawing.Point(76, 23)
        Me.Username_Form_Box.Name = "Username_Form_Box"
        Me.Username_Form_Box.Size = New System.Drawing.Size(124, 20)
        Me.Username_Form_Box.TabIndex = 1
        Me.Username_Form_Box.Text = "Enter Username here"
        '
        'Password_Form_Box
        '
        Me.Password_Form_Box.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Password_Form_Box.Location = New System.Drawing.Point(76, 61)
        Me.Password_Form_Box.Name = "Password_Form_Box"
        Me.Password_Form_Box.Size = New System.Drawing.Size(124, 20)
        Me.Password_Form_Box.TabIndex = 2
        Me.Password_Form_Box.Text = "Enter Password here"
        '
        'Label1_User
        '
        Me.Label1_User.AutoSize = True
        Me.Label1_User.Location = New System.Drawing.Point(12, 26)
        Me.Label1_User.Name = "Label1_User"
        Me.Label1_User.Size = New System.Drawing.Size(58, 13)
        Me.Label1_User.TabIndex = 3
        Me.Label1_User.Text = "Username:"
        '
        'Label2_Pass
        '
        Me.Label2_Pass.AutoSize = True
        Me.Label2_Pass.Location = New System.Drawing.Point(9, 61)
        Me.Label2_Pass.Name = "Label2_Pass"
        Me.Label2_Pass.Size = New System.Drawing.Size(56, 13)
        Me.Label2_Pass.TabIndex = 4
        Me.Label2_Pass.Text = "Password:"
        '
        'Guest_Login
        '
        Me.Guest_Login.Location = New System.Drawing.Point(12, 111)
        Me.Guest_Login.Name = "Guest_Login"
        Me.Guest_Login.Size = New System.Drawing.Size(53, 38)
        Me.Guest_Login.TabIndex = 5
        Me.Guest_Login.Text = "Guest"
        Me.Guest_Login.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(74, 166)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 6
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'ID_Label
        '
        Me.ID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Label.Location = New System.Drawing.Point(133, 48)
        Me.ID_Label.Name = "ID_Label"
        Me.ID_Label.Size = New System.Drawing.Size(10, 10)
        Me.ID_Label.TabIndex = 7
        '
        'Login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 213)
        Me.Controls.Add(Me.ID_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Guest_Login)
        Me.Controls.Add(Me.Label2_Pass)
        Me.Controls.Add(Me.Label1_User)
        Me.Controls.Add(Me.Password_Form_Box)
        Me.Controls.Add(Me.Username_Form_Box)
        Me.Controls.Add(Me.Login_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_Button As Button
    Friend WithEvents Username_Form_Box As TextBox
    Friend WithEvents Password_Form_Box As TextBox
    Friend WithEvents Label1_User As Label
    Friend WithEvents Label2_Pass As Label
    Friend WithEvents Guest_Login As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents ID_Label As Label
End Class
