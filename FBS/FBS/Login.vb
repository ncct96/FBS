Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class Login
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = If(CStr(usernametxt.Text), "")
        Dim password As String = If(CStr(passwordtxt.Text), "")

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Try
            If username.Equals("") Or password.Equals("") Then
                err.AppendLine("Please Input Your Account's Username.")
                ctr = If(ctr, usernametxt)
            ElseIf password.Equals("") Then
                err.AppendLine("Please Input Your Account's Password.")
                ctr = If(ctr, passwordtxt)
            Else
                Dim stringCon As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
                Dim connection As New SqlConnection(stringCon)

                ' Open Database Connection
                connection.Open()
                Dim userSelect As String = "SELECT CustName FROM Customer WHERE CustName = @Name AND CustPass = @Pass"
                Dim command As New SqlCommand(userSelect, connection)
                command.Parameters.AddWithValue("@Name", username)
                command.Parameters.AddWithValue("@Pass", password)
                Dim retrieval As SqlDataReader = command.ExecuteReader

                ' If Else Statement for Customer SQL
                If retrieval.HasRows Then
                    MessageBox.Show("Welcome Back " + "", "User Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid Login Information.", "Account not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                ' Close Database Connection
                connection.Close()
            End If
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ctr.Focus()
                Return
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