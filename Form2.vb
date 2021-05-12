Imports System.IO

Public Class Form2
    Dim temps As Integer = 60
    Dim image(4) As Image
    Dim cpt0 As Integer
    Dim cpt1 As Integer
    Dim cpt2 As Integer
    Dim cpt3 As Integer
    Dim cpt4 As Integer


    Public Property StringPassage As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = StringPassage
        Timer1.Interval = 1000
        Timer1.Start()
        ' image(0) = My.Resources.Image_2
        'image(1) = My.Resources.Image_3
        'image(2) = My.Resources.Image_4
        'image(3) = My.Resources.Image_0
        'image(4) = My.Resources.Image_1
        For Each box As PictureBox In Panel1.Controls
            Dim aleatoire As Integer
            aleatoire = ((4 * Rnd()) + 0)
             Select Case aleatoire
                Case 0
                    If cpt0 < 3 Then
                        aa.Image = image(aleatoire) 
                        cpt0 += 1
                    Else
                            aleatoire = 1
                    end If 

                Case 1
                    If cpt1 < 3 Then
                        aa.Image = image(aleatoire)
                        cpt1 += 1
                    Else
                            aleatoire = 2
                    end If 
                Case 2
                    If cpt2 < 3 Then
                        aa.Image = image(aleatoire)
                        cpt2 += 1
                    Else
                            aleatoire = 3
                    end If 
                Case 3
                    If cpt3 < 3 Then
                        aa.Image = image(aleatoire)
                        cpt3 += 1
                    Else
                            aleatoire = 4
                    end If 
                Case 4
                    If cpt4 < 3 Then
                        aa.Image = image(aleatoire)
                        cpt4 += 1
                    Else
                            aleatoire = 0
                    end If 


            End Select
            


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

    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles BtnAbandon.Click
        If MsgBox("Etes-vous sur de vouloir quitter ?", vbYesNo, "Abandon") = vbYes Then
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImageDosCarte_Click(sender As Object, e As EventArgs) Handles ImageDosCarte.Click
        If ImageDosCarte.Visible = True Then
            ImageDosCarte.Visible = False
        End If
    End Sub

    Private Sub ImageDosCarte_BackgroundImageChanged(sender As Object, e As EventArgs) Handles ImageDosCarte.BackgroundImageChanged

    End Sub


End Class