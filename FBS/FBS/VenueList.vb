Public Class VenueList
    Private MaxStep = 0
    Private Result As New List(Of Venue)
    Private Index = 0
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim db As New DBDataContext
            Dim rs = From venue In db.Venues Select venue
            Result = rs.ToList
        Catch ex As Exception
            MsgBox("Unable to contact database", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
            Return
        End Try

        If Result.Count = 0 Then
            MsgBox("No records found!", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
            Return
        End If

        If Result.Count > 6 Then
            MaxStep = Result.Count / 6
        Else
            MaxStep = 1
        End If

        Index = 0
        DisplayItems(btnNext, New EventArgs)
        btnPrevious.Visible = False
    End Sub

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

    Private Sub DisplayItems(sender As Object, e As EventArgs) Handles btnNext.Click, btnPrevious.Click
        ResetVisibility()

        If sender.Equals(btnPrevious) Then
            Index = Index - 6
        End If

        If Index < 0 Then
            Index = 0
        End If

        For i = Index To Result.Count Step 6
            lblName1.Text = Result.Item(i).VenueName
            lblType1.Text = Result.Item(i).VenueType
            picVenue1.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i).VenuePicture.ToArray))

            If i + 1 < Result.Count Then
                lblName2.Text = Result.Item(i + 1).VenueName
                lblType2.Text = Result.Item(i + 1).VenueType
                picVenue2.Image = Image.FromStream(New IO.MemoryStream(Result.Item(i + 1).VenuePicture.ToArray))
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
    End Sub
    Private Sub MouseEnterEvent(sender As Object, e As EventArgs) Handles pnl1.MouseEnter, pnl2.MouseEnter, pnl3.MouseEnter, pnl4.MouseEnter, pnl5.MouseEnter, pnl6.MouseEnter, btnNext.MouseEnter, btnPrevious.MouseEnter
        Me.Cursor = Cursors.Hand
        If TypeOf sender Is Panel Then
            Dim pnl As Panel = DirectCast(sender, Panel)
            pnl.BackColor = Color.Silver
        End If
    End Sub

    Private Sub MouseLeaveEvent(sender As Object, e As EventArgs) Handles pnl1.MouseLeave, pnl2.MouseLeave, pnl3.MouseLeave, pnl4.MouseLeave, pnl5.MouseLeave, pnl6.MouseLeave, btnNext.MouseLeave, btnPrevious.MouseLeave
        Me.Cursor = Cursors.Default
        If TypeOf sender Is Panel Then
            Dim pnl As Panel = DirectCast(sender, Panel)
            pnl.BackColor = Color.White
        End If
    End Sub

    Private Sub LabelEnterEvent(sender As Object, e As EventArgs) Handles lblName1.MouseEnter, lblName2.MouseEnter, lblName3.MouseEnter, lblName4.MouseEnter, lblName5.MouseEnter, lblName6.MouseEnter,
        lblType1.MouseEnter, lblType2.MouseEnter, lblType3.MouseEnter, lblType4.MouseEnter, lblType5.MouseEnter, lblRate6.MouseEnter
        Dim pnl As Label = DirectCast(sender, Label)
        Debug.Write(pnl.Parent)
        MouseEnterEvent(pnl.Parent, New EventArgs)
    End Sub
End Class