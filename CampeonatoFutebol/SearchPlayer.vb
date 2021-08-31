Imports MySql.Data.MySqlClient

Public Class SearchPlayer
    Dim connection As New MY_CONNECTION2
    Private Sub SearchPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toList()
    End Sub

    Private Sub toList()
        Try
            connection.openConnection()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select e.id_player, e.idTeam, e.name, t.name_team, e.function, e.email, e.shirt_number,  e.phone, e.date_register, e.cpf  from employees as e INNER JOIN teams as t on e.idTeam = t.idTeam order by name asc"

            da = New MySqlDataAdapter(sql, connection.getConnection)
            da.Fill(dt)
            dgPlayers.DataSource = dt

            FormactDg(dgPlayers)


        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Public Sub FormactDg(dg)
        dg.Columns(0).HeaderText = "ID Jogador"
        dg.Columns(2).HeaderText = "Nome"
        dg.Columns(3).HeaderText = "Time"
        dg.Columns(4).HeaderText = "Função"
        dg.Columns(5).HeaderText = "E-Mail"
        dg.Columns(6).HeaderText = "Nº"
        dg.Columns(7).HeaderText = "Telefone"
        dg.Columns(8).HeaderText = "Data do registro"

        'dg.Columns(8).Visible = False
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(9).Visible = False
        'dg.Columns(4).Width = 50
    End Sub

End Class