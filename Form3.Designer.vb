<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBoxPseudo = New System.Windows.Forms.ListBox()
        Me.ListBoxCarre = New System.Windows.Forms.ListBox()
        Me.ListBoxBestTemps = New System.Windows.Forms.ListBox()
        Me.ListBoxTempsTotal = New System.Windows.Forms.ListBox()
        Me.ListBoxParties = New System.Windows.Forms.ListBox()
        Me.ComboBoxPseudo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(692, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBoxPseudo
        '
        Me.ListBoxPseudo.FormattingEnabled = True
        Me.ListBoxPseudo.Location = New System.Drawing.Point(9, 7)
        Me.ListBoxPseudo.Name = "ListBoxPseudo"
        Me.ListBoxPseudo.Size = New System.Drawing.Size(118, 251)
        Me.ListBoxPseudo.TabIndex = 2
        '
        'ListBoxCarre
        '
        Me.ListBoxCarre.FormattingEnabled = True
        Me.ListBoxCarre.Location = New System.Drawing.Point(123, 7)
        Me.ListBoxCarre.Name = "ListBoxCarre"
        Me.ListBoxCarre.Size = New System.Drawing.Size(118, 251)
        Me.ListBoxCarre.TabIndex = 3
        '
        'ListBoxBestTemps
        '
        Me.ListBoxBestTemps.FormattingEnabled = True
        Me.ListBoxBestTemps.Location = New System.Drawing.Point(234, 7)
        Me.ListBoxBestTemps.Name = "ListBoxBestTemps"
        Me.ListBoxBestTemps.Size = New System.Drawing.Size(118, 251)
        Me.ListBoxBestTemps.TabIndex = 4
        '
        'ListBoxTempsTotal
        '
        Me.ListBoxTempsTotal.FormattingEnabled = True
        Me.ListBoxTempsTotal.Location = New System.Drawing.Point(346, 7)
        Me.ListBoxTempsTotal.Name = "ListBoxTempsTotal"
        Me.ListBoxTempsTotal.Size = New System.Drawing.Size(118, 251)
        Me.ListBoxTempsTotal.TabIndex = 5
        '
        'ListBoxParties
        '
        Me.ListBoxParties.FormattingEnabled = True
        Me.ListBoxParties.Location = New System.Drawing.Point(460, 7)
        Me.ListBoxParties.Name = "ListBoxParties"
        Me.ListBoxParties.Size = New System.Drawing.Size(118, 251)
        Me.ListBoxParties.TabIndex = 6
        '
        'ComboBoxPseudo
        '
        Me.ComboBoxPseudo.FormattingEnabled = True
        Me.ComboBoxPseudo.Location = New System.Drawing.Point(35, 47)
        Me.ComboBoxPseudo.Name = "ComboBoxPseudo"
        Me.ComboBoxPseudo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPseudo.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBoxParties)
        Me.Panel1.Controls.Add(Me.ListBoxTempsTotal)
        Me.Panel1.Controls.Add(Me.ListBoxBestTemps)
        Me.Panel1.Controls.Add(Me.ListBoxCarre)
        Me.Panel1.Controls.Add(Me.ListBoxPseudo)
        Me.Panel1.Location = New System.Drawing.Point(132, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 270)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pseudo : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre de carrés :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Meilleur temps  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Temps Total  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(606, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nombre de parties  :"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBoxPseudo)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBoxPseudo As ListBox
    Friend WithEvents ListBoxCarre As ListBox
    Friend WithEvents ListBoxBestTemps As ListBox
    Friend WithEvents ListBoxTempsTotal As ListBox
    Friend WithEvents ListBoxParties As ListBox
    Friend WithEvents ComboBoxPseudo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
