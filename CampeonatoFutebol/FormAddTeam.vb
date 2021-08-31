Imports MySql.Data.MySqlClient
Public Class FormAddTeam
    Dim connection As New MY_CONNECTION2()


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim team As New Classes.Teams
        team.name_team = txtNameTeam.Text
        team.stadium = txtNameEstadium.Text
        team.uniform1 = txtUniform2.Text
        team.uniform2 = txtUniform1.Text






        If team.name_team <> "" Or team.stadium <> "" Or team.uniform1 <> "" Or team.uniform2 <> "" Then

            Try
                connection.openConnection()
                Dim cmd As New MySqlCommand("INSERT INTO `teams`(`name_team`,`stadium`, `uniform_one`, `uniform_two`) VALUES (@n, @st, @uo, @ut)", connection.getConnection())

                cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = team.name_team
                cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = team.stadium
                cmd.Parameters.Add("@uo", MySqlDbType.VarChar).Value = team.uniform1
                cmd.Parameters.Add("@ut", MySqlDbType.VarChar).Value = team.uniform2

                cmd.ExecuteNonQuery()

                MsgBox("Dados salvos com sucesso")
                Me.Hide()
            Catch ex As Exception
                MsgBox("error " + ex.Message)
            End Try

            btnSave.Enabled = False

        Else
            MsgBox("Preencha o campo descrição")
        End If
    End Sub

    Private Sub FormAddTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class