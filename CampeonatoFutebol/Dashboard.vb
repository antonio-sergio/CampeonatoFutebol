Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtChampionship_Click(sender As Object, e As EventArgs) Handles txtChampionship.Click

        Dim mainChampionship As New Championship
        mainChampionship.Show()

    End Sub

    Private Sub txtTeams_Click(sender As Object, e As EventArgs) Handles txtTeams.Click

        Dim mainTeams As New FuteballTeams
        mainTeams.Show()

    End Sub

    Private Sub txtGames_Click(sender As Object, e As EventArgs) Handles txtGames.Click

        Dim mainGames As New Games
        mainGames.Show()

    End Sub

    Private Sub txtPlayers_Click(sender As Object, e As EventArgs) Handles txtPlayers.Click

        Dim mainPlayers As New Players
        mainPlayers.Show()

    End Sub
End Class