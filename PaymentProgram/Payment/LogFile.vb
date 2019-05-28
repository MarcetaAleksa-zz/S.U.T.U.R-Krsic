﻿Imports System.IO
Public Class LogFile

    Public Shared Sub Log()
        Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'college (C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\)
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\Log.txt", True)
        If PaymentMethod_From.counter = 1 Then
            Log_File.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            Log_File.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 3 Then
            Log_File.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If
        Log_File.Close()
    End Sub
    Public Shared Sub FailedLog()
        Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'collegeC:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\FailedLogs.txt", True)
        If PaymentMethod_From.counter = 1 Then
            Failed_Log.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            Failed_Log.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 3 Then
            Failed_Log.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.PriceTextBox.Text + "KM; First Name: " + PaymentMethod_From.FirstNameTextBox.Text + "; Last Name: " + PaymentMethod_From.LastNameTextBox.Text + "; Credit Card Number: " + PaymentMethod_From.CardNumberTextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If
        Failed_Log.Close()
    End Sub
End Class