Imports System.Text

Public Class ReportGenerator
    Private Amount As Integer

    Private Sub GenerateException(sender As Object, e As EventArgs) Handles btnException.Click
        If Not Integer.TryParse(txtAmount.Text.Trim(" "), Amount) Then
            MsgBox("Please enter a valid amount", MsgBoxStyle.Exclamation, "Error")
            Return
        ElseIf Amount < 0 Then
            MsgBox("Please enter a higher amount", MsgBoxStyle.Exclamation, "Error")
            Return
        Else
            dlgPrintPreview.Document = ExceptionReport
            dlgPrintPreview.ShowDialog(Me)
        End If
    End Sub

    Private IsX As Boolean = True
    Private Sub OnFormClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If CBool(IsX) Then
            Application.Exit()
        End If
    End Sub

    Private Sub GoBack(sender As Object, e As EventArgs) Handles btnBack.Click
        IsX = False
        Me.Close()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim textHead As New Font("Calibri", 24, FontStyle.Bold)
        Dim textSubHead As New Font("Calibri", 14, FontStyle.Bold)
        Dim textBody As New Font("Consolas", 14)
        Dim header As String

        Dim stringQuery As String = "SELECT "

        Dim body As New StringBuilder
        Dim database As New DBDataContext
        body.Append("Venue Name         Venue Type              Venue Rate      " + vbNewLine)
        body.Append("------------        -----------------      ------------------" + vbNewLine)

    End Sub

    Private Sub ExceptionReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ExceptionReport.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubheader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 14)
        Dim header As String

        If cboLessMore.SelectedIndex = 0 Then
            header = "Facilities that have less than " + txtAmount.Text.ToString + " bookings"
        Else
            header = "Facilities that have more than " + txtAmount.Text.ToString + " bookings"
        End If
        Dim subheader As String = String.Format(
            "Generated on {0:dd-MMMM-yyyy hh:mm:sss tt}" + vbNewLine + "Prepared by: " + GlobalVars.currentUser, DateTime.Now
        )

        Dim body As New StringBuilder()
        Dim db As New DBDataContext
        body.Append("ID   Count  Name                           Type" + vbNewLine)
        body.Append("---- ------ ------------------------------ -------------------" + vbNewLine)
        If cboLessMore.SelectedIndex = 1 Then
            Dim rs = From venue In db.Venues Select venue Where venue.Timeslots.Count > Amount
            Try
                If rs.Equals(Nothing) Then
                    body.Append("No records matching the criteria were found")
                Else
                    For Each item In rs
                        Dim count = (From ts In db.Timeslots Select ts Where ts.VenueID = item.VenueID).Count
                        body.AppendFormat("{0, 4}", item.VenueID).AppendFormat(" {0, 6}", count.ToString).AppendFormat(" {0, 30}", item.VenueName).AppendFormat(" {0, 20}", item.VenueType).Append(vbNewLine)
                    Next
                End If
            Catch ex As Exception
                MsgBox("Unable to contact database", MsgBoxStyle.Exclamation, "Error")
                dlgPrintPreview.Close()
                Return
            End Try
        ElseIf cboLessMore.SelectedIndex = 0 Then
            Dim rs = From venue In db.Venues Select venue Where venue.Timeslots.Count < Amount
            Try
                If rs.Equals(Nothing) Then
                    body.Append("No records matching the criteria were found")
                Else
                    For Each item In rs
                        Dim count = (From ts In db.Timeslots Select ts Where ts.VenueID = item.VenueID).Count
                        body.AppendFormat("{0, 4}", item.VenueID).AppendFormat(" {0, 6}", count.ToString).AppendFormat(" {0, 30}", item.VenueName).AppendFormat(" {0, 20}", item.VenueType).Append(vbNewLine)
                    Next
                End If
            Catch ex As Exception
                MsgBox("Unable to contact database", MsgBoxStyle.Exclamation, "Error")
                dlgPrintPreview.Close()
                Return
            End Try
        End If

        With e.Graphics
            .DrawImage(My.Resources.FBS, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.DodgerBlue, 100, 0)
            .DrawString(subheader, fontSubheader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLessMore.SelectedIndex = 0
    End Sub

    Private Sub btnDetailed_Click(sender As Object, e As EventArgs) Handles btnDetailed.Click
        Dim DailyRpt As New NicholasReportViewer
        Me.Hide()
        DailyRpt.ShowDialog()
        Me.Show()
    End Sub


End Class