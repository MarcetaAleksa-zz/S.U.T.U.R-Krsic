<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pregledRadnika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pregledRadnika))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.dugmeIzmijeni = New System.Windows.Forms.Button()
        Me.dugmeSacuvaj = New System.Windows.Forms.Button()
        Me.PraznaPoljaLabel = New System.Windows.Forms.Label()
        Me.PonistiIzmjeneDugme = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(891, 68)
        Me.Panel3.TabIndex = 11
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(330, 25)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(210, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "PREGLED RADNIKA"
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Back_Button.Location = New System.Drawing.Point(12, 74)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(40, 40)
        Me.Back_Button.TabIndex = 111
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'dugmeIzmijeni
        '
        Me.dugmeIzmijeni.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dugmeIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dugmeIzmijeni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dugmeIzmijeni.Location = New System.Drawing.Point(58, 74)
        Me.dugmeIzmijeni.Name = "dugmeIzmijeni"
        Me.dugmeIzmijeni.Size = New System.Drawing.Size(109, 40)
        Me.dugmeIzmijeni.TabIndex = 127
        Me.dugmeIzmijeni.Text = "Izmijeni"
        Me.dugmeIzmijeni.UseVisualStyleBackColor = False
        Me.dugmeIzmijeni.Visible = False
        '
        'dugmeSacuvaj
        '
        Me.dugmeSacuvaj.BackColor = System.Drawing.SystemColors.Control
        Me.dugmeSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dugmeSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dugmeSacuvaj.Location = New System.Drawing.Point(58, 74)
        Me.dugmeSacuvaj.Name = "dugmeSacuvaj"
        Me.dugmeSacuvaj.Size = New System.Drawing.Size(109, 40)
        Me.dugmeSacuvaj.TabIndex = 128
        Me.dugmeSacuvaj.Text = "Sacuvaj"
        Me.dugmeSacuvaj.UseVisualStyleBackColor = False
        Me.dugmeSacuvaj.Visible = False
        '
        'PraznaPoljaLabel
        '
        Me.PraznaPoljaLabel.AutoSize = True
        Me.PraznaPoljaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PraznaPoljaLabel.Location = New System.Drawing.Point(530, 105)
        Me.PraznaPoljaLabel.Name = "PraznaPoljaLabel"
        Me.PraznaPoljaLabel.Size = New System.Drawing.Size(251, 12)
        Me.PraznaPoljaLabel.TabIndex = 129
        Me.PraznaPoljaLabel.Text = "*Polja:Ime,Korisnicko Ime, Pozicija i Pol, ne smiju biti prazni!"
        Me.PraznaPoljaLabel.Visible = False
        '
        'PonistiIzmjeneDugme
        '
        Me.PonistiIzmjeneDugme.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PonistiIzmjeneDugme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PonistiIzmjeneDugme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PonistiIzmjeneDugme.ForeColor = System.Drawing.SystemColors.Control
        Me.PonistiIzmjeneDugme.Location = New System.Drawing.Point(173, 74)
        Me.PonistiIzmjeneDugme.Name = "PonistiIzmjeneDugme"
        Me.PonistiIzmjeneDugme.Size = New System.Drawing.Size(109, 40)
        Me.PonistiIzmjeneDugme.TabIndex = 136
        Me.PonistiIzmjeneDugme.Text = "Ponisti izmjene"
        Me.PonistiIzmjeneDugme.UseVisualStyleBackColor = False
        Me.PonistiIzmjeneDugme.Visible = False
        '
        'pregledRadnika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 450)
        Me.Controls.Add(Me.PonistiIzmjeneDugme)
        Me.Controls.Add(Me.PraznaPoljaLabel)
        Me.Controls.Add(Me.dugmeSacuvaj)
        Me.Controls.Add(Me.dugmeIzmijeni)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pregledRadnika"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents Back_Button As Button
    Friend WithEvents dugmeIzmijeni As Button
    Friend WithEvents dugmeSacuvaj As Button
    Friend WithEvents PraznaPoljaLabel As Label
    Friend WithEvents PonistiIzmjeneDugme As Button
End Class
