Imports System.IO

Module Module1
    Structure Joueur
        Dim Pseudo As String
        Dim nbCarre As Integer
        Dim meilleurTemps As Integer
        Dim nbParties As Integer
        Dim tempsTotal As Integer
    End Structure

    Sub Main()
        Sauvegarde()
        Application.Run(Form1)
        Ecrire_Fichier()
    End Sub

    Public lstJoueur(2) As Joueur
    Dim lecture As StreamReader
    Dim ecriture As StreamWriter
    Public nbJoueurs As Integer = 0
    Public Sub Sauvegarde()
        If Not System.IO.File.Exists("Fichier_de_sauvegarde.txt") Then
            System.IO.File.Create("Fichier_de_sauvegarde.txt").Dispose()
        End If
        lecture = New StreamReader("Fichier_de_sauvegarde.txt", True)
        Do While lecture.Peek >= 0
            Ajouter_Joueur(lecture.ReadLine)
        Loop
        lecture.Close()
    End Sub
    Public Sub Ajouter_Joueur(joueur As String)
        If nbJoueurs = lstJoueur.Length Then
            ReDim Preserve lstJoueur(lstJoueur.Length + 2)
        End If
        Dim infos() As String = joueur.Split("/")
        lstJoueur(nbJoueurs).Pseudo = infos(0)
        lstJoueur(nbJoueurs).nbCarre = CInt(infos(1))
        lstJoueur(nbJoueurs).meilleurTemps = CInt(infos(2))
        lstJoueur(nbJoueurs).tempsTotal = CInt(infos(3))
        lstJoueur(nbJoueurs).nbParties = CInt(infos(4))
        nbJoueurs += 1
    End Sub
    'fin d'un partie, soit le joueur existe(méthode retrouver joueur dans le lstJoeur à partir d'un nom en paramètre)
    'si nv joueur faire ajouter_Joueur, fin de partie concaténation de la chaine de carac
    Public Function Recherhce_Joueur(nom As String) As Integer
        For i = 0 To nbJoueurs - 1
            If lstJoueur(i).Pseudo.Equals(nom) Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Sub Modifier_Joueur(indice As Integer, nbCarre As Integer, tempsTrvCarre As Integer, tempsTotal As Integer)
        If Verif_Score(indice, nbCarre, tempsTrvCarre) Then
            lstJoueur(indice).nbCarre = nbCarre
            lstJoueur(indice).meilleurTemps = tempsTrvCarre
        End If
        lstJoueur(indice).tempsTotal += tempsTotal
        lstJoueur(indice).nbParties += 1
    End Sub

    Private Function Verif_Score(indice As Integer, nbCarre As Integer, tempsTrvCarre As Integer) As Boolean
        If lstJoueur(indice).nbCarre < nbCarre Then
            Return True
        End If
        Return lstJoueur(indice).nbCarre = nbCarre AndAlso lstJoueur(indice).meilleurTemps > tempsTrvCarre
    End Function

    Private Sub Ecrire_Fichier()
        System.IO.File.WriteAllText("Fichier_de_sauvegarde.txt", "")
        ecriture = New StreamWriter("Fichier_de_sauvegarde.txt", True)
        For i = 0 To nbJoueurs - 1
            ecriture.WriteLine(lstJoueur(i).Pseudo & "/" & lstJoueur(i).nbCarre & "/" & lstJoueur(i).meilleurTemps & "/" &
                               lstJoueur(i).tempsTotal & "/" & lstJoueur(i).nbParties)
        Next
        ecriture.Close()
    End Sub
End Module
