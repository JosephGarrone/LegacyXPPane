Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        PictureBox12.ImageLocation = My.Settings.PicLoad
        Form5.Visible = False
        Form9.Visible = False
        Form10.Visible = False
        Timer1.Start()
        Me.Opacity = My.Settings.OpacitySetting
        NotifyIcon1.Visible = True
        Dialog1.Visible = False
        Label6.Visible = False
        Form3.Visible = False
        Button15.Visible = True
        ToDo1.Text = My.Settings.TodoSetting1
        ToDo2.Text = My.Settings.TodoSetting2
        ToDo3.Text = My.Settings.TodoSetting3
        ToDo4.Text = My.Settings.TodoSetting4
        ToDo5.Text = My.Settings.TodoSetting5
        If Screen.PrimaryScreen.Bounds.Height < 1023 Then
            Button13.Location = New System.Drawing.Point(11, 762)
            Label2.Location = New System.Drawing.Point(21, 787)
            PictureBox6.Location = New System.Drawing.Point(10, 800)
            PictureBox7.Location = New System.Drawing.Point(55, 800)
            PictureBox8.Location = New System.Drawing.Point(100, 800)
            PictureBox9.Location = New System.Drawing.Point(10, 842)
            PictureBox10.Location = New System.Drawing.Point(55, 842)
            PictureBox11.Location = New System.Drawing.Point(100, 842)
        End If
        If My.Settings.FirstRun = True Then
            Form11.Visible = True
        Else
            Form11.Visible = False
        End If
        My.Settings.StartWidth = (Screen.PrimaryScreen.Bounds.Width - 150)
        My.Settings.StartHeight = (Screen.PrimaryScreen.Bounds.Height - 25)
        My.Settings.BottomBar = (-2)
        My.Settings.BottomBar2 = (My.Settings.StartHeight - 20)
        My.Settings.Save()
        Me.Location = New System.Drawing.Point(My.Settings.StartWidth)
        Me.Size = New System.Drawing.Size(150, My.Settings.StartHeight)
        Me.Button1.Location = New System.Drawing.Point(My.Settings.BottomBar, My.Settings.BottomBar2)
        Form8.Visible = False
        Me.Visible = True
    End Sub

    Private Sub TextBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseHover
        Form5.Visible = True
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        Form5.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 250
        TextBox1.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub ExitXPPaneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitXPPaneToolStripMenuItem1.Click
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub ReOpenXPPaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReOpenXPPaneToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ToDo1.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ToDo2.Text = ""
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ToDo3.Text = ""
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ToDo4.Text = ""
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ToDo5.Text = ""
    End Sub

    Private Sub ExitXPPaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitXPPaneToolStripMenuItem.Click
        Dialog1.Visible = True
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Shell("C:\Program Files\Mozilla Firefox\firefox.exe", vbNormalNoFocus)
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Shell("C:\Program Files\Microsoft Office\OFFICE11\WINWORD.exe", vbNormalNoFocus)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Shell("C:\Program Files\Microsoft Office\OFFICE11\EXCEL.exe", vbNormalNoFocus)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Shell("C:\Program Files\Microsoft Office\OFFICE11\POWERPNT.exe", vbNormalNoFocus)
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Shell("C:\Program Files\Canon\ZoomBrowser EX\Program\ZoomBrowser.exe", vbNormalNoFocus)
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Shell("C:\Program Files\iTunes\iTunes.exe", vbNormalNoFocus)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        My.Settings.Save()
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Form2.Visible = True
    End Sub

    Private Sub Form1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Form2.Visible = False
        Form5.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.OpacitySetting = 0.25
        My.Settings.Save()
        Me.Opacity = My.Settings.OpacitySetting
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Settings.OpacitySetting = 0.75
        My.Settings.Save()
        Me.Opacity = My.Settings.OpacitySetting
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Drawing.Size.Equals(150, 768)
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        My.Settings.OpacitySetting = 0.5
        My.Settings.Save()
        Me.Opacity = My.Settings.OpacitySetting
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        My.Settings.OpacitySetting = 1.0
        My.Settings.Save()
        Me.Opacity = My.Settings.OpacitySetting
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Size = New System.Drawing.Size(150, 1024)
        Button1.Location = New Point(0, 1014)
        Me.Location = New System.Drawing.Point(1130, 0)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Size = New System.Drawing.Size(150, 768)
        Button1.Location = New Point(0, 758)
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Dialog1.Visible = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim ofd As New OpenFileDialog
        Dim strfilename As String

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            strfilename = ofd.FileName.ToString

            '//Media Player 
            My.Settings.PicLoad = strfilename
            PictureBox12.ImageLocation = My.Settings.PicLoad
            My.Settings.Save()
        End If
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form3.Visible = True
    End Sub

    Private Sub PictureBox14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseHover
        Label6.Visible = True
    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseLeave
        Label6.Visible = False
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseHover
        Label7.Visible = True
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseLeave
        Label7.Visible = False
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form4.Visible = True
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        My.Settings.TodoSetting1 = (ToDo1.Text)
        My.Settings.TodoSetting2 = (ToDo2.Text)
        My.Settings.TodoSetting3 = (ToDo3.Text)
        My.Settings.TodoSetting4 = (ToDo4.Text)
        My.Settings.TodoSetting5 = (ToDo5.Text)
        My.Settings.Save()
    End Sub

    Private Sub PictureBox1_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Visible = True
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If PictureBox15.Visible = True Then
            PictureBox15.Visible = False
        ElseIf PictureBox15.Visible = False Then
            PictureBox15.Visible = True
        End If
    End Sub

    Private Sub Button7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form8.Visible = True
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form9.Visible = True
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Form10.Visible = True
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

    End Sub
End Class
