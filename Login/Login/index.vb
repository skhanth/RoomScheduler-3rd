﻿Public Class index

    Public tmpName As String = Login.userName

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & tmpName

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnDailySchedule_Click(sender As Object, e As EventArgs) Handles btnDailySchedule.Click

        DailySchedule.Show()
        Me.Hide()

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        manage_event.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrganization_Click(sender As Object, e As EventArgs) Handles btnOrganization.Click
        organization.Show()
        Me.Hide()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("for help go to support@myroomscheduler.com")
    End Sub
End Class