Imports System.Data.SqlClient

Public Class BookingHistory
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FBSDataSet.Venue' table. You can move, or remove it, as needed.
        Me.VenueTableAdapter.Fill(Me.FBSDataSet.Venue)
        'TODO: This line of code loads data into the 'FBSDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(FBSDataSet.Booking, GlobalVars.currentUser)
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
                searchQuery = "SELECT b.BookingDate, b.BookingTime, b.VisitDate, b.BookingCharges FROM BOOKING b, Timeslot t, Venue v WHERE
                b.SlotID = t.SlotID and v.VenueID = t.SlotID and 
                b.Status = 'Pending' AND b.CustID = (SELECT CustID FROM Customer WHERE CustName = @custName) AND v.VenueID = 
			    (SELECT VenueID from Venue where VenueType = @venue)"
            ElseIf CompletedFilter.Checked Then
                searchQuery = "SELECT b.BookingDate, b.BookingTime, b.VisitDate, b.BookingCharges FROM BOOKING b, Timeslot t, Venue v WHERE
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OngoingFilter_CheckedChanged(sender As Object, e As EventArgs) Handles OngoingFilter.CheckedChanged
        Dim ongoingQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE Status = 'Pending' AND 
CustID = (SELECT CustID FROM Customer WHERE CustName = @custName1)"
        Dim ongoingCommand As New SqlCommand(ongoingQuery, connection)
        ongoingCommand.Parameters.AddWithValue("@custName1", GlobalVars.currentUser)
        Dim adapter As New SqlDataAdapter(ongoingCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub

    Private Sub CompletedFilter_CheckedChanged(sender As Object, e As EventArgs) Handles CompletedFilter.CheckedChanged
        Dim completedQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE Status = 'Paid' AND 
CustID = (SELECT CustID FROM Customer WHERE CustName = @custName2)"
        Dim completedCommand As New SqlCommand(completedQuery, connection)
        completedCommand.Parameters.AddWithValue("@custName2", GlobalVars.currentUser)
        Dim adapter As New SqlDataAdapter(completedCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If BookingHistGrid.SelectedRows.Count > 0 Then
            Dim deleteRow As String = Me.BookingHistGrid.SelectedRows(0).Cells("BookingID").Value.ToString
            Dim result As Integer = MessageBox.Show("Are you sure to cancel this booking?", "Cancel Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                connection.Open()
                ' Delete Queries here
                Dim deleteQuery As String = "DELETE FROM Booking WHERE BookingID = @bookId"
                Dim deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@bookId", deleteRow)
                deleteCommand.ExecuteNonQuery()
                MessageBox.Show("Booking Cancelled", "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
            Else

            End If
        Else
            MessageBox.Show("Please select the row for booking cancellation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Private Sub BookingHistGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookingHistGrid.CellContentDoubleClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    '        Dim popup As New PopUp
    '        Try
    '            popup.updateDateTime.DataBindings.Add("Value", BookingHistGrid.DataSource, "VisitDate")
    '            If popup.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                ' Update Queries here
    '                Dim updateQuery As String = "UPDATE BOOKING SET VisitDate = @value"
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim searchIndex As String = ComboBox1.SelectedValue.ToString
        filterData(searchIndex)
    End Sub
End Class