Imports MySql.Data.MySqlClient
Public Class FuteballTeams
    Dim connection As New MY_CONNECTION2
    Private Sub FuteballTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toList()
        btnEdit.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    Public Sub toList()
        Try
            connection.openConnection()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from teams order by name_team asc"

            da = New MySqlDataAdapter(sql, connection.getConnection)
            da.Fill(dt)
            dg.DataSource = dt

            FormactDg()


        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Public Sub FormactDg()
        dg.Columns(0).HeaderText = "Time"
        dg.Columns(1).HeaderText = "Uniforme 1"
        dg.Columns(2).HeaderText = "Uniforme 2"
        dg.Columns(3).HeaderText = "Estádio/Campo"
        dg.Columns(4).HeaderText = "ID"

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim fomrAddTeam As New FormAddTeam
        FormAddTeam.Show()


    End Sub



    Sub counterRegister()
        Dim total As Integer = dg.Rows.Count
        lblRegisters.Text = total
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim formEdit As New EditTeam
        EditTeam.Show()
        toList()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        toList()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

        btnDelete.Enabled = True
        txtCode.Text = dg.CurrentRow.Cells(4).Value

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim team As New Classes.Teams
        Dim result As DialogResult = MessageBox.Show("Confirmar exclusão?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = vbYes Then
            Try
                connection.openConnection()
                Dim cmd As New MySqlCommand("DELETE FROM `teams` WHERE `idTeam` = '" & txtCode.Text & "' ", connection.getConnection())

                cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = team.name_team


                cmd.ExecuteNonQuery()

                MsgBox("O time foi excluído")
            Catch ex As Exception
                MsgBox("Erro ao tentar excluí time " + ex.Message)
            End Try

            btnSave.Enabled = False
            toList()

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search()
    End Sub

    Private Sub Search()
        Try
            connection.openConnection()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            da = New MySqlDataAdapter("select * from teams where name_team LIKE '" & txtSearch.Text & "%' order by name_team asc", connection.getConnection)
            da.Fill(dt)
            dg.DataSource = dt


            counterRegister()

        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub
End Class