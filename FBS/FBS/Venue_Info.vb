Public Class Venue_Info
    Private Sub loadStyles(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mouseEnter_Event(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox4.MouseEnter, PictureBox3.MouseEnter, PictureBox2.MouseEnter, PictureBox1.MouseEnter, btn_reserve.MouseEnter, btn_back.MouseEnter
        Me.Cursor = Cursors.Hand
        If TypeOf sender Is PictureBox Then
            sender.SizeMode = PictureBoxSizeMode.CenterImage
        End If

    End Sub

    Private Sub mouseLeave_Event(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave, PictureBox5.MouseLeave, PictureBox4.MouseLeave, PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave, btn_reserve.MouseLeave, btn_back.MouseLeave
        Me.Cursor = Cursors.Default
        If TypeOf sender Is PictureBox Then
            sender.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

    Private Sub pictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox2.Click, PictureBox1.Click
        Dim Obj As New Image_Modal
        Obj.PictureBox1.Image = My.Resources._1200px_Donald_Trump_official_portrait
        Obj.Show()
    End Sub
End Class