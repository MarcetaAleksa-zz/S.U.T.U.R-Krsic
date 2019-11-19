<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForma
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(372, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ponisti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(258, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sacuvaj"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(-9, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(596, 68)
        Me.Panel3.TabIndex = 12
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(185, 24)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(191, 25)
        Me.LabelZaNaziv.TabIndex = 6
        Me.LabelZaNaziv.Text = "IZMIJENI ARTIKAL"
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
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel9.Controls.Add(Me.t1)
        Me.Panel9.Location = New System.Drawing.Point(25, 123)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(213, 39)
        Me.Panel9.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.t2)
        Me.Panel1.Location = New System.Drawing.Point(253, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 39)
        Me.Panel1.TabIndex = 20
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.t3)
        Me.Panel2.Location = New System.Drawing.Point(374, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 39)
        Me.Panel2.TabIndex = 20
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(53, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NAZIV ARTIKLA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(253, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "KOLICINA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(384, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CIJENA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjekatVB_v1._0.My.Resources.Resources.edittt2
        Me.PictureBox1.Location = New System.Drawing.Point(151, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'EditForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 237)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditForma"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents t1 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents t2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents t3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
