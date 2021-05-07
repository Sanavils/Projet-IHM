<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.BtnAbandon = New System.Windows.Forms.Button()
        Me.ImageRaton = New System.Windows.Forms.PictureBox()
        Me.ImageDosCarte = New System.Windows.Forms.PictureBox()
        CType(Me.ImageRaton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageDosCarte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pseudo :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(304, 21)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(39, 13)
        Me.LabelTemps.TabIndex = 3
        Me.LabelTemps.Text = "Temps"
        '
        'BtnAbandon
        '
        Me.BtnAbandon.Location = New System.Drawing.Point(691, 16)
        Me.BtnAbandon.Name = "BtnAbandon"
        Me.BtnAbandon.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbandon.TabIndex = 4
        Me.BtnAbandon.Text = "Abandon "
        Me.BtnAbandon.UseVisualStyleBackColor = True
        '
        'ImageRaton
        '
        Me.ImageRaton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageRaton.Image = Global.Projet_IHM.My.Resources.Resources.ppnimp
        Me.ImageRaton.InitialImage = Global.Projet_IHM.My.Resources.Resources.ppnimp
        Me.ImageRaton.Location = New System.Drawing.Point(43, 67)
        Me.ImageRaton.Name = "ImageRaton"
        Me.ImageRaton.Size = New System.Drawing.Size(71, 116)
        Me.ImageRaton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageRaton.TabIndex = 5
        Me.ImageRaton.TabStop = False
        '
        'ImageDosCarte
        '
        Me.ImageDosCarte.Image = Global.Projet_IHM.My.Resources.Resources.dos_de_carte
        Me.ImageDosCarte.Location = New System.Drawing.Point(22, 67)
        Me.ImageDosCarte.Name = "ImageDosCarte"
        Me.ImageDosCarte.Size = New System.Drawing.Size(106, 124)
        Me.ImageDosCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageDosCarte.TabIndex = 6
        Me.ImageDosCarte.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ImageDosCarte)
        Me.Controls.Add(Me.ImageRaton)
        Me.Controls.Add(Me.BtnAbandon)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ImageRaton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageDosCarte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTemps As Label
    Friend WithEvents BtnAbandon As Button
    Friend WithEvents ImageRaton As PictureBox
    Friend WithEvents ImageDosCarte As PictureBox
End Class
