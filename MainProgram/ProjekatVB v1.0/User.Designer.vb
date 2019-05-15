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
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.U_Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.U_Possition_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.U_Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.U_Birth_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.U_Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.U_Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.U_Name_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Monthly_Pay_GroupBox = New System.Windows.Forms.GroupBox()
        Me.U_PB_TextBox = New System.Windows.Forms.TextBox()
        Me.U_OCH_TextBox = New System.Windows.Forms.TextBox()
        Me.U_PBOFWD_TextBox = New System.Windows.Forms.TextBox()
        Me.U_FWD_Button = New System.Windows.Forms.TextBox()
        Me.DaysInMonth = New System.Windows.Forms.TextBox()
        Me.U_WDIM_TextBox = New System.Windows.Forms.TextBox()
        Me.U_PB_Label = New System.Windows.Forms.Label()
        Me.U_OCH_Label = New System.Windows.Forms.Label()
        Me.U_PBOWD_Label = New System.Windows.Forms.Label()
        Me.U_FWD_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.U_WDIM_Label = New System.Windows.Forms.Label()
        Me.U_Month_Dropdown = New System.Windows.Forms.ComboBox()
        Me.U_Picture = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.U_Name_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabUserInfo.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.U_Monthly_Pay_GroupBox.SuspendLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(16, 91)
        Me.Back_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(52, 43)
        Me.Back_Button.TabIndex = 129
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(76, 91)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(168, 43)
        Me.Exit_Button.TabIndex = 130
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabStorage)
        Me.TabControl1.Controls.Add(Me.TabUserInfo)
        Me.TabControl1.Location = New System.Drawing.Point(16, 142)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 474)
        Me.TabControl1.TabIndex = 128
        '
        'TabStorage
        '
        Me.TabStorage.Location = New System.Drawing.Point(4, 25)
        Me.TabStorage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabStorage.Name = "TabStorage"
        Me.TabStorage.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabStorage.Size = New System.Drawing.Size(1027, 445)
        Me.TabStorage.TabIndex = 0
        Me.TabStorage.Text = "Storage"
        Me.TabStorage.UseVisualStyleBackColor = True
        '
        'TabUserInfo
        '
        Me.TabUserInfo.BackColor = System.Drawing.SystemColors.Control
        Me.TabUserInfo.Controls.Add(Me.Panel9)
        Me.TabUserInfo.Controls.Add(Me.Panel8)
        Me.TabUserInfo.Controls.Add(Me.Panel7)
        Me.TabUserInfo.Controls.Add(Me.Panel6)
        Me.TabUserInfo.Controls.Add(Me.Panel5)
        Me.TabUserInfo.Controls.Add(Me.Panel4)
        Me.TabUserInfo.Controls.Add(Me.Panel2)
        Me.TabUserInfo.Controls.Add(Me.U_Monthly_Pay_GroupBox)
        Me.TabUserInfo.Controls.Add(Me.U_Picture)
        Me.TabUserInfo.Controls.Add(Me.Label5)
        Me.TabUserInfo.Controls.Add(Me.Label8)
        Me.TabUserInfo.Controls.Add(Me.Label7)
        Me.TabUserInfo.Controls.Add(Me.Label6)
        Me.TabUserInfo.Controls.Add(Me.Label4)
        Me.TabUserInfo.Controls.Add(Me.Label3)
        Me.TabUserInfo.Controls.Add(Me.U_Name_Label)
        Me.TabUserInfo.Location = New System.Drawing.Point(4, 25)
        Me.TabUserInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabUserInfo.Name = "TabUserInfo"
        Me.TabUserInfo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabUserInfo.Size = New System.Drawing.Size(1027, 445)
        Me.TabUserInfo.TabIndex = 1
        Me.TabUserInfo.Text = "User Information"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.U_Phone_TextBox)
        Me.Panel9.Location = New System.Drawing.Point(147, 310)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(185, 32)
        Me.Panel9.TabIndex = 18
        '
        'U_Phone_TextBox
        '
        Me.U_Phone_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Phone_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Phone_TextBox.Location = New System.Drawing.Point(16, 7)
        Me.U_Phone_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Phone_TextBox.Name = "U_Phone_TextBox"
        Me.U_Phone_TextBox.ReadOnly = True
        Me.U_Phone_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Phone_TextBox.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel8.Controls.Add(Me.U_Possition_TextBox)
        Me.Panel8.Location = New System.Drawing.Point(147, 271)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(185, 32)
        Me.Panel8.TabIndex = 18
        '
        'U_Possition_TextBox
        '
        Me.U_Possition_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Possition_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Possition_TextBox.Location = New System.Drawing.Point(16, 10)
        Me.U_Possition_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Possition_TextBox.Name = "U_Possition_TextBox"
        Me.U_Possition_TextBox.ReadOnly = True
        Me.U_Possition_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Possition_TextBox.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel7.Controls.Add(Me.U_Username_TextBox)
        Me.Panel7.Location = New System.Drawing.Point(147, 231)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(185, 32)
        Me.Panel7.TabIndex = 18
        '
        'U_Username_TextBox
        '
        Me.U_Username_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Username_TextBox.Location = New System.Drawing.Point(16, 9)
        Me.U_Username_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Username_TextBox.Name = "U_Username_TextBox"
        Me.U_Username_TextBox.ReadOnly = True
        Me.U_Username_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Username_TextBox.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel6.Controls.Add(Me.U_Birth_TextBox)
        Me.Panel6.Location = New System.Drawing.Point(147, 192)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(185, 32)
        Me.Panel6.TabIndex = 18
        '
        'U_Birth_TextBox
        '
        Me.U_Birth_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Birth_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Birth_TextBox.Location = New System.Drawing.Point(16, 9)
        Me.U_Birth_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Birth_TextBox.Name = "U_Birth_TextBox"
        Me.U_Birth_TextBox.ReadOnly = True
        Me.U_Birth_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Birth_TextBox.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel5.Controls.Add(Me.U_Email_TextBox)
        Me.Panel5.Location = New System.Drawing.Point(147, 150)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(185, 32)
        Me.Panel5.TabIndex = 18
        '
        'U_Email_TextBox
        '
        Me.U_Email_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Email_TextBox.Location = New System.Drawing.Point(16, 9)
        Me.U_Email_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Email_TextBox.Name = "U_Email_TextBox"
        Me.U_Email_TextBox.ReadOnly = True
        Me.U_Email_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Email_TextBox.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel4.Controls.Add(Me.U_Surname_TextBox)
        Me.Panel4.Location = New System.Drawing.Point(147, 105)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 32)
        Me.Panel4.TabIndex = 18
        '
        'U_Surname_TextBox
        '
        Me.U_Surname_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Surname_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Surname_TextBox.Location = New System.Drawing.Point(16, 7)
        Me.U_Surname_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Surname_TextBox.Name = "U_Surname_TextBox"
        Me.U_Surname_TextBox.ReadOnly = True
        Me.U_Surname_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Surname_TextBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.U_Name_TextBox)
        Me.Panel2.Location = New System.Drawing.Point(147, 65)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 32)
        Me.Panel2.TabIndex = 18
        '
        'U_Name_TextBox
        '
        Me.U_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Name_TextBox.Location = New System.Drawing.Point(16, 9)
        Me.U_Name_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Name_TextBox.Name = "U_Name_TextBox"
        Me.U_Name_TextBox.ReadOnly = True
        Me.U_Name_TextBox.Size = New System.Drawing.Size(153, 15)
        Me.U_Name_TextBox.TabIndex = 12
        '
        'U_Monthly_Pay_GroupBox
        '
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel14)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel13)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel12)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel11)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel10)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel1)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PB_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_OCH_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_PBOWD_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_FWD_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Label1)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_WDIM_Label)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.U_Month_Dropdown)
        Me.U_Monthly_Pay_GroupBox.Location = New System.Drawing.Point(532, 7)
        Me.U_Monthly_Pay_GroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Monthly_Pay_GroupBox.Name = "U_Monthly_Pay_GroupBox"
        Me.U_Monthly_Pay_GroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Monthly_Pay_GroupBox.Size = New System.Drawing.Size(484, 431)
        Me.U_Monthly_Pay_GroupBox.TabIndex = 17
        Me.U_Monthly_Pay_GroupBox.TabStop = False
        Me.U_Monthly_Pay_GroupBox.Text = "Monthly Pay"
        '
        'U_PB_TextBox
        '
        Me.U_PB_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_PB_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_PB_TextBox.Location = New System.Drawing.Point(13, 8)
        Me.U_PB_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_PB_TextBox.Name = "U_PB_TextBox"
        Me.U_PB_TextBox.ReadOnly = True
        Me.U_PB_TextBox.Size = New System.Drawing.Size(56, 15)
        Me.U_PB_TextBox.TabIndex = 26
        '
        'U_OCH_TextBox
        '
        Me.U_OCH_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_OCH_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_OCH_TextBox.Location = New System.Drawing.Point(13, 8)
        Me.U_OCH_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_OCH_TextBox.Name = "U_OCH_TextBox"
        Me.U_OCH_TextBox.ReadOnly = True
        Me.U_OCH_TextBox.Size = New System.Drawing.Size(56, 15)
        Me.U_OCH_TextBox.TabIndex = 25
        '
        'U_PBOFWD_TextBox
        '
        Me.U_PBOFWD_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_PBOFWD_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_PBOFWD_TextBox.Location = New System.Drawing.Point(13, 8)
        Me.U_PBOFWD_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_PBOFWD_TextBox.Name = "U_PBOFWD_TextBox"
        Me.U_PBOFWD_TextBox.ReadOnly = True
        Me.U_PBOFWD_TextBox.Size = New System.Drawing.Size(56, 15)
        Me.U_PBOFWD_TextBox.TabIndex = 24
        '
        'U_FWD_Button
        '
        Me.U_FWD_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_FWD_Button.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_FWD_Button.Location = New System.Drawing.Point(13, 9)
        Me.U_FWD_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_FWD_Button.Name = "U_FWD_Button"
        Me.U_FWD_Button.ReadOnly = True
        Me.U_FWD_Button.Size = New System.Drawing.Size(56, 15)
        Me.U_FWD_Button.TabIndex = 23
        '
        'DaysInMonth
        '
        Me.DaysInMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DaysInMonth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DaysInMonth.Location = New System.Drawing.Point(13, 9)
        Me.DaysInMonth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DaysInMonth.Name = "DaysInMonth"
        Me.DaysInMonth.ReadOnly = True
        Me.DaysInMonth.Size = New System.Drawing.Size(56, 15)
        Me.DaysInMonth.TabIndex = 22
        '
        'U_WDIM_TextBox
        '
        Me.U_WDIM_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_WDIM_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_WDIM_TextBox.Location = New System.Drawing.Point(13, 8)
        Me.U_WDIM_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_WDIM_TextBox.Name = "U_WDIM_TextBox"
        Me.U_WDIM_TextBox.ReadOnly = True
        Me.U_WDIM_TextBox.Size = New System.Drawing.Size(56, 15)
        Me.U_WDIM_TextBox.TabIndex = 22
        '
        'U_PB_Label
        '
        Me.U_PB_Label.AutoSize = True
        Me.U_PB_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_PB_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_PB_Label.Location = New System.Drawing.Point(111, 309)
        Me.U_PB_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_PB_Label.Name = "U_PB_Label"
        Me.U_PB_Label.Size = New System.Drawing.Size(115, 20)
        Me.U_PB_Label.TabIndex = 21
        Me.U_PB_Label.Text = "PAY BONUS"
        '
        'U_OCH_Label
        '
        Me.U_OCH_Label.AutoSize = True
        Me.U_OCH_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_OCH_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_OCH_Label.Location = New System.Drawing.Point(31, 256)
        Me.U_OCH_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_OCH_Label.Name = "U_OCH_Label"
        Me.U_OCH_Label.Size = New System.Drawing.Size(195, 20)
        Me.U_OCH_Label.TabIndex = 20
        Me.U_OCH_Label.Text = "OVERCLOCK HOURS"
        '
        'U_PBOWD_Label
        '
        Me.U_PBOWD_Label.AutoSize = True
        Me.U_PBOWD_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_PBOWD_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_PBOWD_Label.Location = New System.Drawing.Point(44, 208)
        Me.U_PBOWD_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_PBOWD_Label.Name = "U_PBOWD_Label"
        Me.U_PBOWD_Label.Size = New System.Drawing.Size(182, 20)
        Me.U_PBOWD_Label.TabIndex = 19
        Me.U_PBOWD_Label.Text = "PAY ON FULLFILED"
        '
        'U_FWD_Label
        '
        Me.U_FWD_Label.AutoSize = True
        Me.U_FWD_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_FWD_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_FWD_Label.Location = New System.Drawing.Point(8, 151)
        Me.U_FWD_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_FWD_Label.Name = "U_FWD_Label"
        Me.U_FWD_Label.Size = New System.Drawing.Size(225, 20)
        Me.U_FWD_Label.TabIndex = 18
        Me.U_FWD_Label.Text = "FULLFILED WORK DAYS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(71, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DAYS IN MONTH"
        '
        'U_WDIM_Label
        '
        Me.U_WDIM_Label.AutoSize = True
        Me.U_WDIM_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_WDIM_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_WDIM_Label.Location = New System.Drawing.Point(9, 111)
        Me.U_WDIM_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_WDIM_Label.Name = "U_WDIM_Label"
        Me.U_WDIM_Label.Size = New System.Drawing.Size(217, 20)
        Me.U_WDIM_Label.TabIndex = 17
        Me.U_WDIM_Label.Text = "WORK DAYS IN MONTH"
        '
        'U_Month_Dropdown
        '
        Me.U_Month_Dropdown.FormattingEnabled = True
        Me.U_Month_Dropdown.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.U_Month_Dropdown.Location = New System.Drawing.Point(8, 23)
        Me.U_Month_Dropdown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Month_Dropdown.Name = "U_Month_Dropdown"
        Me.U_Month_Dropdown.Size = New System.Drawing.Size(419, 24)
        Me.U_Month_Dropdown.TabIndex = 16
        '
        'U_Picture
        '
        Me.U_Picture.Location = New System.Drawing.Point(340, 64)
        Me.U_Picture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Picture.Name = "U_Picture"
        Me.U_Picture.Size = New System.Drawing.Size(168, 139)
        Me.U_Picture.TabIndex = 10
        Me.U_Picture.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(61, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "E-MAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(44, 316)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "PHONE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 278)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "POSSITION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(65, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "BIRTH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SURNAME"
        '
        'U_Name_Label
        '
        Me.U_Name_Label.AutoSize = True
        Me.U_Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Name_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_Name_Label.Location = New System.Drawing.Point(71, 69)
        Me.U_Name_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.U_Name_Label.Name = "U_Name_Label"
        Me.U_Name_Label.Size = New System.Drawing.Size(61, 20)
        Me.U_Name_Label.TabIndex = 0
        Me.U_Name_Label.Text = "NAME"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1455, 84)
        Me.Panel3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(407, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 31)
        Me.Label2.TabIndex = 66666
        Me.Label2.Text = "USER PANEL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DaysInMonth)
        Me.Panel1.Location = New System.Drawing.Point(242, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 32)
        Me.Panel1.TabIndex = 18
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel10.Controls.Add(Me.U_WDIM_TextBox)
        Me.Panel10.Controls.Add(Me.TextBox1)
        Me.Panel10.Location = New System.Drawing.Point(242, 105)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(83, 32)
        Me.Panel10.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(13, 9)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(56, 15)
        Me.TextBox1.TabIndex = 22
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel11.Controls.Add(Me.U_FWD_Button)
        Me.Panel11.Controls.Add(Me.TextBox2)
        Me.Panel11.Location = New System.Drawing.Point(242, 143)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(83, 32)
        Me.Panel11.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(13, 9)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(56, 15)
        Me.TextBox2.TabIndex = 22
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel12.Controls.Add(Me.U_PBOFWD_TextBox)
        Me.Panel12.Controls.Add(Me.TextBox3)
        Me.Panel12.Location = New System.Drawing.Point(242, 204)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(83, 32)
        Me.Panel12.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(13, 9)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(56, 15)
        Me.TextBox3.TabIndex = 22
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel13.Controls.Add(Me.U_OCH_TextBox)
        Me.Panel13.Controls.Add(Me.TextBox4)
        Me.Panel13.Location = New System.Drawing.Point(242, 256)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(83, 32)
        Me.Panel13.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(13, 9)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(56, 15)
        Me.TextBox4.TabIndex = 22
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel14.Controls.Add(Me.U_PB_TextBox)
        Me.Panel14.Controls.Add(Me.TextBox5)
        Me.Panel14.Location = New System.Drawing.Point(242, 297)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(83, 32)
        Me.Panel14.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(13, 9)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(56, 15)
        Me.TextBox5.TabIndex = 22
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 636)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Panel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabUserInfo.ResumeLayout(False)
        Me.TabUserInfo.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.U_Monthly_Pay_GroupBox.ResumeLayout(False)
        Me.U_Monthly_Pay_GroupBox.PerformLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabStorage As TabPage
    Friend WithEvents TabUserInfo As TabPage
    Friend WithEvents U_Name_TextBox As TextBox
    Friend WithEvents U_Picture As PictureBox
    Friend WithEvents U_Username_TextBox As TextBox
    Friend WithEvents U_Birth_TextBox As TextBox
    Friend WithEvents U_Email_TextBox As TextBox
    Friend WithEvents U_Surname_TextBox As TextBox
    Friend WithEvents U_Name_Label As Label
    Friend WithEvents U_Phone_TextBox As TextBox
    Friend WithEvents U_Possition_TextBox As TextBox
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
    Friend WithEvents DaysInMonth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
