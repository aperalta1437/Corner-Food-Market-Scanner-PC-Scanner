<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.pnlHireEmployee = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInsertExit = New System.Windows.Forms.Button()
        Me.btnInsertHire = New System.Windows.Forms.Button()
        Me.txtInsertEmail = New System.Windows.Forms.TextBox()
        Me.txtInsertLName = New System.Windows.Forms.TextBox()
        Me.txtInsertStreet = New System.Windows.Forms.TextBox()
        Me.txtInsertPostal = New System.Windows.Forms.TextBox()
        Me.txtInsertPhone = New System.Windows.Forms.TextBox()
        Me.txtInsertState = New System.Windows.Forms.TextBox()
        Me.txtInsertCity = New System.Windows.Forms.TextBox()
        Me.txtInsertFName = New System.Windows.Forms.TextBox()
        Me.txtInsertID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHireEmployee.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHireEmployee
        '
        Me.pnlHireEmployee.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnlHireEmployee.Controls.Add(Me.Panel1)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertEmail)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertLName)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertStreet)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertPostal)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertPhone)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertState)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertCity)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertFName)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertID)
        Me.pnlHireEmployee.Controls.Add(Me.Label9)
        Me.pnlHireEmployee.Controls.Add(Me.Label8)
        Me.pnlHireEmployee.Controls.Add(Me.Label7)
        Me.pnlHireEmployee.Controls.Add(Me.Label6)
        Me.pnlHireEmployee.Controls.Add(Me.Label5)
        Me.pnlHireEmployee.Controls.Add(Me.Label4)
        Me.pnlHireEmployee.Controls.Add(Me.Label3)
        Me.pnlHireEmployee.Controls.Add(Me.Label2)
        Me.pnlHireEmployee.Controls.Add(Me.Label1)
        Me.pnlHireEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHireEmployee.Location = New System.Drawing.Point(0, 0)
        Me.pnlHireEmployee.Name = "pnlHireEmployee"
        Me.pnlHireEmployee.Size = New System.Drawing.Size(491, 515)
        Me.pnlHireEmployee.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.btnInsertExit)
        Me.Panel1.Controls.Add(Me.btnInsertHire)
        Me.Panel1.Location = New System.Drawing.Point(0, 435)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 80)
        Me.Panel1.TabIndex = 20
        '
        'btnInsertExit
        '
        Me.btnInsertExit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnInsertExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInsertExit.FlatAppearance.BorderSize = 2
        Me.btnInsertExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.btnInsertExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertExit.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertExit.ForeColor = System.Drawing.Color.Black
        Me.btnInsertExit.Location = New System.Drawing.Point(78, 17)
        Me.btnInsertExit.Name = "btnInsertExit"
        Me.btnInsertExit.Size = New System.Drawing.Size(152, 41)
        Me.btnInsertExit.TabIndex = 21
        Me.btnInsertExit.Text = "Exit"
        Me.btnInsertExit.UseVisualStyleBackColor = False
        '
        'btnInsertHire
        '
        Me.btnInsertHire.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnInsertHire.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInsertHire.FlatAppearance.BorderSize = 2
        Me.btnInsertHire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.btnInsertHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertHire.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertHire.ForeColor = System.Drawing.Color.Black
        Me.btnInsertHire.Location = New System.Drawing.Point(258, 17)
        Me.btnInsertHire.Name = "btnInsertHire"
        Me.btnInsertHire.Size = New System.Drawing.Size(155, 41)
        Me.btnInsertHire.TabIndex = 20
        Me.btnInsertHire.Text = "Hire"
        Me.btnInsertHire.UseVisualStyleBackColor = False
        '
        'txtInsertEmail
        '
        Me.txtInsertEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertEmail.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertEmail.Location = New System.Drawing.Point(209, 369)
        Me.txtInsertEmail.Name = "txtInsertEmail"
        Me.txtInsertEmail.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertEmail.TabIndex = 17
        '
        'txtInsertLName
        '
        Me.txtInsertLName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertLName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertLName.Location = New System.Drawing.Point(209, 123)
        Me.txtInsertLName.Name = "txtInsertLName"
        Me.txtInsertLName.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertLName.TabIndex = 16
        '
        'txtInsertStreet
        '
        Me.txtInsertStreet.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertStreet.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertStreet.Location = New System.Drawing.Point(209, 164)
        Me.txtInsertStreet.Name = "txtInsertStreet"
        Me.txtInsertStreet.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertStreet.TabIndex = 15
        '
        'txtInsertPostal
        '
        Me.txtInsertPostal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertPostal.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertPostal.Location = New System.Drawing.Point(209, 287)
        Me.txtInsertPostal.Name = "txtInsertPostal"
        Me.txtInsertPostal.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertPostal.TabIndex = 14
        '
        'txtInsertPhone
        '
        Me.txtInsertPhone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertPhone.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertPhone.Location = New System.Drawing.Point(209, 328)
        Me.txtInsertPhone.Name = "txtInsertPhone"
        Me.txtInsertPhone.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertPhone.TabIndex = 13
        '
        'txtInsertState
        '
        Me.txtInsertState.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertState.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertState.Location = New System.Drawing.Point(209, 246)
        Me.txtInsertState.Name = "txtInsertState"
        Me.txtInsertState.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertState.TabIndex = 12
        '
        'txtInsertCity
        '
        Me.txtInsertCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertCity.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertCity.Location = New System.Drawing.Point(209, 205)
        Me.txtInsertCity.Name = "txtInsertCity"
        Me.txtInsertCity.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertCity.TabIndex = 11
        '
        'txtInsertFName
        '
        Me.txtInsertFName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertFName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertFName.Location = New System.Drawing.Point(209, 82)
        Me.txtInsertFName.Name = "txtInsertFName"
        Me.txtInsertFName.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertFName.TabIndex = 10
        '
        'txtInsertID
        '
        Me.txtInsertID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertID.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertID.Location = New System.Drawing.Point(209, 41)
        Me.txtInsertID.Name = "txtInsertID"
        Me.txtInsertID.Size = New System.Drawing.Size(207, 29)
        Me.txtInsertID.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(52, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Personal Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(86, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(89, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(133, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Street"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(141, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(153, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Postal Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 515)
        Me.Controls.Add(Me.pnlHireEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.pnlHireEmployee.ResumeLayout(False)
        Me.pnlHireEmployee.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHireEmployee As Panel
    Friend WithEvents txtInsertEmail As TextBox
    Friend WithEvents txtInsertLName As TextBox
    Friend WithEvents txtInsertStreet As TextBox
    Friend WithEvents txtInsertPostal As TextBox
    Friend WithEvents txtInsertPhone As TextBox
    Friend WithEvents txtInsertState As TextBox
    Friend WithEvents txtInsertCity As TextBox
    Friend WithEvents txtInsertFName As TextBox
    Friend WithEvents txtInsertID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInsertExit As Button
    Friend WithEvents btnInsertHire As Button
End Class
