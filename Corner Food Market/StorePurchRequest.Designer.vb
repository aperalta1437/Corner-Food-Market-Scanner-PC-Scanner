<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StorePurchRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StorePurchRequest))
        Me.pnlHireEmployee = New System.Windows.Forms.Panel()
        Me.txtInsertUPC = New System.Windows.Forms.TextBox()
        Me.lstInsertNumOrdered = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInsertExit = New System.Windows.Forms.Button()
        Me.btnInsertAdd = New System.Windows.Forms.Button()
        Me.txtInsertPrice = New System.Windows.Forms.TextBox()
        Me.txtInsertStPurchNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHireEmployee.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHireEmployee
        '
        Me.pnlHireEmployee.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertUPC)
        Me.pnlHireEmployee.Controls.Add(Me.lstInsertNumOrdered)
        Me.pnlHireEmployee.Controls.Add(Me.Panel1)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertPrice)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertStPurchNum)
        Me.pnlHireEmployee.Controls.Add(Me.Label8)
        Me.pnlHireEmployee.Controls.Add(Me.Label7)
        Me.pnlHireEmployee.Controls.Add(Me.Label6)
        Me.pnlHireEmployee.Controls.Add(Me.Label1)
        Me.pnlHireEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHireEmployee.Location = New System.Drawing.Point(0, 0)
        Me.pnlHireEmployee.Name = "pnlHireEmployee"
        Me.pnlHireEmployee.Size = New System.Drawing.Size(466, 330)
        Me.pnlHireEmployee.TabIndex = 2
        '
        'txtInsertUPC
        '
        Me.txtInsertUPC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertUPC.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertUPC.Location = New System.Drawing.Point(229, 82)
        Me.txtInsertUPC.Name = "txtInsertUPC"
        Me.txtInsertUPC.Size = New System.Drawing.Size(169, 29)
        Me.txtInsertUPC.TabIndex = 24
        '
        'lstInsertNumOrdered
        '
        Me.lstInsertNumOrdered.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInsertNumOrdered.FormattingEnabled = True
        Me.lstInsertNumOrdered.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.lstInsertNumOrdered.Location = New System.Drawing.Point(229, 123)
        Me.lstInsertNumOrdered.Name = "lstInsertNumOrdered"
        Me.lstInsertNumOrdered.Size = New System.Drawing.Size(169, 29)
        Me.lstInsertNumOrdered.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.btnInsertExit)
        Me.Panel1.Controls.Add(Me.btnInsertAdd)
        Me.Panel1.Location = New System.Drawing.Point(0, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 80)
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
        Me.btnInsertExit.Location = New System.Drawing.Point(65, 17)
        Me.btnInsertExit.Name = "btnInsertExit"
        Me.btnInsertExit.Size = New System.Drawing.Size(152, 41)
        Me.btnInsertExit.TabIndex = 21
        Me.btnInsertExit.Text = "Exit"
        Me.btnInsertExit.UseVisualStyleBackColor = False
        '
        'btnInsertAdd
        '
        Me.btnInsertAdd.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnInsertAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInsertAdd.FlatAppearance.BorderSize = 2
        Me.btnInsertAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.btnInsertAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertAdd.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertAdd.ForeColor = System.Drawing.Color.Black
        Me.btnInsertAdd.Location = New System.Drawing.Point(245, 17)
        Me.btnInsertAdd.Name = "btnInsertAdd"
        Me.btnInsertAdd.Size = New System.Drawing.Size(155, 41)
        Me.btnInsertAdd.TabIndex = 20
        Me.btnInsertAdd.Text = "Add"
        Me.btnInsertAdd.UseVisualStyleBackColor = False
        '
        'txtInsertPrice
        '
        Me.txtInsertPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertPrice.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertPrice.Location = New System.Drawing.Point(229, 164)
        Me.txtInsertPrice.Name = "txtInsertPrice"
        Me.txtInsertPrice.Size = New System.Drawing.Size(169, 29)
        Me.txtInsertPrice.TabIndex = 15
        '
        'txtInsertStPurchNum
        '
        Me.txtInsertStPurchNum.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertStPurchNum.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertStPurchNum.Location = New System.Drawing.Point(229, 41)
        Me.txtInsertStPurchNum.Name = "txtInsertStPurchNum"
        Me.txtInsertStPurchNum.Size = New System.Drawing.Size(169, 29)
        Me.txtInsertStPurchNum.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(161, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "UPC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(81, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No. Ordered"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(79, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Quoted Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Store Purch No."
        '
        'StorePurchRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 330)
        Me.Controls.Add(Me.pnlHireEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StorePurchRequest"
        Me.Text = "Store Purchase Request"
        Me.pnlHireEmployee.ResumeLayout(False)
        Me.pnlHireEmployee.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHireEmployee As Panel
    Friend WithEvents lstInsertNumOrdered As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInsertExit As Button
    Friend WithEvents btnInsertAdd As Button
    Friend WithEvents txtInsertPrice As TextBox
    Friend WithEvents txtInsertStPurchNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInsertUPC As TextBox
End Class
