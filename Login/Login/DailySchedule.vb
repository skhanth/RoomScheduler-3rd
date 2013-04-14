Imports System.IO

Public Class DailySchedule

    Private fileToLoad As New StreamReader("mySchedule.txt")

    Public tmpName As String = Login.userName

    Private Sub DailySchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & tmpName
        txtMap.Text = fileToLoad.ReadToEnd()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub
End Class