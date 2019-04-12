Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class VenueList
    Dim myDataAdapter As OleDbDataAdapter
    Dim myDataSet As DataSet

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = My.Settings.ConnectionString
        Dim conn As New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM Venue"
        Dim command As New SqlCommand(query, conn)

        Try
            conn.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            dgvVenueList.DataSource = dt
            conn.Close()
        Catch Exception As Exception
            Debug.WriteLine(Exception)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class