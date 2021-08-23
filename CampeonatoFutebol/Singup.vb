Imports MySql.Data.MySqlClient

Public Class Singup
    Private Sub Singup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSingup_Click(sender As Object, e As EventArgs) Handles ButtonSingup.Click
        Dim fname As String = TextBoxInputFName.Text
        Dim lname As String = TextBoxInputLName.Text
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxRepeatPass.Text
        Dim user As String = TextBoxUsername.Text

        If fname.Trim() = "" Or lname.Trim() = "" Or password.Trim = "" Or cpassword.Trim() = "" Or user.Trim() = "" Then
            MessageBox.Show("Um ou mais campos obrigatórios estão em branco", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("Senhas não conferem", "Por favor tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernameExist(user) Then
            MessageBox.Show("Usuário já está em uso", "tente outro por favor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'dados validados, conexão com o banco de dados aplicando os valores informados nas variáveis do banco 
            Dim conn As New MY_CONNECTION2()
            Dim command As New MySqlCommand("INSERT INTO `users`(`first_name`, `last_name`, `email`, `username`, `password`) VALUES (@fn, @ln, @mail, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()
            'verifica se foi bem sucedida as transações de dados com o banco
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Usuário Cadastrado com Sucesso!", "Usuário adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()
            Else
                MessageBox.Show("Falha ao cadastrar usuário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()
            End If
        End If


    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean
        Dim con As New MY_CONNECTION2()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)


        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim login As New LoginForm
        LoginForm.Show()

    End Sub
End Class