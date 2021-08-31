Imports MySql.Data.MySqlClient
Public Class Functions
    Dim connection As New MY_CONNECTION2
    Public Sub FormactDg(dg)
        dg.Columns(0).HeaderText = "Time"
        dg.Columns(1).HeaderText = "Uniforme 1"
        dg.Columns(2).HeaderText = "Uniforme 2"
        dg.Columns(3).HeaderText = "Estádio/Campo"
        dg.Columns(4).HeaderText = "ID"
        dg.Columns(4).Visible = False

        dg.Columns(4).Width = 50
    End Sub


End Class
