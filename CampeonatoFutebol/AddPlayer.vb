Imports MySql.Data.MySqlClient

Public Class AddPlayer
    Dim connection As New MY_CONNECTION2
    Private Sub AddPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toList()


        enableItem()
    End Sub



    Sub clear()

        txtCpf.Text = ""
        txtCodTeam.Text = ""
        txtFunction.Text = ""
        txtName.Text = ""
        txtPhone.Text = ""
        txtSearch.Text = ""
        txtShirtNumber.Text = ""
        txtEmail.Text = ""

    End Sub

    Sub enableItem()
        txtName.Enabled = True
        txtCodTeam.Enabled = True

        txtPhone.Enabled = True
        txtSearch.Enabled = True
        txtShirtNumber.Enabled = True
        txtCpf.Enabled = True
        txtFunction.Enabled = True
        btnSave.Enabled = True
        txtEmail.Enabled = True
    End Sub

    Sub disabledItem()
        txtName.Enabled = False
        txtCodTeam.Enabled = False

        txtPhone.Enabled = False
        txtSearch.Enabled = False
        txtShirtNumber.Enabled = False
        txtCpf.Enabled = False
        txtFunction.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim data As String
            data = Now.ToString("yyyy-MM-dd")


            Dim connection As New MY_CONNECTION2
            connection.openConnection()
            Dim cmd As New MySqlCommand("INSERT INTO `employees`(`idteam`, `name`, `cpf`, `phone`, `email`, `shirt_number`, `function`, `date_register`) VALUES ( '" & txtCodTeam.Text & " ','" & txtName.Text & "','" & txtCpf.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtShirtNumber.Text & "','" & txtFunction.Text & "','" & Data & "' )", connection.getConnection())
            cmd.ExecuteNonQuery()

            MsgBox("Salvo com sucesso")
            clear()
        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
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

            dgCodeTeam.DataSource = dt
            FormactDgCode(dgCodeTeam)


        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
    End Sub

    Public Sub FormactDgCode(dg)
        dg.Columns(0).HeaderText = "Time"
        dg.Columns(4).HeaderText = "Cod"
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(4).Visible = True


        dg.Columns(4).Width = 40
    End Sub

    Private Sub searchPlayers_Click(sender As Object, e As EventArgs) Handles searchPlayers.Click
        Me.Hide()
        SearchPlayer.Show()
    End Sub

    Private Sub dgCodeTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCodeTeam.CellContentClick
        clear()
        toList()
    End Sub
End Class