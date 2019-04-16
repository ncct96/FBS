Public Class NicholasReportViewer
    Private Sub NicholasReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New FBSDataSet
        Dim ad As New FBSDataSetTableAdapters.BookingTableAdapter
        ad.Fill(ds.Booking, "1")
        Dim rpt As New DailyRpt
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class