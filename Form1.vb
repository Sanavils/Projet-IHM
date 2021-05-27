Imports System.IO

Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Voulez vous quitter ?", vbYesNo, "Quitter") = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub JouerBtn_Click(sender As Object, e As EventArgs) Handles JouerBtn.Click
        Form2.initNom(PseudoComboBox.Text)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PseudoComboBox_TextChanged(sender As Object, e As EventArgs) Handles PseudoComboBox.TextChanged
        If Trim(PseudoComboBox.Text).Length > 2 Then
            JouerBtn.Enabled = True
        Else
            JouerBtn.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To nbJoueurs - 1
            PseudoComboBox.Items.Add(lstJoueur(i).Pseudo)
        Next
    End Sub
End Class

