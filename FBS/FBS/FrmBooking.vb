Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmBooking
    Public _Booking As New List(Of Timeslot)
    Dim rate As Double
    Dim timeSlotCount As Integer
    Dim totalPayment As Double
    Dim slotArr(5) As Slot
    Private Sub FrmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VenueDataSet.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter1.Fill(Me.VenueDataSet.Venue)
        Dim db As New DBDataContext()
        initSlotName()
        rate = LoadVenueRate()
        dtpBooking.MinDate = Date.Today().AddDays(1)
        dtpBooking.MaxDate = Date.Today().AddDays(10)
    End Sub

    Private Sub cbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVenue.SelectedIndexChanged
        rate = LoadVenueRate()
        timeSlotCount = 3
        totalPayment = CalcTotalPymt(rate)
        lblPrice.Text = "RM " & Format(rate, "f")
        lblHour.Text = "2  hour(s)"
        lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
        initSlotName()
        CheckSlot()
        resetSlot()
        initAvailableSlot()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim ID As Integer
        Dim result As Integer = MessageBox.Show("Confirm your booking?", "Booking Confirmation", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.No Then
            Me.Close()
        ElseIf result = DialogResult.Yes Then
            insertBooking(ID)
        End If
    End Sub

    Function insertBooking(ID As Integer)
        Dim bookingDate As Date = Date.Now
        Debug.Print(bookingDate)
        Dim bookingTime As String = bookingDate.ToString("HH:mm:ss")

        Try
            Dim db As New DBDataContext()
            'Dim cust = db.Customers.FirstOrDefault(Function(o) o.CustID = 2)

            Dim s As New Booking With {
                .BookingDate = bookingDate,
                .BookingTime = bookingTime,
                .BookingCharges = totalPayment,
                .VisitDate = bookingDate,
                .CustID = 1,
                .SlotID = 1,
                .Status = False'Convert.ToInt32(lstTimeslot.SelectedItem.ToString)
            }

            Debug.Print(s.CustID)

            db.Bookings.InsertOnSubmit(s)
            db.SubmitChanges()
            MessageBox.Show("Successfully insert record")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Function

    Function CalcTotalPymt(rate As Double) As Double
        Dim totalPayment As Double = rate * 2
        Return totalPayment
    End Function

    Function CheckSlot()
        Dim db As New DBDataContext()
        Dim slot As Integer = lstTimeslot.SelectedIndex + 1

        For i = 1 To 6
            For Each s In db.Timeslots
                Debug.Print(dtpBooking.Value)
                Debug.Print(s.Date)
                Debug.Print("bye")
                Debug.Print(i)
                If s.VenueID = cbVenue.SelectedValue Then
                    If s.Date = dtpBooking.Value Then
                        Debug.Print("hi")
                        If s.Slot = i Then
                            Debug.Print("hi1")
                            If s.Status = False Then
                                slotArr(i - 1) = Nothing
                            End If
                        End If
                    End If
                End If
            Next
        Next

        Dim dateRecord = db.Timeslots.Where(Function(o) o.Date = dtpBooking.Value)

        If dateRecord Is Nothing Then
            Dim slotRecord = db.Timeslots.Where(Function(o) o.Slot = lstTimeslot.SelectedIndex + 1)

        End If
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

            rate = CDbl(cmd.ExecuteScalar)


            totalPayment = CalcTotalPymt(rate)
            lblTotalPayment.Text = "RM " & Format(totalPayment, "f")
            lblRate.Text = "RM " & Format(rate, "f")
            lblPrice.Text = "RM " & Format(rate, "f")
        Catch ex As Exception

        End Try

        Return rate
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        initSlotName()
        CheckSlot()
        resetSlot()
        initAvailableSlot()
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

    End Sub

    Function initSlotName()
        Dim slot, slot1, slot2, slot3, slot4, slot5 As New Slot
        slot.slotID = 1
        slot.slotName = "10:00 am - 12:00 pm"

        slot1.slotID = 2
        slot1.slotName = "12:00 pm - 2:00 pm"

        slot2.slotID = 3
        slot2.slotName = "2:00 pm - 4:00 pm"

        slot3.slotID = 4
        slot3.slotName = "4:00 pm - 6:00 pm"

        slot4.slotID = 5
        slot4.slotName = "6:00 pm - 8:00 pm"

        slot5.slotID = 6
        slot5.slotName = "8:00 pm - 10:00 pm"

        slotArr(0) = slot
        slotArr(1) = slot1
        slotArr(2) = slot2
        slotArr(3) = slot3
        slotArr(4) = slot4
        slotArr(5) = slot5

        lstTimeslot.Items.Add(slotArr(0).slotName)
        lstTimeslot.Items.Add(slotArr(1).slotName)
        lstTimeslot.Items.Add(slotArr(2).slotName)
        lstTimeslot.Items.Add(slotArr(3).slotName)
        lstTimeslot.Items.Add(slotArr(4).slotName)
        lstTimeslot.Items.Add(slotArr(5).slotName)
    End Function

    Function initAvailableSlot()
        For count = 0 To 5
            If slotArr(count) IsNot Nothing Then
                lstTimeslot.Items.Add(slotArr(count).slotName)
            End If
        Next
    End Function

    Function resetSlot()
        lstTimeslot.Items.Clear()
    End Function

    Private Sub dtpBooking_ValueChanged(sender As Object, e As EventArgs) Handles dtpBooking.ValueChanged
        initSlotName()
        CheckSlot()
        resetSlot()
        initAvailableSlot()
    End Sub
End Class