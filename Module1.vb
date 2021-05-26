Imports System.IO

Module Module1
    Structure Joueur
        Dim Pseudo As String
        Dim meilleurTemps As Integer
        Dim nbCarre As Integer
        Dim nbParties As Integer
        Dim tempsTotal As Integer
    End Structure
    Dim tabJoueur As ArrayList = New ArrayList()
    Dim donneeJoueur As String
    Sub Main()
        Fichier_Sauvegarde()
        Application.Run(Form1)
    End Sub
    Dim infos() As String
    Public Sub Sauvegarde(Joueur As Joueur)
        infos = File.ReadAllLines("Fichier de sauvegarde")
        For i = 0 To infos.Length - 1
            If infos(i).Contains(Joueur.Pseudo) Then
                Traitement_Joueur(Joueur, i)
            End If
        Next
        'faire différence entre joueur existant et nv joueur
        'nv joueur -> écrire une nvlle ligne dans txt
        Fichier_Sauvegarde()
        'j existant -> récupération des données du fichier (ReadAllLine)
        '-> mettre dans un tableau -> chercher à chaque indice un joueur
        For i = 0 To tabJoueur.Count - 1
            tabJoueur(i) = donneeJoueur

        Next
        'à l'indice donnée créer une variable donnée du joueur -> split selon le caractère de séparation
        'analyse : regarde si il a trouvé plus de carré, encapsulation (CInt) -> si + alors on rajoute les nouvelles données / si - regarde le meilleur temps donc si + on sauv tout si - change rien
        'chaîne de carac de toutes les données -> placer à l'ancienne chaine de carac (données) -> (WriteAllLine)
        ' Dim f As New StreamReader("Fichier de sauvegarde")
        'Do While f.Peek() >= 0
        'Console.WriteLine(f.ReadLine())
        'Loop
        'f.Close()
    End Sub
    Private Sub Traitement_Joueur(Joueur As Joueur, index As Integer)
        Dim tabSauv() As String = infos(index).Split("/")
        If Joueur.nbCarre > tabSauv(1) Then
            tabSauv(1) = Joueur.nbCarre
        End If
        If Joueur.meilleurTemps < tabSauv(2) Then
            tabSauv(2) = Joueur.meilleurTemps
        End If
        tabSauv(4) += 1
        tabSauv(3) += Joueur.tempsTotal
    End Sub
    Private Sub Creer_Joueur(Joueur As Joueur)
        Dim chaine As String
        chaine = Joueur.Pseudo & "/" & Joueur.nbCarre & "/" & Joueur.meilleurTemps & "/" & Joueur.tempsTotal & "/" & Joueur.nbParties
    End Sub
    Private Sub Fichier_Sauvegarde()
        Dim ecriture As StreamWriter
        ecriture = My.Computer.FileSystem.OpenTextFileWriter("Fichier de sauvegarde", True)
        ecriture.Close()
    End Sub
End Module
