Imports System.Data.SqlClient
Imports System.IO

Public Class VenueInfo
    Private Sub OnFormLoad(sender As Object, e As EventArgs)
        Try
            Dim db As New DBDataContext
            Dim venue = db.Venues.FirstOrDefault(Function(o) o.VenueID = 3)
            If venue Is Nothing Then
                MsgBox("Venue not found", MsgBoxStyle.Exclamation, "Error")
                Me.Close()
                Return
            End If

            lblName.Text = venue.VenueName
            lblRate.Text = venue.VenueRate
            lblType.Text = venue.VenueType
            lblCapacity.Text = venue.VenueMaxCapacity
            lblEvent.Text = venue.VenueRecommendations
            picVenue.Image = Image.FromStream(New IO.MemoryStream(venue.VenuePicture.ToArray))
            Return
        Catch exception As Exception
            MsgBox("Venue not found", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
            Return
        End Try

        Dim connectionString As String = My.Settings.ConnectionString
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM Venue WHERE VenueID = @ID"
            Dim command As New SqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID", 1)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Debug.WriteLine("Data found")
            Else
                Debug.WriteLine("No records were returned")
            End If

            lblName.Text = reader.GetString(2)
            lblCapacity.Text = reader.GetInt32(8)
            lblEvent.Text = reader.GetString(9)

            conn.Close()
        Catch Exception As Exception
            Debug.WriteLine(Exception)
        End Try
    End Sub

    Private Sub MouseEnter_Event(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, btnReserve.MouseEnter
        Me.Cursor = Cursors.Hand
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub MouseLeave_Event(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, btnReserve.MouseLeave
        Me.Cursor = Cursors.Default
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles picVenue.Click
        Dim ImgPopUp As New ImagePopUp
        ImgPopUp.picImage.Image = My.Resources._66938284_p0
        ImgPopUp.Text = "Image"
        ImgPopUp.ShowDialog()
    End Sub
End Class