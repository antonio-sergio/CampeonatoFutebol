﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Singup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxInputFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxInputLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxRepeatPass = New System.Windows.Forms.TextBox()
        Me.ButtonSingup = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'TextBoxInputFName
        '
        Me.TextBoxInputFName.Location = New System.Drawing.Point(297, 79)
        Me.TextBoxInputFName.Name = "TextBoxInputFName"
        Me.TextBoxInputFName.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxInputFName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sobrenome"
        '
        'TextBoxInputLName
        '
        Me.TextBoxInputLName.Location = New System.Drawing.Point(297, 109)
        Me.TextBoxInputLName.Name = "TextBoxInputLName"
        Me.TextBoxInputLName.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxInputLName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "E-Mail"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(297, 138)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxEmail.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Usuário:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(297, 171)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxUsername.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Senha"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(297, 201)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxPassword.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Confirme a senha"
        '
        'TextBoxRepeatPass
        '
        Me.TextBoxRepeatPass.Location = New System.Drawing.Point(297, 236)
        Me.TextBoxRepeatPass.Name = "TextBoxRepeatPass"
        Me.TextBoxRepeatPass.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxRepeatPass.TabIndex = 1
        '
        'ButtonSingup
        '
        Me.ButtonSingup.Location = New System.Drawing.Point(326, 335)
        Me.ButtonSingup.Name = "ButtonSingup"
        Me.ButtonSingup.Size = New System.Drawing.Size(110, 23)
        Me.ButtonSingup.TabIndex = 2
        Me.ButtonSingup.Text = "Confirmar Cadastro"
        Me.ButtonSingup.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Já está cadastrado? Faça o login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Singup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonSingup)
        Me.Controls.Add(Me.TextBoxRepeatPass)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxInputLName)
        Me.Controls.Add(Me.TextBoxInputFName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Singup"
        Me.Text = "Singup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxInputFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxInputLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxRepeatPass As TextBox
    Friend WithEvents ButtonSingup As Button
    Friend WithEvents Button1 As Button
End Class
