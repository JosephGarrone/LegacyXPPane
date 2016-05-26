Public Class Form9

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "Bob: Ready for commands."
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & SystemInformation.UserName & ": " & TextBox1.Text
        Dim swearno As Integer
        swearno = 1
        'Words : shutdown : Computer
        If InStr(TextBox1.Text, "Search") > 0 And InStr(TextBox1.Text, ".exe") > 0 Then
            Dim driveletter As String
            Dim textstring As String
            Dim searchtype As String
            textstring = TextBox1.Text
            driveletter = "C"
            searchtype = ""
            If InStr(TextBox1.Text, "Search C") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search C:'."
                driveletter = "C"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search D") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search D:'."
                driveletter = "D"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search E") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search E:'."
                driveletter = "E"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search F") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search F:'."
                driveletter = "F"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search G") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search G:'."
                driveletter = "G"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search H") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search H:'."
                driveletter = "H"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search I") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search I:'."
                driveletter = "I"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search J") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search J:'."
                driveletter = "J"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search K") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search K:'."
                driveletter = "K"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search L") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search L:'."
                driveletter = "L"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search M") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search M:'."
                driveletter = "M"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search N") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search N:'."
                driveletter = "N"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search O") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search O:'."
                driveletter = "O"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search P") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search P:'."
                driveletter = "P"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search Q") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search Q:'."
                driveletter = "Q"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search R") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search R:'."
                driveletter = "R"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search S") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search S:'."
                driveletter = "S"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search T") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search T:'."
                driveletter = "T"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search U") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search U:'."
                driveletter = "U"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search V") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search V:'."
                driveletter = "V"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search W") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search W:'."
                driveletter = "W"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search X") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search X:'."
                driveletter = "X"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search Y") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search Y:'."
                driveletter = "Y"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            ElseIf InStr(TextBox1.Text, "Search Z") > 0 Then
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search Z:'."
                driveletter = "Z"
                textstring = textstring.Replace("Search " & driveletter, "")
                RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'Search for " & textstring & searchtype & " in " & driveletter
            End If

        ElseIf InStr(TextBox1.Text, "shutdown") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\WINDOWS\system32", FileIO.SearchOption.SearchTopLevelOnly, "shutdown.exe")
                Shell("C:\Windows\system32\shutdown.exe -s -t 0")
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'shutdown.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'shutdown.exe' Initiated."

            'Words : browse, internet, mozilla, firefox : Mozilla
        ElseIf InStr(TextBox1.Text, "browse") > 0 Or InStr(TextBox1.Text, "internet") > 0 Or InStr(TextBox1.Text, "mozilla") > 0 Or InStr(TextBox1.Text, "firefox") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\Mozilla Firefox", FileIO.SearchOption.SearchTopLevelOnly, "firefox.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'firefox.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'firefox.exe' Initiated."


            'Words : music, listen, itunes : iTunes
        ElseIf InStr(TextBox1.Text, "music") > 0 Or InStr(TextBox1.Text, "itunes") > 0 Or InStr(TextBox1.Text, "listen") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\iTunes", FileIO.SearchOption.SearchTopLevelOnly, "iTunes.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'iTunes.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'iTunes.exe' Initiated."

            'Words : Assorted : Mozilla
        ElseIf InStr(TextBox1.Text, "www.") > 0 Then
            Dim browser As String
            Dim site As String
            Dim full As String
            browser = "C:\Program Files\Mozilla Firefox\firefox.exe"
            site = TextBox1.Text
            full = browser & " " & site
            Shell(full, vbNormalFocus)
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing " & TextBox1.Text
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. " & TextBox1.Text & " Initiated."

            'Words : exit, close, goodbye : B.O.B
        ElseIf InStr(TextBox1.Text, "exit") > 0 Or InStr(TextBox1.Text, "close") > 0 Or InStr(TextBox1.Text, "goodbye") > 0 Then
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing shutdown of B.O.B."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization of B.O.B shutdown complete."
            Me.Close()

            'Words : documents, files, folders : Explorer
        ElseIf InStr(TextBox1.Text, "documents") > 0 Or InStr(TextBox1.Text, "files") > 0 Or InStr(TextBox1.Text, "folders") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\WINDOWS", FileIO.SearchOption.SearchTopLevelOnly, "explorer.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'explorer.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'explorer.exe' Initiated."

            'Words : c++, cplusplus, vc++, visual c++ : C++ 
        ElseIf InStr(TextBox1.Text, "c++") > 0 Or InStr(TextBox1.Text, "cplusplus") > 0 Or InStr(TextBox1.Text, "vc++") > 0 Or InStr(TextBox1.Text, "visual c++") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE", FileIO.SearchOption.SearchTopLevelOnly, "VCExpress.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'VCExpress.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'VCExpress.exe' Initiated."

            'Words : vb2008, vbexpress, vb, visual basic : Visual Basic
        ElseIf InStr(TextBox1.Text, "vb2008") > 0 Or InStr(TextBox1.Text, "vbexpress") > 0 Or InStr(TextBox1.Text, "vb") > 0 Or InStr(TextBox1.Text, "visual basic") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE", FileIO.SearchOption.SearchTopLevelOnly, "vbexpress.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'vbexpress.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'vbexpress.exe' Initiated."

            'Words : vb2008, vbexpress, vb, visual basic : Visual Basic
        ElseIf InStr(TextBox1.Text, "vb2008") > 0 Or InStr(TextBox1.Text, "vbexpress") > 0 Or InStr(TextBox1.Text, "vb") > 0 Or InStr(TextBox1.Text, "visual basic") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\Microsoft Visual Studio 9.0\Common7\IDE", FileIO.SearchOption.SearchTopLevelOnly, "vbexpress.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'vbexpress.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'vbexpress.exe' Initiated."

            'Words : avg, anti-virus, avg scan : Visual Basic
        ElseIf InStr(TextBox1.Text, "avg") > 0 Or InStr(TextBox1.Text, "anti-virus") > 0 Or InStr(TextBox1.Text, "avg scan") > 0 Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles _
      ("C:\Program Files\AVG\AVG9", FileIO.SearchOption.SearchTopLevelOnly, "avgui.exe")
                Shell(foundFile, AppWinStyle.NormalFocus)
            Next
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initializing 'avgui.exe'."
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Complete. 'avgui.exe' Initiated."

            'Words : help, what do i do, wth, what : Help
        ElseIf InStr(TextBox1.Text, "help") > 0 Or InStr(TextBox1.Text, "what do i do") > 0 Or InStr(TextBox1.Text, "wth") > 0 Or InStr(TextBox1.Text, "what") > 0 Then
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Simply enter a sentence which contains one of the Basic Operations Base commands. I.E. 'I would like to browse a website.' I will recognise the word browse and launch your webbrowser. For a full list of BOB commands please see the help file."

        Else
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Initialization Fail. Unable to understand command. For help simply type a sentence with the word help in it."
        End If
            If InStr(TextBox1.Text, "fuck") > 0 Or InStr(TextBox1.Text, "fuck") > 0 Or InStr(TextBox1.Text, "cunt") > 0 Or InStr(TextBox1.Text, "shit") > 0 Or InStr(TextBox1.Text, "bitch") > 0 Or InStr(TextBox1.Text, "dick") > 0 Then
                If swearno > 0 Then
                    swearno = swearno - 1
                    RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Please do not swear at me. You have " & swearno.ToString & " swear words left before I will be forced to shut down your computer."
                ElseIf swearno < 0 Then
                    Shell("C:\Windows\system32\shutdown.exe -s -t 0")
                End If
            End If
            RichTextBox1.Text = RichTextBox1.Text & ControlChars.NewLine & "Bob: Ready for commands."
            TextBox1.Clear()
            TextBox1.Focus()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class