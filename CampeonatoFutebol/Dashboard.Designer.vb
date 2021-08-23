<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtChampionship = New System.Windows.Forms.Button()
        Me.txtTeams = New System.Windows.Forms.Button()
        Me.txtGames = New System.Windows.Forms.Button()
        Me.txtPlayers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChampionship
        '
        Me.txtChampionship.Location = New System.Drawing.Point(52, 95)
        Me.txtChampionship.Name = "txtChampionship"
        Me.txtChampionship.Size = New System.Drawing.Size(75, 23)
        Me.txtChampionship.TabIndex = 0
        Me.txtChampionship.Text = "Campeonato"
        Me.txtChampionship.UseVisualStyleBackColor = True
        '
        'txtTeams
        '
        Me.txtTeams.Location = New System.Drawing.Point(52, 124)
        Me.txtTeams.Name = "txtTeams"
        Me.txtTeams.Size = New System.Drawing.Size(75, 23)
        Me.txtTeams.TabIndex = 0
        Me.txtTeams.Text = "Times"
        Me.txtTeams.UseVisualStyleBackColor = True
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(52, 153)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(75, 23)
        Me.txtGames.TabIndex = 0
        Me.txtGames.Text = "Jogos"
        Me.txtGames.UseVisualStyleBackColor = True
        '
        'txtPlayers
        '
        Me.txtPlayers.Location = New System.Drawing.Point(52, 182)
        Me.txtPlayers.Name = "txtPlayers"
        Me.txtPlayers.Size = New System.Drawing.Size(75, 23)
        Me.txtPlayers.TabIndex = 0
        Me.txtPlayers.Text = "Jogadores"
        Me.txtPlayers.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPlayers)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.txtTeams)
        Me.Controls.Add(Me.txtChampionship)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtChampionship As Button
    Friend WithEvents txtTeams As Button
    Friend WithEvents txtGames As Button
    Friend WithEvents txtPlayers As Button
End Class
