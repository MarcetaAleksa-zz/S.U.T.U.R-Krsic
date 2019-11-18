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
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(25, 97)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(121, 20)
        Me.t1.TabIndex = 0
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(163, 97)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(58, 20)
        Me.t2.TabIndex = 1
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(238, 96)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(60, 20)
        Me.t3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ponisti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sacuvaj"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Naziv proizvoda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kolicina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cijena"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(-9, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(408, 52)
        Me.Panel3.TabIndex = 12
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(79, 16)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(191, 25)
        Me.LabelZaNaziv.TabIndex = 6
        Me.LabelZaNaziv.Text = "IZMIJENI ARTIKAL"
        '
        'EditForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 154)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditForma"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t1 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
End Class
