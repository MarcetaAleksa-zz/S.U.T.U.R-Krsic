<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Korisnik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Korisnik))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabUserInfo = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dugmeSacuvaj = New System.Windows.Forms.Button()
        Me.U_NoFile_Label = New System.Windows.Forms.Label()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.U_Male_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.U_Phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.U_Possition_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.U_Username_TextBox = New System.Windows.Forms.TextBox()
        Me.PonistiIzmjeneDugme = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.U_Birth_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.U_Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.U_Adresa_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.U_Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.U_Name_TextBox = New System.Windows.Forms.TextBox()
        Me.U_Monthly_Pay_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.U_PBOFWD_TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.U_FWD_Button = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.U_WDIM_TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DaysInMonth = New System.Windows.Forms.TextBox()
        Me.U_PBOWD_Label = New System.Windows.Forms.Label()
        Me.U_FWD_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.U_WDIM_Label = New System.Windows.Forms.Label()
        Me.U_Month_Dropdown = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.U_Picture = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.U_Name_Label = New System.Windows.Forms.Label()
        Me.TabStorage = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel3.SuspendLayout()
        Me.TabUserInfo.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel42.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.U_Monthly_Pay_GroupBox.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStorage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(12, 74)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 129
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(57, 74)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 130
        Me.Exit_Button.Text = " Nazad"
        Me.Exit_Button.UseVisualStyleBackColor = True
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
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1091, 68)
        Me.Panel3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(295, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 66666
        Me.Label2.Text = "KORISNIČKI PANEL"
        '
        'TabUserInfo
        '
        Me.TabUserInfo.BackColor = System.Drawing.SystemColors.Control
        Me.TabUserInfo.Controls.Add(Me.Button1)
        Me.TabUserInfo.Controls.Add(Me.dugmeSacuvaj)
        Me.TabUserInfo.Controls.Add(Me.U_NoFile_Label)
        Me.TabUserInfo.Controls.Add(Me.Panel40)
        Me.TabUserInfo.Controls.Add(Me.Panel9)
        Me.TabUserInfo.Controls.Add(Me.Panel8)
        Me.TabUserInfo.Controls.Add(Me.Panel7)
        Me.TabUserInfo.Controls.Add(Me.PonistiIzmjeneDugme)
        Me.TabUserInfo.Controls.Add(Me.Panel6)
        Me.TabUserInfo.Controls.Add(Me.Panel42)
        Me.TabUserInfo.Controls.Add(Me.Panel5)
        Me.TabUserInfo.Controls.Add(Me.Panel4)
        Me.TabUserInfo.Controls.Add(Me.Panel2)
        Me.TabUserInfo.Controls.Add(Me.U_Monthly_Pay_GroupBox)
        Me.TabUserInfo.Controls.Add(Me.Label50)
        Me.TabUserInfo.Controls.Add(Me.U_Picture)
        Me.TabUserInfo.Controls.Add(Me.Label5)
        Me.TabUserInfo.Controls.Add(Me.Label43)
        Me.TabUserInfo.Controls.Add(Me.Label8)
        Me.TabUserInfo.Controls.Add(Me.Label7)
        Me.TabUserInfo.Controls.Add(Me.Label6)
        Me.TabUserInfo.Controls.Add(Me.Label4)
        Me.TabUserInfo.Controls.Add(Me.Label3)
        Me.TabUserInfo.Controls.Add(Me.U_Name_Label)
        Me.TabUserInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabUserInfo.Name = "TabUserInfo"
        Me.TabUserInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUserInfo.Size = New System.Drawing.Size(768, 359)
        Me.TabUserInfo.TabIndex = 1
        Me.TabUserInfo.Text = "Informacije o korisniku"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(12, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 35)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "Izmijeni"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dugmeSacuvaj
        '
        Me.dugmeSacuvaj.BackColor = System.Drawing.SystemColors.Control
        Me.dugmeSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dugmeSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dugmeSacuvaj.Location = New System.Drawing.Point(122, 6)
        Me.dugmeSacuvaj.Name = "dugmeSacuvaj"
        Me.dugmeSacuvaj.Size = New System.Drawing.Size(109, 35)
        Me.dugmeSacuvaj.TabIndex = 138
        Me.dugmeSacuvaj.Text = "Sacuvaj"
        Me.dugmeSacuvaj.UseVisualStyleBackColor = False
        Me.dugmeSacuvaj.Visible = False
        '
        'U_NoFile_Label
        '
        Me.U_NoFile_Label.AutoSize = True
        Me.U_NoFile_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_NoFile_Label.Location = New System.Drawing.Point(289, 103)
        Me.U_NoFile_Label.Name = "U_NoFile_Label"
        Me.U_NoFile_Label.Size = New System.Drawing.Size(59, 13)
        Me.U_NoFile_Label.TabIndex = 33
        Me.U_NoFile_Label.Text = "Nema slike"
        Me.U_NoFile_Label.Visible = False
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel40.Controls.Add(Me.U_Male_TextBox)
        Me.Panel40.Location = New System.Drawing.Point(110, 330)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(71, 26)
        Me.Panel40.TabIndex = 18
        '
        'U_Male_TextBox
        '
        Me.U_Male_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Male_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Male_TextBox.Location = New System.Drawing.Point(12, 6)
        Me.U_Male_TextBox.Name = "U_Male_TextBox"
        Me.U_Male_TextBox.ReadOnly = True
        Me.U_Male_TextBox.Size = New System.Drawing.Size(53, 13)
        Me.U_Male_TextBox.TabIndex = 15
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.U_Phone_TextBox)
        Me.Panel9.Location = New System.Drawing.Point(109, 297)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(139, 26)
        Me.Panel9.TabIndex = 18
        '
        'U_Phone_TextBox
        '
        Me.U_Phone_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Phone_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Phone_TextBox.Location = New System.Drawing.Point(12, 6)
        Me.U_Phone_TextBox.Name = "U_Phone_TextBox"
        Me.U_Phone_TextBox.ReadOnly = True
        Me.U_Phone_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Phone_TextBox.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel8.Controls.Add(Me.U_Possition_TextBox)
        Me.Panel8.Location = New System.Drawing.Point(109, 265)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(139, 26)
        Me.Panel8.TabIndex = 18
        '
        'U_Possition_TextBox
        '
        Me.U_Possition_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Possition_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Possition_TextBox.Location = New System.Drawing.Point(12, 8)
        Me.U_Possition_TextBox.Name = "U_Possition_TextBox"
        Me.U_Possition_TextBox.ReadOnly = True
        Me.U_Possition_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Possition_TextBox.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel7.Controls.Add(Me.U_Username_TextBox)
        Me.Panel7.Location = New System.Drawing.Point(110, 121)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 26)
        Me.Panel7.TabIndex = 18
        '
        'U_Username_TextBox
        '
        Me.U_Username_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Username_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Username_TextBox.Name = "U_Username_TextBox"
        Me.U_Username_TextBox.ReadOnly = True
        Me.U_Username_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Username_TextBox.TabIndex = 9
        '
        'PonistiIzmjeneDugme
        '
        Me.PonistiIzmjeneDugme.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PonistiIzmjeneDugme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PonistiIzmjeneDugme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PonistiIzmjeneDugme.ForeColor = System.Drawing.SystemColors.Control
        Me.PonistiIzmjeneDugme.Location = New System.Drawing.Point(12, 5)
        Me.PonistiIzmjeneDugme.Name = "PonistiIzmjeneDugme"
        Me.PonistiIzmjeneDugme.Size = New System.Drawing.Size(109, 35)
        Me.PonistiIzmjeneDugme.TabIndex = 139
        Me.PonistiIzmjeneDugme.Text = "Ponisti izmjene"
        Me.PonistiIzmjeneDugme.UseVisualStyleBackColor = False
        Me.PonistiIzmjeneDugme.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel6.Controls.Add(Me.U_Birth_TextBox)
        Me.Panel6.Location = New System.Drawing.Point(109, 233)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(139, 26)
        Me.Panel6.TabIndex = 18
        '
        'U_Birth_TextBox
        '
        Me.U_Birth_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Birth_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Birth_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Birth_TextBox.Name = "U_Birth_TextBox"
        Me.U_Birth_TextBox.ReadOnly = True
        Me.U_Birth_TextBox.Size = New System.Drawing.Size(116, 13)
        Me.U_Birth_TextBox.TabIndex = 8
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel42.Controls.Add(Me.U_Email_TextBox)
        Me.Panel42.Location = New System.Drawing.Point(110, 171)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(231, 26)
        Me.Panel42.TabIndex = 18
        '
        'U_Email_TextBox
        '
        Me.U_Email_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Email_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Email_TextBox.Name = "U_Email_TextBox"
        Me.U_Email_TextBox.ReadOnly = True
        Me.U_Email_TextBox.Size = New System.Drawing.Size(216, 13)
        Me.U_Email_TextBox.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel5.Controls.Add(Me.U_Adresa_TextBox)
        Me.Panel5.Location = New System.Drawing.Point(109, 201)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(231, 26)
        Me.Panel5.TabIndex = 18
        '
        'U_Adresa_TextBox
        '
        Me.U_Adresa_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Adresa_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Adresa_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Adresa_TextBox.Name = "U_Adresa_TextBox"
        Me.U_Adresa_TextBox.ReadOnly = True
        Me.U_Adresa_TextBox.Size = New System.Drawing.Size(216, 13)
        Me.U_Adresa_TextBox.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel4.Controls.Add(Me.U_Surname_TextBox)
        Me.Panel4.Location = New System.Drawing.Point(110, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(139, 26)
        Me.Panel4.TabIndex = 18
        '
        'U_Surname_TextBox
        '
        Me.U_Surname_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Surname_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Surname_TextBox.Location = New System.Drawing.Point(12, 6)
        Me.U_Surname_TextBox.Name = "U_Surname_TextBox"
        Me.U_Surname_TextBox.ReadOnly = True
        Me.U_Surname_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Surname_TextBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.U_Name_TextBox)
        Me.Panel2.Location = New System.Drawing.Point(110, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 26)
        Me.Panel2.TabIndex = 18
        '
        'U_Name_TextBox
        '
        Me.U_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Name_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Name_TextBox.Name = "U_Name_TextBox"
        Me.U_Name_TextBox.ReadOnly = True
        Me.U_Name_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Name_TextBox.TabIndex = 12
        '
        'U_Monthly_Pay_GroupBox
        '
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel12)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel11)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel10)
        Me.U_Monthly_Pay_GroupBox.Controls.Add(Me.Panel1)
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
        Me.U_Monthly_Pay_GroupBox.Text = "Mjesečna plata"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel12.Controls.Add(Me.U_PBOFWD_TextBox)
        Me.Panel12.Controls.Add(Me.TextBox3)
        Me.Panel12.Location = New System.Drawing.Point(228, 165)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(62, 26)
        Me.Panel12.TabIndex = 18
        '
        'U_PBOFWD_TextBox
        '
        Me.U_PBOFWD_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_PBOFWD_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_PBOFWD_TextBox.Location = New System.Drawing.Point(10, 6)
        Me.U_PBOFWD_TextBox.Name = "U_PBOFWD_TextBox"
        Me.U_PBOFWD_TextBox.ReadOnly = True
        Me.U_PBOFWD_TextBox.Size = New System.Drawing.Size(42, 13)
        Me.U_PBOFWD_TextBox.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(10, 7)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(42, 13)
        Me.TextBox3.TabIndex = 22
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel11.Controls.Add(Me.U_FWD_Button)
        Me.Panel11.Controls.Add(Me.TextBox2)
        Me.Panel11.Location = New System.Drawing.Point(228, 115)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(62, 26)
        Me.Panel11.TabIndex = 18
        '
        'U_FWD_Button
        '
        Me.U_FWD_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_FWD_Button.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_FWD_Button.Location = New System.Drawing.Point(10, 7)
        Me.U_FWD_Button.Name = "U_FWD_Button"
        Me.U_FWD_Button.ReadOnly = True
        Me.U_FWD_Button.Size = New System.Drawing.Size(42, 13)
        Me.U_FWD_Button.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(10, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(42, 13)
        Me.TextBox2.TabIndex = 22
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel10.Controls.Add(Me.U_WDIM_TextBox)
        Me.Panel10.Controls.Add(Me.TextBox1)
        Me.Panel10.Location = New System.Drawing.Point(228, 84)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(62, 26)
        Me.Panel10.TabIndex = 18
        '
        'U_WDIM_TextBox
        '
        Me.U_WDIM_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_WDIM_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_WDIM_TextBox.Location = New System.Drawing.Point(10, 6)
        Me.U_WDIM_TextBox.Name = "U_WDIM_TextBox"
        Me.U_WDIM_TextBox.ReadOnly = True
        Me.U_WDIM_TextBox.Size = New System.Drawing.Size(42, 13)
        Me.U_WDIM_TextBox.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(10, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(42, 13)
        Me.TextBox1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DaysInMonth)
        Me.Panel1.Location = New System.Drawing.Point(228, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 26)
        Me.Panel1.TabIndex = 18
        '
        'DaysInMonth
        '
        Me.DaysInMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DaysInMonth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DaysInMonth.Location = New System.Drawing.Point(10, 7)
        Me.DaysInMonth.Name = "DaysInMonth"
        Me.DaysInMonth.ReadOnly = True
        Me.DaysInMonth.Size = New System.Drawing.Size(42, 13)
        Me.DaysInMonth.TabIndex = 22
        '
        'U_PBOWD_Label
        '
        Me.U_PBOWD_Label.AutoSize = True
        Me.U_PBOWD_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_PBOWD_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_PBOWD_Label.Location = New System.Drawing.Point(169, 169)
        Me.U_PBOWD_Label.Name = "U_PBOWD_Label"
        Me.U_PBOWD_Label.Size = New System.Drawing.Size(56, 16)
        Me.U_PBOWD_Label.TabIndex = 19
        Me.U_PBOWD_Label.Text = "PLATA"
        '
        'U_FWD_Label
        '
        Me.U_FWD_Label.AutoSize = True
        Me.U_FWD_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_FWD_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_FWD_Label.Location = New System.Drawing.Point(48, 121)
        Me.U_FWD_Label.Name = "U_FWD_Label"
        Me.U_FWD_Label.Size = New System.Drawing.Size(177, 16)
        Me.U_FWD_Label.TabIndex = 18
        Me.U_FWD_Label.Text = "ODRAĐENI RADNI DANI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "BROJ DANA U MJESECU"
        '
        'U_WDIM_Label
        '
        Me.U_WDIM_Label.AutoSize = True
        Me.U_WDIM_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.U_WDIM_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_WDIM_Label.Location = New System.Drawing.Point(40, 90)
        Me.U_WDIM_Label.Name = "U_WDIM_Label"
        Me.U_WDIM_Label.Size = New System.Drawing.Size(185, 16)
        Me.U_WDIM_Label.TabIndex = 17
        Me.U_WDIM_Label.Text = "RADNI DANI U MJESECU"
        '
        'U_Month_Dropdown
        '
        Me.U_Month_Dropdown.FormattingEnabled = True
        Me.U_Month_Dropdown.Items.AddRange(New Object() {"Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septrembar", "Oktobar", "Novembar", "Decembar"})
        Me.U_Month_Dropdown.Location = New System.Drawing.Point(6, 19)
        Me.U_Month_Dropdown.Name = "U_Month_Dropdown"
        Me.U_Month_Dropdown.Size = New System.Drawing.Size(315, 21)
        Me.U_Month_Dropdown.TabIndex = 16
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(50, 178)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(57, 16)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "E-MAIL"
        '
        'U_Picture
        '
        Me.U_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.U_Picture.Location = New System.Drawing.Point(255, 52)
        Me.U_Picture.Name = "U_Picture"
        Me.U_Picture.Size = New System.Drawing.Size(126, 113)
        Me.U_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.U_Picture.TabIndex = 10
        Me.U_Picture.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(35, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADRESA"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(64, 334)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(37, 16)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "POL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(25, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "TELEFON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "POZICIJA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "KORISN IME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(2, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DATUM ROĐ."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PREZIME"
        '
        'U_Name_Label
        '
        Me.U_Name_Label.AutoSize = True
        Me.U_Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Name_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_Name_Label.Location = New System.Drawing.Point(69, 56)
        Me.U_Name_Label.Name = "U_Name_Label"
        Me.U_Name_Label.Size = New System.Drawing.Size(34, 16)
        Me.U_Name_Label.TabIndex = 0
        Me.U_Name_Label.Text = "IME"
        '
        'TabStorage
        '
        Me.TabStorage.BackColor = System.Drawing.SystemColors.Control
        Me.TabStorage.Controls.Add(Me.DataGridView1)
        Me.TabStorage.Location = New System.Drawing.Point(4, 22)
        Me.TabStorage.Name = "TabStorage"
        Me.TabStorage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStorage.Size = New System.Drawing.Size(768, 359)
        Me.TabStorage.TabIndex = 0
        Me.TabStorage.Text = "Skladište"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(755, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabStorage)
        Me.TabControl1.Controls.Add(Me.TabUserInfo)
        Me.TabControl1.Location = New System.Drawing.Point(12, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 385)
        Me.TabControl1.TabIndex = 128
        '
        'Korisnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 517)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Korisnik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Panel"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabUserInfo.ResumeLayout(False)
        Me.TabUserInfo.PerformLayout()
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel42.ResumeLayout(False)
        Me.Panel42.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.U_Monthly_Pay_GroupBox.ResumeLayout(False)
        Me.U_Monthly_Pay_GroupBox.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStorage.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TabUserInfo As TabPage
    Friend WithEvents Panel40 As Panel
    Friend WithEvents U_Male_TextBox As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents U_Phone_TextBox As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents U_Possition_TextBox As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents U_Username_TextBox As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents U_Birth_TextBox As TextBox
    Friend WithEvents Panel42 As Panel
    Friend WithEvents U_Email_TextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents U_Adresa_TextBox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents U_Surname_TextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents U_Name_TextBox As TextBox
    Friend WithEvents U_Monthly_Pay_GroupBox As GroupBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents U_PBOFWD_TextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents U_FWD_Button As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents U_WDIM_TextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DaysInMonth As TextBox
    Friend WithEvents U_PBOWD_Label As Label
    Friend WithEvents U_FWD_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents U_WDIM_Label As Label
    Friend WithEvents U_Month_Dropdown As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents U_Picture As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents U_Name_Label As Label
    Friend WithEvents TabStorage As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents U_NoFile_Label As Label
    Friend WithEvents PonistiIzmjeneDugme As Button
    Friend WithEvents dugmeSacuvaj As Button
    Friend WithEvents Button1 As Button
End Class
