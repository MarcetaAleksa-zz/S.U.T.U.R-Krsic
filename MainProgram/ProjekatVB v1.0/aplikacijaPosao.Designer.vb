<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aplikacijaPosao
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aplikacijaPosao))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UR_Birth_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UR_Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UR_Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UR_Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.UR_ConfirmPassword_Textbox = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.UR_Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.UR_Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.A_Register_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.URComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 68)
        Me.Panel3.TabIndex = 11
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(219, 26)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(355, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "OBRAZAC ZA PRIJAVU NA POSAO"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel4.Controls.Add(Me.UR_Birth_TextBox)
        Me.Panel4.Location = New System.Drawing.Point(258, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 26)
        Me.Panel4.TabIndex = 15
        '
        'UR_Birth_TextBox
        '
        Me.UR_Birth_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Birth_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Birth_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Birth_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Birth_TextBox.Name = "UR_Birth_TextBox"
        Me.UR_Birth_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Birth_TextBox.TabIndex = 114
        Me.UR_Birth_TextBox.Text = "Unesi datum rođenja ovde"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.UR_Surname_TextBox)
        Me.Panel2.Location = New System.Drawing.Point(258, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 26)
        Me.Panel2.TabIndex = 14
        '
        'UR_Surname_TextBox
        '
        Me.UR_Surname_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Surname_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Surname_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Surname_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Surname_TextBox.Name = "UR_Surname_TextBox"
        Me.UR_Surname_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Surname_TextBox.TabIndex = 113
        Me.UR_Surname_TextBox.Text = "Unesi prezime ovde"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Location = New System.Drawing.Point(258, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 26)
        Me.Panel5.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.Location = New System.Drawing.Point(15, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 13)
        Me.TextBox1.TabIndex = 112
        Me.TextBox1.Text = "Unesi ime ovde"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel7.Controls.Add(Me.UR_Email_TextBox)
        Me.Panel7.Location = New System.Drawing.Point(258, 152)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(220, 26)
        Me.Panel7.TabIndex = 17
        '
        'UR_Email_TextBox
        '
        Me.UR_Email_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Email_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Email_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Email_TextBox.Name = "UR_Email_TextBox"
        Me.UR_Email_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Email_TextBox.TabIndex = 117
        Me.UR_Email_TextBox.Text = "Unesi E-mail ovde"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel6.Controls.Add(Me.UR_Phone_TextBox)
        Me.Panel6.Location = New System.Drawing.Point(258, 120)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(220, 26)
        Me.Panel6.TabIndex = 16
        '
        'UR_Phone_TextBox
        '
        Me.UR_Phone_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Phone_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Phone_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Phone_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Phone_TextBox.Name = "UR_Phone_TextBox"
        Me.UR_Phone_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Phone_TextBox.TabIndex = 116
        Me.UR_Phone_TextBox.Text = "Unesi broj telefona ovde"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel11.Controls.Add(Me.UR_ConfirmPassword_Textbox)
        Me.Panel11.Location = New System.Drawing.Point(258, 294)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(220, 26)
        Me.Panel11.TabIndex = 20
        '
        'UR_ConfirmPassword_Textbox
        '
        Me.UR_ConfirmPassword_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_ConfirmPassword_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_ConfirmPassword_Textbox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_ConfirmPassword_Textbox.Location = New System.Drawing.Point(15, 7)
        Me.UR_ConfirmPassword_Textbox.Name = "UR_ConfirmPassword_Textbox"
        Me.UR_ConfirmPassword_Textbox.Size = New System.Drawing.Size(189, 13)
        Me.UR_ConfirmPassword_Textbox.TabIndex = 120
        Me.UR_ConfirmPassword_Textbox.Text = "Potvrdi lozinku"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel10.Controls.Add(Me.UR_Password_TextBox)
        Me.Panel10.Location = New System.Drawing.Point(258, 262)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(220, 26)
        Me.Panel10.TabIndex = 19
        '
        'UR_Password_TextBox
        '
        Me.UR_Password_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Password_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Password_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Password_TextBox.Name = "UR_Password_TextBox"
        Me.UR_Password_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Password_TextBox.TabIndex = 119
        Me.UR_Password_TextBox.Text = "Unesi lozinku ovde"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.UR_Username_TextBox)
        Me.Panel9.Location = New System.Drawing.Point(258, 230)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(220, 26)
        Me.Panel9.TabIndex = 18
        '
        'UR_Username_TextBox
        '
        Me.UR_Username_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UR_Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UR_Username_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UR_Username_TextBox.Location = New System.Drawing.Point(15, 7)
        Me.UR_Username_TextBox.Name = "UR_Username_TextBox"
        Me.UR_Username_TextBox.Size = New System.Drawing.Size(189, 13)
        Me.UR_Username_TextBox.TabIndex = 118
        Me.UR_Username_TextBox.Text = "Unesi korisničko ime ovde"
        '
        'Back_Button
        '
        Me.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back_Button.Location = New System.Drawing.Point(368, 335)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(108, 31)
        Me.Back_Button.TabIndex = 129
        Me.Back_Button.Text = "Nazad"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'A_Register_Button
        '
        Me.A_Register_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.A_Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A_Register_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A_Register_Button.Location = New System.Drawing.Point(258, 335)
        Me.A_Register_Button.Name = "A_Register_Button"
        Me.A_Register_Button.Size = New System.Drawing.Size(108, 31)
        Me.A_Register_Button.TabIndex = 128
        Me.A_Register_Button.Text = "Apliciraj"
        Me.A_Register_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 40)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Back_Button)
        Me.Panel1.Controls.Add(Me.A_Register_Button)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(3, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 446)
        Me.Panel1.TabIndex = 133
        Me.Panel1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "*Nikada svoju lozinku ne dijelite sa nekim."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(320, 138)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 134
        Me.CheckBox1.Text = "Saglasan sam"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel8.Controls.Add(Me.URComboBox)
        Me.Panel8.Location = New System.Drawing.Point(258, 198)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(82, 26)
        Me.Panel8.TabIndex = 131
        '
        'URComboBox
        '
        Me.URComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.URComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.URComboBox.FormattingEnabled = True
        Me.URComboBox.Items.AddRange(New Object() {"Muški", "Ženski"})
        Me.URComboBox.Location = New System.Drawing.Point(3, 2)
        Me.URComboBox.Name = "URComboBox"
        Me.URComboBox.Size = New System.Drawing.Size(79, 21)
        Me.URComboBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Izaberi pol:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(22, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 35)
        Me.Button1.TabIndex = 135
        Me.Button1.UseVisualStyleBackColor = True
        '
        'aplikacijaPosao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "aplikacijaPosao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "aplikacijaPosao"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UR_Birth_TextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UR_Surname_TextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UR_Email_TextBox As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents UR_Phone_TextBox As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents UR_ConfirmPassword_Textbox As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents UR_Password_TextBox As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents UR_Username_TextBox As TextBox
    Friend WithEvents Back_Button As Button
    Friend WithEvents A_Register_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents URComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
