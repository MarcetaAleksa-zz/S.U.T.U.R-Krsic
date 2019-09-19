Public Class logovi
    Public Shared Sub Log()
        Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")

        'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
        Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt", True)
        Log_File.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Log_File.Close()
    End Sub
    Public Shared Sub FailedLog()
        Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")

        'promjeniti ime korisnika na Aleksandar ili marce (c:\Users\(jedno od ponudjenih imena)\...)
        Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt", True)
        Failed_Log.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Failed_Log.Close()
    End Sub
    Public Shared Sub BrisanjeKorisnika()
        Dim Brisanje_Korisnika As System.IO.StreamWriter
        Dim Brisanje_Datum As String
        Brisanje_Datum = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        Try
            Brisanje_Korisnika = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\ObrisaniKorisnici.txt", True)
            Brisanje_Korisnika.WriteLine("Admin: " + Prijava.Username_Form_Box.Text + ";; Obrisani korisnik: " + PretragaRadnika.U_Username_TextBox.Text + ";; Datum i vrijeme brisanja: " + Brisanje_Datum)
            Brisanje_Korisnika.Close()
        Catch
        End Try

    End Sub

    Public Shared Sub DodavanjeKorisnika()
        Dim Dodavanje_Korisnika As System.IO.StreamWriter
        Dim Dodavanje_Datum As String
        Dodavanje_Datum = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        Try
            Dodavanje_Korisnika = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\DodaniKorisnici.txt", True)
            Dodavanje_Korisnika.WriteLine("Admin: " + Prijava.Username_Form_Box.Text + ";; Dodani korisnik: " + UnosRadnika.UR_Username_TextBox.Text + ";; Ime i prezime: " + UnosRadnika.UR_Name_TextBox.Text + " " + UnosRadnika.UR_Surname_TextBox.Text + ";;Email:" + UnosRadnika.UR_Email_TextBox.Text + ";; Datum i vrijeme dodavanja: " + Dodavanje_Datum)
            Dodavanje_Korisnika.Close()
        Catch
        End Try

    End Sub

End Class
