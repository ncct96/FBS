Imports System.Data.SqlClient

Public Class Venue_Info
    Private Sub loadStyles(sender As Object, e As EventArgs) Handles MyBase.Load
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

            lbl_name.Text = reader.GetString(2)
            lbl_time.Text = ": " + reader.GetString(3) + " - " + reader.GetString(4) + ", " + reader.GetDateTime(5).ToString("HH:mm:ss") + " - " + reader.GetDateTime(6).ToString("HH:mm:ss")
            lbl_people.Text = ": " + reader.GetInt32(8)
            lbl_recommend.Text = ": " + reader.GetString(9)

            conn.Close()
        Catch Exception As Exception
            Debug.WriteLine(Exception)
        End Try
    End Sub

    Private Sub mouseEnter_Event(sender As Object, e As EventArgs) Handles picture_venue.MouseEnter, btn_reserve.MouseEnter, btn_back.MouseEnter
        Me.Cursor = Cursors.Hand
        If TypeOf sender Is PictureBox Then
            sender.SizeMode = PictureBoxSizeMode.CenterImage
        End If

    End Sub

    Private Sub mouseLeave_Event(sender As Object, e As EventArgs) Handles picture_venue.MouseLeave, btn_reserve.MouseLeave, btn_back.MouseLeave
        Me.Cursor = Cursors.Default
        If TypeOf sender Is PictureBox Then
            sender.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

    Private Sub pictureBox_Click(sender As Object, e As EventArgs) Handles picture_venue.Click
        Dim Obj As New Image_Modal
        Obj.PictureBox1.Image = My.Resources._1200px_Donald_Trump_official_portrait
        Obj.Show()
    End Sub
End Class