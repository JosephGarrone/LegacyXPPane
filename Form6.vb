Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width - 100, Screen.PrimaryScreen.Bounds.Height - 100)
        Me.Location = New System.Drawing.Point(0, 0)
        RichTextBox1.SelectionHangingIndent = 0
        ToolStripComboBox1.Text = RichTextBox1.Font.Size
        ToolStripComboBox2.Text = RichTextBox1.Font.Name
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        Dim str As String
        ofd.Filter = ("Text Files (*.txt, *.rtf) | *.txt ; *.rtf")

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            str = ofd.FileName.ToString

            RichTextBox1.LoadFile(ofd.FileName)
            Me.Text = "JoPad - " & ofd.FileName
            My.Settings.JoPaSa = str
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        Dim sfn As String
        sfd.Filter = ("Text Files (*.txt) | *.txt|Rich Text Files (*.rtf) | *.rtf")


        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            sfn = sfd.FileName.ToString

            My.Computer.FileSystem.WriteAllText(sfd.FileName, RichTextBox1.Text, False)
            RichTextBox1.SaveFile(sfd.FileName, sfd.Filter)
            Me.Text = "JoPad - " & sfd.FileName

        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Dim fsd As New FontDialog

        If fsd.ShowDialog = Windows.Forms.DialogResult.OK Then

            RichTextBox1.SelectionFont = New System.Drawing.Font(fsd.Font.Name, fsd.Font.Size, fsd.Font.Style)
            ToolStripComboBox2.Items.Add(fsd.Font.Name)
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Dim colord As New ColorDialog

        If colord.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionColor = colord.Color
        End If
    End Sub

    Private Sub RichTextBox1_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.FontChanged
        ToolStripComboBox2.Text = RichTextBox1.Font.Name
        ToolStripComboBox1.Text = RichTextBox1.Font.Size
    End Sub

    Private Sub RichTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseUp

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = True Then
            RichTextBox1.WordWrap = True
            WordWrapToolStripMenuItem.Text = "Disable Wordwrap"
        Else
            RichTextBox1.WordWrap = False
            WordWrapToolStripMenuItem.Text = "Enable Wordwrap"
        End If
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DisableWordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.WordWrap = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim sfd As New SaveFileDialog
        Dim sfn As String
        sfd.Filter = ("Text Files (*.txt) | *.txt|Rich Text Files (*.rtf) | *.rtf")


        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            sfn = sfd.FileName.ToString

            My.Computer.FileSystem.WriteAllText(sfd.FileName, RichTextBox1.Text, False)
            RichTextBox1.SaveFile(sfd.FileName, sfd.Filter)
            Me.Text = "JoPad - " & sfd.FileName

        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim ofd As New OpenFileDialog
        Dim str As String
        ofd.Filter = ("Text Files (*.txt, *.rtf) | *.txt ; *.rtf")

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            str = ofd.FileName.ToString

            RichTextBox1.LoadFile(ofd.FileName)
            Me.Text = "JoPad - " & ofd.FileName
            My.Settings.JoPaSa = str
        End If
    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged

        If RichTextBox1.SelectionLength > 0 Then
            Dim selStart As Integer = RichTextBox1.SelectionStart
            Dim selLength As Integer = RichTextBox1.SelectionLength
            Dim currFont As System.Drawing.Font

            Dim i As Integer
            For i = 0 To selLength - 1
                RichTextBox1.Select(selStart + i, 1)
                currFont = RichTextBox1.SelectionFont
                RichTextBox1.SelectionFont = New Font(currFont.FontFamily, ToolStripComboBox1.SelectedItem, _
                    currFont.Style)
            Next
            RichTextBox1.Select(selStart, selLength)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.Name, ToolStripComboBox1.SelectedItem, _
                RichTextBox1.SelectionFont.Style)
        End If


    End Sub

    Private Sub ToolStripComboBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.Click

    End Sub

    Private Sub ToolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        If ToolStripComboBox2.SelectedItem = "Palace Script MT" Then
            RichTextBox1.SelectionFont = New Font("Palace Script MT", RichTextBox1.Font.Size, FontStyle.Italic)
        Else
            RichTextBox1.SelectionFont = New System.Drawing.Font(ToolStripComboBox2.SelectedItem.ToString, RichTextBox1.Font.Size, RichTextBox1.Font.Style)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If RichTextBox1.CanUndo = True Then
            RichTextBox1.Undo()
        Else : Return
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If RichTextBox1.CanRedo = True Then
            RichTextBox1.Redo()
        Else : Return
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        RichTextBox1.ReadOnly = True
        ToolStripButton6.Visible = False
        toolstripbutton7.visible = True
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        RichTextBox1.ReadOnly = False
        ToolStripButton6.Visible = True
        ToolStripButton7.Visible = False
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        RichTextBox1.SelectionHangingIndent = 20
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionIndent = 30
        RichTextBox1.SelectionRightIndent = 30
        RichTextBox1.DeselectAll()
        ToolStripButton10.Visible = False
        ToolStripButton11.Visible = True
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionIndent = 0
        RichTextBox1.SelectionRightIndent = 0
        RichTextBox1.DeselectAll()
        ToolStripButton11.Visible = False
        ToolStripButton10.Visible = True
    End Sub

    Private Sub CustomIndentsMarginsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomIndentsMarginsToolStripMenuItem.Click
        Form7.Visible = True
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Dim ExistingFont As Font = RichTextBox1.SelectionFont
        Dim NewFontStyle As New FontStyle
        With ExistingFont
            NewFontStyle = -((Not .Bold) * FontStyle.Bold)
            NewFontStyle += -(.Italic * FontStyle.Italic)
            NewFontStyle += -(.Underline * FontStyle.Underline)
            NewFontStyle += -(.Strikeout * FontStyle.Strikeout)
            RichTextBox1.SelectionFont = New Font(ExistingFont, NewFontStyle)
        End With
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Dim ExistingFont As Font = RichTextBox1.SelectionFont
        Dim NewFontStyle As New FontStyle
        With ExistingFont
            NewFontStyle = -((Not .Italic) * FontStyle.Italic)
            NewFontStyle += -(.Underline * FontStyle.Underline)
            NewFontStyle += -(.Bold * FontStyle.Bold)
            NewFontStyle += -(.Strikeout * FontStyle.Strikeout)
            RichTextBox1.SelectionFont = New Font(ExistingFont, NewFontStyle)
        End With
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Dim ExistingFont As Font = RichTextBox1.SelectionFont
        Dim NewFontStyle As New FontStyle
        With ExistingFont
            NewFontStyle = -((Not .Underline) * FontStyle.Underline)
            NewFontStyle += -(.Italic * FontStyle.Italic)
            NewFontStyle += -(.Bold * FontStyle.Bold)
            NewFontStyle += -(.Strikeout * FontStyle.Strikeout)
            RichTextBox1.SelectionFont = New Font(ExistingFont, NewFontStyle)
        End With
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        Dim ExistingFont As Font = RichTextBox1.SelectionFont
        Dim NewFontStyle As New FontStyle
        With ExistingFont
            NewFontStyle = -((Not .Strikeout) * FontStyle.Strikeout)
            NewFontStyle += -(.Underline * FontStyle.Underline)
            NewFontStyle += -(.Bold * FontStyle.Bold)
            NewFontStyle += -(.Italic * FontStyle.Italic)
            RichTextBox1.SelectionFont = New Font(ExistingFont, NewFontStyle)
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ContextMenuStrip1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuStrip1.MouseHover

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub UndoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem1.Click
        If RichTextBox1.CanUndo Then
            RichTextBox1.Undo()
        Else : Return
        End If
    End Sub

    Private Sub RedoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem1.Click
        If RichTextBox1.CanRedo Then
            RichTextBox1.Redo()
        Else : Return
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub copyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CleartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleartToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        dialog2.visible = True
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class