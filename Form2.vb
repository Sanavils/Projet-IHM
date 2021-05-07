Imports System.IO

Public Class Form2
    Dim temps As Integer = 60
    Public Property StringPassage As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = StringPassage
        Timer1.Interval = 1000
        Timer1.Start()
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
        ImageDosCarte.Image = Image.FromFile("ppnimp.png")
    End Sub
End Class