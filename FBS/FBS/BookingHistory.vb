Imports System.Data.SqlClient

Public Class BookingHistory
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FBSDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.FBSDataSet.Booking, GlobalVars.currentId)

        'For Each item As ToolStripItem In Main.FBSMenuStrip.Items
        '    Me.BHMenuStrip.Items.Add(item)
        'Next

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
            searchQuery = "SELECT BookingDate, BookingTime, VisitDate, BookingChanges FROM BOOKING WHERE
            CONCAT(BookingDate, BookingTime, VisitDate, BookingChanges) AND Status = 'Ongoing' LIKE @search"
        ElseIf CompletedFilter.Checked Then
            searchQuery = "SELECT BookingDate, BookingTime, VisitDate, BookingChanges FROM BOOKING WHERE
            CONCAT(BookingDate, BookingTime, VisitDate, BookingChanges) AND Status = 'Completed' LIKE @search"
        End If
        If Not searchQuery.Equals("") Then
            Dim command As New SqlCommand(searchQuery, connection)
            command.Parameters.AddWithValue("@search", value)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            BookingHistGrid.DataSource = table
        End If
    End Sub

    Private Sub OngoingFilter_CheckedChanged(sender As Object, e As EventArgs) Handles OngoingFilter.CheckedChanged
        Dim ongoingQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingChanges FROM BOOKING WHERE Status = 'Ongoing'"
        Dim ongoingCommand As New SqlCommand(ongoingQuery, connection)
        Dim adapter As New SqlDataAdapter(ongoingCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub

    Private Sub CompletedFilter_CheckedChanged(sender As Object, e As EventArgs) Handles CompletedFilter.CheckedChanged
        Dim completedQuery As String = "SELECT BookingDate, BookingTime, VisitDate, BookingChanges FROM BOOKING WHERE Status = 'Completed'"
        Dim completedCommand As New SqlCommand(completedQuery, connection)
        Dim adapter As New SqlDataAdapter(completedCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        BookingHistGrid.DataSource = table
    End Sub
End Class