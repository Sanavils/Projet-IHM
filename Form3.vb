Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_List()
        Add_Event()
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
        For Each List In Panel1.Controls
            List.Selectedindex = ComboBoxPseudo.SelectedIndex Or sender.SelectedIndex
        Next
    End Sub
    Private Sub Liste_Controls(sender As Object, e As EventArgs)
        ComboBoxPseudo.SelectedIndex = sender.SelectedIndex
        For Each listes As ListBox In Panel1.Controls
            If listes IsNot sender Then
                listes.SelectedIndex = sender.SelectedIndex
            End If
        Next
    End Sub

    Private Sub Add_Event()
        For Each List As ListBox In Panel1.Controls
            AddHandler List.SelectedIndexChanged, AddressOf Liste_Controls
        Next
    End Sub

    Private Sub ButtonCroissant_Click(sender As Object, e As EventArgs) Handles ButtonCroissant.Click
        Tri_Croissant()
        Tri_ComboBox()
    End Sub

    Private Sub ButtonDecroissant_Click(sender As Object, e As EventArgs) Handles ButtonDecroissant.Click
        Tri_Decroissant()
        Tri_ComboBox()
    End Sub

    Private Sub Tri_ComboBox()
        For i = 0 To ComboBoxPseudo.Items.Count - 1
            ComboBoxPseudo.Items(i) = ListBoxPseudo.Items(i)
        Next
    End Sub
    Private Sub Tri_Decroissant()
        For i = 0 To ListBoxCarre.Items.Count - 1
            For j = i + 1 To ListBoxCarre.Items.Count - 1
                If ListBoxCarre.Items(i) > ListBoxCarre.Items(j) Then
                ElseIf ListBoxCarre.Items(i) = ListBoxCarre.Items(j) Then
                    If ListBoxBestTemps.Items(i) > ListBoxBestTemps.Items(j) Then
                        Changer_Place(i, j)
                    End If
                End If
                Changer_Place(i, j)
            Next
        Next
    End Sub

    Private Sub Tri_Croissant()
        For i = 0 To ListBoxCarre.Items.Count - 1
            For j = i + 1 To ListBoxCarre.Items.Count - 1
                If ListBoxCarre.Items(i) < ListBoxCarre.Items(j) Then
                ElseIf ListBoxCarre.Items(i) = ListBoxCarre.Items(j) Then
                    If ListBoxBestTemps.Items(i) < ListBoxBestTemps.Items(j) Then
                        Changer_Place(i, j)
                    End If
                End If
                Changer_Place(i, j)
            Next
        Next
    End Sub

    Private Sub Changer_Place(indice1 As Integer, indice2 As Integer)
        Dim copie
        For Each List As ListBox In Panel1.Controls
            copie = List.Items(indice1)
            List.Items(indice1) = List.Items(indice2)
            List.Items(indice2) = copie
        Next
    End Sub
    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Dim idx As Integer = ListBoxPseudo.Items.IndexOf(ComboBoxPseudo.Text)
        If idx <> -1 Then
            MessageBox.Show("Le Joueur " & ListBoxPseudo.Items(idx) & " a un score de " & ListBoxCarre.Items(idx) & " réalisé en " & ListBoxBestTemps.Items(idx) _
                        & " seconde(s), il cummule un temps total de " & ListBoxTempsTotal.Items(idx) & " seconde(s), pour un nombre de " &
                        ListBoxParties.Items(idx) & " partie(s).")
        Else
            MessageBox.Show("Choisissez un joueur !")
        End If

    End Sub

    Private Sub ComboBoxPseudo_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxPseudo.TextChanged
        ListBoxPseudo.SelectedIndex = ListBoxPseudo.Items.IndexOf(ComboBoxPseudo.Text)
    End Sub
End Class