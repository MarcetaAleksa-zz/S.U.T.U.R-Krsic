<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteForma
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
        Me.Panel3.Location = New System.Drawing.Point(-39, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(625, 68)
        Me.Panel3.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjekatVB_v1._0.My.Resources.Resources.slicurina
        Me.PictureBox1.Location = New System.Drawing.Point(220, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(254, 27)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(176, 25)
        Me.LabelZaNaziv.TabIndex = 6
        Me.LabelZaNaziv.Text = "IZBRISI ARTIKAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(417, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CIJENA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(286, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "KOLICINA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(68, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "NAZIV ARTIKLA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.t3)
        Me.Panel2.Location = New System.Drawing.Point(407, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 39)
        Me.Panel2.TabIndex = 27
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
        Me.t3.ReadOnly = True
        Me.t3.Size = New System.Drawing.Size(75, 22)
        Me.t3.TabIndex = 118
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.t2)
        Me.Panel1.Location = New System.Drawing.Point(286, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 39)
        Me.Panel1.TabIndex = 28
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
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(75, 22)
        Me.t2.TabIndex = 118
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.t1)
        Me.Panel9.Location = New System.Drawing.Point(58, 159)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(213, 39)
        Me.Panel9.TabIndex = 26
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
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(181, 22)
        Me.t1.TabIndex = 118
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(291, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 39)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "IZBRISI"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(405, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 39)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Ponisti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Da li ste sigurni da zelite izbrisati dole navedeni artikal?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DeleteForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 276)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteForma"
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelZaNaziv As Label
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
End Class
