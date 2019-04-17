Imports System.Data.SqlClient

Public Class BookingHistory
    Dim currentDate As Date = Date.Now
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Dim emptyString As String = ""
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FBSDataSet.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.Fill(Me.FBSDataSet.Venue)
        Debug.Print("saddsadsadsa")
        'TODO: This line of code loads data into the 'FBSDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(FBSDataSet.Booking, GlobalVars.currentUser)
        emptyString = ComboBox1.SelectedValue.ToString
        Debug.Print("saddsadsadsa")
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BookingTableAdapter.FillBy(Me.FBSDataSet.Booking)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub filterData(value As String)
        Dim searchQuery As String = ""
        Try
            If OngoingFilter.Checked Then
                searchQuery = "SELECT b.BookingID, v.VenueType AS 'Venue', b.VisitDate AS 'Booking Date', b.BookingCharges AS 'Fees Charged' FROM BOOKING b, Timeslot t, Venue v WHERE
                b.SlotID = t.SlotID and v.VenueID = t.SlotID and 
                b.Status = 'Pending' AND b.CustID = (SELECT CustID FROM Customer WHERE CustName = @custName) AND v.VenueID = 
			    (SELECT VenueID from Venue where VenueType = @venue)"
            ElseIf CompletedFilter.Checked Then
                searchQuery = "SELECT b.BookingID, v.VenueType AS 'Venue', b.VisitDate AS 'Booking Date', b.BookingCharges AS 'Fees Charged' FROM BOOKING b, Timeslot t, Venue v WHERE
                b.SlotID = t.SlotID and v.VenueID = t.SlotID and 
                b.Status = 'Paid' AND b.CustID = (SELECT CustID FROM Customer WHERE CustName = @custName) AND v.VenueID = 
			    (SELECT VenueID from Venue where VenueType = @venue)"
            End If
            If Not searchQuery.Equals("") Then
                Dim command As New SqlCommand(searchQuery, connection)
                command.Parameters.AddWithValue("@custName", GlobalVars.currentUser)
                command.Parameters.AddWithValue("@venue", value)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                BookingHistGrid.DataSource = table
                'refreshData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub refreshData()
        BookingBindingSource.DataSource = BookingTableAdapter.GetData(GlobalVars.currentUser)
        BookingBindingSource.ResetBindings(True)
    End Sub

    Private Sub OngoingFilter_CheckedChanged(sender As Object, e As EventArgs) Handles OngoingFilter.CheckedChanged
        'Dim venueSelected As String = If(ComboBox1.SelectedIndex.ToString, "")
        ' Dim ongoingQuery As String
        ' ongoingQuery = "SELECT b.BookingID, v.VenueType AS 'Venue', b.VisitDate AS 'Booking Date', b.BookingCharges AS 'Fees Charged' FROM BOOKING b, Timeslot t, Venue v WHERE
        '         b.SlotID = t.SlotID and v.VenueID = t.SlotID and 
        '         b.Status = 'Paid' AND b.CustID = (SELECT CustID FROM Customer WHERE CustName = @custName1) AND v.VenueID = 
        '(SELECT VenueID from Venue where VenueType = @venue1)"
        ' Dim ongoingCommand As New SqlCommand(ongoingQuery, connection)
        ' ongoingCommand.Parameters.AddWithValue("@custName1", GlobalVars.currentUser)
        ' ongoingCommand.Parameters.AddWithValue("@venue1", venueSelected)
        ' Dim adapter As New SqlDataAdapter(ongoingCommand)
        ' Dim table As New DataTable()
        ' adapter.Fill(table)
        ' BookingHistGrid.DataSource = table
        'refreshData()
        If Not emptyString.Equals("") Then
            filterData(emptyString)
        End If

    End Sub

    Private Sub CompletedFilter_CheckedChanged(sender As Object, e As EventArgs) Handles CompletedFilter.CheckedChanged
        'Dim venueSelected As String = If(ComboBox1.SelectedIndex.ToString, "")
        ' Dim completedQuery As String
        ' completedQuery = "SELECT b.BookingID, v.VenueType AS 'Venue', b.VisitDate AS 'Booking Date', b.BookingCharges AS 'Fees Charged' FROM BOOKING b, Timeslot t, Venue v WHERE
        '         b.SlotID = t.SlotID and v.VenueID = t.SlotID and 
        '         b.Status = 'Paid' AND b.CustID = (SELECT CustID FROM Customer WHERE CustName = @custName2) AND v.VenueID = 
        '(SELECT VenueID from Venue where VenueType = @venue2)"
        ' Dim completedCommand As New SqlCommand(completedQuery, connection)
        ' completedCommand.Parameters.AddWithValue("@custName2", GlobalVars.currentUser)
        ' completedCommand.Parameters.AddWithValue("@venue2", venueSelected)
        ' Dim adapter As New SqlDataAdapter(completedCommand)
        ' Dim table As New DataTable()
        ' adapter.Fill(table)
        ' BookingHistGrid.DataSource = table
        ' ' refreshData()
        If Not emptyString.Equals("") Then
            filterData(emptyString)
        End If

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If BookingHistGrid.SelectedRows.Count > 0 Then
            Dim deleteRow As String = Me.BookingHistGrid.SelectedRows(0).Cells(0).Value.ToString
            Dim selectDate As Date = Me.BookingHistGrid.SelectedRows(0).Cells(2).Value.ToString
            Dim diff As Integer
            diff = (selectDate - currentDate).TotalDays

            Debug.Print(diff)

            If diff >= 3 Then
                Dim result As Integer = MessageBox.Show("Are you sure to cancel this booking?", "Cancel Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    connection.Open()
                    ' Update Queries here
                    Dim updateQuery As String = "UPDATE Booking SET Status = @status WHERE BookingID = @bookId"
                    Dim deleteCommand As New SqlCommand(updateQuery, connection)
                    deleteCommand.Parameters.AddWithValue("@status", "Cancelled")
                    deleteCommand.Parameters.AddWithValue("@bookId", deleteRow)
                    deleteCommand.ExecuteNonQuery()
                    MessageBox.Show("Booking Cancelled", "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()

                    connection.Open()
                    ' Update Queries here
                    Dim releaseQuery As String = "UPDATE Timeslot SET Status = @status WHERE BookingID = @bookId"
                    Dim releaseCommand As New SqlCommand(releaseQuery, connection)
                    releaseCommand.Parameters.AddWithValue("@status", True)
                    releaseCommand.Parameters.AddWithValue("@bookId", deleteRow)
                    releaseCommand.ExecuteNonQuery()
                    Debug.Print("Slot Released")
                    connection.Close()

                    refreshData()
                Else

                End If
            Else
                MessageBox.Show("You're not allow to cancel booking that are not 3 days before the appointment date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select the row for booking cancellation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim searchIndex As String = If(ComboBox1.SelectedValue.ToString, "")
        emptyString = searchIndex
        filterData(searchIndex)
    End Sub
End Class