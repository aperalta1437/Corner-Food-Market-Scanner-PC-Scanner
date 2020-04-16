Imports System.Data.SqlClient

Public Class StartSales

    Private strScannedUPC As String
    Private strScannedKeys As New List(Of String)
    Private saleCalculator As New SaleCalculator

    Private mainForm As MainForm
    Private resizer As New Resizer

    Private WithEvents kbHook As New KeyboardHook

    Public Sub New(ByRef mForm As MainForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainForm = mForm

    End Sub

    Private Sub StartSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resizer.FindAllControls(Me)
        CenterForm(Me)
    End Sub

    Private Sub StartSales_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        resizer.ResizeAllControls(Me)
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown

        Try
            If Key.ToString.Substring(0, 1) = "D" Then
                strScannedKeys.Add(Key.ToString.Substring(1))
            ElseIf strScannedKeys.Count >= 10 AndAlso Key.ToString = "Return" Then
                strScannedUPC = String.Join("", strScannedKeys)
                strScannedKeys = New List(Of String)
                getScannedItem()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub getScannedItem()
        Dim dblItemPrice As Double
        Dim strFormattedPrice As String = String.Empty
        Dim command As SqlCommand
        Dim datareader As SqlDataReader
        Dim query As String =
            "SELECT UPC, DESCRIPTION, RETAIL_PRICE FROM ITEM WHERE UPC = '" & strScannedUPC & "'"

        Try
            command = New SqlCommand(query, connection)
            datareader = command.ExecuteReader()
            datareader.Read()
            dblItemPrice = CDbl(datareader.GetValue(2))
            saleCalculator.Subtotal += dblItemPrice
            saleCalculator.calcSale()
            strFormattedPrice = dblItemPrice.ToString("c")
            ListBox1.Items.Add(datareader.GetValue(0).ToString() & vbTab & datareader.GetValue(1).ToString() & vbTab & strFormattedPrice)
            lblSubtotal.Text = saleCalculator.Subtotal.ToString("c")
            lblTax.Text = saleCalculator.Tax.ToString("c")
            lblFoodStamp.Text = saleCalculator.FoodStamp.ToString("c")
            lblTotal.Text = saleCalculator.Total.ToString("c")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            datareader.Close()
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        End Try

    End Sub

    Private Sub StartSales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainForm.ClosingStartSales()
    End Sub
End Class

