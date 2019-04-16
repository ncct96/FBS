Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class Login
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = If(CStr(usernametxt.Text), "")
        Dim password As String = If(CStr(passwordtxt.Text), "")
        Dim tf As Boolean = False

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Try
            If username.Equals("") Then
                err.AppendLine("Please Input Your Account's Username.")
                ctr = If(ctr, usernametxt)
            ElseIf password.Equals("") Then
                err.AppendLine("Please Input Your Account's Password.")
                ctr = If(ctr, passwordtxt)
            Else
                Dim stringCon As String = My.Settings.FBSConnectionString
                Dim connection As New SqlConnection(stringCon)

                ' userCommand Reader Open
                connection.Open()
                Dim userSelect As String = "SELECT CustId FROM Customer WHERE CustName = @Name AND CustPass = @Pass"
                Dim userCommand As New SqlCommand(userSelect, connection)
                userCommand.Parameters.AddWithValue("@Name", username)
                userCommand.Parameters.AddWithValue("@Pass", password)
                Dim userRetrieval As SqlDataReader = userCommand.ExecuteReader

                ' If Else Statement for Customer SQL
                If userRetrieval.HasRows Then
                    MessageBox.Show("Welcome Back " + "User", "User Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GlobalVars.currentUser = username
                    GlobalVars.currentType = "Customer"
                    ' userCommand Reader Close
                    connection.Close()

                    ' userCommand Scalar Open
                    connection.Open()
                    GlobalVars.currentId = CType(userCommand.ExecuteScalar, String)
                    ' userCommand Scalar Close
                    connection.Close()
                    tf = True
                Else
                    ' userCommand Reader Close
                    connection.Close()
                    ' adminCommand Reader Open
                    connection.Open()
                    Dim adminSelect As String = "SELECT AdminId FROM Admin WHERE AdminName = @Name AND AdminPassw = @Passw"
                    Dim adminCommand As New SqlCommand(adminSelect, connection)
                    adminCommand.Parameters.AddWithValue("@Name", username)
                    adminCommand.Parameters.AddWithValue("@Passw", password)
                    Dim adminRetrieval As SqlDataReader = adminCommand.ExecuteReader
                    If adminRetrieval.HasRows Then
                        MessageBox.Show("Welcome Back " + "Admin", "Admin Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GlobalVars.currentUser = username
                        GlobalVars.currentType = "Admin"
                        ' adminCommand Reader Close
                        connection.Close()
                        ' adminCommand Scalar Open
                        connection.Open()
                        GlobalVars.currentId = CType(adminCommand.ExecuteScalar, String)
                        ' adminCommand Scalar Close
                        connection.Close()
                        tf = True
                    Else
                        MessageBox.Show("Invalid Login Information.", "Account not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ctr.Focus()
                Return
            End If

            If tf Then
                Dim pass As New Main
                Me.Hide()
                pass.ShowDialog()
                Me.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim register = New Register()
        register.Show()
    End Sub

    Private Sub passwordCheck_CheckedChanged(sender As Object, e As EventArgs) Handles passwordCheck.CheckedChanged
        If passwordtxt.UseSystemPasswordChar = True Then
            passwordtxt.UseSystemPasswordChar = False
        ElseIf passwordtxt.UseSystemPasswordChar = False Then
            passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
End Class