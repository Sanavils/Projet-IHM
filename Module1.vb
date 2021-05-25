Imports System.IO

Module Module1
    Structure Joueur
        Dim Pseudo As String
        Dim meilleurTemps As Integer
        Dim nbCarre As Integer
        Dim nbParties As Integer
        Dim tempsTotal As Integer
    End Structure

    Sub Main()
        Fichier_Sauvegarde()
        Application.Run(Form1)
    End Sub
    Public Sub Sauvegarde(Joueur As Joueur)
        'faire différence entre joueur existant et nv joueur
        'nv joueur -> écrire une nvlle ligne dans txt
        'j existant -> récupération des données du fichier (ReadAllLine)
        '-> mettre dans un tableau -> chercher à chaque indice un joueur
        'à l'indice donnée créer une variable donnée du joueur -> split selon le caractère de séparation
        'analyse : regarde si il a trouvé plus de carré, encapsulation (CInt) -> si + alors on rajoute les nouvelles données / si - regarde le meilleur temps donc si + on sauv tout si - change rien
        'chaîne de carac de toutes les données -> placer à l'ancienne chaine de carac (données) -> (WriteAllLine)
    End Sub

    Private Sub Fichier_Sauvegarde()
        Dim ecriture As StreamWriter
        ecriture = My.Computer.FileSystem.OpenTextFileWriter("Fichier de sauvegarde", True)
        ecriture.Close()
    End Sub
End Module
