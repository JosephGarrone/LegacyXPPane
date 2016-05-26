Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If CheckBox1.CheckState = CheckState.Checked And CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Checked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.WholeWord, RichTextBoxFinds.MatchCase)

        ElseIf CheckBox1.CheckState = CheckState.Checked And CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Unchecked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.WholeWord, RichTextBoxFinds.MatchCase, RichTextBoxFinds.NoHighlight)

        ElseIf CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Checked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.MatchCase)

        ElseIf CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Unchecked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.MatchCase, RichTextBoxFinds.NoHighlight)

        ElseIf CheckBox1.CheckState = CheckState.Checked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Checked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.WholeWord)

        ElseIf CheckBox1.CheckState = CheckState.Checked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Unchecked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.WholeWord, RichTextBoxFinds.NoHighlight)

        ElseIf CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Checked Then
            Form6.RichTextBox1.Find(TextBox1.Text)

        ElseIf CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Unchecked Then
            Form6.RichTextBox1.Find(TextBox1.Text, RichTextBoxFinds.NoHighlight)

        End If
        Form6.RichTextBox1.Focus()
        Me.Hide()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
