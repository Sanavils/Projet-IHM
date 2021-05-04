Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Voulez vous quitter ?", vbYesNo, "Quitter") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PseudoComboBox.KeyPress
        VerifBox(e)
        If PseudoComboBox.Text.Length >= 2 Then
            JouerBtn.Enabled = True
        Else
            JouerBtn.Enabled = False
        End If
    End Sub

    Private Sub VerifBox(e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
End Class

