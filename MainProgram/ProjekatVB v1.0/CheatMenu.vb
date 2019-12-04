Public Class CheatMenu
    Private Sub btKupovina_Click(sender As Object, e As EventArgs) Handles btKupovina.Click
        Me.Hide()
        Narudzba.Show()
    End Sub

    Private Sub btPosao_Click(sender As Object, e As EventArgs) Handles btPosao.Click
        Me.Hide()
        aplikacijaPosao.Show()
    End Sub

    Private Sub btNazad_Click(sender As Object, e As EventArgs) Handles btNazad.Click
        Me.Hide()
        Prijava.Show()
    End Sub

    Private Sub btIzlaz_Click(sender As Object, e As EventArgs) Handles btIzlaz.Click
        Prijava.Close()
        Me.Close()
    End Sub

    Private Sub btKorisnik_Click(sender As Object, e As EventArgs) Handles btKorisnik.Click
        Prijava.Username_Form_Box.Text = "HarunH"
        Korisnik.Show()
        Me.Hide()
    End Sub

    Private Sub btAdmin_Click(sender As Object, e As EventArgs) Handles btAdmin.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        Prijava.tipNaloga = 1
        Administrator.Show()
        Me.Hide()
    End Sub

    Private Sub btDodajKorisnika_Click(sender As Object, e As EventArgs) Handles btDodajKorisnika.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        UnosRadnika.Show()
        Me.Hide()
    End Sub

    Private Sub btKorisnikSvi_Click(sender As Object, e As EventArgs) Handles btKorisnikSvi.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        PregledRadnika.Show()
        Me.Hide()
    End Sub

    Private Sub btScrollKorisnik_Click(sender As Object, e As EventArgs) Handles btScrollKorisnik.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        PretragaRadnika.Show()
        Me.Hide()
    End Sub

    Private Sub btLogs_Click(sender As Object, e As EventArgs) Handles btLogs.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        FormaLogova.Show()
        Me.Hide()
    End Sub

    Private Sub btArtikli_Click(sender As Object, e As EventArgs) Handles btArtikli.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        kontrolaSkladista.Show()
        Me.Hide()
    End Sub

    Private Sub btIzmjena_Click(sender As Object, e As EventArgs) Handles btIzmjena.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        Artikli.Show()
        Me.Hide()
    End Sub

    Private Sub btIzbrisiDodaj_Click(sender As Object, e As EventArgs) Handles btIzbrisiDodaj.Click
        Prijava.Username_Form_Box.Text = "MarLeksa"
        dodajObrisi_Artikle.Show()
        Me.Hide()
    End Sub

    Private Sub CheatMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        pregledAplikacija.Show()
    End Sub
End Class