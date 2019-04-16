Imports System.Data.SqlClient

Public Class BookingHistory
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        Dim input As String = If(CStr(searchTxt.Text), "")
        filterData(input)
    End Sub

    Private Sub filterData(value As String)
        Dim searchQuery As String = ""
        If OngoingFilter.Checked Then
            searchQuery = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE
            CONCAT(BookingDate, BookingTime, VisitDate, BookingChanges) AND Status = 0 AND 
            CustID = (SELECT CustID FROM Customer WHERE CustName = @custName) LIKE @search"
        ElseIf CompletedFilter.Checked Then
            searchQuery = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE
            CONCAT(BookingDate, BookingTime, VisitDate, BookingChanges) AND Status = 1 AND 
            CustID = (SELECT CustID FROM Customer WHERE CustName = @custName) LIKE @search"
        End If
        If Not searchQuery.Equals("") Then
            Dim command As New SqlCommand(searchQuery, connection)
            command.Parameters.AddWithValue("@custName", GlobalVars.currentUser)
            command.Parameters.AddWithValue("@search", value)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            BookingHistGrid.DataSource = table
        End If
    End Sub

    Private Sub OngoingFilter_CheckedChanged(sender As Object, e As EventArgs) Handles OngoingFilter.CheckedChanged
        Dim ongoingQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE Status = 0 AND 
CustID = (SELECT CustID FROM Customer WHERE CustName = @custName1)"
        Dim ongoingCommand As New SqlCommand(ongoingQuery, connection)
        ongoingCommand.Parameters.AddWithValue("@custName1", GlobalVars.currentUser)
        Dim adapter As New SqlDataAdapter(ongoingCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub

    Private Sub CompletedFilter_CheckedChanged(sender As Object, e As EventArgs) Handles CompletedFilter.CheckedChanged
        Dim completedQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingCharges FROM BOOKING WHERE Status = 1 AND 
CustID = (SELECT CustID FROM Customer WHERE CustName = @custName2)"
        Dim completedCommand As New SqlCommand(completedQuery, connection)
        completedCommand.Parameters.AddWithValue("@custName2", GlobalVars.currentUser)
        Dim adapter As New SqlDataAdapter(completedCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ' Delete Queries here
    End Sub

    Private Sub BookingHistGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookingHistGrid.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim popup As New PopUp
            Try
                popup.updateDateTime.DataBindings.Add("Value", BookingHistGrid.DataSource, "VisitDate")
                If popup.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Update Queries here
                    Dim updateQuery As String = "UPDATE BOOKING SET VisitDate = @value"
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class