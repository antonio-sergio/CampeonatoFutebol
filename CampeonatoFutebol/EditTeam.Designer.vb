<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditTeam
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtUniform1 = New System.Windows.Forms.TextBox()
        Me.txtUniform2 = New System.Windows.Forms.TextBox()
        Me.txtNameEstadium = New System.Windows.Forms.TextBox()
        Me.txtNameTeam = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.Label()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(163, 199)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(446, 150)
        Me.dg.TabIndex = 35
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(535, 72)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(38, 20)
        Me.txtCode.TabIndex = 34
        '
        'txtUniform1
        '
        Me.txtUniform1.Enabled = False
        Me.txtUniform1.Location = New System.Drawing.Point(278, 124)
        Me.txtUniform1.Name = "txtUniform1"
        Me.txtUniform1.Size = New System.Drawing.Size(107, 20)
        Me.txtUniform1.TabIndex = 33
        '
        'txtUniform2
        '
        Me.txtUniform2.Enabled = False
        Me.txtUniform2.Location = New System.Drawing.Point(460, 124)
        Me.txtUniform2.Name = "txtUniform2"
        Me.txtUniform2.Size = New System.Drawing.Size(138, 20)
        Me.txtUniform2.TabIndex = 32
        '
        'txtNameEstadium
        '
        Me.txtNameEstadium.Enabled = False
        Me.txtNameEstadium.Location = New System.Drawing.Point(309, 98)
        Me.txtNameEstadium.Name = "txtNameEstadium"
        Me.txtNameEstadium.Size = New System.Drawing.Size(289, 20)
        Me.txtNameEstadium.TabIndex = 31
        '
        'txtNameTeam
        '
        Me.txtNameTeam.Enabled = False
        Me.txtNameTeam.Location = New System.Drawing.Point(253, 72)
        Me.txtNameTeam.Name = "txtNameTeam"
        Me.txtNameTeam.Size = New System.Drawing.Size(276, 20)
        Me.txtNameTeam.TabIndex = 30
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(608, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Uniforme 1:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Uniforme 2:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nome do Estádio:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nome:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'T
        '
        Me.T.AutoSize = True
        Me.T.Location = New System.Drawing.Point(469, 183)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(97, 13)
        Me.T.TabIndex = 24
        Me.T.Text = "Times Registrados:"
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.Enabled = False
        Me.btnSaveEdit.Location = New System.Drawing.Point(209, 160)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEdit.TabIndex = 23
        Me.btnSaveEdit.Text = "Salvar"
        Me.btnSaveEdit.UseVisualStyleBackColor = True
        '
        'EditTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtUniform1)
        Me.Controls.Add(Me.txtUniform2)
        Me.Controls.Add(Me.txtNameEstadium)
        Me.Controls.Add(Me.txtNameTeam)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Name = "EditTeam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditTeam"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtUniform1 As TextBox
    Friend WithEvents txtUniform2 As TextBox
    Friend WithEvents txtNameEstadium As TextBox
    Friend WithEvents txtNameTeam As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents T As Label
    Friend WithEvents btnSaveEdit As Button
End Class
