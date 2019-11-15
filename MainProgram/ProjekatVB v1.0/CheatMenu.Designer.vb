<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheatMenu
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
        Me.btAdmin = New System.Windows.Forms.Button()
        Me.btKorisnik = New System.Windows.Forms.Button()
        Me.lbGost = New System.Windows.Forms.Label()
        Me.btKupovina = New System.Windows.Forms.Button()
        Me.btPosao = New System.Windows.Forms.Button()
        Me.lbKorisnik = New System.Windows.Forms.Label()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.btDodajKorisnika = New System.Windows.Forms.Button()
        Me.btKorisnikSvi = New System.Windows.Forms.Button()
        Me.btScrollKorisnik = New System.Windows.Forms.Button()
        Me.btLogs = New System.Windows.Forms.Button()
        Me.btArtikli = New System.Windows.Forms.Button()
        Me.btIzmjena = New System.Windows.Forms.Button()
        Me.btIzbrisiDodaj = New System.Windows.Forms.Button()
        Me.btNazad = New System.Windows.Forms.Button()
        Me.btIzlaz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btAdmin
        '
        Me.btAdmin.Location = New System.Drawing.Point(381, 90)
        Me.btAdmin.Name = "btAdmin"
        Me.btAdmin.Size = New System.Drawing.Size(140, 65)
        Me.btAdmin.TabIndex = 0
        Me.btAdmin.Text = "Admin"
        Me.btAdmin.UseVisualStyleBackColor = True
        '
        'btKorisnik
        '
        Me.btKorisnik.Location = New System.Drawing.Point(164, 90)
        Me.btKorisnik.Name = "btKorisnik"
        Me.btKorisnik.Size = New System.Drawing.Size(140, 65)
        Me.btKorisnik.TabIndex = 1
        Me.btKorisnik.Text = "Korisnik"
        Me.btKorisnik.UseVisualStyleBackColor = True
        '
        'lbGost
        '
        Me.lbGost.AutoSize = True
        Me.lbGost.Location = New System.Drawing.Point(45, 46)
        Me.lbGost.Name = "lbGost"
        Me.lbGost.Size = New System.Drawing.Size(32, 13)
        Me.lbGost.TabIndex = 2
        Me.lbGost.Text = "Gost:"
        '
        'btKupovina
        '
        Me.btKupovina.Location = New System.Drawing.Point(48, 90)
        Me.btKupovina.Name = "btKupovina"
        Me.btKupovina.Size = New System.Drawing.Size(75, 23)
        Me.btKupovina.TabIndex = 3
        Me.btKupovina.Text = "Kupovina"
        Me.btKupovina.UseVisualStyleBackColor = True
        '
        'btPosao
        '
        Me.btPosao.Location = New System.Drawing.Point(48, 132)
        Me.btPosao.Name = "btPosao"
        Me.btPosao.Size = New System.Drawing.Size(75, 23)
        Me.btPosao.TabIndex = 4
        Me.btPosao.Text = "Posao"
        Me.btPosao.UseVisualStyleBackColor = True
        '
        'lbKorisnik
        '
        Me.lbKorisnik.AutoSize = True
        Me.lbKorisnik.Location = New System.Drawing.Point(161, 45)
        Me.lbKorisnik.Name = "lbKorisnik"
        Me.lbKorisnik.Size = New System.Drawing.Size(44, 13)
        Me.lbKorisnik.TabIndex = 5
        Me.lbKorisnik.Text = "Korisnik"
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(381, 44)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(36, 13)
        Me.lbAdmin.TabIndex = 6
        Me.lbAdmin.Text = "Admin"
        '
        'btDodajKorisnika
        '
        Me.btDodajKorisnika.Location = New System.Drawing.Point(381, 174)
        Me.btDodajKorisnika.Name = "btDodajKorisnika"
        Me.btDodajKorisnika.Size = New System.Drawing.Size(140, 23)
        Me.btDodajKorisnika.TabIndex = 7
        Me.btDodajKorisnika.Text = "Dodaj Korisnika"
        Me.btDodajKorisnika.UseVisualStyleBackColor = True
        '
        'btKorisnikSvi
        '
        Me.btKorisnikSvi.Location = New System.Drawing.Point(381, 228)
        Me.btKorisnikSvi.Name = "btKorisnikSvi"
        Me.btKorisnikSvi.Size = New System.Drawing.Size(140, 23)
        Me.btKorisnikSvi.TabIndex = 8
        Me.btKorisnikSvi.Text = "Pregled Svih Korisnika"
        Me.btKorisnikSvi.UseVisualStyleBackColor = True
        '
        'btScrollKorisnik
        '
        Me.btScrollKorisnik.Location = New System.Drawing.Point(381, 276)
        Me.btScrollKorisnik.Name = "btScrollKorisnik"
        Me.btScrollKorisnik.Size = New System.Drawing.Size(140, 23)
        Me.btScrollKorisnik.TabIndex = 9
        Me.btScrollKorisnik.Text = "Scroll Korisnika"
        Me.btScrollKorisnik.UseVisualStyleBackColor = True
        '
        'btLogs
        '
        Me.btLogs.Location = New System.Drawing.Point(381, 324)
        Me.btLogs.Name = "btLogs"
        Me.btLogs.Size = New System.Drawing.Size(140, 23)
        Me.btLogs.TabIndex = 10
        Me.btLogs.Text = "Logovi"
        Me.btLogs.UseVisualStyleBackColor = True
        '
        'btArtikli
        '
        Me.btArtikli.Location = New System.Drawing.Point(381, 365)
        Me.btArtikli.Name = "btArtikli"
        Me.btArtikli.Size = New System.Drawing.Size(140, 44)
        Me.btArtikli.TabIndex = 11
        Me.btArtikli.Text = "Artikli"
        Me.btArtikli.UseVisualStyleBackColor = True
        '
        'btIzmjena
        '
        Me.btIzmjena.Location = New System.Drawing.Point(555, 365)
        Me.btIzmjena.Name = "btIzmjena"
        Me.btIzmjena.Size = New System.Drawing.Size(75, 23)
        Me.btIzmjena.TabIndex = 12
        Me.btIzmjena.Text = "Izmjena"
        Me.btIzmjena.UseVisualStyleBackColor = True
        '
        'btIzbrisiDodaj
        '
        Me.btIzbrisiDodaj.Location = New System.Drawing.Point(555, 395)
        Me.btIzbrisiDodaj.Name = "btIzbrisiDodaj"
        Me.btIzbrisiDodaj.Size = New System.Drawing.Size(75, 23)
        Me.btIzbrisiDodaj.TabIndex = 13
        Me.btIzbrisiDodaj.Text = "Izbrisi\Dodaj"
        Me.btIzbrisiDodaj.UseVisualStyleBackColor = True
        '
        'btNazad
        '
        Me.btNazad.Location = New System.Drawing.Point(713, 13)
        Me.btNazad.Name = "btNazad"
        Me.btNazad.Size = New System.Drawing.Size(75, 23)
        Me.btNazad.TabIndex = 14
        Me.btNazad.Text = "Nazad"
        Me.btNazad.UseVisualStyleBackColor = True
        '
        'btIzlaz
        '
        Me.btIzlaz.Location = New System.Drawing.Point(713, 46)
        Me.btIzlaz.Name = "btIzlaz"
        Me.btIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btIzlaz.TabIndex = 15
        Me.btIzlaz.Text = "Izlaz"
        Me.btIzlaz.UseVisualStyleBackColor = True
        '
        'CheatMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btIzlaz)
        Me.Controls.Add(Me.btNazad)
        Me.Controls.Add(Me.btIzbrisiDodaj)
        Me.Controls.Add(Me.btIzmjena)
        Me.Controls.Add(Me.btArtikli)
        Me.Controls.Add(Me.btLogs)
        Me.Controls.Add(Me.btScrollKorisnik)
        Me.Controls.Add(Me.btKorisnikSvi)
        Me.Controls.Add(Me.btDodajKorisnika)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.lbKorisnik)
        Me.Controls.Add(Me.btPosao)
        Me.Controls.Add(Me.btKupovina)
        Me.Controls.Add(Me.lbGost)
        Me.Controls.Add(Me.btKorisnik)
        Me.Controls.Add(Me.btAdmin)
        Me.Name = "CheatMenu"
        Me.Text = "CheatMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAdmin As Button
    Friend WithEvents btKorisnik As Button
    Friend WithEvents lbGost As Label
    Friend WithEvents btKupovina As Button
    Friend WithEvents btPosao As Button
    Friend WithEvents lbKorisnik As Label
    Friend WithEvents lbAdmin As Label
    Friend WithEvents btDodajKorisnika As Button
    Friend WithEvents btKorisnikSvi As Button
    Friend WithEvents btScrollKorisnik As Button
    Friend WithEvents btLogs As Button
    Friend WithEvents btArtikli As Button
    Friend WithEvents btIzmjena As Button
    Friend WithEvents btIzbrisiDodaj As Button
    Friend WithEvents btNazad As Button
    Friend WithEvents btIzlaz As Button
End Class
