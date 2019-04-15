Public Class BookingHistory
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
End Class