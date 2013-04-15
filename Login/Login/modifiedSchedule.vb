Imports System.IO
Imports WindowsApplication1.DailySchedule
Public Class modifiedSchedule
    Private readCurrent As New StreamReader("mySchedule.txt")
    'Private updateCurrent As New StreamWriter("mySchedule.txt")
    Private readAvail As New StreamReader("availableSchedule.txt")
    'Private updateAvail As New StreamWriter("availableSchedule.txt")
    Dim ct As Integer = 5
    Public tempList As ListBox = DailySchedule.listDailySched

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        'lstAvail.Items.Add(lstNow.SelectedItem)
        'lstNow.Items.Remove(lstNow.SelectedItem)
        lstNow.Items.Add(lstAvail.SelectedItem)
        lstAvail.Items.Remove(lstAvail.SelectedItem)
    End Sub

    Private Sub modifiedSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempString As String
        While (readCurrent.Peek() <> -1)
            tempString = readCurrent.ReadLine()
            lstNow.Items.Add(tempString)
        End While
        While (readAvail.Peek() <> -1)
            tempString = readAvail.ReadLine()
            lstAvail.Items.Add(tempString)
        End While

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        lstAvail.Items.Add(lstNow.SelectedItem)
        lstNow.Items.Remove(lstNow.SelectedItem)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        DailySchedule.listDailySched.Items.Clear()

        For i As Integer = 0 To lstNow.Items.Count() - 1
            DailySchedule.listDailySched.Items.Add(CStr(lstNow.Items.Item(i)))

        Next
        DailySchedule.listDailySched.Sorted = True
        Me.Hide()

    End Sub
End Class