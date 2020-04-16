Imports System.Data.SqlClient

Public Class Vendor

    Private frmCaller As ManageDB

    Public Sub New(ByRef frm As ManageDB)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmCaller = frm

    End Sub

    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub

    Private Sub btnInsertExit_Click(sender As Object, e As EventArgs) Handles btnInsertExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnInsertAdd_Click(sender As Object, e As EventArgs) Handles btnInsertAdd.Click
        Dim isValidData As Boolean = True
        Dim errorList As String = ""
        Dim command As SqlCommand
        Dim query As String = "EXEC usp_ADD_VENDOR'" + txtInsertNum.Text + "', '" + txtInsertName.Text +
                                "', '" + txtInsertStreet.Text + "', '" + txtInsertCity.Text + "', '" + txtInsertState.Text +
                                "', '" + txtInsertPostal.Text + "', '" + txtInsertEmail.Text + "', '" + txtInsertPhone.Text + "'"
        command = New SqlCommand(query, DBConnection.connection)

        If Not IsNumeric(txtInsertPostal.Text) OrElse txtInsertPostal.Text.Length <> 5 Then
            errorList += vbNewLine + "- The postal code must be a 5-digit number."
            txtInsertPostal.ForeColor = Color.Red
            isValidData = False
        Else
            txtInsertPostal.ForeColor = Color.WhiteSmoke
        End If


        If connectDB() AndAlso isValidData Then
            Try
                command.ExecuteNonQuery()
                MessageBox.Show("The record was created successfully.")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("The attempt to execute that action was unsuccessful. The following error was encountered: " +
                                vbNewLine + vbNewLine + ex.Message + vbNewLine + vbNewLine +
                                "Please, fix the error and try again or contact your system administrator.")
            End Try
        ElseIf Not isValidData Then
            MessageBox.Show("The entered data is invalid. " + vbNewLine +
                            "Please, make sure the following requirements are met and try again: " +
                            vbNewLine + errorList)
        Else
            Me.Close()
        End If
    End Sub
End Class