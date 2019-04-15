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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabStorage = New System.Windows.Forms.TabPage()
        Me.TabUserInfo = New System.Windows.Forms.TabPage()
        Me.U_Monthly_Pay_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.U_PB_TextBox = New System.Windows.Forms.TextBox()
        Me.U_OCH_TextBox = New System.Windows.Forms.TextBox()
        Me.U_PBOFWD_TextBox = New System.Windows.Forms.TextBox()
        Me.U_FWD_Button = New System.Windows.Forms.TextBox()
        Me.U_WDIM_TextBox = New System.Windows.Forms.TextBox()
        Me.U_PB_Label = New System.Windows.Forms.Label()
        Me.U_OCH_Label = New System.Windows.Forms.Label()
        Me.U_PBOWD_Label = New System.Windows.Forms.Label()
        Me.U_FWD_Label = New System.Windows.Forms.Label()
        Me.U_WDIM_Label = New System.Windows.Forms.Label()
        Me.U_Month_Dropdown = New System.Windows.Forms.ComboBox()
        Me.U_Username_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Possition_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Possition_Label = New System.Windows.Forms.Label()
        Me.U_Name_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Username_label = New System.Windows.Forms.Label()
        Me.U_Picture = New System.Windows.Forms.PictureBox()
        Me.U_Fax_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Email_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Fax_Label = New System.Windows.Forms.Label()
        Me.U_Phone_Label = New System.Windows.Forms.Label()
        Me.U_Email_Label = New System.Windows.Forms.Label()
        Me.U_SName_Label = New System.Windows.Forms.Label()
        Me.U_Name_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DaysInMonth = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabUserInfo.SuspendLayout()
        Me.U_Monthly_Pay_GroupBox.SuspendLayout()
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
        Me.TabUserInfo.Controls.Add(Me.U_Monthly_Pay_GroupBox)
        Me.TabUserInfo.Controls.Add(Me.U_Username_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Possition_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Possition_Label)
        Me.TabUserInfo.Controls.Add(Me.U_Name_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Username_label)
        Me.TabUserInfo.Controls.Add(Me.U_Picture)
        Me.TabUserInfo.Controls.Add(Me.U_Fax_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Phone_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Email_TextBox)
        Me.TabUserInfo.Controls.Add(Me.U_Surname_TextBox)
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
        'U_Monthly_Pay_GroupBox
        '
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Button1)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PB_TextBox)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_OCH_TextBox)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PBOFWD_TextBox)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_FWD_Button)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.DaysInMonth)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_WDIM_TextBox)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PB_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_OCH_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PBOWD_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_FWD_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Label1)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_WDIM_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_Month_Dropdown)
        Me.U_Monthly_Pay_GroupBox.Location = New System.Drawing.Point(399, 6)
        Me.U_Monthly_Pay_GroupBox.Name = "U_Monthly_Pay_GroupBox"
        Me.U_Monthly_Pay_GroupBox.Size = New System.Drawing.Size(363, 350)
        Me.U_Monthly_Pay_GroupBox.TabIndex = 17
        Me.U_Monthly_Pay_GroupBox.TabStop = False
        Me.U_Monthly_Pay_GroupBox.Text = "Monthly Pay"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'U_PB_TextBox
        '
        Me.U_PB_TextBox.Location = New System.Drawing.Point(183, 244)
        Me.U_PB_TextBox.Name = "U_PB_TextBox"
        Me.U_PB_TextBox.ReadOnly = True
        Me.U_PB_TextBox.Size = New System.Drawing.Size(43, 20)
        Me.U_PB_TextBox.TabIndex = 26
        '
        'U_OCH_TextBox
        '
        Me.U_OCH_TextBox.Location = New System.Drawing.Point(183, 208)
        Me.U_OCH_TextBox.Name = "U_OCH_TextBox"
        Me.U_OCH_TextBox.ReadOnly = True
        Me.U_OCH_TextBox.Size = New System.Drawing.Size(43, 20)
        Me.U_OCH_TextBox.TabIndex = 25
        '
        'U_PBOFWD_TextBox
        '
        Me.U_PBOFWD_TextBox.Location = New System.Drawing.Point(183, 166)
        Me.U_PBOFWD_TextBox.Name = "U_PBOFWD_TextBox"
        Me.U_PBOFWD_TextBox.ReadOnly = True
        Me.U_PBOFWD_TextBox.Size = New System.Drawing.Size(43, 20)
        Me.U_PBOFWD_TextBox.TabIndex = 24
        '
        'U_FWD_Button
        '
        Me.U_FWD_Button.Location = New System.Drawing.Point(183, 116)
        Me.U_FWD_Button.Name = "U_FWD_Button"
        Me.U_FWD_Button.ReadOnly = True
        Me.U_FWD_Button.Size = New System.Drawing.Size(43, 20)
        Me.U_FWD_Button.TabIndex = 23
        '
        'U_WDIM_TextBox
        '
        Me.U_WDIM_TextBox.Location = New System.Drawing.Point(183, 90)
        Me.U_WDIM_TextBox.Name = "U_WDIM_TextBox"
        Me.U_WDIM_TextBox.ReadOnly = True
        Me.U_WDIM_TextBox.Size = New System.Drawing.Size(43, 20)
        Me.U_WDIM_TextBox.TabIndex = 22
        '
        'U_PB_Label
        '
        Me.U_PB_Label.AutoSize = True
        Me.U_PB_Label.Location = New System.Drawing.Point(7, 251)
        Me.U_PB_Label.Name = "U_PB_Label"
        Me.U_PB_Label.Size = New System.Drawing.Size(61, 13)
        Me.U_PB_Label.TabIndex = 21
        Me.U_PB_Label.Text = "Pay Bonus:"
        '
        'U_OCH_Label
        '
        Me.U_OCH_Label.AutoSize = True
        Me.U_OCH_Label.Location = New System.Drawing.Point(7, 208)
        Me.U_OCH_Label.Name = "U_OCH_Label"
        Me.U_OCH_Label.Size = New System.Drawing.Size(90, 13)
        Me.U_OCH_Label.TabIndex = 20
        Me.U_OCH_Label.Text = "Overclock Hours:"
        '
        'U_PBOWD_Label
        '
        Me.U_PBOWD_Label.AutoSize = True
        Me.U_PBOWD_Label.Location = New System.Drawing.Point(7, 169)
        Me.U_PBOWD_Label.Name = "U_PBOWD_Label"
        Me.U_PBOWD_Label.Size = New System.Drawing.Size(170, 13)
        Me.U_PBOWD_Label.TabIndex = 19
        Me.U_PBOWD_Label.Text = "Pay Based on Fulfilled Work Days:"
        '
        'U_FWD_Label
        '
        Me.U_FWD_Label.AutoSize = True
        Me.U_FWD_Label.Location = New System.Drawing.Point(6, 123)
        Me.U_FWD_Label.Name = "U_FWD_Label"
        Me.U_FWD_Label.Size = New System.Drawing.Size(101, 13)
        Me.U_FWD_Label.TabIndex = 18
        Me.U_FWD_Label.Text = "Fulfilled Work Days:"
        '
        'U_WDIM_Label
        '
        Me.U_WDIM_Label.AutoSize = True
        Me.U_WDIM_Label.Location = New System.Drawing.Point(7, 90)
        Me.U_WDIM_Label.Name = "U_WDIM_Label"
        Me.U_WDIM_Label.Size = New System.Drawing.Size(107, 13)
        Me.U_WDIM_Label.TabIndex = 17
        Me.U_WDIM_Label.Text = "Work Days in Month:"
        '
        'U_Month_Dropdown
        '
        Me.U_Month_Dropdown.FormattingEnabled = True
        Me.U_Month_Dropdown.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.U_Month_Dropdown.Location = New System.Drawing.Point(6, 19)
        Me.U_Month_Dropdown.Name = "U_Month_Dropdown"
        Me.U_Month_Dropdown.Size = New System.Drawing.Size(315, 21)
        Me.U_Month_Dropdown.TabIndex = 16
        '
        'U_Username_TextBox
        '
        Me.U_Username_TextBox.Location = New System.Drawing.Point(93, 211)
        Me.U_Username_TextBox.Name = "U_Username_TextBox"
        Me.U_Username_TextBox.ReadOnly = True
        Me.U_Username_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Username_TextBox.TabIndex = 15
        '
        'U_Possition_TextBox
        '
        Me.U_Possition_TextBox.Location = New System.Drawing.Point(93, 185)
        Me.U_Possition_TextBox.Name = "U_Possition_TextBox"
        Me.U_Possition_TextBox.ReadOnly = True
        Me.U_Possition_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Possition_TextBox.TabIndex = 14
        '
        'U_Possition_Label
        '
        Me.U_Possition_Label.AutoSize = True
        Me.U_Possition_Label.Location = New System.Drawing.Point(6, 185)
        Me.U_Possition_Label.Name = "U_Possition_Label"
        Me.U_Possition_Label.Size = New System.Drawing.Size(81, 13)
        Me.U_Possition_Label.TabIndex = 13
        Me.U_Possition_Label.Text = "Work Possition:"
        '
        'U_Name_TextBox
        '
        Me.U_Name_TextBox.Location = New System.Drawing.Point(93, 22)
        Me.U_Name_TextBox.Name = "U_Name_TextBox"
        Me.U_Name_TextBox.ReadOnly = True
        Me.U_Name_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Name_TextBox.TabIndex = 12
        '
        'U_Username_label
        '
        Me.U_Username_label.AutoSize = True
        Me.U_Username_label.Location = New System.Drawing.Point(29, 211)
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
        'U_Fax_TextBox
        '
        Me.U_Fax_TextBox.Location = New System.Drawing.Point(93, 154)
        Me.U_Fax_TextBox.Name = "U_Fax_TextBox"
        Me.U_Fax_TextBox.ReadOnly = True
        Me.U_Fax_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Fax_TextBox.TabIndex = 9
        '
        'U_Phone_TextBox
        '
        Me.U_Phone_TextBox.Location = New System.Drawing.Point(93, 122)
        Me.U_Phone_TextBox.Name = "U_Phone_TextBox"
        Me.U_Phone_TextBox.ReadOnly = True
        Me.U_Phone_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Phone_TextBox.TabIndex = 8
        '
        'U_Email_TextBox
        '
        Me.U_Email_TextBox.Location = New System.Drawing.Point(93, 91)
        Me.U_Email_TextBox.Name = "U_Email_TextBox"
        Me.U_Email_TextBox.ReadOnly = True
        Me.U_Email_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Email_TextBox.TabIndex = 7
        '
        'U_Surname_TextBox
        '
        Me.U_Surname_TextBox.Location = New System.Drawing.Point(93, 55)
        Me.U_Surname_TextBox.Name = "U_Surname_TextBox"
        Me.U_Surname_TextBox.ReadOnly = True
        Me.U_Surname_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.U_Surname_TextBox.TabIndex = 6
        '
        'U_Fax_Label
        '
        Me.U_Fax_Label.AutoSize = True
        Me.U_Fax_Label.Location = New System.Drawing.Point(60, 154)
        Me.U_Fax_Label.Name = "U_Fax_Label"
        Me.U_Fax_Label.Size = New System.Drawing.Size(27, 13)
        Me.U_Fax_Label.TabIndex = 4
        Me.U_Fax_Label.Text = "Fax:"
        '
        'U_Phone_Label
        '
        Me.U_Phone_Label.AutoSize = True
        Me.U_Phone_Label.Location = New System.Drawing.Point(46, 125)
        Me.U_Phone_Label.Name = "U_Phone_Label"
        Me.U_Phone_Label.Size = New System.Drawing.Size(41, 13)
        Me.U_Phone_Label.TabIndex = 3
        Me.U_Phone_Label.Text = "Phone:"
        '
        'U_Email_Label
        '
        Me.U_Email_Label.AutoSize = True
        Me.U_Email_Label.Location = New System.Drawing.Point(49, 91)
        Me.U_Email_Label.Name = "U_Email_Label"
        Me.U_Email_Label.Size = New System.Drawing.Size(38, 13)
        Me.U_Email_Label.TabIndex = 2
        Me.U_Email_Label.Text = "E-mail:"
        '
        'U_SName_Label
        '
        Me.U_SName_Label.AutoSize = True
        Me.U_SName_Label.Location = New System.Drawing.Point(29, 58)
        Me.U_SName_Label.Name = "U_SName_Label"
        Me.U_SName_Label.Size = New System.Drawing.Size(52, 13)
        Me.U_SName_Label.TabIndex = 1
        Me.U_SName_Label.Text = "Surname:"
        '
        'U_Name_Label
        '
        Me.U_Name_Label.AutoSize = True
        Me.U_Name_Label.Location = New System.Drawing.Point(49, 25)
        Me.U_Name_Label.Name = "U_Name_Label"
        Me.U_Name_Label.Size = New System.Drawing.Size(38, 13)
        Me.U_Name_Label.TabIndex = 0
        Me.U_Name_Label.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Days in Month:"
        '
        'DaysInMonth
        '
        Me.DaysInMonth.Location = New System.Drawing.Point(183, 53)
        Me.DaysInMonth.Name = "DaysInMonth"
        Me.DaysInMonth.ReadOnly = True
        Me.DaysInMonth.Size = New System.Drawing.Size(43, 20)
        Me.DaysInMonth.TabIndex = 22
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
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
        Me.U_Monthly_Pay_GroupBox.ResumeLayout(False)
        Me.U_Monthly_Pay_GroupBox.PerformLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabStorage As TabPage
    Friend WithEvents TabUserInfo As TabPage
    Friend WithEvents U_Name_TextBox As TextBox
    Friend WithEvents U_Username_label As Label
    Friend WithEvents U_Picture As PictureBox
    Friend WithEvents U_Fax_TextBox As TextBox
    Friend WithEvents U_Phone_TextBox As TextBox
    Friend WithEvents U_Email_TextBox As TextBox
    Friend WithEvents U_Surname_TextBox As TextBox
    Friend WithEvents U_Fax_Label As Label
    Friend WithEvents U_Phone_Label As Label
    Friend WithEvents U_Email_Label As Label
    Friend WithEvents U_SName_Label As Label
    Friend WithEvents U_Name_Label As Label
    Friend WithEvents U_Username_TextBox As TextBox
    Friend WithEvents U_Possition_TextBox As TextBox
    Friend WithEvents U_Possition_Label As Label
    Friend WithEvents U_Monthly_Pay_GroupBox As GroupBox
    Friend WithEvents U_Month_Dropdown As ComboBox
    Friend WithEvents U_PB_Label As Label
    Friend WithEvents U_OCH_Label As Label
    Friend WithEvents U_PBOWD_Label As Label
    Friend WithEvents U_FWD_Label As Label
    Friend WithEvents U_WDIM_Label As Label
    Friend WithEvents U_PB_TextBox As TextBox
    Friend WithEvents U_OCH_TextBox As TextBox
    Friend WithEvents U_PBOFWD_TextBox As TextBox
    Friend WithEvents U_FWD_Button As TextBox
    Friend WithEvents U_WDIM_TextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DaysInMonth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
