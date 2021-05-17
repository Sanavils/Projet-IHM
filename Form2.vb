Imports System.IO

Public Class Form2
    Dim temps As Integer = 60
    Dim tabImage(5) As Image
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
        tabImage(0) = My.Resources.Image_2
        tabImage(1) = My.Resources.Image_3
        tabImage(2) = My.Resources.Image_4
        tabImage(3) = My.Resources.Image_0
        tabImage(4) = My.Resources.Image_1
        tabImage(5) = My.Resources.Image_5

        Randomize()
        For Each box As Label In Panel1.Controls
            box.Image = tabImage(5)
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
        sender.Image = tabImage(sender.Tag)
        sender.Image.Tag = 1
    End Sub

    Private Sub Add_Event()
        For Each label As Label In Panel1.Controls
            AddHandler label.Click, AddressOf Click_Label
        Next
    End Sub


End Class