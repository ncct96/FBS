Public Class NicholasReportViewer
    Private Sub NicholasReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New BookingDS
        Dim ad As New BookingDSTableAdapters.BookingTableAdapter
        ad.Fill(ds.Booking)
        Dim rpt As New DailyRpt
        rpt.SetDataSource(ds)
        rpt.SummaryInfo.ReportTitle = "Daily Sales Report"
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class