Imports System.Data.SqlClient
Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VenueDS.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.Fill(Me.VenueDS.Venue)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVenue.SelectedIndexChanged
        Try
            Dim ds As DataSet
            Dim connectionString As String = "Data Source=ncct96.database.windows.net;Initial Catalog=FBS;User ID=ncct96;Password=Wmq6783Aew5352;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            Dim conn As New SqlConnection(connectionString)
            conn.Open()

            Dim queryPic As String = "SELECT VenueRate FROM Venue WHERE VenueID = " + cbVenue.SelectedValue
            Dim comm As New SqlCommand(queryPic, conn)
            Dim adapter As New SqlDataAdapter(comm)
            adapter.Fill(ds, "Test")
            lblRate.DataBindings.Add("Text", ds, "VenueRate")
        Catch ex As Exception

        End Try
    End Sub
End Class