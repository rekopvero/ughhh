Imports System
Imports System.Windows.Forms

Module StartupModule
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1()) ' Change to your login form name
    End Sub
End Module
