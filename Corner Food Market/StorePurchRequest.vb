Imports System.Data.SqlClient

Public Class StorePurchRequest

    Private frmCaller As ManageDB

    Public Sub New(ByRef frm As ManageDB)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmCaller = frm

    End Sub

    Private Sub StorePurchRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub

    Private Sub txtInsertPrice_Leave(sender As Object, e As EventArgs) Handles txtInsertPrice.Leave
        Try
            txtInsertPrice.Text = FormatCurrency(CDbl(txtInsertPrice.Text), , , TriState.True, TriState.True)
        Catch ex As Exception
            MessageBox.Show("Only decimal numbers are accepted for the price.")
            txtInsertPrice.Text = String.Empty
        End Try
    End Sub

    Private Sub btnInsertExit_Click(sender As Object, e As EventArgs) Handles btnInsertExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnInsertAdd_Click(sender As Object, e As EventArgs) Handles btnInsertAdd.Click
        Dim isValidData As Boolean = True
        Dim errorList As String = ""
        Dim command As SqlCommand
        Dim query As String = "EXEC usp_ADD_STORE_PURCH_REQUEST'" + txtInsertStPurchNum.Text + "', '" + txtInsertUPC.Text.ToUpper +
                                "', " + lstInsertNumOrdered.Text + ", " +
                                Replace(Replace(txtInsertPrice.Text, "$", ""), ",", "")
        command = New SqlCommand(query, DBConnection.connection)

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