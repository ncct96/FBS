Public Class FacilitiesReport
    Private Sub FacilitiesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New BookingDS
        Dim adapter As New BookingDSTableAdapters.BookingTableAdapter
        Dim report As New FacilitiesSummary
        report.SetDataSource(dataset)
        report.SummaryInfo.ReportTitle = "Facilities Summary Report"
        FacilitiesReportViewer.ReportSource = report
    End Sub
End Class