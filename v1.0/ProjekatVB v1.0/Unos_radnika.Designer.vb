<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnosRadnika
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnosRadnika))
        Me.UR_Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Possition_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Possition_Label = New System.Windows.Forms.Label()
        Me.UR_Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Phone_label = New System.Windows.Forms.Label()
        Me.UR_Picture = New System.Windows.Forms.PictureBox()
        Me.UR_Username_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Birth_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Email_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Name_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_Username_Label = New System.Windows.Forms.Label()
        Me.UR_Birth_Label = New System.Windows.Forms.Label()
        Me.UR_Email_Label = New System.Windows.Forms.Label()
        Me.UR_SName_Label = New System.Windows.Forms.Label()
        Me.UR_Name_Label = New System.Windows.Forms.Label()
        Me.UR_Password_Label = New System.Windows.Forms.Label()
        Me.UR_Password_TextBox = New System.Windows.Forms.TextBox()
        Me.UR_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.UR_ChangePicture_Button = New System.Windows.Forms.Button()
        Me.UR_FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.UR_NoFile_Label = New System.Windows.Forms.Label()
        Me.UR_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.UR_ChooseImage_Label = New System.Windows.Forms.Label()
        Me.UR_ClearImage_Button = New System.Windows.Forms.Button()
        Me.UR_ConfirmPassword_Label = New System.Windows.Forms.Label()
        Me.UR_ConfirmPassword_Textbox = New System.Windows.Forms.TextBox()
        Me.UR_Male_Button = New System.Windows.Forms.RadioButton()
        Me.UR_Female_Button = New System.Windows.Forms.RadioButton()
        Me.A_Register_Button = New System.Windows.Forms.Button()
        Me.UR_Admin_Button = New System.Windows.Forms.RadioButton()
        Me.UR_User_Button = New System.Windows.Forms.RadioButton()
        Me.UR_AT_GroupBox = New System.Windows.Forms.GroupBox()
        Me.UR_Gender_GroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.UR_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UR_AT_GroupBox.SuspendLayout()
        Me.UR_Gender_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UR_Phone_TextBox
        '
        Me.UR_Phone_TextBox.Location = New System.Drawing.Point(87, 174)
        Me.UR_Phone_TextBox.Name = "UR_Phone_TextBox"
        Me.UR_Phone_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Phone_TextBox.TabIndex = 25
        '
        'UR_Possition_TextBox
        '
        Me.UR_Possition_TextBox.Location = New System.Drawing.Point(87, 144)
        Me.UR_Possition_TextBox.Name = "UR_Possition_TextBox"
        Me.UR_Possition_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Possition_TextBox.TabIndex = 24
        '
        'UR_Possition_Label
        '
        Me.UR_Possition_Label.AutoSize = True
        Me.UR_Possition_Label.Location = New System.Drawing.Point(3, 151)
        Me.UR_Possition_Label.Name = "UR_Possition_Label"
        Me.UR_Possition_Label.Size = New System.Drawing.Size(81, 13)
        Me.UR_Possition_Label.TabIndex = 28
        Me.UR_Possition_Label.Text = "Work Possition:"
        '
        'UR_Surname_TextBox
        '
        Me.UR_Surname_TextBox.Location = New System.Drawing.Point(87, 84)
        Me.UR_Surname_TextBox.Name = "UR_Surname_TextBox"
        Me.UR_Surname_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Surname_TextBox.TabIndex = 22
        '
        'UR_Phone_label
        '
        Me.UR_Phone_label.AutoSize = True
        Me.UR_Phone_label.Location = New System.Drawing.Point(40, 177)
        Me.UR_Phone_label.Name = "UR_Phone_label"
        Me.UR_Phone_label.Size = New System.Drawing.Size(41, 13)
        Me.UR_Phone_label.TabIndex = 26
        Me.UR_Phone_label.Text = "Phone:"
        '
        'UR_Picture
        '
        Me.UR_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UR_Picture.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.UR_Picture.Location = New System.Drawing.Point(225, 48)
        Me.UR_Picture.Name = "UR_Picture"
        Me.UR_Picture.Size = New System.Drawing.Size(126, 113)
        Me.UR_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UR_Picture.TabIndex = 25
        Me.UR_Picture.TabStop = False
        '
        'UR_Username_TextBox
        '
        Me.UR_Username_TextBox.Location = New System.Drawing.Point(251, 169)
        Me.UR_Username_TextBox.Name = "UR_Username_TextBox"
        Me.UR_Username_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Username_TextBox.TabIndex = 27
        '
        'UR_Birth_TextBox
        '
        Me.UR_Birth_TextBox.Location = New System.Drawing.Point(87, 110)
        Me.UR_Birth_TextBox.Name = "UR_Birth_TextBox"
        Me.UR_Birth_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Birth_TextBox.TabIndex = 23
        '
        'UR_Email_TextBox
        '
        Me.UR_Email_TextBox.Location = New System.Drawing.Point(87, 200)
        Me.UR_Email_TextBox.Name = "UR_Email_TextBox"
        Me.UR_Email_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Email_TextBox.TabIndex = 26
        '
        'UR_Name_TextBox
        '
        Me.UR_Name_TextBox.Location = New System.Drawing.Point(87, 54)
        Me.UR_Name_TextBox.Name = "UR_Name_TextBox"
        Me.UR_Name_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Name_TextBox.TabIndex = 21
        '
        'UR_Username_Label
        '
        Me.UR_Username_Label.AutoSize = True
        Me.UR_Username_Label.Location = New System.Drawing.Point(190, 176)
        Me.UR_Username_Label.Name = "UR_Username_Label"
        Me.UR_Username_Label.Size = New System.Drawing.Size(58, 13)
        Me.UR_Username_Label.TabIndex = 20
        Me.UR_Username_Label.Text = "Username:"
        '
        'UR_Birth_Label
        '
        Me.UR_Birth_Label.AutoSize = True
        Me.UR_Birth_Label.Location = New System.Drawing.Point(53, 117)
        Me.UR_Birth_Label.Name = "UR_Birth_Label"
        Me.UR_Birth_Label.Size = New System.Drawing.Size(31, 13)
        Me.UR_Birth_Label.TabIndex = 19
        Me.UR_Birth_Label.Text = "Birth:"
        '
        'UR_Email_Label
        '
        Me.UR_Email_Label.AutoSize = True
        Me.UR_Email_Label.Location = New System.Drawing.Point(46, 208)
        Me.UR_Email_Label.Name = "UR_Email_Label"
        Me.UR_Email_Label.Size = New System.Drawing.Size(38, 13)
        Me.UR_Email_Label.TabIndex = 18
        Me.UR_Email_Label.Text = "E-mail:"
        '
        'UR_SName_Label
        '
        Me.UR_SName_Label.AutoSize = True
        Me.UR_SName_Label.Location = New System.Drawing.Point(32, 88)
        Me.UR_SName_Label.Name = "UR_SName_Label"
        Me.UR_SName_Label.Size = New System.Drawing.Size(52, 13)
        Me.UR_SName_Label.TabIndex = 17
        Me.UR_SName_Label.Text = "Surname:"
        '
        'UR_Name_Label
        '
        Me.UR_Name_Label.AutoSize = True
        Me.UR_Name_Label.Location = New System.Drawing.Point(46, 54)
        Me.UR_Name_Label.Name = "UR_Name_Label"
        Me.UR_Name_Label.Size = New System.Drawing.Size(38, 13)
        Me.UR_Name_Label.TabIndex = 16
        Me.UR_Name_Label.Text = "Name:"
        '
        'UR_Password_Label
        '
        Me.UR_Password_Label.AutoSize = True
        Me.UR_Password_Label.Location = New System.Drawing.Point(190, 207)
        Me.UR_Password_Label.Name = "UR_Password_Label"
        Me.UR_Password_Label.Size = New System.Drawing.Size(56, 13)
        Me.UR_Password_Label.TabIndex = 20
        Me.UR_Password_Label.Text = "Password:"
        '
        'UR_Password_TextBox
        '
        Me.UR_Password_TextBox.Location = New System.Drawing.Point(251, 200)
        Me.UR_Password_TextBox.Name = "UR_Password_TextBox"
        Me.UR_Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UR_Password_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.UR_Password_TextBox.TabIndex = 28
        '
        'UR_OpenFileDialog
        '
        Me.UR_OpenFileDialog.FileName = "Image"
        Me.UR_OpenFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" &
    " *.png"
        '
        'UR_ChangePicture_Button
        '
        Me.UR_ChangePicture_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UR_ChangePicture_Button.Image = CType(resources.GetObject("UR_ChangePicture_Button.Image"), System.Drawing.Image)
        Me.UR_ChangePicture_Button.Location = New System.Drawing.Point(323, 19)
        Me.UR_ChangePicture_Button.Name = "UR_ChangePicture_Button"
        Me.UR_ChangePicture_Button.Size = New System.Drawing.Size(28, 23)
        Me.UR_ChangePicture_Button.TabIndex = 31
        Me.UR_ChangePicture_Button.TabStop = False
        Me.UR_ChangePicture_Button.UseVisualStyleBackColor = True
        '
        'UR_NoFile_Label
        '
        Me.UR_NoFile_Label.AutoSize = True
        Me.UR_NoFile_Label.Location = New System.Drawing.Point(268, 99)
        Me.UR_NoFile_Label.Name = "UR_NoFile_Label"
        Me.UR_NoFile_Label.Size = New System.Drawing.Size(40, 13)
        Me.UR_NoFile_Label.TabIndex = 32
        Me.UR_NoFile_Label.Text = "No File"
        Me.UR_NoFile_Label.Visible = False
        '
        'UR_Timer
        '
        Me.UR_Timer.Enabled = True
        '
        'UR_ChooseImage_Label
        '
        Me.UR_ChooseImage_Label.AutoSize = True
        Me.UR_ChooseImage_Label.Location = New System.Drawing.Point(243, 24)
        Me.UR_ChooseImage_Label.Name = "UR_ChooseImage_Label"
        Me.UR_ChooseImage_Label.Size = New System.Drawing.Size(77, 13)
        Me.UR_ChooseImage_Label.TabIndex = 33
        Me.UR_ChooseImage_Label.Text = "Choose image:"
        '
        'UR_ClearImage_Button
        '
        Me.UR_ClearImage_Button.BackColor = System.Drawing.Color.Transparent
        Me.UR_ClearImage_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UR_ClearImage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UR_ClearImage_Button.Image = CType(resources.GetObject("UR_ClearImage_Button.Image"), System.Drawing.Image)
        Me.UR_ClearImage_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UR_ClearImage_Button.Location = New System.Drawing.Point(323, 143)
        Me.UR_ClearImage_Button.Name = "UR_ClearImage_Button"
        Me.UR_ClearImage_Button.Size = New System.Drawing.Size(28, 18)
        Me.UR_ClearImage_Button.TabIndex = 34
        Me.UR_ClearImage_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.UR_ClearImage_Button.UseVisualStyleBackColor = False
        Me.UR_ClearImage_Button.Visible = False
        '
        'UR_ConfirmPassword_Label
        '
        Me.UR_ConfirmPassword_Label.AutoSize = True
        Me.UR_ConfirmPassword_Label.Location = New System.Drawing.Point(154, 229)
        Me.UR_ConfirmPassword_Label.Name = "UR_ConfirmPassword_Label"
        Me.UR_ConfirmPassword_Label.Size = New System.Drawing.Size(94, 13)
        Me.UR_ConfirmPassword_Label.TabIndex = 20
        Me.UR_ConfirmPassword_Label.Text = "Confirm Password:"
        '
        'UR_ConfirmPassword_Textbox
        '
        Me.UR_ConfirmPassword_Textbox.Location = New System.Drawing.Point(251, 226)
        Me.UR_ConfirmPassword_Textbox.Name = "UR_ConfirmPassword_Textbox"
        Me.UR_ConfirmPassword_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UR_ConfirmPassword_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.UR_ConfirmPassword_Textbox.TabIndex = 29
        '
        'UR_Male_Button
        '
        Me.UR_Male_Button.AutoSize = True
        Me.UR_Male_Button.Location = New System.Drawing.Point(6, 19)
        Me.UR_Male_Button.Name = "UR_Male_Button"
        Me.UR_Male_Button.Size = New System.Drawing.Size(48, 17)
        Me.UR_Male_Button.TabIndex = 35
        Me.UR_Male_Button.Text = "Male"
        Me.UR_Male_Button.UseVisualStyleBackColor = True
        '
        'UR_Female_Button
        '
        Me.UR_Female_Button.AutoSize = True
        Me.UR_Female_Button.Location = New System.Drawing.Point(6, 45)
        Me.UR_Female_Button.Name = "UR_Female_Button"
        Me.UR_Female_Button.Size = New System.Drawing.Size(59, 17)
        Me.UR_Female_Button.TabIndex = 35
        Me.UR_Female_Button.TabStop = True
        Me.UR_Female_Button.Text = "Female"
        Me.UR_Female_Button.UseVisualStyleBackColor = True
        '
        'A_Register_Button
        '
        Me.A_Register_Button.Location = New System.Drawing.Point(358, 239)
        Me.A_Register_Button.Name = "A_Register_Button"
        Me.A_Register_Button.Size = New System.Drawing.Size(75, 23)
        Me.A_Register_Button.TabIndex = 30
        Me.A_Register_Button.Text = "Register"
        Me.A_Register_Button.UseVisualStyleBackColor = True
        '
        'UR_Admin_Button
        '
        Me.UR_Admin_Button.AutoSize = True
        Me.UR_Admin_Button.Location = New System.Drawing.Point(6, 19)
        Me.UR_Admin_Button.Name = "UR_Admin_Button"
        Me.UR_Admin_Button.Size = New System.Drawing.Size(54, 17)
        Me.UR_Admin_Button.TabIndex = 35
        Me.UR_Admin_Button.Text = "Admin"
        Me.UR_Admin_Button.UseVisualStyleBackColor = True
        '
        'UR_User_Button
        '
        Me.UR_User_Button.AutoSize = True
        Me.UR_User_Button.Location = New System.Drawing.Point(6, 39)
        Me.UR_User_Button.Name = "UR_User_Button"
        Me.UR_User_Button.Size = New System.Drawing.Size(47, 17)
        Me.UR_User_Button.TabIndex = 35
        Me.UR_User_Button.Text = "User"
        Me.UR_User_Button.UseVisualStyleBackColor = True
        '
        'UR_AT_GroupBox
        '
        Me.UR_AT_GroupBox.Controls.Add(Me.UR_Admin_Button)
        Me.UR_AT_GroupBox.Controls.Add(Me.UR_User_Button)
        Me.UR_AT_GroupBox.Location = New System.Drawing.Point(226, 264)
        Me.UR_AT_GroupBox.Name = "UR_AT_GroupBox"
        Me.UR_AT_GroupBox.Size = New System.Drawing.Size(94, 62)
        Me.UR_AT_GroupBox.TabIndex = 36
        Me.UR_AT_GroupBox.TabStop = False
        Me.UR_AT_GroupBox.Text = "Account type:"
        '
        'UR_Gender_GroupBox
        '
        Me.UR_Gender_GroupBox.Controls.Add(Me.UR_Male_Button)
        Me.UR_Gender_GroupBox.Controls.Add(Me.UR_Female_Button)
        Me.UR_Gender_GroupBox.Location = New System.Drawing.Point(56, 255)
        Me.UR_Gender_GroupBox.Name = "UR_Gender_GroupBox"
        Me.UR_Gender_GroupBox.Size = New System.Drawing.Size(100, 81)
        Me.UR_Gender_GroupBox.TabIndex = 37
        Me.UR_Gender_GroupBox.TabStop = False
        Me.UR_Gender_GroupBox.Text = "Gender:"
        '
        'UnosRadnika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 380)
        Me.Controls.Add(Me.UR_Gender_GroupBox)
        Me.Controls.Add(Me.UR_AT_GroupBox)
        Me.Controls.Add(Me.A_Register_Button)
        Me.Controls.Add(Me.UR_ClearImage_Button)
        Me.Controls.Add(Me.UR_ChooseImage_Label)
        Me.Controls.Add(Me.UR_NoFile_Label)
        Me.Controls.Add(Me.UR_ChangePicture_Button)
        Me.Controls.Add(Me.UR_Phone_TextBox)
        Me.Controls.Add(Me.UR_Possition_TextBox)
        Me.Controls.Add(Me.UR_Possition_Label)
        Me.Controls.Add(Me.UR_Surname_TextBox)
        Me.Controls.Add(Me.UR_Phone_label)
        Me.Controls.Add(Me.UR_Picture)
        Me.Controls.Add(Me.UR_ConfirmPassword_Textbox)
        Me.Controls.Add(Me.UR_Password_TextBox)
        Me.Controls.Add(Me.UR_Username_TextBox)
        Me.Controls.Add(Me.UR_Birth_TextBox)
        Me.Controls.Add(Me.UR_ConfirmPassword_Label)
        Me.Controls.Add(Me.UR_Email_TextBox)
        Me.Controls.Add(Me.UR_Password_Label)
        Me.Controls.Add(Me.UR_Name_TextBox)
        Me.Controls.Add(Me.UR_Username_Label)
        Me.Controls.Add(Me.UR_Birth_Label)
        Me.Controls.Add(Me.UR_Email_Label)
        Me.Controls.Add(Me.UR_SName_Label)
        Me.Controls.Add(Me.UR_Name_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnosRadnika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unos radnika"
        CType(Me.UR_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UR_AT_GroupBox.ResumeLayout(False)
        Me.UR_AT_GroupBox.PerformLayout()
        Me.UR_Gender_GroupBox.ResumeLayout(False)
        Me.UR_Gender_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UR_Phone_TextBox As TextBox
    Friend WithEvents UR_Possition_TextBox As TextBox
    Friend WithEvents UR_Possition_Label As Label
    Friend WithEvents UR_Surname_TextBox As TextBox
    Friend WithEvents UR_Phone_label As Label
    Friend WithEvents UR_Username_TextBox As TextBox
    Friend WithEvents UR_Birth_TextBox As TextBox
    Friend WithEvents UR_Email_TextBox As TextBox
    Friend WithEvents UR_Name_TextBox As TextBox
    Friend WithEvents UR_Username_Label As Label
    Friend WithEvents UR_Birth_Label As Label
    Friend WithEvents UR_Email_Label As Label
    Friend WithEvents UR_SName_Label As Label
    Friend WithEvents UR_Name_Label As Label
    Friend WithEvents UR_Password_Label As Label
    Friend WithEvents UR_Password_TextBox As TextBox
    Friend WithEvents UR_Picture As PictureBox
    Friend WithEvents UR_OpenFileDialog As OpenFileDialog
    Friend WithEvents UR_ChangePicture_Button As Button
    Friend WithEvents UR_FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents UR_NoFile_Label As Label
    Friend WithEvents UR_Timer As Timer
    Friend WithEvents UR_ChooseImage_Label As Label
    Friend WithEvents UR_ClearImage_Button As Button
    Friend WithEvents UR_ConfirmPassword_Label As Label
    Friend WithEvents UR_ConfirmPassword_Textbox As TextBox
    Friend WithEvents UR_Male_Button As RadioButton
    Friend WithEvents UR_Female_Button As RadioButton
    Friend WithEvents A_Register_Button As Button
    Friend WithEvents UR_Admin_Button As RadioButton
    Friend WithEvents UR_User_Button As RadioButton
    Friend WithEvents UR_AT_GroupBox As GroupBox
    Friend WithEvents UR_Gender_GroupBox As GroupBox
End Class
