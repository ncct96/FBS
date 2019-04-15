Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String = GlobalVars.currentType

        If user.Equals("Customer") Then
            ' Account Menu Strip
            Dim accountMenu As New ToolStripMenuItem
            accountMenu.Text = "&Account"
            accountMenu.ShortcutKeys = Keys.Control And Keys.A
            accountMenu.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim acSubCUser As New ToolStripMenuItem
            acSubCUser.Text = "Change &User"
            acSubCUser.ShortcutKeys = Keys.Alt And Keys.U
            acSubCUser.ShowShortcutKeys = True
            acSubCUser.TextImageRelation = TextImageRelation.ImageBeforeText

            ' Navigate Menu Strip
            Dim navigateMenu As New ToolStripMenuItem
            navigateMenu.Text = "&Booking"
            navigateMenu.ShortcutKeys = Keys.Control And Keys.N
            navigateMenu.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubMBooking As New ToolStripMenuItem
            nvSubMBooking.Text = "&Make Booking"
            nvSubMBooking.ShortcutKeys = Keys.Alt And Keys.M
            nvSubMBooking.ShowShortcutKeys = True
            nvSubMBooking.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubVBooking As New ToolStripMenuItem
            nvSubVBooking.Text = "&View Bookings"
            nvSubVBooking.ShortcutKeys = Keys.Alt And Keys.V
            nvSubVBooking.ShowShortcutKeys = True
            nvSubVBooking.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubCBooking As New ToolStripMenuItem
            nvSubCBooking.Text = "&Cancel Bookings"
            nvSubCBooking.ShortcutKeys = Keys.Alt And Keys.C
            nvSubCBooking.ShowShortcutKeys = True
            nvSubCBooking.TextImageRelation = TextImageRelation.ImageBeforeText

            ' Event Handlers for user menu items
            AddHandler acSubCUser.Click, AddressOf acSubCUser_Click
            AddHandler nvSubMBooking.Click, AddressOf nvSubMBooking_Click
            AddHandler nvSubVBooking.Click, AddressOf nvSubVBooking_Click
            AddHandler nvSubCBooking.Click, AddressOf nvSubCBooking_Click

            ' Add menu strip into place
            accountMenu.DropDownItems.Add(acSubCUser)
            navigateMenu.DropDownItems.AddRange({nvSubVBooking, nvSubMBooking, nvSubCBooking})
            Me.FBSMenuStrip.Items.AddRange({accountMenu, navigateMenu})

        ElseIf user.Equals("Admin") Then
            ' Account Menu Strip
            Dim accountMenu As New ToolStripMenuItem
            accountMenu.Text = "&Account"
            accountMenu.ShortcutKeys = Keys.Control And Keys.A
            accountMenu.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim acSubCUser As New ToolStripMenuItem
            acSubCUser.Text = "&Change User"
            acSubCUser.ShortcutKeys = Keys.Alt And Keys.C
            acSubCUser.ShowShortcutKeys = True
            acSubCUser.TextImageRelation = TextImageRelation.ImageBeforeText

            ' Navigate Menu Strip
            Dim navigateMenu As New ToolStripMenuItem
            navigateMenu.Text = "&Manage"
            navigateMenu.ShortcutKeys = Keys.Control And Keys.M
            navigateMenu.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubGReport As New ToolStripMenuItem
            nvSubGReport.Text = "&Generate Report"
            nvSubGReport.ShortcutKeys = Keys.Alt And Keys.G
            nvSubGReport.ShowShortcutKeys = True
            nvSubGReport.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubSUser As New ToolStripMenuItem
            nvSubSUser.Text = "&Search User"
            nvSubSUser.ShortcutKeys = Keys.Alt And Keys.S
            nvSubSUser.ShowShortcutKeys = True
            nvSubSUser.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubVBooking As New ToolStripMenuItem
            nvSubVBooking.Text = "&View User Bookings"
            nvSubVBooking.ShortcutKeys = Keys.Alt And Keys.V
            nvSubVBooking.ShowShortcutKeys = True
            nvSubVBooking.TextImageRelation = TextImageRelation.ImageBeforeText
            Dim nvSubMVenue As New ToolStripMenuItem
            nvSubMVenue.Text = "&Modify Venue"
            nvSubMVenue.ShortcutKeys = Keys.Alt And Keys.M
            nvSubMVenue.ShowShortcutKeys = True
            nvSubMVenue.TextImageRelation = TextImageRelation.ImageBeforeText

            ' Event Handlers for Admin menu items
            AddHandler acSubCUser.Click, AddressOf acSubCUser_Click
            AddHandler nvSubMVenue.Click, AddressOf nvSubMVenue_Click
            AddHandler nvSubGReport.Click, AddressOf nvSubGReport_Click
            AddHandler nvSubSUser.Click, AddressOf nvSubSUser_Click
            AddHandler nvSubVBooking.Click, AddressOf nvSubVBooking2_Click

            ' Add menu strip item into place
            accountMenu.DropDownItems.Add(acSubCUser)
            navigateMenu.DropDownItems.AddRange({nvSubGReport, nvSubSUser, nvSubVBooking, nvSubMVenue})
            Me.FBSMenuStrip.Items.AddRange({accountMenu, navigateMenu})

            'Add the menu strip to controls so it can be shared to other forms
            Me.Controls.Add(Me.FBSMenuStrip)
        End If
    End Sub

    Private Sub nvSubVBooking2_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub nvSubSUser_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub nvSubGReport_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub nvSubMVenue_Click(sender As Object, e As EventArgs)
        Dim venueList As New VenueList
        venueList.ShowDialog()
    End Sub

    Private Sub acSubCUser_Click(sender As Object, e As EventArgs)
        GlobalVars.changeUser()
        Me.Close()
    End Sub

    Private Sub nvSubCBooking_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub nvSubVBooking_Click(sender As Object, e As EventArgs)
        Dim pass As New BookingHistory
        pass.ShowDialog()
    End Sub

    Private Sub nvSubMBooking_Click(sender As Object, e As EventArgs)
        Dim makeBook As New Booking
        makeBook.Show()
    End Sub
End Class
