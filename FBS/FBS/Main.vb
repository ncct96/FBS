Public Class Main
    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, picExit.MouseEnter, picBooking.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, picExit.MouseLeave, picExit.MouseLeave, picBooking.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OnImgClick(sender As Object, e As EventArgs) Handles picVenue.Click, picBooking.Click, picExit.Click
        If sender.Equals(picVenue) Then
            Dim venueList As New VenueList
            Me.Hide()
            venueList.ShowDialog()
            Me.Show()
        ElseIf sender.Equals(picBooking) Then
            Dim booking As New Booking
            Me.Hide()
            booking.ShowDialog()
            Me.Show()
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
End Class
