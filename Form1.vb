Imports System.IO

Public Class Form1
    Public Property PathSaveApp As String = ".\\localdata\\"
    Public Property FileName As String = "data.ihm"

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Voulez vous quitter ?", vbYesNo, "Quitter") = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub JouerBtn_Click(sender As Object, e As EventArgs) Handles JouerBtn.Click
        'Me.Hide()
        'Form2.Show()
        'If Not Directory.Exists(PathSaveApp) Then
        'Directory.CreateDirectory(PathSaveApp)
        'End If
        'If Not Directory.Exists(PathSaveApp & FileName) Then
        'Dim a As FileStream = File.Create(PathSaveApp & FileName)
        'a.Close()
        'End If
        'Dim b As New StreamWriter(PathSaveApp & FileName)
        'b.WriteLine(PseudoComboBox.Text)
        'b.Close()

        'If File.Exists(PathSaveApp & FileName) Then
        'Dim c As New StreamReader(PathSaveApp & FileName)
        'c.ReadLine()
        'End If
        Dim obj As New Form2
        obj.StringPassage = PseudoComboBox.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PseudoComboBox_TextChanged(sender As Object, e As EventArgs) Handles PseudoComboBox.TextChanged
        If Trim(PseudoComboBox.Text).Length > 2 Then
            JouerBtn.Enabled = True
        Else
            JouerBtn.Enabled = False
        End If
    End Sub
End Class

