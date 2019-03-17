Public Class Venue_Info
    Private Sub loadStyles(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pictureBox_mouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox4.MouseEnter, PictureBox3.MouseEnter, PictureBox2.MouseEnter, PictureBox1.MouseEnter
        Me.Cursor = Cursors.Hand
        sender.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub pictureBox_mouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave, PictureBox5.MouseLeave, PictureBox4.MouseLeave, PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave
        Me.Cursor = Cursors.Default
        sender.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox2.Click, PictureBox1.Click
        Dim Obj As New Image_Modal
        Obj.PictureBox1.Image = My.Resources._1200px_Donald_Trump_official_portrait
        Obj.Show()
    End Sub

    Private Sub button_mouseEnter(sender As Object, e As EventArgs) Handles btn_reserve.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub button_mouseLeave(sender As Object, e As EventArgs) Handles btn_reserve.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
End Class