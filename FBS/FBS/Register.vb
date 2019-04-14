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
        Dim retype As String = If(CStr(retypetxt.Text), "")

        If usern.Equals("") Then
            err.AppendLine("Please input your username.")
            ctr = If(ctr, untxt)
        ElseIf passw.Equals("") Then
            err.AppendLine("Please input your password.")
            ctr = If(ctr, pwtxt)
        ElseIf phone.Equals("") Then
            err.AppendLine("Please input A valid phone number.")
            ctr = If(ctr, phonetxt)
        ElseIf Not retype.Equals(passw) Then
            err.AppendLine("Please ensure the password retype is correct.")
            ctr = If(ctr, retypetxt)
        Else
            Dim stringCon As String = My.Settings.FBSConnectionString
            Dim connection As New SqlConnection(stringCon)

            ' Open 1st Database Connection
            connection.Open()
            Dim checkUsername As String = "SELECT CustName FROM Customer WHERE CustName = @Name"
            Dim command As New SqlCommand(checkUsername, connection)
            command.Parameters.AddWithValue("@Name", usern)
            Dim retrieval As SqlDataReader = command.ExecuteReader

            If retrieval.HasRows Then
                err.AppendLine("Current Username Has Been Taken, Please Try Again.")
                ctr = If(ctr, untxt)
            Else
                ' Close 1st Database Connection
                connection.Close()

                connection.Open()
                Dim checkCount As String = "SELECT * FROM Customer"
                Dim count As Integer = 1001
                Dim commandCount As New SqlCommand(checkCount, connection)
                Dim countRetrieval As New SqlDataAdapter(checkCount, stringCon)
                Dim ds As New DataSet
                countRetrieval.Fill(ds, "Customer")
                Dim dbcount As Integer = ds.Tables("Customer").Rows.Count
                count += dbcount
                connection.Close()

                ' Open 2nd Database Connection
                connection.Open()
                Dim registerAccount As String = "INSERT INTO Customer VALUES (@count, @usern, @passw)"
                Dim comm As New SqlCommand(registerAccount, connection)
                comm.Parameters.AddWithValue("@count", "C" + count.ToString)
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

    Private Sub passwShow_CheckedChanged(sender As Object, e As EventArgs) Handles passwShow.CheckedChanged
        If pwtxt.UseSystemPasswordChar = True And retypetxt.UseSystemPasswordChar = True Then
            pwtxt.UseSystemPasswordChar = False
            retypetxt.UseSystemPasswordChar = False
        Else
            pwtxt.UseSystemPasswordChar = True
            retypetxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        untxt.Text = GlobalVars.currentUser
    End Sub
End Class