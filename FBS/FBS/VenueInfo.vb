Public Class VenueInfo
    Public ID As Integer

    'ON FORM LOAD
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim db As New DBDataContext
            Dim venue = db.Venues.FirstOrDefault(Function(o) o.VenueID = ID)
            If venue Is Nothing Then
                MsgBox("Venue not found", MsgBoxStyle.Exclamation, "Error")
                IsX = False
                Me.Close()
                Return
            End If

            lblName.Text = venue.VenueName
            lblRate.Text = Decimal.Parse(CType(venue.VenueRate, String)).ToString("0.00")
            lblType.Text = venue.VenueType
            lblCapacity.Text = venue.VenueMaxCapacity.ToString
            lblEvent.Text = venue.VenueRecommendations
            picVenue.Image = Image.FromStream(New IO.MemoryStream(venue.VenuePicture.ToArray))
            Return
        Catch exception As Exception
            MsgBox("Unable to contact database, please try again later.", MsgBoxStyle.Exclamation, "Error")
            IsX = False
            Me.Close()
            Return
        End Try
    End Sub

    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, btnReserve.MouseEnter, btnBack.MouseEnter
        Me.Cursor = Cursors.Hand
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, btnReserve.MouseLeave, btnBack.MouseLeave
        Me.Cursor = Cursors.Default
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    'OPEN POPUP
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles picVenue.Click
        Dim ImgPopUp As New ImagePopUp
        ImgPopUp.picImage.Image = picVenue.Image
        ImgPopUp.Text = "Image"
        ImgPopUp.ShowDialog()
    End Sub

    Private IsX As Boolean = True
    Private Sub OnFormClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If CBool(IsX) Then
            Application.Exit()
        End If
    End Sub

    Private Sub GoBack(sender As Object, e As EventArgs) Handles btnBack.Click
        IsX = False
        Me.Close()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Dim booking As New FrmBooking
        Me.Hide()
        FrmBooking.ShowDialog()
        Me.Show()
    End Sub
End Class