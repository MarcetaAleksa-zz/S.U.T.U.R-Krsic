Public Class LogoviForma
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UspjesnaPrijavaButton.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\UspjesnaPrijavaLogs.txt")

    End Sub

    Private Sub NoviNalogButton_Click(sender As Object, e As EventArgs) Handles NeuspjesnaPrijavaButton.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\NeuspjesnaPrijavaLogs.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeletedUsersLogsButton.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\ObrisaniKorisniciLogs.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddUsersLogButton.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\DodaniKorisniciLogs.txt")
    End Sub

    Private Sub UspjesnaKupovinaButton_Click(sender As Object, e As EventArgs) Handles UspjesnaKupovinaButton.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\UspjesnaKupovinaLogs.txt")
    End Sub

    Private Sub NeuspjesnaKupovinaLogs_Click(sender As Object, e As EventArgs) Handles NeuspjesnaKupovinaLogs.Click
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\NeuspjesnaKupovinaLogs.txt")
    End Sub
End Class