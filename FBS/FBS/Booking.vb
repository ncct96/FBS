Imports System.Data.SqlClient
Imports System.Configuration
Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VenueDS.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.Fill(Me.VenueDS.Venue)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVenue.SelectedIndexChanged
        Try
            Dim strConn As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
            Dim conn As New SqlConnection(strConn)

            Dim rateSQL As String = "SELECT VenueRate FROM Venue WHERE VenueID = @ID"
            Dim cmd As New SqlCommand(rateSQL, conn)
            cmd.Parameters.AddWithValue("@ID", cbVenue.SelectedValue)

            conn.Open()
      
            lblRate.Text = "RM " & Format(cmd.ExecuteScalar, "f")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class