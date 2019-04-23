Imports System.IO
Public Class LogFile
    Public Shared Sub Log()
        Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'college (C:\\Users\\IT\Desktop\\Projekat\\Imdonefore\\PaymentProgram\\Payment\\bin\\Debug\\)
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\Log.txt", True)
        If PaymentMethod_From.counter = 3 Then
            Log_File.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + MasterCard_Form.FirstName_TextBox.Text + "; Last Name: " + MasterCard_Form.LastName_TextBox.Text + "; Credit Card Number: " + MasterCard_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 1 Then
            Log_File.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + AmericanExpress_Form.FirstName_TextBox.Text + "; Last Name: " + AmericanExpress_Form.LastName_TextBox.Text + "; Credit Card Number: " + AmericanExpress_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            Log_File.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + VisaCard_Form.FirstName_TextBox.Text + "; Last Name: " + VisaCard_Form.LastName_TextBox.Text + "; Credit Card Number: " + VisaCard_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If
        Log_File.Close()
    End Sub
    Public Shared Sub FailedLog()
        Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'college C:\\Users\\IT\Desktop\\Projekat\\Imdonefore\\PaymentProgram\\Payment\\bin\\Debug\\
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\FailedLogs.txt", True)
        If PaymentMethod_From.counter = 3 Then
            Failed_Log.WriteLine("Card Type: Master Card; Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + MasterCard_Form.FirstName_TextBox.Text + "; Last Name: " + MasterCard_Form.LastName_TextBox.Text + "; Credit Card Number: " + MasterCard_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 1 Then
            Failed_Log.WriteLine("Card Type: American Express;  Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + AmericanExpress_Form.FirstName_TextBox.Text + "; Last Name: " + AmericanExpress_Form.LastName_TextBox.Text + "; Credit Card Number: " + AmericanExpress_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        ElseIf PaymentMethod_From.counter = 2 Then
            Failed_Log.WriteLine("Card Type: Visa; Ammount: " + PaymentMethod_From.Price + "KM; First Name: " + VisaCard_Form.FirstName_TextBox.Text + "; Last Name: " + VisaCard_Form.LastName_TextBox.Text + "; Credit Card Number: " + VisaCard_Form.CardNumber_TextBox.Text + "; " + PaymentMethod_From.ErrorMsg + ";; Purchase attempt: " + Log_Date)
        End If
        Failed_Log.Close()
    End Sub
End Class
