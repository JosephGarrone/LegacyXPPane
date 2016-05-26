Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        timer1.start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 200
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Loading Form1..."
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Loading Form2..."
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Loading Form3..."
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Loading Form4..."
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Loading Form5..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Loading Form6..."
        End If
        If ProgressBar1.Value = 70 Then
            Label1.Text = "Loading Form7..."
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Loading Form8..."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Loading Buttons and Labels..."
        End If
        If ProgressBar1.Value = 100 Then
            Label1.Text = "Initializing"
        End If
    End Sub
End Class
