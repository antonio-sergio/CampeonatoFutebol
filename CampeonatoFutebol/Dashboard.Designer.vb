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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.txtTeams = New System.Windows.Forms.Button()
        Me.txtGames = New System.Windows.Forms.Button()
        Me.txtPlayers = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChampionship = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTeams
        '
        Me.txtTeams.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtTeams.BackgroundImage = CType(resources.GetObject("txtTeams.BackgroundImage"), System.Drawing.Image)
        Me.txtTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtTeams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTeams.FlatAppearance.BorderSize = 0
        Me.txtTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTeams.Location = New System.Drawing.Point(8, 128)
        Me.txtTeams.Name = "txtTeams"
        Me.txtTeams.Size = New System.Drawing.Size(60, 60)
        Me.txtTeams.TabIndex = 1
        Me.txtTeams.UseVisualStyleBackColor = False
        '
        'txtGames
        '
        Me.txtGames.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtGames.BackgroundImage = CType(resources.GetObject("txtGames.BackgroundImage"), System.Drawing.Image)
        Me.txtGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtGames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGames.FlatAppearance.BorderSize = 0
        Me.txtGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtGames.Location = New System.Drawing.Point(8, 215)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(60, 60)
        Me.txtGames.TabIndex = 2
        Me.txtGames.UseVisualStyleBackColor = False
        '
        'txtPlayers
        '
        Me.txtPlayers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPlayers.BackgroundImage = CType(resources.GetObject("txtPlayers.BackgroundImage"), System.Drawing.Image)
        Me.txtPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPlayers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtPlayers.FlatAppearance.BorderSize = 0
        Me.txtPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtPlayers.Location = New System.Drawing.Point(8, 293)
        Me.txtPlayers.Name = "txtPlayers"
        Me.txtPlayers.Size = New System.Drawing.Size(60, 60)
        Me.txtPlayers.TabIndex = 3
        Me.txtPlayers.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(269, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "by antonioalves.dev"
        '
        'txtChampionship
        '
        Me.txtChampionship.AccessibleName = ""
        Me.txtChampionship.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtChampionship.BackgroundImage = CType(resources.GetObject("txtChampionship.BackgroundImage"), System.Drawing.Image)
        Me.txtChampionship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtChampionship.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtChampionship.FlatAppearance.BorderSize = 0
        Me.txtChampionship.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtChampionship.Location = New System.Drawing.Point(8, 50)
        Me.txtChampionship.Name = "txtChampionship"
        Me.txtChampionship.Size = New System.Drawing.Size(60, 60)
        Me.txtChampionship.TabIndex = 0
        Me.txtChampionship.Tag = ""
        Me.txtChampionship.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(243, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 30)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Jogadores"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 31)
        Me.Panel1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.Location = New System.Drawing.Point(637, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Pesquisar"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(15, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 30)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Campeonato"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(97, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Times"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(164, -1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 30)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Jogos"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtChampionship)
        Me.Controls.Add(Me.txtPlayers)
        Me.Controls.Add(Me.txtTeams)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChampionship As Button
    Friend WithEvents txtTeams As Button
    Friend WithEvents txtGames As Button
    Friend WithEvents txtPlayers As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents HelpProvider2 As HelpProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
