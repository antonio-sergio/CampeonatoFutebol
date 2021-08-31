<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddTeam
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
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtUniform2 = New System.Windows.Forms.TextBox()
        Me.txtUniform1 = New System.Windows.Forms.TextBox()
        Me.txtNameEstadium = New System.Windows.Forms.TextBox()
        Me.txtNameTeam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegisters = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(323, 109)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(38, 20)
        Me.txtCode.TabIndex = 39
        '
        'txtUniform2
        '
        Me.txtUniform2.Location = New System.Drawing.Point(323, 213)
        Me.txtUniform2.Name = "txtUniform2"
        Me.txtUniform2.Size = New System.Drawing.Size(131, 20)
        Me.txtUniform2.TabIndex = 4
        '
        'txtUniform1
        '
        Me.txtUniform1.Location = New System.Drawing.Point(323, 187)
        Me.txtUniform1.Name = "txtUniform1"
        Me.txtUniform1.Size = New System.Drawing.Size(131, 20)
        Me.txtUniform1.TabIndex = 3
        '
        'txtNameEstadium
        '
        Me.txtNameEstadium.Location = New System.Drawing.Point(323, 161)
        Me.txtNameEstadium.Name = "txtNameEstadium"
        Me.txtNameEstadium.Size = New System.Drawing.Size(165, 20)
        Me.txtNameEstadium.TabIndex = 2
        '
        'txtNameTeam
        '
        Me.txtNameTeam.Location = New System.Drawing.Point(323, 135)
        Me.txtNameTeam.Name = "txtNameTeam"
        Me.txtNameTeam.Size = New System.Drawing.Size(165, 20)
        Me.txtNameTeam.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Uniforme 1:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Uniforme 2:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nome do Estádio:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nome:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'lblRegisters
        '
        Me.lblRegisters.AutoSize = True
        Me.lblRegisters.Location = New System.Drawing.Point(661, 266)
        Me.lblRegisters.Name = "lblRegisters"
        Me.lblRegisters.Size = New System.Drawing.Size(0, 13)
        Me.lblRegisters.TabIndex = 29
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(362, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormAddTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtUniform2)
        Me.Controls.Add(Me.txtUniform1)
        Me.Controls.Add(Me.txtNameEstadium)
        Me.Controls.Add(Me.txtNameTeam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRegisters)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "FormAddTeam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddTeam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtUniform2 As TextBox
    Friend WithEvents txtUniform1 As TextBox
    Friend WithEvents txtNameEstadium As TextBox
    Friend WithEvents txtNameTeam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRegisters As Label
    Friend WithEvents btnSave As Button
End Class
