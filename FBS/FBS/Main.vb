Public Class Main
    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, picExit.MouseEnter, picBooking.MouseEnter
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, picExit.MouseLeave, picExit.MouseLeave
        Me.Cursor = Cursors.Default
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub OnImgClick(sender As Object, e As EventArgs) Handles picVenue.Click
        If sender = picVenue Then
            Dim venueInfo As New VenueInfo
            Me.Hide()
            venueInfo.Show()
            Me.Show()
        ElseIf sender = picBooking Then
            Dim booking As New Booking
            Me.Hide()
            booking.Show()
        ElseIf sender = picExit Then
            Dim login As New Login
            Me.Close()
            login.Show()
        End If
    End Sub
End Class
