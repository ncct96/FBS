Imports System.Data.SqlClient

Public Class DeleteAccount
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Private Sub DeleteAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FBSDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.FBSDataSet.Customer)
        CustomerBindingSource.DataSource = CustomerTableAdapter.GetData
    End Sub

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs)
        Dim searchVal As String = If(CStr(searchTxt.Text), "")
        If Not searchVal.Equals("") Then
            searchData(searchVal)
        Else
            refreshData()
        End If
    End Sub

    Private Sub searchData(value As String)
        Try
            Dim searchQuery As String = "SELECT CustID, CustName, CustPass, CustNumber FROM Customer WHERE CustName LIKE @pattern OR CustPass LIKE @pattern OR CustNumber LIKE @pattern"
            Dim searchCommand As New SqlCommand(searchQuery, connection)
            searchCommand.Parameters.AddWithValue("@pattern", value)
            Dim adapter As New SqlDataAdapter(searchCommand)
            Dim table As New DataTable()
            adapter.Fill(table)
            AccountGrid.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            If AccountGrid.SelectedRows.Count > 0 Then
                Dim deleteRow As String = Me.AccountGrid.SelectedRows(0).Cells(0).Value.ToString
                Dim result As Integer = MessageBox.Show("Are you sure to cancel this booking?", "Cancel Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    connection.Open()
                    Dim deleteUserQuery As String = "DELETE FROM Customer WHERE CustID = @custoid"
                    Dim deleteUserCommand As New SqlCommand(deleteUserQuery, connection)
                    deleteUserCommand.Parameters.AddWithValue("@custoid", deleteRow)
                    deleteUserCommand.ExecuteNonQuery()
                    MessageBox.Show("User Account Deleted.", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    refreshData()
                End If
            Else
                MessageBox.Show("Please select the row for booking cancellation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub refreshData()
        'Me.AccountGrid.DataSource = Nothing
        'Me.CustomerTableAdapter.Fill(Me.FBSDataSet.Customer)
        'Me.AccountGrid.DataSource = Me.CustomerBindingSource
        'Me.AccountGrid.Refresh()
        CustomerBindingSource.DataSource = CustomerTableAdapter.GetData
        CustomerBindingSource.ResetBindings(True)
    End Sub
End Class