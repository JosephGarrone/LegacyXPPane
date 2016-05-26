Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "1 Minute" Then
            Timer1.Interval = 1 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "10 Minutes" Then
            Timer1.Interval = 10 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "15 Minutes" Then
            Timer1.Interval = 15 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "20 Minutes" Then
            Timer1.Interval = 20 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "30 Minutes" Then
            Timer1.Interval = 30 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "45 Minutes" Then
            Timer1.Interval = 45 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "60 Minutes" Then
            Timer1.Interval = 60 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "1 Hour 30 Minutes" Then
            Timer1.Interval = 90 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "2 Hours" Then
            Timer1.Interval = 120 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "12 Hours" Then
            Timer1.Interval = 840 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "24 Hours" Then
            Timer1.Interval = 1680 * 1000 * 60
            Timer1.Enabled = True
        End If
        If ComboBox1.SelectedItem = "10 Seconds" Then
            Timer1.Interval = 10 * 1000
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer2.Interval = TextBox1.Text * 1000 * 60
        Timer2.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        NotifyIcon1.Visible = False
        Me.Visible = False
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        NotifyIcon1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        MessageBox.Show("The Alarm/Timer has finished. Your time is up!", "Alarm/Timer Reminder", MessageBoxButtons.OK)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        MessageBox.Show("The Alarm/Timer has finished. Your time is up!", "Alarm/Timer Reminder", MessageBoxButtons.OK)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub ReOpenAlarmTimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReOpenAlarmTimerToolStripMenuItem.Click
        Me.Visible = True
    End Sub

    Private Sub ExitWindowsXPPaneAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitWindowsXPPaneAppToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Form1.NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
    End Sub
End Class