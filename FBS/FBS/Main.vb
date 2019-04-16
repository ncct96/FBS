Public Class Main
    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, picView.MouseEnter, picExit.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, picView.MouseLeave, picExit.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OnImgClick(sender As Object, e As EventArgs) Handles picVenue.Click, picView.Click, picExit.Click
        If sender.Equals(picVenue) Then
            If GlobalVars.currentType.Equals("Customer") Then
                Dim venueList As New VenueList
                Me.Hide()
                venueList.ShowDialog()
                Me.Show()
            Else
                Dim adminVenue As New AdminVenue
                Me.Hide()
                adminVenue.ShowDialog()
                Me.Show()
            End If
        ElseIf sender.Equals(picView) Then
            If GlobalVars.currentType.Equals("Customer") Then
                'Dim booking As New Booking
                Me.Hide()
                'booking.ShowDialog()
                Me.Show()
            Else
                Dim reportGenerator As New ReportGenerator
                Me.Hide()
                reportGenerator.ShowDialog()
                Me.Show()
            End If
        ElseIf sender.Equals(picExit) Then
            IsX = False
            Me.Close()
        End If
    End Sub

    Private IsX = True
    Private Sub OnFormClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsX Then
            Application.Exit()
        End If
    End Sub

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVars.currentType.Equals("Customer") Then
            lblVenue.Text = "View Venues"
            picVenue.Image = My.Resources.Home
            lblView.Text = "View Booking History"
            picView.Image = My.Resources.Book
        Else
            lblVenue.Text = "Venue Maintenence"
            picVenue.Image = My.Resources.Gears
            lblView.Text = "Generate Report"
            picView.Image = My.Resources.Reports
        End If
    End Sub

    ' Ck partial edits starts
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookHistory As New BookingHistory
        Me.Hide()
        bookHistory.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deleteAcc As New DeleteAccount
        Me.Hide()
        deleteAcc.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim updateStat As New UpdateStatus
        Me.Hide()
        updateStat.ShowDialog()
        Me.Show()
    End Sub
    ' Ck partial edits end
End Class
