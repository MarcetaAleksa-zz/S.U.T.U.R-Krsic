<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DodajForma
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(802, 68)
        Me.Panel3.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjekatVB_v1._0.My.Resources.Resources.ADD
        Me.PictureBox1.Location = New System.Drawing.Point(175, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(209, 24)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(176, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "DODAJ ARTIKAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(473, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "CIJENA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(342, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "KOLICINA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(27, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "NAZIV ARTIKLA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.t3)
        Me.Panel2.Location = New System.Drawing.Point(463, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 39)
        Me.Panel2.TabIndex = 35
        '
        't3
        '
        Me.t3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.t3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.ForeColor = System.Drawing.Color.Black
        Me.t3.Location = New System.Drawing.Point(15, 7)
        Me.t3.MaxLength = 20
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(75, 22)
        Me.t3.TabIndex = 118
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.t2)
        Me.Panel1.Location = New System.Drawing.Point(342, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 39)
        Me.Panel1.TabIndex = 36
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.t2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.ForeColor = System.Drawing.Color.Black
        Me.t2.Location = New System.Drawing.Point(15, 7)
        Me.t2.MaxLength = 20
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(75, 22)
        Me.t2.TabIndex = 118
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.t1)
        Me.Panel9.Location = New System.Drawing.Point(17, 142)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(213, 39)
        Me.Panel9.TabIndex = 34
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.t1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(15, 7)
        Me.t1.MaxLength = 50
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(181, 22)
        Me.t1.TabIndex = 118
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(298, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 39)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "DODAJ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(412, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 39)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Ponisti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(261, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TIP"
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"", "Cvijece", "Krst", "Sanduk", "Svijeca"})
        Me.ComboBox1.Location = New System.Drawing.Point(236, 149)
        Me.ComboBox1.MaxLength = 20
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 0
        '
        'DodajForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 276)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DodajForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DodajForma"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents t3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents t2 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents t1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
