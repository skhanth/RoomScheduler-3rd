﻿Public Class Daily

    Dim tmpName As String = Login.userName

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & tmpName

    End Sub

    
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        index.Show()
    End Sub
End Class