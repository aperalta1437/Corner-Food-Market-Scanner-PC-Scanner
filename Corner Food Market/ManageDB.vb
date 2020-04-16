Public Class ManageDB

    Private intActiveTab As Integer = 1
    Private intSelectedTab As Integer = 1

    Private mainForm As MainForm

    Public Sub New(ByRef mForm As MainForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainForm = mForm

    End Sub

    Public Function GetSelectedTab() As Integer
        Return intSelectedTab
    End Function

    Private Sub ManageDB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainForm.ClosingManageDB()
    End Sub

    Private Sub ManageDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub

    Private Sub turnOffActiveTab()
        Select Case intActiveTab
            Case 1
                pnlInsertTab.Visible = False
                btnInsertTab.BackColor = Color.White
                btnInsertTab.ForeColor = Color.DarkSeaGreen
            Case 2
                pnlDeleteTab.Visible = False
                btnDeleteTab.BackColor = Color.White
                btnDeleteTab.ForeColor = Color.DarkSeaGreen
            Case 3
                pnlUpdateTab.Visible = False
                btnUpdateTab.BackColor = Color.White
                btnUpdateTab.ForeColor = Color.DarkSeaGreen
        End Select

    End Sub

    Private Sub turnOnSelectedTab()
        Select Case intSelectedTab
            Case 1
                pnlInsertTab.Visible = True
                btnInsertTab.BackColor = Color.DarkSeaGreen
                btnInsertTab.ForeColor = Color.White
            Case 2
                pnlDeleteTab.Visible = True
                btnDeleteTab.BackColor = Color.DarkSeaGreen
                btnDeleteTab.ForeColor = Color.White
            Case 3
                pnlUpdateTab.Visible = True
                btnUpdateTab.BackColor = Color.DarkSeaGreen
                btnUpdateTab.ForeColor = Color.White
        End Select

    End Sub

    Private Sub btnInsertTab_Click(sender As Object, e As EventArgs) Handles btnInsertTab.Click
        intSelectedTab = 1
        If intSelectedTab <> intActiveTab Then
            turnOnSelectedTab()
            turnOffActiveTab()
            intActiveTab = 1
        End If
    End Sub

    Private Sub btnDeleteTab_Click(sender As Object, e As EventArgs) Handles btnDeleteTab.Click
        intSelectedTab = 2
        If intSelectedTab <> intActiveTab Then
            turnOnSelectedTab()
            turnOffActiveTab()
            intActiveTab = 2
        End If
    End Sub

    Private Sub btnUpdateTab_Click(sender As Object, e As EventArgs) Handles btnUpdateTab.Click
        intSelectedTab = 3
        If intSelectedTab <> intActiveTab Then
            turnOnSelectedTab()
            turnOffActiveTab()
            intActiveTab = 3
        End If
    End Sub

    Private Sub btnInsertEmployee_Click(sender As Object, e As EventArgs) Handles btnInsertEmployee.Click
        Dim frmHireEmployee As New Employee(Me)
        frmHireEmployee.ShowDialog()
    End Sub

    Private Sub btnInsertStorePurch_Click(sender As Object, e As EventArgs) Handles btnInsertStorePurch.Click
        Dim frmAddStorePurch As New StorePurchase(Me)
        frmAddStorePurch.ShowDialog()
    End Sub

    Private Sub btnInsertStPurchRequest_Click(sender As Object, e As EventArgs) Handles btnInsertStPurchRequest.Click
        Dim frmAddStorePurchRequest As New StorePurchRequest(Me)
        frmAddStorePurchRequest.ShowDialog()
    End Sub

    Private Sub btnInsertVendor_Click(sender As Object, e As EventArgs) Handles btnInsertVendor.Click
        Dim frmAddVendor As New Vendor(Me)
        frmAddVendor.ShowDialog()
    End Sub

    Private Sub btnInsertItem_Click(sender As Object, e As EventArgs) Handles btnInsertItem.Click
        Dim frmAddItem As New Item(Me)
        frmAddItem.ShowDialog()
    End Sub
End Class