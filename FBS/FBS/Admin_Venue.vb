Public Class Admin_Venue
    Private DAYS As String() = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
    Private TIME As String() = {"10.00AM", "11.00AM", "12.00PM", "1.00PM", "2.00PM", "3.00PM", "4.00PM", "5.00PM", "6.00PM", "7.00PM", "8.00PM", "9.00PM", "10.00PM"}
    Private Sub UploadPhoto(sender As Object, e As EventArgs) Handles picVenue.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg,*.png"
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            picVenue.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub UpdateVenue(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub AddVenue(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub

    Private Sub VenueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DayChanged(sender As Object, e As EventArgs) Handles cboFromDay.SelectedIndexChanged
        cboToDay.Enabled = True
        cboToDay.Items.Clear()

        For i As Integer = cboFromDay.SelectedIndex To DAYS.Length - 1 Step 1
            cboToDay.Items.Add(DAYS(i))
        Next

    End Sub

    Private Sub TimeChanged(sender As Object, e As EventArgs) Handles cboFromTime.SelectedIndexChanged

    End Sub

    Private Sub InitializeUI(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In DAYS
            cboFromDay.Items.Add(item)
        Next

        For Each item In TIME
            cboFromTime.Items.Add(item)
        Next
    End Sub
End Class