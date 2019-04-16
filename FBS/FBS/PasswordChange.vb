Imports System.Data.SqlClient
Imports System.Text

Public Class PasswordChange
    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim stringCon As String = My.Settings.FBSConnectionString
        Dim connection As New SqlConnection(stringCon)

        Dim oldpassw As String = If(CStr(oldpasswTxt.Text), "")
        Dim newpassw As String = If(CStr(newpasswTxt.Text), "")
        Dim repassw As String = If(CStr(repasswTxt.Text), "")
        Dim check As Boolean = False

        If oldpassw.Equals("") Then
            err.AppendLine("Please input your password.")
            ctr = If(ctr, oldpasswTxt)
        ElseIf newpassw.Equals("") Then
            err.AppendLine("Please input your new password.")
            ctr = If(ctr, newpasswTxt)
        ElseIf repassw.Equals("") Then
            err.AppendLine("Please retype your new password.")
            ctr = If(ctr, repasswTxt)
        ElseIf Not repassw.Equals(newpassw) Then
            err.AppendLine("Password mismatched.")
            ctr = If(ctr, repasswTxt)
        Else
            If GlobalVars.currentType.Equals("Customer") Then
                connection.Open()
                Dim passwordChange As String = "SELECT CustPass FROM Customer WHERE CustName = @name AND CustPass = @pass"
                Dim passwCommand As New SqlCommand(passwordChange, connection)
                passwCommand.Parameters.AddWithValue("@name", GlobalVars.currentUser)
                passwCommand.Parameters.AddWithValue("@pass", oldpassw)
                Dim passRetrieve As SqlDataReader = passwCommand.ExecuteReader
                If passRetrieve.HasRows Then
                    check = True
                End If
                connection.Close()

                If check Then
                    If oldpassw.Equals(newpassw) Then
                        err.AppendLine("Password changed cannot be same as old password.")
                        ctr = If(ctr, newpasswTxt)
                    Else
                        Dim answer As Integer = MessageBox.Show("Are you sure to make the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If answer = DialogResult.Yes Then
                            connection.Open()
                            Dim passwordExecute As String = "UPDATE Customer SET CustPass = @newpass WHERE CustName = @custName"
                            Dim passwordCommand As New SqlCommand(passwordExecute, connection)
                            passwordCommand.Parameters.AddWithValue("@newpass", newpassw)
                            passwordCommand.Parameters.AddWithValue("@custName", GlobalVars.currentUser)
                            passwordCommand.ExecuteNonQuery()
                            connection.Close()
                            MessageBox.Show("Password Changed Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            ElseIf GlobalVars.currentType.Equals("Admin") Then
                connection.Open()
                Dim passwordChange As String = "SELECT AdminPassw FROM Admin WHERE AdminName = @aname AND AdminPassw = @apass"
                Dim passwCommand As New SqlCommand(passwordChange, connection)
                passwCommand.Parameters.AddWithValue("@aname", GlobalVars.currentUser)
                passwCommand.Parameters.AddWithValue("@apass", oldpassw)
                Dim passRetrieve As SqlDataReader = passwCommand.ExecuteReader
                If passRetrieve.HasRows Then
                    check = True
                End If
                connection.Close()

                If check Then
                    If oldpassw.Equals(newpassw) Then
                        err.AppendLine("Password changed cannot be same as old password.")
                        ctr = If(ctr, newpasswTxt)
                    Else
                        Dim answer As Integer = MessageBox.Show("Are you sure to make the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If answer = DialogResult.Yes Then
                            connection.Open()
                            Dim passwordExecute As String = "UPDATE Admin SET AdminPassw = @anewpass WHERE AdminName = @admName"
                            Dim passwordCommand As New SqlCommand(passwordExecute, connection)
                            passwordCommand.Parameters.AddWithValue("@anewpass", newpassw)
                            passwordCommand.Parameters.AddWithValue("@admName", GlobalVars.currentUser)
                            passwordCommand.ExecuteNonQuery()
                            connection.Close()
                            MessageBox.Show("Password Changed Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ctr.Focus()
            Return
        End If

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class