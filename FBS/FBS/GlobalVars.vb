Public Class GlobalVars
    Public Shared currentUser As String
    Public Shared currentType As String
    Public Shared currentId As String

    Public Shared Sub changeUser()
        currentUser = ""
        currentType = ""
        currentId = ""
    End Sub
End Class
