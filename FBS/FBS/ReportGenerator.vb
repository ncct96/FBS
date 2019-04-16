Public Class ReportGenerator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dlgPrintPreview.Document = ExceptionReport
        dlgPrintPreview.ShowDialog(Me)
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

    Private Sub ExceptionReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ExceptionReport.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubheader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim header = "Usage summary for year"
        Dim subheader As String = String.Format(
            "Generated on {0:dd-MMMM-yyyy hh:mm:sss tt}" + vbNewLine + "Prepared by: ", DateTime.Now
        )

        With e.Graphics
            .DrawImage(My.Resources.FBS, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.DodgerBlue, 100, 0)
            .DrawString(subheader, fontSubheader, Brushes.Black, 100, 40)
        End With
    End Sub
End Class