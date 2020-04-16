Imports System.Data.SqlClient

Module DBConnection
    Public connection As New SqlConnection("Server=DESKTOP-0G7IL5K\PESS;Database=Corner_Food_Market;User=PESS;pwd=Hol@2030")

    Public Function connectDB() As Boolean
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("There were issues while trying to connect to the database. " +
                            "Please contact your system administrator or try again later.")
            Return False
        End Try

        Return True
    End Function

    Public Function disconnectDB() As Boolean
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Return True
    End Function
End Module
