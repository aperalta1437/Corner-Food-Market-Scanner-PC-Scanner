Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application.
        Me.Close()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterForm(Me)

        Try
            DBConnection.connectDB()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim command As SqlCommand
        Dim query As String = "SELECT PASSWORD1 FROM LOGIN_CREDENTIALS WHERE USERNAME = '" & txtUsername.Text & "';"

        command = New SqlCommand(query, DBConnection.connection)

        Dim dataReader As SqlDataReader = command.ExecuteReader()

        If dataReader.Read AndAlso dataReader.GetValue(0).ToString = txtPassword.Text Then
            MessageBox.Show("Connection was successful.")
            Me.Hide()
        Else
            MessageBox.Show("Connection was unsuccessful.")
        End If

        dataReader.Close()
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("This action will close the application. Do you want to continue?", "Confirm",
                            MessageBoxButtons.YesNo) = DialogResult.Yes Then
                e.Cancel = False        ' Continue to close the form.
                disconnectDB()          ' Closing database connection.
            Else
                e.Cancel = True         ' Do not close the form.
            End If
        End If

    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub txtBoxUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BackColor = Color.OldLace
    End Sub

    Private Sub txtBoxUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtBoxPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = Color.OldLace
    End Sub

    Private Sub txtBoxPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = Color.White
    End Sub
End Class