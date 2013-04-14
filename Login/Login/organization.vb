Imports WindowsApplication1.scheduleInfo

Public Class organization

    Public tmpName As String = Login.userName

    Public org1 As New scheduleInfo("ACM", "")
    Public org2 As New scheduleInfo("ACU", "")
    Public org3 As New scheduleInfo("Art Club", "")
    Public org4 As New scheduleInfo("Gamer League", "")
    Public org5 As New scheduleInfo("Honors", "")
    Public currentOrg As New scheduleInfo("President Club", "")

    Private Sub organization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWelcomeUser.Text = "Welcome " & tmpName

        lstAvailableOrg.Items.Add(org1)
        lstAvailableOrg.Items.Add(org2)
        lstAvailableOrg.Items.Add(org3)
        lstAvailableOrg.Items.Add(org4)
        lstAvailableOrg.Items.Add(org5)
        lstCurrentOrg.Items.Add(currentOrg)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        index.Show()

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        lstCurrentOrg.Items.Add(lstAvailableOrg.SelectedItem)
        lstAvailableOrg.Items.Remove(lstAvailableOrg.SelectedItem)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        lstAvailableOrg.Items.Add(lstCurrentOrg.SelectedItem)
        lstCurrentOrg.Items.Remove(lstCurrentOrg.SelectedItem)
    End Sub
End Class