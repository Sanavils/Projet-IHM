Imports System.IO

Public Class Form2
    Dim temps As Integer = 60
    Dim stockImage(5) As Image
    Dim cpt0 As Integer, cpt1 As Integer, cpt2 As Integer, cpt3 As Integer, cpt4 As Integer
    Dim cptCarte As Integer
    Dim tabImage As ArrayList = New ArrayList()
    Dim Start As Boolean = False
    Dim carteClicked As Integer = 0
    Dim seconde As Integer = 1000
    Public Property StringPassage As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelPseudo.Text = StringPassage
        Timer1.Interval = seconde
        stockImage(0) = My.Resources.Image_0
        stockImage(1) = My.Resources.Image_1
        stockImage(2) = My.Resources.Image_2
        stockImage(3) = My.Resources.Image_3
        stockImage(4) = My.Resources.Image_4
        stockImage(5) = My.Resources.Image_5

        'Randomize()
        For Each box As Label In Panel1.Controls
            box.Image = stockImage(5)
            box.Image.Tag = 0
            Image_Random(box)
        Next
        Add_Event()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temps = temps - 1
        Me.LabelTemps.Text = temps & " secondes"
        If temps < 10 Then
            LabelTemps.ForeColor = Color.Red
        End If
        If temps = 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Function Image_Random(box As Label) As Image
        Dim aleatoire As Integer
        Dim bool As Boolean = False
        While bool = False

            aleatoire = ((4 * Rnd()) + 0)
            Select Case aleatoire

                Case 0
                    If cpt0 < 4 Then
                        box.Tag = aleatoire
                        cpt0 += 1
                        bool = True
                    End If

                Case 1
                    If cpt1 < 4 Then
                        box.Tag = aleatoire
                        cpt1 += 1
                        bool = True

                    End If
                Case 2
                    If cpt2 < 4 Then
                        box.Tag = aleatoire
                        cpt2 += 1
                        bool = True
                    End If
                Case 3
                    If cpt3 < 4 Then
                        box.Tag = aleatoire
                        cpt3 += 1
                        bool = True

                    End If
                Case 4
                    If cpt4 < 4 Then
                        box.Tag = aleatoire
                        cpt4 += 1
                        bool = True

                    End If
            End Select
        End While
        bool = True
    End Function
    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        If MsgBox("Etes-vous sur de vouloir quitter ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Form1.Show()
        End If

    End Sub
    Private Sub Click_Label(sender As Object, e As EventArgs)
        If Start = False Then
            Timer1.Start()
            Start = True
        End If

        sender.Image = stockImage(sender.Tag)
        sender.Image.Tag = 1
        If sender.Image.Tag = 1 And carteClicked <= 4 Then
            carteClicked += 1
            tabImage.Add(sender.Tag)
            If carteClicked > 1 And carteClicked <= 4 Then
                Verif_Tableau()
            End If
        End If


    End Sub
    Private Sub Verif_Tableau()
        Dim size As Integer = tabImage.Count - 2
        For j = 0 To size
            If tabImage(j) <> tabImage(j + 1) Then
                If tabImage.Count = 4 Then
                    For Each Carte As Label In Panel1.Controls
                        If Carte.Tag = 1 And Carte.Enabled = True Then
                            Carte.Enabled = False
                        End If
                    Next
                End If
                Retourner_Carte()
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Retourner_Carte()
        Refresh()
        Threading.Thread.Sleep(seconde)
        For Each Label As Label In Panel1.Controls
            If Label.Image.Tag = 1 And Label.Enabled = True Then
                Label.Image = stockImage(5)
                Label.Image.Tag = 0
            End If
        Next
        carteClicked = 0
        tabImage.Clear()
    End Sub
    Private Sub Add_Event()
        For Each label As Label In Panel1.Controls
            AddHandler label.Click, AddressOf Click_Label
        Next
    End Sub


End Class