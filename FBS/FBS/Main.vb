Public Class Main
    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, picView.MouseEnter, picBooking.MouseEnter, picUser.MouseEnter, picExit.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, picView.MouseLeave, picBooking.MouseLeave, picUser.MouseLeave, picExit.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OnImgClick(sender As Object, e As EventArgs) Handles picVenue.Click, picView.Click, picBooking.Click, picUser.Click, picExit.Click
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
        ElseIf sender.Equals(picBooking) Then
            If GlobalVars.currentType.Equals("Customer") Then
                Dim booking As New FrmBooking
                Me.Hide()
                booking.ShowDialog()
                Me.Show()
            Else
                Dim paymentStatus As New UpdateStatus
                Me.Hide()
                paymentStatus.ShowDialog()
                Me.Show()
            End If
        ElseIf sender.Equals(picView) Then
            If GlobalVars.currentType.Equals("Customer") Then
                Dim bookingHistory As New BookingHistory
                Me.Hide()
                bookingHistory.ShowDialog()
                Me.Show()
            Else
                Dim reportGenerator As New ReportGenerator
                Me.Hide()
                reportGenerator.ShowDialog()
                Me.Show()
            End If
        ElseIf sender.Equals(picUser) Then
            If GlobalVars.currentType.Equals("Customer") Then
                Dim pwChange As New PasswordChange
                Me.Hide()
                pwChange.ShowDialog()
                Me.Show()
            Else
                Dim userMaintain As New DeleteAccount
                Me.Hide()
                userMaintain.ShowDialog()
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
        lblName.Text = "Welcome Back " + GlobalVars.currentUser + "!"
        If GlobalVars.currentType.Equals("Customer") Then
            lblVenue.Text = "View Facilities"
            picVenue.Image = My.Resources.Home
            lblBooking.Text = "Make Booking"
            picBooking.Image = My.Resources.Book
            lblView.Text = "Booking History"
            picView.Image = My.Resources.Time
            lblUser.Text = "Change Password"
            picUser.Image = My.Resources.User
        Else
            lblVenue.Text = "Venue Maintenence"
            picVenue.Image = My.Resources.Gears
            lblBooking.Text = "Update Payment Status"
            picBooking.Image = My.Resources.Book
            lblView.Text = "Generate Report"
            picView.Image = My.Resources.Reports
            lblUser.Text = "User Management"
            picUser.Image = My.Resources.User
        End If
    End Sub

    ' Ck partial edits starts
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim bookHistory As New BookingHistory
        Me.Hide()
        bookHistory.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim deleteAcc As New DeleteAccount
        Me.Hide()
        deleteAcc.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim updateStat As New UpdateStatus
        Me.Hide()
        updateStat.ShowDialog()
        Me.Show()
    End Sub
    ' Ck partial edits end
End Class
