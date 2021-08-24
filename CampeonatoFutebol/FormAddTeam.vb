Imports MySql.Data.MySqlClient
Public Class FormAddTeam
    Dim connection As New MY_CONNECTION2()


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name As String = txtNameTeam.Text
        Dim stadium As String = txtNameEstadium.Text
        Dim uniform1 As String = txtUniform1.Text
        Dim uniform2 As String = txtUniform2.Text

        If name <> "" Or stadium <> "" Or uniform1 <> "" Or uniform2 <> "" Then

            Try
                connection.openConnection()
                Dim cmd As New MySqlCommand("INSERT INTO `teams`(`name_team`,`stadium`, `uniform_one`, `uniform_two`) VALUES (@n, @st, @uo, @ut)", connection.getConnection())

                cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = stadium
                cmd.Parameters.Add("@uo", MySqlDbType.VarChar).Value = uniform1
                cmd.Parameters.Add("@ut", MySqlDbType.VarChar).Value = uniform2

                cmd.ExecuteNonQuery()

                MsgBox("Dados salvos com sucesso")
            Catch ex As Exception
                MsgBox("error " + ex.Message)
            End Try

            btnSave.Enabled = False

        Else
            MsgBox("Preencha o campo descrição")
        End If
    End Sub


End Class