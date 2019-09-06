Public Class logovi
    Public Shared Sub UspjesnaPrijavaLog()
        Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")

        'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
        Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt", True)
        Log_File.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Log_File.Close()
    End Sub
    Public Shared Sub NeuspjesnaPrijavaLog()
        Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")

        'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
        Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt", True)
        Failed_Log.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Failed_Log.Close()
    End Sub
    Public Shared Sub BrisanjeKorisnikaLog()
        Dim Brisanje_Korisnika As System.IO.StreamWriter
        Dim Brisanje_Datum As String
        Brisanje_Datum = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        Try
            'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
            Brisanje_Korisnika = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Deleted\\ObrisaniKorisnici.txt", True)
            Brisanje_Korisnika.WriteLine("Admin: " + Prijava.Username_Form_Box.Text + ";; Obrisani korisnik: " + PretragaRadnika.U_Username_TextBox.Text + ";; Datum i vrijeme brisanja: " + Brisanje_Datum)
            Brisanje_Korisnika.Close()
        Catch
        End Try

    End Sub
    Public Shared Sub DodavanjeKorisnikaLog()
        Dim Dodavanje_Korisnika As System.IO.StreamWriter
        Dim DodavanjeKorisnika_Datum As String
        DodavanjeKorisnika_Datum = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        Try
            'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
            Dodavanje_Korisnika = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Deleted\\DodaniKorisnici.txt", True)
            Dodavanje_Korisnika.WriteLine("Admin: " + Prijava.Username_Form_Box.Text + ";; Dodani korisnik: " + UnosRadnika.UR_Username_TextBox.Text + ";; Ime korisnika: " + UnosRadnika.UR_Name_TextBox.Text + ";; Prezime: " + UnosRadnika.UR_Surname_TextBox.Text + ";;Pozicija : " + UnosRadnika.URComboBox.Text + ";;Email: " + UnosRadnika.UR_Email_TextBox.Text + ";;Broj telefona: " + UnosRadnika.UR_Phone_TextBox.Text)
            Dodavanje_Korisnika.Close()
        Catch
        End Try
    End Sub

End Class
