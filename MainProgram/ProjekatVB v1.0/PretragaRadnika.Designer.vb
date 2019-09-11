<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PretragaRadnika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PretragaRadnika))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.U_Name_Label = New System.Windows.Forms.Label()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.U_Picture = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Brisanje = New System.Windows.Forms.Button()
        Me.IzbrisiLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(802, 68)
        Me.Panel3.TabIndex = 11
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(134, 24)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(225, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "PRETRAGA RADNIKA"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.U_Phone_TextBox)
        Me.Panel9.Location = New System.Drawing.Point(115, 322)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(139, 26)
        Me.Panel9.TabIndex = 27
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
        Me.Panel8.Location = New System.Drawing.Point(115, 290)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(139, 26)
        Me.Panel8.TabIndex = 28
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
        Me.Panel7.Location = New System.Drawing.Point(115, 224)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 26)
        Me.Panel7.TabIndex = 29
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel6.Controls.Add(Me.U_Birth_TextBox)
        Me.Panel6.Location = New System.Drawing.Point(115, 257)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(139, 26)
        Me.Panel6.TabIndex = 30
        '
        'U_Birth_TextBox
        '
        Me.U_Birth_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Birth_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Birth_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Birth_TextBox.Name = "U_Birth_TextBox"
        Me.U_Birth_TextBox.ReadOnly = True
        Me.U_Birth_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Birth_TextBox.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel5.Controls.Add(Me.U_Email_TextBox)
        Me.Panel5.Location = New System.Drawing.Point(115, 192)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 26)
        Me.Panel5.TabIndex = 31
        '
        'U_Email_TextBox
        '
        Me.U_Email_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.U_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_Email_TextBox.Location = New System.Drawing.Point(12, 7)
        Me.U_Email_TextBox.Name = "U_Email_TextBox"
        Me.U_Email_TextBox.ReadOnly = True
        Me.U_Email_TextBox.Size = New System.Drawing.Size(115, 13)
        Me.U_Email_TextBox.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel4.Controls.Add(Me.U_Surname_TextBox)
        Me.Panel4.Location = New System.Drawing.Point(115, 155)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(139, 26)
        Me.Panel4.TabIndex = 32
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
        Me.Panel2.Location = New System.Drawing.Point(115, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 26)
        Me.Panel2.TabIndex = 33
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(55, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "E-MAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(31, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "TELEFON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(34, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "POZICIJA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "KORISN IME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "DATUM ROĐ."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "PREZIME"
        '
        'U_Name_Label
        '
        Me.U_Name_Label.AutoSize = True
        Me.U_Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Name_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.U_Name_Label.Location = New System.Drawing.Point(74, 126)
        Me.U_Name_Label.Name = "U_Name_Label"
        Me.U_Name_Label.Size = New System.Drawing.Size(34, 16)
        Me.U_Name_Label.TabIndex = 25
        Me.U_Name_Label.Text = "IME"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'U_Picture
        '
        Me.U_Picture.Location = New System.Drawing.Point(260, 122)
        Me.U_Picture.Name = "U_Picture"
        Me.U_Picture.Size = New System.Drawing.Size(126, 113)
        Me.U_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.U_Picture.TabIndex = 26
        Me.U_Picture.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Back_Button.Location = New System.Drawing.Point(17, 74)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(40, 40)
        Me.Back_Button.TabIndex = 112
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Brisanje
        '
        Me.Brisanje.Location = New System.Drawing.Point(446, 74)
        Me.Brisanje.Name = "Brisanje"
        Me.Brisanje.Size = New System.Drawing.Size(40, 40)
        Me.Brisanje.TabIndex = 113
        Me.Brisanje.UseVisualStyleBackColor = True
        Me.Brisanje.Visible = False
        '
        'IzbrisiLabel
        '
        Me.IzbrisiLabel.AutoSize = True
        Me.IzbrisiLabel.Location = New System.Drawing.Point(359, 85)
        Me.IzbrisiLabel.Name = "IzbrisiLabel"
        Me.IzbrisiLabel.Size = New System.Drawing.Size(81, 13)
        Me.IzbrisiLabel.TabIndex = 114
        Me.IzbrisiLabel.Text = "Izbrisi korisnika:"
        Me.IzbrisiLabel.Visible = False
        '
        'Timer2
        '
        '
        'PretragaRadnika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 390)
        Me.Controls.Add(Me.IzbrisiLabel)
        Me.Controls.Add(Me.Brisanje)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.U_Picture)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.U_Name_Label)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PretragaRadnika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PretragaRadnika"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
        CType(Me.U_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents U_Phone_TextBox As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents U_Possition_TextBox As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents U_Username_TextBox As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents U_Birth_TextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents U_Email_TextBox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents U_Surname_TextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents U_Name_TextBox As TextBox
    Friend WithEvents U_Picture As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents U_Name_Label As Label
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Back_Button As Button
    Friend WithEvents Brisanje As Button
    Friend WithEvents IzbrisiLabel As Label
    Friend WithEvents Timer2 As Timer
End Class
