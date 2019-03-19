Imports System.Data.SqlClient

Public Class Venue_Info
    Private Sub loadStyles(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = My.Settings.ConnectionString
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()

            Dim query As String = "SELECT * FROM Venue WHERE VenueID = 1"
            Dim command As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Debug.WriteLine("Data: " + reader.GetString(2))
            Else
                Debug.WriteLine("No records were returned")
            End If

            lbl_time.Text = reader.GetString(4) + " - " + reader.GetString(5) + ", " + reader.GetValue(6).ToString() + " - " + reader.GetValue(7).ToString()
            lbl_people.Text = reader.GetInt32(9)
            lbl_recommend.Text = reader.GetString(10)

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