Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class AdminVenue
    Private VenueName, Type, VenueEvent As String
    Private Rate As Decimal
    Private Capacity As Integer
    Private Modified As Boolean = False
    Private IsNew As Boolean = True
    Private PictureChanged = False

    'UPLOAD PHOTO HANDLER
    Private Sub UploadPhoto(sender As Object, e As EventArgs) Handles picVenue.Click
        Dim OpenFileDialog As New OpenFileDialog With {
            .Filter = "Picture Files (*)|*.bmp;*.jpg;*.jpeg,*.png"
        }

        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ValueChanged(New Object, New EventArgs)
            picVenue.Image = Image.FromFile(OpenFileDialog.FileName)
            PictureChanged = True
        End If
    End Sub

    Private Sub ValueChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged, txtRate.TextChanged, txtName.TextChanged, txtEvent.TextChanged, txtCapacity.TextChanged
        Modified = True
        btnDelete.Text = "Reset"
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    'ADD/UPDATE VENUE
    Private Sub AddVenue(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateControls() Then
            Return
        End If

        If IsNew = True Then
            Dim venue As New Venue With {
            .VenueName = VenueName,
            .VenueRate = Rate,
            .VenueType = Type,
            .VenueMaxCapacity = Capacity,
            .VenueRecommendations = VenueEvent
            }

            Try
                Dim ms As New MemoryStream
                picVenue.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                venue.VenuePicture = CType(ms.ToArray, Linq.Binary)
            Catch exception As Exception
                MsgBox("Invalid Image", MsgBoxStyle.Exclamation, "Error")
                Return
            End Try

            Try
                Dim db As New DBDataContext
                db.Venues.InsertOnSubmit(venue)
                db.SubmitChanges()
            Catch exception As Exception
                MsgBox("Unable to update Database, Please try again later.", MsgBoxStyle.Exclamation, "Error")
                Return
            End Try

            MsgBox("Updated Database Successfully!", MsgBoxStyle.Information, "Success!")

            OnFormLoad(New Object, New EventArgs)
        Else
            If MsgBox("Confirm Update?", MsgBoxStyle.OkCancel, "Updating record") = DialogResult.OK Then
                Dim db As New DBDataContext
                Dim venue = db.Venues.FirstOrDefault(Function(v) v.VenueID = Integer.Parse(cboID.SelectedValue))

                venue.VenueName = VenueName
                venue.VenueRate = Rate
                venue.VenueType = Type
                venue.VenueMaxCapacity = Capacity
                venue.VenueRecommendations = VenueEvent

                If PictureChanged Then
                    Try
                        Dim ms As New MemoryStream
                        picVenue.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                        venue.VenuePicture = CType(ms.ToArray, Linq.Binary)
                    Catch exception As Exception
                        MsgBox("Invalid Image", MsgBoxStyle.Exclamation, "Error")
                        Return
                    End Try
                End If

                db.SubmitChanges()
                MsgBox("Updated Database Successfully!", MsgBoxStyle.Information, "Success!")
            End If
        End If
    End Sub

    'VENUE ID CHANGED
    Private Sub VenueChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        If Modified Or PictureChanged Then
            If MsgBox("You have unsaved changes, do you still want to navigate away?", MsgBoxStyle.OkCancel, "Unsaved changes") <> DialogResult.OK Then
                Return
            End If
        End If

        If cboID.SelectedIndex = 0 Or cboID.SelectedIndex = -1 Then
            btnUpdate.Text = "Add As New"
            txtCapacity.Text = ""
            txtEvent.Text = ""
            txtName.Text = ""
            txtRate.Text = ""
            txtType.Text = ""
            picVenue.Image = Nothing

            IsNew = True
            btnUpdate.Text = "Add As New"
            btnDelete.Enabled = False
        Else
            Dim db As New DBDataContext
            Dim venue = db.Venues.FirstOrDefault(Function(v) v.VenueID = Integer.Parse(cboID.SelectedValue))

            txtCapacity.Text = venue.VenueMaxCapacity.ToString()
            txtEvent.Text = venue.VenueRecommendations
            txtName.Text = venue.VenueName
            txtRate.Text = Decimal.Parse(venue.VenueRate).ToString("0.00")
            txtType.Text = venue.VenueType
            picVenue.Image = Image.FromStream(New MemoryStream(venue.VenuePicture.ToArray))

            IsNew = False
            btnUpdate.Text = "Update"
            btnDelete.Enabled = True
        End If

        PictureChanged = False
        Modified = False
        btnUpdate.Enabled = False
        btnDelete.Text = "Delete"
    End Sub

    'RESET/DELETE CURRENT VENUE
    Private Sub DeleteVenue(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Modified Then
            If MsgBox("Reset all fields to their original state?", MsgBoxStyle.OkCancel, "Reset fields") = DialogResult.OK Then
                VenueChanged(New Object, New EventArgs)
                PictureChanged = False
                Modified = False
            End If
        Else
            If MsgBox("Delete Record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Deleting record") = DialogResult.OK Then
                Dim db As New DBDataContext
                Dim venue = db.Venues.FirstOrDefault(Function(v) v.VenueID = Integer.Parse(cboID.SelectedValue))

                If venue Is Nothing Then
                    MsgBox("Oops, we couldn't find that record, try refreshing this page!", MsgBoxStyle.Exclamation, "Error")
                    Return
                End If

                db.Venues.DeleteOnSubmit(venue)
                db.SubmitChanges()

                MsgBox("Record Deleted! No turning back now.", MsgBoxStyle.Information, "Success!")

                OnFormLoad(New Object, New EventArgs)
            End If
        End If
    End Sub

    'VALIDATE DETAILS
    Private Function ValidateControls() As Boolean
        VenueName = txtName.Text.Trim(" ")
        Type = txtType.Text.Trim(" ")
        VenueEvent = txtEvent.Text.Trim(" ")

        If VenueName = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Type = "" Then
            MsgBox("Please enter a type", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Not Decimal.TryParse(txtRate.Text.Trim(" "), Rate) Then
            MsgBox("Please enter a valid rate", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Rate < 0 Then
            MsgBox("Please enter a valid rate", MsgBoxStyle.Exclamation, "Error")
            Rate = Math.Round(Rate, 2)
            Return False
        ElseIf Not Integer.TryParse(txtCapacity.Text.Trim(" "), Capacity) Then
            MsgBox("Please enter a valid capacity", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Capacity < 1 Then
            MsgBox("Please enter a valid capacity", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf VenueEvent = "" Then
            MsgBox("Please enter a valid recommended event", MsgBoxStyle.Exclamation, "Error")
            Return False
        Else
            Return True
        End If
    End Function

    'FORM LOAD
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cboID.DataSource = Nothing
        cboID.Items.Clear()
        cboID.DisplayMember = "Text"
        cboID.ValueMember = "Value"

        Dim dt As New DataTable
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Integer))
        dt.Rows.Add("[ Add New Venue ]", -1)

        Dim db As New DBDataContext
        Dim rs = From venue In db.Venues Select venue

        For Each venue In rs
            dt.Rows.Add(venue.VenueName, venue.VenueID)
        Next

        cboID.DataSource = dt
        cboID.SelectedIndex = 0

        PictureChanged = False
        Modified = False
        IsNew = True
        PictureChanged = False
        btnUpdate.Text = "Add As New"
        btnDelete.Text = "Delete"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class