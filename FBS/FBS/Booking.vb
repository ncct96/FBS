Imports System.Data.SqlClient
Imports System.Configuration
Public Class Booking
    Public _Booking As New List(Of Timeslot)
    Dim rate As Double
    Dim timeSlotCount As Integer
    Dim totalPayment As Double
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VenueDS.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.FillVenue(Me.VenueDS.Venue)
        'initTimeslot()
        rate = LoadVenueRate()
        dtpBooking.MinDate = Date.Today().AddDays(1)
        dtpBooking.MaxDate = Date.Today().AddDays(10)
    End Sub

    Private Sub cbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVenue.SelectedIndexChanged
        rate = LoadVenueRate()
        timeSlotCount = 3
        totalPayment = CalcTotalPymt(rate)
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim ID As Integer
        Dim result As Integer = MessageBox.Show("Confirm your booking?", "caption", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.No Then
            Me.Close()
        ElseIf result = DialogResult.Yes Then
            ID = initID()
            If ID <> 1 Then
                ID += 1
                insertBooking(ID)
            End If
        End If
    End Sub

    Function initID() As Integer
        Dim ID As Integer
        Try
            Dim strConn As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
            Dim conn As New SqlConnection(strConn)

            Dim bookingSQL As String = "SELECT MAX(BookingID) FROM BOOKING"
            Dim cmd As New SqlCommand(bookingSQL, conn)
            conn.Open()

            ID = cmd.ExecuteScalar

            If String.IsNullOrEmpty(ID) Then
                ID = 1
            End If
        Catch ex As Exception

        End Try

        Return ID
    End Function

    Function insertBooking(ID As Integer)
        Dim bookingDate As Date = Date.Now
        Dim bookingTime As String = bookingDate.ToString("HH:mm:ss")

        Try
            Dim strConn As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
            Dim conn As New SqlConnection(strConn)
            Dim insBookingSQL As String = "SET IDENTITY_INSERT Booking ON;INSERT INTO Booking VALUES (@BookingID, @BookingDate, @BookingTime, @VisitDate, @BookingCharges, @CustID, @SlotID)"
            Dim cmd As New SqlCommand(insBookingSQL, conn)
            conn.Open()
            cmd.Parameters.AddWithValue("@BookingID", ID)
            cmd.Parameters.AddWithValue("@BookingDate", bookingDate)
            cmd.Parameters.AddWithValue("@BookingTime", bookingTime)
            cmd.Parameters.AddWithValue("@VisitDate", dtpBooking.Value)
            cmd.Parameters.AddWithValue("@BookingCharges", totalPayment)
            cmd.Parameters.AddWithValue("@CustID", 1)
            cmd.Parameters.AddWithValue("@SlotID", 1)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try

    End Function

    Function CalcTotalPymt(rate As Double) As Double
        Dim totalPayment As Double = rate * 2
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

    Private Sub cblbTimeslot_ItemCheck(sender As Object, e As ItemCheckEventArgs)

        totalPayment = CalcTotalPymt(rate)
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
    End Sub

    'Function initTimeslot()
    '    Dim startTime As DateTime = DateTime.Today.AddHours(9)
    '    Dim endTime As DateTime = DateTime.Today.AddHours(10)
    '    Dim startTimeLst As List(Of DateTime)
    '    Dim endTimeLst As List(Of DateTime)

    '    While startTime <= DateTime.Today.AddHours(22)
    '        cbStartTime.Items.Add(startTime.TimeOfDay.ToString("hh\:mm"))
    '        startTime = startTime.AddMinutes(60)
    '    End While

    '    While endTime <= DateTime.Today.AddHours(23)
    '        cbStartTime.Items.Add(endTime.TimeOfDay.ToString("hh\:mm"))
    '        endTime = endTime.AddMinutes(60)
    '    End While
    'End Function

    Function checkTotalHrs()

    End Function

    Private Sub lstTimeslot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTimeslot.SelectedIndexChanged
        totalPayment = CalcTotalPymt(rate)
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
    End Sub

    'Private Sub cbEndTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEndTime.SelectedIndexChanged
    '    Debug.Print(cbEndTime.SelectedItem)
    '    Dim endTime As String
    '    If cbEndTime.SelectedItem = "0:00" Then

    '    End If
    'End Sub

    'Private Sub dtpBooking_ValueChanged(sender As Object, e As EventArgs) Handles dtpBooking.ValueChanged
    '    Debug.Print(dtpBooking.Value)
    'End Sub
End Class