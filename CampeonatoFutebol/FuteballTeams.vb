Imports MySql.Data.MySqlClient
Public Class FuteballTeams
    Dim connection As New MY_CONNECTION2
    Private Sub FuteballTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toList()
    End Sub

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
            toList()

        Else
            MsgBox("Preencha o campo descrição")
        End If
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

            formactDg()

        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Private Sub formactDg()
        dg.Columns(0).HeaderText = "Time"
        dg.Columns(1).HeaderText = "Uniforme 1"
        dg.Columns(2).HeaderText = "Uniforme 2"
        dg.Columns(3).HeaderText = "Estádio/Campo"
        dg.Columns(4).HeaderText = "ID"
        dg.Columns(4).Visible = False

        dg.Columns(4).Width = 50
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtNameTeam.Enabled = True
        txtNameEstadium.Enabled = True
        txtUniform1.Enabled = True
        txtUniform2.Enabled = True

        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class