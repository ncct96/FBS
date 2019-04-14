Public Class BookingHistory
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String = GlobalVars.currentType

        If user.Equals("Customer") Then
            ' Account Menu Strip
            Dim accountMenu As New ToolStripMenuItem("&Account")
            accountMenu.ShortcutKeys = Keys.Control And Keys.A
            Dim acSubCUser As New ToolStripMenuItem("Change &User")
            acSubCUser.ShortcutKeys = Keys.Alt And Keys.U

            ' Navigate Menu Strip
            Dim navigateMenu As New ToolStripMenuItem("&Booking")
            navigateMenu.ShortcutKeys = Keys.Control And Keys.N
            Dim nvSubMBooking As New ToolStripMenuItem("&Make Booking")
            nvSubMBooking.ShortcutKeys = Keys.Alt And Keys.M
            Dim nvSubVBooking As New ToolStripMenuItem("&View Bookings")
            nvSubVBooking.ShortcutKeys = Keys.Alt And Keys.V
            Dim nvSubCBooking As New ToolStripMenuItem("&Cancel Bookings")
            nvSubCBooking.ShortcutKeys = Keys.Alt And Keys.C

            ' Add menu strip into place
            accountMenu.DropDownItems.Add(acSubCUser)

            navigateMenu.DropDownItems.Add(nvSubVBooking)
            navigateMenu.DropDownItems.Add(nvSubMBooking)
            navigateMenu.DropDownItems.Add(nvSubCBooking)

            Me.FBSMenuStrip.Items.Add(accountMenu)
            Me.FBSMenuStrip.Items.Add(navigateMenu)

        ElseIf user.Equals("Admin") Then
            ' Account Menu Strip
            Dim accountMenu As New ToolStripMenuItem("&Account")
            accountMenu.ShortcutKeys = Keys.Control And Keys.A
            Dim acSubCUser As New ToolStripMenuItem("&Change User")
            acSubCUser.ShortcutKeys = Keys.Alt And Keys.C

            ' Navigate Menu Strip
            Dim navigateMenu As New ToolStripMenuItem("&Manage")
            navigateMenu.ShortcutKeys = Keys.Control And Keys.M
            Dim nvSubGReport As New ToolStripMenuItem("&Generate Report")
            nvSubGReport.ShortcutKeys = Keys.Alt And Keys.G
            Dim nvSubSUser As New ToolStripMenuItem("&Search User")
            nvSubSUser.ShortcutKeys = Keys.Alt And Keys.S
            Dim nvSubVBooking As New ToolStripMenuItem("&View User Bookings")
            nvSubVBooking.ShortcutKeys = Keys.Alt And Keys.V
            Dim nvSubMVenue As New ToolStripMenuItem("&Modify Venue")
            nvSubMVenue.ShortcutKeys = Keys.Alt And Keys.M

            ' Add menu strip item into place
            accountMenu.DropDownItems.Add(acSubCUser)

            navigateMenu.DropDownItems.Add(nvSubGReport)
            navigateMenu.DropDownItems.Add(nvSubSUser)
            navigateMenu.DropDownItems.Add(nvSubVBooking)
            navigateMenu.DropDownItems.Add(nvSubMVenue)
            Me.FBSMenuStrip.Items.Add(accountMenu)
            Me.FBSMenuStrip.Items.Add(navigateMenu)

        End If

    End Sub
End Class