Public Class VenueList
    Private MaxStep = 0
    Private Result As New List(Of Venue)
    Private IDs(6) As Integer
    Private Index = 0
    Private FirstRun = True
    Private VenueTypes() As String = {"Badminton Court", "Basketball Court", "Football Field", "Gymnasium", "Tennis Court", "Swimming Pool"}

    'ON FORM LOAD
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        If FirstRun Then
            cboType.Items.Clear()
            cboType.Items.Add("All")
            For Each type In VenueTypes
                cboType.Items.Add(type)
            Next
            FirstRun = False
        End If

        cboType.SelectedIndex = 0

        If Result.Count > 6 Then
            MaxStep = Result.Count / 6
        Else
            MaxStep = 1
        End If
    End Sub

    Private Sub OnIndexChange(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        Try
            Dim db As New DBDataContext
            If cboType.SelectedIndex = 0 Then
                Dim rs = From venue In db.Venues Select venue
                Result = rs.ToList
            Else
                Dim rs = From venue In db.Venues Select venue Where venue.VenueType = cboType.SelectedItem.ToString
                Result = rs.ToList
            End If
        Catch ex As Exception
            MsgBox("Unable to contact database", MsgBoxStyle.Exclamation, "Error")
            IsX = False
            Me.Close()
            Return
        End Try

        If Result.Count = 0 Then
            MsgBox("No records found!", MsgBoxStyle.Exclamation, "Error")
            IsX = False
            Me.Close()
            Return
        End If

        Index = 0
        DisplayItems(btnNext, New EventArgs)
        btnPrevious.Visible = False
    End Sub

    'RESET ALL CONTROLS TO VISIBLE
    Private Sub ResetVisibility()
        pnl1.Visible = True
        pnl2.Visible = True
        pnl3.Visible = True
        pnl4.Visible = True
        pnl5.Visible = True
        pnl6.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True
    End Sub

    'DISPLAY ITEMS IN PANELS
    Private Sub DisplayItems(sender As Object, e As EventArgs) Handles btnNext.Click, btnPrevious.Click
        ResetVisibility()

        If sender.Equals(btnPrevious) Then
            Index = Index - 6
        End If

        If Index < 0 Then
            Index = 0
        End If

        Try
            For i = Index To Result.Count Step 6
                lblName1.Text = Result.Item(i).VenueName
                lblType1.Text = Result.Item(i).VenueType
                picVenue1.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i).VenuePicture.ToArray))
                IDs(0) = Result.Item(i).VenueID

                If i + 1 < Result.Count Then
                    lblName2.Text = Result.Item(i + 1).VenueName
                    lblType2.Text = Result.Item(i + 1).VenueType
                    picVenue2.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 1).VenuePicture.ToArray))
                    IDs(1) = Result.Item(i + 1).VenueID
                Else
                    pnl2.Visible = False
                    pnl3.Visible = False
                    pnl4.Visible = False
                    pnl5.Visible = False
                    pnl6.Visible = False
                    If sender.Equals(btnNext) Then
                        btnNext.Visible = False
                    End If
                    Exit For
                End If

                If i + 2 < Result.Count Then
                    lblName3.Text = Result.Item(i + 2).VenueName
                    lblType3.Text = Result.Item(i + 2).VenueType
                    picVenue3.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 2).VenuePicture.ToArray))
                    IDs(2) = Result.Item(i + 2).VenueID
                Else
                    pnl3.Visible = False
                    pnl4.Visible = False
                    pnl5.Visible = False
                    pnl6.Visible = False
                    If sender.Equals(btnNext) Then
                        btnNext.Visible = False
                    End If
                    Exit For
                End If

                If i + 3 < Result.Count Then
                    lblName4.Text = Result.Item(i + 3).VenueName
                    lblType4.Text = Result.Item(i + 3).VenueType
                    picVenue4.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 3).VenuePicture.ToArray))
                    IDs(3) = Result.Item(i + 3).VenueID
                Else
                    pnl4.Visible = False
                    pnl5.Visible = False
                    pnl6.Visible = False
                    If sender.Equals(btnNext) Then
                        btnNext.Visible = False
                    End If
                    Exit For
                End If

                If i + 4 < Result.Count Then
                    lblName5.Text = Result.Item(i + 4).VenueName
                    lblType5.Text = Result.Item(i + 4).VenueType
                    picVenue5.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 4).VenuePicture.ToArray))
                    IDs(4) = Result.Item(i + 4).VenueID
                Else
                    pnl5.Visible = False
                    pnl6.Visible = False
                    If sender.Equals(btnNext) Then
                        btnNext.Visible = False
                    End If
                    Exit For
                End If

                If i + 5 < Result.Count Then
                    lblName6.Text = Result.Item(i + 5).VenueName
                    lblType6.Text = Result.Item(i + 5).VenueType
                    lblRate6.Text = Decimal.Parse(Result.Item(i + 5).VenueRate).ToString("0.00")
                    picVenue6.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 5).VenuePicture.ToArray))
                    IDs(5) = Result.Item(i + 5).VenueID
                Else
                    pnl6.Visible = False
                    If sender.Equals(btnNext) Then
                        btnNext.Visible = False
                    End If
                    Exit For
                End If

                If sender.Equals(btnNext) Then
                    If i + 6 >= Result.Count Then
                        btnNext.Visible = False
                    Else
                        Index = Index + 6
                    End If
                ElseIf sender.Equals(btnPrevious) Then
                    If i - 6 <= 0 Then
                        btnPrevious.Visible = False
                        Index = Index + 6
                    End If
                End If
                Exit For
            Next
        Catch
            MsgBox("An error occured while processing the records.", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    'OPEN VENUE INFO
    Private Sub OpenVenueInfo(sender As Object, e As EventArgs) Handles pnl6.Click, pnl5.Click, pnl4.Click, pnl3.Click, pnl2.Click, pnl1.Click, lblType6.Click, lblType5.Click, lblType4.Click, lblType3.Click, lblType2.Click, lblType1.Click, lblName6.Click, lblName5.Click, lblName4.Click, lblName3.Click, lblName2.Click, lblName1.Click, picVenue6.Click, picVenue5.Click, picVenue4.Click, picVenue3.Click, picVenue2.Click, picVenue1.Click
        Dim id As Integer
        If TypeOf sender Is Panel Then
            If sender.Equals(pnl1) Then
                id = IDs(0)
            ElseIf sender.Equals(pnl2) Then
                id = IDs(1)
            ElseIf sender.Equals(pnl3) Then
                id = IDs(2)
            ElseIf sender.Equals(pnl4) Then
                id = IDs(3)
            ElseIf sender.Equals(pnl5) Then
                id = IDs(4)
            Else
                id = IDs(5)
            End If
        Else
            Dim control As Control = DirectCast(sender, Control)
            If control.Parent.Equals(pnl1) Then
                id = IDs(0)
            ElseIf control.Parent.Equals(pnl2) Then
                id = IDs(1)
            ElseIf control.Parent.Equals(pnl3) Then
                id = IDs(2)
            ElseIf control.Parent.Equals(pnl4) Then
                id = IDs(3)
            ElseIf control.Parent.Equals(pnl5) Then
                id = IDs(4)
            Else
                id = IDs(5)
            End If
        End If

        Dim VenueInfo As New VenueInfo With {
            .ID = id
        }
        Me.Hide()
        VenueInfo.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MouseEnterEvent(sender As Object, e As EventArgs) Handles pnl1.MouseEnter, pnl2.MouseEnter, pnl3.MouseEnter, pnl4.MouseEnter, pnl5.MouseEnter, pnl6.MouseEnter, btnNext.MouseEnter, btnPrevious.MouseEnter, picVenue6.MouseEnter, picVenue5.MouseEnter, picVenue4.MouseEnter, picVenue3.MouseEnter, picVenue2.MouseEnter, picVenue1.MouseEnter, btnBack.MouseEnter
        Me.Cursor = Cursors.Hand
        If TypeOf sender Is Panel Then
            Dim pnl As Panel = DirectCast(sender, Panel)
            pnl.BackColor = Color.Silver
        End If
    End Sub

    Private Sub MouseLeaveEvent(sender As Object, e As EventArgs) Handles pnl1.MouseLeave, pnl2.MouseLeave, pnl3.MouseLeave, pnl4.MouseLeave, pnl5.MouseLeave, pnl6.MouseLeave, btnNext.MouseLeave, btnPrevious.MouseLeave, picVenue6.MouseLeave, picVenue5.MouseLeave, picVenue4.MouseLeave, picVenue3.MouseLeave, picVenue2.MouseLeave, picVenue1.MouseLeave, btnBack.MouseLeave
        Me.Cursor = Cursors.Default
        If TypeOf sender Is Panel Then
            Dim pnl As Panel = DirectCast(sender, Panel)
            pnl.BackColor = Color.White
        End If
    End Sub

    Private Sub LabelEnterEvent(sender As Object, e As EventArgs) Handles lblName1.MouseEnter, lblName2.MouseEnter, lblName3.MouseEnter, lblName4.MouseEnter, lblName5.MouseEnter, lblName6.MouseEnter,
        lblType1.MouseEnter, lblType2.MouseEnter, lblType3.MouseEnter, lblType4.MouseEnter, lblType5.MouseEnter, lblRate6.MouseEnter
        Dim pnl As Label = DirectCast(sender, Label)
        MouseEnterEvent(pnl.Parent, New EventArgs)
    End Sub

    Private Sub LabelLeaveEvent(sender As Object, e As EventArgs) Handles lblName1.MouseLeave, lblName2.MouseLeave, lblName3.MouseLeave, lblName4.MouseLeave, lblName5.MouseLeave, lblName6.MouseLeave,
        lblType1.MouseLeave, lblType2.MouseLeave, lblType3.MouseLeave, lblType4.MouseLeave, lblType5.MouseLeave, lblRate6.MouseLeave
        Dim pnl As Label = DirectCast(sender, Label)
        Debug.Write(pnl.Parent)
        MouseLeaveEvent(pnl.Parent, New EventArgs)
    End Sub

    Private IsX = True
    Private Sub OnFormClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsX Then
            Application.Exit()
        End If
    End Sub

    Private Sub GoBack(sender As Object, e As EventArgs) Handles btnBack.Click
        IsX = False
        Me.Close()
    End Sub
End Class