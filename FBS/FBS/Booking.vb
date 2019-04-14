Imports System.Data.SqlClient
Imports System.Configuration
Public Class Booking
    Dim rate As Double
    Dim timeSlotCount As Integer
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VenueDS.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.FillVenue(Me.VenueDS.Venue)
        rate = LoadVenueRate()
        dtpBooking.MinDate = Date.Today().AddDays(1)
        dtpBooking.MaxDate = Date.Today().AddDays(10)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVenue.SelectedIndexChanged
        rate = LoadVenueRate()
        timeSlotCount = cblbTimeslot.CheckedItems.Count + 1
        Dim totalPayment As Double = CalcTotalPymt(rate, timeSlotCount)
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

    End Sub

    Function CalcTotalPymt(rate As Double, totalHour As Integer) As Double
        Dim totalPayment As Double = rate * totalHour
        Return totalPayment
    End Function

    Function LoadVenueRate() As Double
        Dim rate As Double
        Try
            Dim strConn As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
            Dim conn As New SqlConnection(strConn)

            Dim rateSQL As String = "SELECT VenueRate FROM Venue WHERE VenueID = @ID"
            Dim cmd As New SqlCommand(rateSQL, conn)
            cmd.Parameters.AddWithValue("@ID", cbVenue.SelectedValue)

            conn.Open()

            rate = cmd.ExecuteScalar

            lblRate.Text = "RM " & Format(rate, "f")
        Catch ex As Exception

        End Try

        Return rate
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cblbTimeslot_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles cblbTimeslot.ItemCheck
        Dim totalPayment As Double = CalcTotalPymt(rate, cblbTimeslot.CheckedItems.Count + 1)
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
    End Sub
End Class