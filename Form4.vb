Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub TimeBox_TextChanged(sender As Object, e As EventArgs) Handles TimeBox.TextChanged

    End Sub
    Private Sub TimeBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TimeBox.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If Not Char.IsNumber(e.KeyChar) And Not Trim(TimeBox.Text).Length <= 3 Then
            e.Handled = True
        End If
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeBox.Text = 60
    End Sub
End Class