Public Class Login

    Public userName As String = Nothing
    Dim passWord As String = Nothing

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If userName <> "jin" Then
            MessageBox.Show("User is Invalid")
        End If
        If PassWord <> "123" Then
            MessageBox.Show("Password is Invalid")
        End If
        If userName = "jin" And passWord = "123" Then
            index.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblForgotPW.Click
        ForgotPassword.Show()
    End Sub

    Private Sub tbUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        userName = txtUserName.Text
    End Sub

    Private Sub tbPassWord_TextChanged(sender As Object, e As EventArgs) Handles txtPassWord.TextChanged
        passWord = txtPassWord.Text
    End Sub
End Class
