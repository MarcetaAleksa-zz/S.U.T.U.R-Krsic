Public Class Logovi
    Public Shared Sub Log()
        Dim Log_File As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'college (C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\)
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Log_File = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt", True)
        Log_File.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Log_File.Close()
    End Sub
    Public Shared Sub FailedLog()
        Dim Failed_Log As System.IO.StreamWriter
        Dim Log_Date As String
        Log_Date = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
        'college (C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\)
        'kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\\\bin\\Debug\\
        Failed_Log = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt", True)
        Failed_Log.WriteLine("Username: " + Prijava.Username_Form_Box.Text + ";; Password: " + Prijava.Password_Form_Box.Text + ";; Date of Attempt: " + Log_Date)
        Failed_Log.Close()
    End Sub
End Class
