Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim conn As New MY_CONNECTION2()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()

        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn And `password` = @pass", conn.getConnection())


        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        If TextBoxUsername.Text.Trim() = "" Or TextBoxUsername.Text.Trim().ToLower() = "username" Then
            MessageBox.Show("Digite seu username para efetuar o login", "É necessário um username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then
            MessageBox.Show("Digite sua senha para efetuar o login", "É necessário uma senha", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Me.Hide()
                Dim mainAppForm As New Dashboard()
                mainAppForm.Show()
            Else 'senão, msg de erro
                MessageBox.Show("Usuário e/ou senha inválidos", "Login falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim windowSingUp As New Singup()
        windowSingUp.Show()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
