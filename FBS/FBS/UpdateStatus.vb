Imports System.Data.SqlClient

Public Class UpdateStatus
    Dim stringCon As String = My.Settings.FBSConnectionString
    Dim connection As New SqlConnection(stringCon)
    Private Sub UpdateStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FBSDataSet.Booking1' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.FBSDataSet.Booking1)

    End Sub

    Private Sub refreshData()
        PaymentBindingSource.DataSource = PaymentTableAdapter.GetData
        PaymentBindingSource.ResetBindings(True)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            If UpdatePayGrid.SelectedRows.Count > 0 Then
                Dim updateRow As String = Me.UpdatePayGrid.SelectedRows(0).Cells(0).Value.ToString
                Dim result As Integer = MessageBox.Show("Do you want to set this row to paid?", "Update Payment Status", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If result = DialogResult.Yes Then
                    connection.Open()
                    Dim updatePayQuery As String = "UPDATE BOOKING SET Status = @updateStat WHERE BookingID = @bookid"
                    Dim updatePayCommand As New SqlCommand(updatePayQuery, connection)
                    updatePayCommand.Parameters.AddWithValue("@updateStat", "Paid")
                    updatePayCommand.Parameters.AddWithValue("@bookid", updateRow)
                    updatePayCommand.ExecuteNonQuery()
                    MessageBox.Show("Payment Status Updated.", "Update Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    refreshData()
                Else
                    MessageBox.Show("Please select the row for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class