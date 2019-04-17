Public Class CancellationReport
    Private Sub CancellationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New CKreport
        Dim ad As New CKreportTableAdapters.BookingTableAdapter
        ad.Fill(ds.Booking)
        Dim rpt As New CancellationSum
        rpt.SetDataSource(ds)
        rpt.SummaryInfo.ReportTitle = "Daily Total Loss Report"
        CrystalReportViewer2.ReportSource = rpt
    End Sub
End Class