Imports WindowsApplication1.scheduleInfo

Public Class manage_event

    Public tmpName As String = Login.userName

    Public event1 As New scheduleInfo("ACM Picnic", "Jun 10 2013")
    Public event2 As New scheduleInfo("Movie night", "May 12 2013")
    Public event3 As New scheduleInfo("Marathon", "May 20 2013")
    Public event4 As New scheduleInfo("Art showcase", "July 9 2013")
    Public event5 As New scheduleInfo("Basketball", "Aug 17 2013")
    Public currentEvent As New scheduleInfo("VolleyBall", "Sept 14 2013")




    Private Sub events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & tmpName

        lstAvailableEvent.Items.Add(event1)
        lstAvailableEvent.Items.Add(event2)
        lstAvailableEvent.Items.Add(event3)
        lstAvailableEvent.Items.Add(event4)
        lstAvailableEvent.Items.Add(event5)
        lstCurrentEvent.Items.Add(currentEvent)

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub


    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        'If lstAvailable.SelectedItem = True Then
        lstCurrentEvent.Items.Add(lstAvailableEvent.SelectedItem)
        lstAvailableEvent.Items.Remove(lstAvailableEvent.SelectedItem)
        'Else
        ' MessageBox.Show("sdgsfsf", "sdfsdf")
        'End If
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        lstAvailableEvent.Items.Add(lstCurrentEvent.SelectedItem)
        lstCurrentEvent.Items.Remove(lstCurrentEvent.SelectedItem)
    End Sub
End Class