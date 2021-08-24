Imports MySql.Data.MySqlClient
Public Class EditTeam
    Dim connection As New MY_CONNECTION2
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click

        Dim name As String = txtNameTeam.Text
        Dim stadium As String = txtNameEstadium.Text
        Dim uniform1 As String = txtUniform1.Text
        Dim uniform2 As String = txtUniform2.Text


        txtNameTeam.Enabled = True
        txtNameEstadium.Enabled = True
        txtUniform1.Enabled = True
        txtUniform2.Enabled = True
        btnSaveEdit.Enabled = True



        If name <> "" And stadium <> "" And uniform1 <> "" And uniform2 <> "" Then

            Try
                Dim cmd As New MySqlCommand("UPDATE `teams` SET `name_team`='" & name & "',`uniform_one`='" & uniform1 & "',`uniform_two`='" & uniform2 & "',`stadium`='" & stadium & "' WHERE `id` = '" & txtCode.Text & "' ", connection.getConnection())

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