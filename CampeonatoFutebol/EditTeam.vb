Imports MySql.Data.MySqlClient
Public Class EditTeam
    Dim connection As New MY_CONNECTION2
    Dim functions As New Functions
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Dim team As New Classes.Teams
        team.name_team = txtNameTeam.Text
        team.stadium = txtNameEstadium.Text
        team.uniform1 = txtUniform1.Text
        team.uniform2 = txtUniform2.Text


        txtNameTeam.Enabled = True
        txtNameEstadium.Enabled = True
        txtUniform1.Enabled = True
        txtUniform2.Enabled = True
        btnSaveEdit.Enabled = True



        If Name <> "" And team.stadium <> "" And team.uniform1 <> "" And team.uniform2 <> "" Then

            Try
                Dim cmd As New MySqlCommand("UPDATE `teams` SET `name_team`='" & team.name_team & "',`uniform_one`='" & team.uniform1 & "',`uniform_two`='" & team.uniform2 & "',`stadium`='" & team.stadium & "' WHERE `idTeam` = '" & txtCode.Text & "' ", connection.getConnection())

                cmd.ExecuteNonQuery()


                MsgBox("Dados Editados com sucesso")
            Catch ex As Exception
                MsgBox("Erro ao editar dados " + ex.Message)
            End Try


        Else
            MsgBox("Preencha todos os campos")
        End If

        toList()


    End Sub

    Private Sub EditTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNameTeam.Enabled = True
        btnSaveEdit.Enabled = True
        toList()
    End Sub

    Private Sub toList()
        Try
            connection.openConnection()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from teams order by name_team asc"

            da = New MySqlDataAdapter(sql, connection.getConnection)
            da.Fill(dt)
            dg.DataSource = dt

            functions.FormactDg(dg)


        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub



    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

        txtNameTeam.Enabled = True
        txtNameEstadium.Enabled = True
        txtUniform1.Enabled = True
        txtUniform2.Enabled = True


        txtCode.Text = dg.CurrentRow.Cells(4).Value
        txtNameTeam.Text = dg.CurrentRow.Cells(0).Value
        txtUniform1.Text = dg.CurrentRow.Cells(1).Value
        txtUniform2.Text = dg.CurrentRow.Cells(2).Value
        txtNameEstadium.Text = dg.CurrentRow.Cells(3).Value
    End Sub
End Class