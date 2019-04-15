Imports System.Text

Public Class PasswordChange
    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim err As StringBuilder()
        Dim ctr As Control = Nothing

        Dim oldpassw As String = If(CStr(oldpasswTxt.Text), "")
        Dim newpassw As String = If(CStr(newpasswTxt.Text), "")
        Dim repassw As String = If(CStr(repasswTxt.Text), "")
    End Sub
End Class