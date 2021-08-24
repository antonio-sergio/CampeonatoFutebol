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

            formactDg()
            counterRegister()

        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Public Sub formactDg()
        dg.Columns(0).HeaderText = "Time"
        dg.Columns(1).HeaderText = "Uniforme 1"
        dg.Columns(2).HeaderText = "Uniforme 2"
        dg.Columns(3).HeaderText = "Estádio/Campo"
        dg.Columns(4).HeaderText = "ID"
        dg.Columns(4).Visible = False

        dg.Columns(4).Width = 50
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
End Class