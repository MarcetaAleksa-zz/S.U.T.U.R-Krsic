<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabStorage = New System.Windows.Forms.TabPage()
        Me.TabUserInfo = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.U_Username_label = New System.Windows.Forms.Label()
        Me.U_Picture = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.U_Fax_Label = New System.Windows.Forms.Label()
        Me.U_Phone_Label = New System.Windows.Forms.Label()
        Me.U_Email_Label = New System.Windows.Forms.Label()
        Me.U_SName_Label = New System.Windows.Forms.Label()
        Me.U_Name_Label = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabUserInfo.SuspendLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(12, 12)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 3
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(57, 12)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 7
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabStorage)
        Me.TabControl1.Controls.Add(Me.TabUserInfo)
        Me.TabControl1.Location = New System.Drawing.Point(12, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 385)
        Me.TabControl1.TabIndex = 8
        '
        'TabStorage
        '
        Me.TabStorage.Location = New System.Drawing.Point(4, 22)
        Me.TabStorage.Name = "TabStorage"
        Me.TabStorage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStorage.Size = New System.Drawing.Size(768, 359)
        Me.TabStorage.TabIndex = 0
        Me.TabStorage.Text = "Storage"
        Me.TabStorage.UseVisualStyleBackColor = True
        '
        'TabUserInfo
        '
        Me.TabUserInfo.Controls.Add(Me.TextBox1)
        Me.TabUserInfo.Controls.Add(Me.U_Username_label)
        Me.TabUserInfo.Controls.Add(Me.U_Picture)
        Me.TabUserInfo.Controls.Add(Me.TextBox5)
        Me.TabUserInfo.Controls.Add(Me.TextBox4)
        Me.TabUserInfo.Controls.Add(Me.TextBox3)
        Me.TabUserInfo.Controls.Add(Me.TextBox2)
        Me.TabUserInfo.Controls.Add(Me.U_Fax_Label)
        Me.TabUserInfo.Controls.Add(Me.U_Phone_Label)
        Me.TabUserInfo.Controls.Add(Me.U_Email_Label)
        Me.TabUserInfo.Controls.Add(Me.U_SName_Label)
        Me.TabUserInfo.Controls.Add(Me.U_Name_Label)
        Me.TabUserInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabUserInfo.Name = "TabUserInfo"
        Me.TabUserInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUserInfo.Size = New System.Drawing.Size(768, 359)
        Me.TabUserInfo.TabIndex = 1
        Me.TabUserInfo.Text = "User Information"
        Me.TabUserInfo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'U_Username_label
        '
        Me.U_Username_label.AutoSize = True
        Me.U_Username_label.Location = New System.Drawing.Point(3, 201)
        Me.U_Username_label.Name = "U_Username_label"
        Me.U_Username_label.Size = New System.Drawing.Size(58, 13)
        Me.U_Username_label.TabIndex = 11
        Me.U_Username_label.Text = "Username:"
        '
        'U_Picture
        '
        Me.U_Picture.Location = New System.Drawing.Point(67, 240)
        Me.U_Picture.Name = "U_Picture"
        Me.U_Picture.Size = New System.Drawing.Size(126, 113)
        Me.U_Picture.TabIndex = 10
        Me.U_Picture.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(67, 154)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(67, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(67, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(67, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'U_Fax_Label
        '
        Me.U_Fax_Label.AutoSize = True
        Me.U_Fax_Label.Location = New System.Drawing.Point(6, 157)
        Me.U_Fax_Label.Name = "U_Fax_Label"
        Me.U_Fax_Label.Size = New System.Drawing.Size(27, 13)
        Me.U_Fax_Label.TabIndex = 4
        Me.U_Fax_Label.Text = "Fax:"
        '
        'U_Phone_Label
        '
        Me.U_Phone_Label.AutoSize = True
        Me.U_Phone_Label.Location = New System.Drawing.Point(6, 125)
        Me.U_Phone_Label.Name = "U_Phone_Label"
        Me.U_Phone_Label.Size = New System.Drawing.Size(41, 13)
        Me.U_Phone_Label.TabIndex = 3
        Me.U_Phone_Label.Text = "Phone:"
        '
        'U_Email_Label
        '
        Me.U_Email_Label.AutoSize = True
        Me.U_Email_Label.Location = New System.Drawing.Point(6, 91)
        Me.U_Email_Label.Name = "U_Email_Label"
        Me.U_Email_Label.Size = New System.Drawing.Size(38, 13)
        Me.U_Email_Label.TabIndex = 2
        Me.U_Email_Label.Text = "E-mail:"
        '
        'U_SName_Label
        '
        Me.U_SName_Label.AutoSize = True
        Me.U_SName_Label.Location = New System.Drawing.Point(6, 58)
        Me.U_SName_Label.Name = "U_SName_Label"
        Me.U_SName_Label.Size = New System.Drawing.Size(58, 13)
        Me.U_SName_Label.TabIndex = 1
        Me.U_SName_Label.Text = "Surename:"
        '
        'U_Name_Label
        '
        Me.U_Name_Label.AutoSize = True
        Me.U_Name_Label.Location = New System.Drawing.Point(6, 25)
        Me.U_Name_Label.Name = "U_Name_Label"
        Me.U_Name_Label.Size = New System.Drawing.Size(38, 13)
        Me.U_Name_Label.TabIndex = 0
        Me.U_Name_Label.Text = "Name:"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Panel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabUserInfo.ResumeLayout(False)
        Me.TabUserInfo.PerformLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabStorage As TabPage
    Friend WithEvents TabUserInfo As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents U_Username_label As Label
    Friend WithEvents U_Picture As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents U_Fax_Label As Label
    Friend WithEvents U_Phone_Label As Label
    Friend WithEvents U_Email_Label As Label
    Friend WithEvents U_SName_Label As Label
    Friend WithEvents U_Name_Label As Label
End Class
