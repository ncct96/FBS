Imports System.Text
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Register
    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim usern As String = If(CStr(untxt.Text), "")
        Dim passw As String = If(CStr(pwtxt.Text), "")
        Dim phone As String = If(phonetxt.MaskCompleted, phonetxt.Text, "")

        If usern.Equals("") Then
            err.AppendLine("Please Input Your Username.")
            ctr = If(ctr, untxt)
        ElseIf passw.Equals("") Then
            err.AppendLine("Please Input Your Password.")
            ctr = If(ctr, pwtxt)
        ElseIf phone.Equals("") Then
            err.AppendLine("Please Input A Valid Phone Number.")
            ctr = If(ctr, phonetxt)
        Else
            Dim stringCon As String = ConfigurationManager.ConnectionStrings("FBSConnectionString").ConnectionString
            Dim connection As New SqlConnection(stringCon)

            ' Open 1st Database Connection
            connection.Open()
            Dim count As Integer = 1000
            Dim checkUsername As String = "SELECT CustName FROM Customer WHERE CustName = @Name"
            Dim command As New SqlCommand(checkUsername, connection)
            command.Parameters.AddWithValue("@Name", usern)
            Dim retrieval As SqlDataReader = command.ExecuteReader

            If retrieval.HasRows Then
                err.AppendLine("Current Username Has Been Taken, Please Try Again.")
                ctr = If(ctr, untxt)
            Else
                While retrieval.HasRows
                    count += 1
                End While

                ' Close 1st Database Connection
                connection.Close()

                ' Open 2nd Database Connection
                connection.Open()
                Dim registerAccount As String = "INSERT INTO Customer VALUES (@count, @usern, @passw)"
                Dim comm As New SqlCommand(registerAccount, connection)
                comm.Parameters.AddWithValue("@count", count)
                comm.Parameters.AddWithValue("@usern", usern)
                comm.Parameters.AddWithValue("@passw", passw)
                comm.ExecuteNonQuery()

                ' Close 2nd Database Connection
                connection.Close()

                MessageBox.Show("New Account Created.", "Register Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ctr.Focus()
            Return
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class