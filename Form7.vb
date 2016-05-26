Public Class Form7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown3.Value = Form6.RichTextBox1.SelectionIndent
        NumericUpDown4.Value = Form6.RichTextBox1.SelectionRightIndent
        NumericUpDown1.Value = Form6.RichTextBox1.SelectionHangingIndent
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.RichTextBox1.SelectionIndent = NumericUpDown3.Value
        Form6.RichTextBox1.SelectionRightIndent = NumericUpDown4.Value
        Form6.RichTextBox1.SelectionHangingIndent = NumericUpDown1.Value
        Form6.RichTextBox1.WordWrap = True
        Me.Close()
    End Sub
End Class