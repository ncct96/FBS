Imports System.IO

Public Class AdminVenue
    Private VenueName, VenueEvent As String
    Private Rate As Decimal
    Private Capacity As Integer
    Private IsFirstRun As Boolean = True
    Private Modified As Boolean = False
    Private IsNew As Boolean = True
    Private OverPay As Boolean = False
    Private OverSized As Boolean = False
    Private PictureChanged = False
    Private VenueTypes() As String = {"Badminton Court", "Basketball Court", "Football Field", "Gymnasium", "Tennis Court", "Swimming Pool"}

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

    Private Sub ValueChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged, txtName.TextChanged, txtEvent.TextChanged, txtCapacity.TextChanged, cboType.SelectedIndexChanged
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
            .VenueType = cboType.SelectedItem,
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

            PictureChanged = False
            Modified = False
            btnUpdate.Enabled = False
            OnFormLoad(New Object, New EventArgs)
        Else
            If MsgBox("Confirm Update?", MsgBoxStyle.OkCancel, "Updating record") = DialogResult.OK Then
                Dim db As New DBDataContext
                Dim venue = db.Venues.FirstOrDefault(Function(v) v.VenueID = Integer.Parse(cboID.SelectedValue))

                venue.VenueName = VenueName
                venue.VenueRate = Rate
                venue.VenueType = CType(cboType.SelectedItem, String)
                venue.VenueMaxCapacity = Capacity
                venue.VenueRecommendations = VenueEvent

                If CBool(PictureChanged) Then
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
                PictureChanged = False
                Modified = False
                btnUpdate.Enabled = False
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
            cboType.SelectedIndex = -1
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
            txtRate.Text = Decimal.Parse(CType(venue.VenueRate, String)).ToString("0.00")
            cboType.SelectedIndex = cboType.FindString(venue.VenueType)
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
                PictureChanged = False
                Modified = False
                VenueChanged(New Object, New EventArgs)
            End If
        Else
            If MsgBox("Delete Record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Deleting record") = DialogResult.OK Then
                Dim db As New DBDataContext
                Dim venue = db.Venues.FirstOrDefault(Function(v) v.VenueID = Integer.Parse(CType(cboID.SelectedValue, String)))

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
        VenueEvent = txtEvent.Text.Trim(" ")

        If VenueName = "" Then
            MsgBox("Please enter a name", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf cboType.SelectedIndex = -1 Then
            MsgBox("Please select a type", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Not Decimal.TryParse(txtRate.Text.Trim(" "), Rate) Then
            MsgBox("Please enter a valid rate", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Rate < 0 Then
            MsgBox("Please enter a valid rate", MsgBoxStyle.Exclamation, "Error")
            Rate = Math.Round(Rate, 2)
            Return False
        ElseIf Rate > 5000 And OverPay = False Then
            If MsgBox("Hold on there cowboy! Are you sure that your services are THAT expensive?", MsgBoxStyle.YesNo, "Whoa there!") = DialogResult.No Then
                Return False
            Else
                OverPay = True
            End If
        ElseIf Not Integer.TryParse(txtCapacity.Text.Trim(" "), Capacity) Then
            MsgBox("Please enter a valid capacity", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Capacity < 1 Then
            MsgBox("Please enter a valid capacity", MsgBoxStyle.Exclamation, "Error")
            Return False
        ElseIf Capacity > 5000 And OverSized = False Then
            If MsgBox("Hold on there cowboy! Are you sure that the facility can hold that many people?", MsgBoxStyle.YesNo, "Whoa there!") = DialogResult.No Then
                Return False
            Else
                OverSized = True
            End If
        ElseIf VenueEvent = "" Then
            MsgBox("Please enter a valid recommended event", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If

        Rate = Decimal.Parse(txtRate.Text.Trim(" "))
        Capacity = Integer.Parse(txtCapacity.Text.Trim(" "))
        OverPay = False
        OverSized = False
        Return True
    End Function

    'FORM LOAD
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cboType.Items.Clear()
        For Each type In VenueTypes
            cboType.Items.Add(type)
        Next

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

        IsNew = True
        PictureChanged = False
        btnUpdate.Text = "Add As New"
        btnDelete.Text = "Delete"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        PictureChanged = False
        Modified = False
    End Sub

    Private Sub MouseEnterEvent(sender As Object, e As EventArgs) Handles picVenue.MouseEnter, btnUpdate.MouseEnter, btnDelete.MouseEnter, cboID.MouseEnter, cboType.MouseEnter
        Me.Cursor = Cursors.Hand
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub MouseLeaveEvent(sender As Object, e As EventArgs) Handles picVenue.MouseLeave, btnUpdate.MouseLeave, btnDelete.MouseLeave, cboID.MouseLeave, cboType.MouseLeave
        Me.Cursor = Cursors.Default
        If sender.Equals(picVenue) Then
            picVenue.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class