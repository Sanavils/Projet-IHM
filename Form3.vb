Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_List()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Init_List()
        Dim j As Joueur
        For i = 0 To nbJoueurs - 1
            j = lstJoueur(i)
            ComboBoxPseudo.Items.Add(j.Pseudo)
            ListBoxPseudo.Items.Add(j.Pseudo)
            ListBoxCarre.Items.Add(j.nbCarre)
            ListBoxBestTemps.Items.Add(j.meilleurTemps)
            ListBoxTempsTotal.Items.Add(j.tempsTotal)
            ListBoxParties.Items.Add(j.nbParties)
        Next
    End Sub

    Private Sub ComboBoxPseudo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPseudo.SelectedIndexChanged
        'For Each Liste 
    End Sub
End Class