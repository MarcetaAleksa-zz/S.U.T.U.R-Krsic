Imports System.IO
Imports System.Data.SqlClient
Public Class LogFile
    Shared card As String
    Public Shared Sub Log()
        ' Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        'college (C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\)
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        'Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + PaymentMethod_From.ovojenalog + "\\Documents\\GitHub\\S.U.T.U.R-Krsic\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\Log.txt", True)
        If PaymentMethod_From.counter = 1 Then
            card = "Master Card"
            'Log_File.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            card = "American Express"
            'Log_File.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 3 Then
            card = "Visa"
            'Log_File.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If
        'Log_File.Close()


        Try
            databaseconnection.connection.Open()
            Dim command As New SqlCommand("INSERT INTO log_kupovina(Kartica, Iznos, Ime, Prezime, broj_kartice, Kupovina, Datum) Values('" & card & "','" & PaymentMethod_From.PriceTextBox.Text & "','" & PaymentMethod_From.FirstNameTextBox.Text & "','" & PaymentMethod_From.LastNameTextBox.Text & "','" & PaymentMethod_From.CardNumberTextBox.Text & "', 1, '" & Log_Date & "')", databaseconnection.connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            databaseconnection.connection.Close()
        End Try




        'dodaj u bazu uspjenu transakciju!





    End Sub
    Public Shared Sub FailedLog()
        ' Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        'collegeC:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        ' njemecka C:\\Users\\Nutzer\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\FailedLogs.txt
        'Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\" + PaymentMethod_From.ovojenalog + "\\Documents\\GitHub\\S.U.T.U.R-Krsic\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\FailedLogs.txt", True)
        'If PaymentMethod_From.counter = 1 Then
        '    Failed_Log.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        'ElseIf PaymentMethod_From.counter = 2 Then
        '    Failed_Log.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        'ElseIf PaymentMethod_From.counter = 3 Then
        '    Failed_Log.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        'End If
        'Failed_Log.Close()
        If PaymentMethod_From.counter = 1 Then
            card = "Master Card"
            'Log_File.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            card = "American Express"
            'Log_File.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 3 Then
            card = "Visa"
            'Log_File.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If

        Try
            databaseconnection.connection.Open()
            Dim command As New SqlCommand("INSERT INTO log_kupovina(Kartica, Iznos, Ime, Prezime, broj_kartice, Kupovina, Datum) Values('" & card & "','" & PaymentMethod_From.PriceTextBox.Text & "','" & PaymentMethod_From.FirstNameTextBox.Text & "','" & PaymentMethod_From.LastNameTextBox.Text & "','" & PaymentMethod_From.CardNumberTextBox.Text & "', 0, '" & Log_Date & "')", databaseconnection.connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            databaseconnection.connection.Close()
        End Try

        'dodaj u bazu neuspjesnu transakciju!





    End Sub
End Class