Public Class Dashboard


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

        Dim mainPlayers As New AddPlayer
        mainPlayers.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Championship.Show()
    End Sub

    Private Sub TIMES_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FuteballTeams.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Games.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddPlayer.Show()
    End Sub
End Class