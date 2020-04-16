Public Class MainForm

    Private frmManageDB As ManageDB
    Private frmStartSales As StartSales

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub

    Private Sub tmrLogoSize_Tick(sender As Object, e As EventArgs) Handles tmrLogoSize.Tick
        If (picIntroLogo.Width > (Me.Width * 2 / 3)) Then
            picIntroLogo.Width -= 2
        Else
            tmrLogoSize.Enabled = False
        End If
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        picIntroLogo.Width = Me.Width
        Dim frmLogin As New LoginForm
        frmLogin.ShowDialog()
        tmrLogoSize.Enabled = True
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        picIntroLogo.Width = (Me.Width * 2 / 3)
    End Sub

    Private Sub btnManageDB_Click(sender As Object, e As EventArgs) Handles btnManageDB.Click
        If IsNothing(frmManageDB) Then
            frmManageDB = New ManageDB(Me)
            frmManageDB.Show()
        Else
            MessageBox.Show("This window is opened.")
        End If
    End Sub

    Private Sub btnStartSelling_Click(sender As Object, e As EventArgs) Handles btnStartSelling.Click
        If IsNothing(frmStartSales) Then
            frmStartSales = New StartSales(Me)
            frmStartSales.Show()
        Else
            MessageBox.Show("This window is opened.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("This action will close the application. Do you want to continue?", "Confirm",
                            MessageBoxButtons.YesNo) = DialogResult.Yes Then
                e.Cancel = False        ' Continue to close the form.
                disconnectDB()
            Else
                e.Cancel = True         ' Do not close the form.
            End If
        End If
    End Sub

    Public Sub ClosingManageDB()
        frmManageDB = Nothing
    End Sub

    Public Sub ClosingStartSales()
        frmStartSales = Nothing
    End Sub


End Class