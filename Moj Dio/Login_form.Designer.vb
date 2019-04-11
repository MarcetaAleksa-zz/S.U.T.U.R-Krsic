<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_form))
        Me.Login = New System.Windows.Forms.Button()
        Me.TextBox1_User = New System.Windows.Forms.TextBox()
        Me.TextBox2_Pass = New System.Windows.Forms.TextBox()
        Me.Label1_User = New System.Windows.Forms.Label()
        Me.Label2_Pass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(115, 171)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(163, 44)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'TextBox1_User
        '
        Me.TextBox1_User.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1_User.Location = New System.Drawing.Point(176, 69)
        Me.TextBox1_User.Name = "TextBox1_User"
        Me.TextBox1_User.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1_User.TabIndex = 1
        '
        'TextBox2_Pass
        '
        Me.TextBox2_Pass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2_Pass.Location = New System.Drawing.Point(176, 117)
        Me.TextBox2_Pass.Name = "TextBox2_Pass"
        Me.TextBox2_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2_Pass.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2_Pass.TabIndex = 2
        '
        'Label1_User
        '
        Me.Label1_User.AutoSize = True
        Me.Label1_User.Location = New System.Drawing.Point(112, 69)
        Me.Label1_User.Name = "Label1_User"
        Me.Label1_User.Size = New System.Drawing.Size(58, 13)
        Me.Label1_User.TabIndex = 3
        Me.Label1_User.Text = "Username:"
        '
        'Label2_Pass
        '
        Me.Label2_Pass.AutoSize = True
        Me.Label2_Pass.Location = New System.Drawing.Point(114, 117)
        Me.Label2_Pass.Name = "Label2_Pass"
        Me.Label2_Pass.Size = New System.Drawing.Size(56, 13)
        Me.Label2_Pass.TabIndex = 4
        Me.Label2_Pass.Text = "Password:"
        '
        'Login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 299)
        Me.Controls.Add(Me.Label2_Pass)
        Me.Controls.Add(Me.Label1_User)
        Me.Controls.Add(Me.TextBox2_Pass)
        Me.Controls.Add(Me.TextBox1_User)
        Me.Controls.Add(Me.Login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_form"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents TextBox1_User As TextBox
    Friend WithEvents TextBox2_Pass As TextBox
    Friend WithEvents Label1_User As Label
    Friend WithEvents Label2_Pass As Label
End Class
