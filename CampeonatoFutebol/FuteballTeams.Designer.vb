<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuteballTeams
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(200, 282)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(481, 150)
        Me.dg.TabIndex = 21
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(272, 95)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(38, 20)
        Me.txtCode.TabIndex = 20
        '
        'txtUniform1
        '
        Me.txtUniform1.Enabled = False
        Me.txtUniform1.Location = New System.Drawing.Point(317, 203)
        Me.txtUniform1.Name = "txtUniform1"
        Me.txtUniform1.Size = New System.Drawing.Size(100, 20)
        Me.txtUniform1.TabIndex = 19
        '
        'txtUniform2
        '
        Me.txtUniform2.Enabled = False
        Me.txtUniform2.Location = New System.Drawing.Point(317, 237)
        Me.txtUniform2.Name = "txtUniform2"
        Me.txtUniform2.Size = New System.Drawing.Size(100, 20)
        Me.txtUniform2.TabIndex = 18
        '
        'txtNameEstadium
        '
        Me.txtNameEstadium.Enabled = False
        Me.txtNameEstadium.Location = New System.Drawing.Point(314, 171)
        Me.txtNameEstadium.Name = "txtNameEstadium"
        Me.txtNameEstadium.Size = New System.Drawing.Size(100, 20)
        Me.txtNameEstadium.TabIndex = 17
        '
        'txtNameTeam
        '
        Me.txtNameTeam.Enabled = False
        Me.txtNameTeam.Location = New System.Drawing.Point(314, 135)
        Me.txtNameTeam.Name = "txtNameTeam"
        Me.txtNameTeam.Size = New System.Drawing.Size(100, 20)
        Me.txtNameTeam.TabIndex = 16
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(599, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Uniforme 1:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Uniforme 2:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nome do Estádio:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nome:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'T
        '
        Me.T.AutoSize = True
        Me.T.Location = New System.Drawing.Point(515, 33)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(43, 13)
        Me.T.TabIndex = 10
        Me.T.Text = "Buscar:"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(84, 280)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Excluir"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(84, 168)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(84, 216)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Editar Time"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 130)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Adicionar Time"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "times de futebol"
        '
        'FuteballTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FuteballTeams"
        Me.Text = "FuteballTeams"
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
End Class
