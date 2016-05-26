Public Class Form3

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Visible = True
    End Sub

    Private Sub Form3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PictureBox1.Size = New Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Button1.Location = New System.Drawing.Point(((Screen.PrimaryScreen.Bounds.Width / 2) - 135), (Screen.PrimaryScreen.Bounds.Height - 62))
        Button2.Location = New System.Drawing.Point((4), (Screen.PrimaryScreen.Bounds.Height - 77))
    End Sub
End Class

