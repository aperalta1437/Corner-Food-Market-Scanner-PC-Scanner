<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item))
        Me.pnlHireEmployee = New System.Windows.Forms.Panel()
        Me.txtInsertDesc = New System.Windows.Forms.TextBox()
        Me.txtInsertRetailPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstInsertOnStore = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstInsertCategory = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInsertExit = New System.Windows.Forms.Button()
        Me.btnInsertAdd = New System.Windows.Forms.Button()
        Me.txtInsertWholePrice = New System.Windows.Forms.TextBox()
        Me.txtInsertUPC = New System.Windows.Forms.TextBox()
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
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertDesc)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertRetailPrice)
        Me.pnlHireEmployee.Controls.Add(Me.Label3)
        Me.pnlHireEmployee.Controls.Add(Me.lstInsertOnStore)
        Me.pnlHireEmployee.Controls.Add(Me.Label2)
        Me.pnlHireEmployee.Controls.Add(Me.lstInsertCategory)
        Me.pnlHireEmployee.Controls.Add(Me.Panel1)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertWholePrice)
        Me.pnlHireEmployee.Controls.Add(Me.txtInsertUPC)
        Me.pnlHireEmployee.Controls.Add(Me.Label8)
        Me.pnlHireEmployee.Controls.Add(Me.Label7)
        Me.pnlHireEmployee.Controls.Add(Me.Label6)
        Me.pnlHireEmployee.Controls.Add(Me.Label1)
        Me.pnlHireEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHireEmployee.Location = New System.Drawing.Point(0, 0)
        Me.pnlHireEmployee.Name = "pnlHireEmployee"
        Me.pnlHireEmployee.Size = New System.Drawing.Size(468, 395)
        Me.pnlHireEmployee.TabIndex = 2
        '
        'txtInsertDesc
        '
        Me.txtInsertDesc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertDesc.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertDesc.Location = New System.Drawing.Point(212, 82)
        Me.txtInsertDesc.Name = "txtInsertDesc"
        Me.txtInsertDesc.Size = New System.Drawing.Size(206, 29)
        Me.txtInsertDesc.TabIndex = 28
        '
        'txtInsertRetailPrice
        '
        Me.txtInsertRetailPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertRetailPrice.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertRetailPrice.Location = New System.Drawing.Point(212, 250)
        Me.txtInsertRetailPrice.Name = "txtInsertRetailPrice"
        Me.txtInsertRetailPrice.Size = New System.Drawing.Size(206, 29)
        Me.txtInsertRetailPrice.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(88, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 30)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Retail Price"
        '
        'lstInsertOnStore
        '
        Me.lstInsertOnStore.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInsertOnStore.FormattingEnabled = True
        Me.lstInsertOnStore.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.lstInsertOnStore.Location = New System.Drawing.Point(212, 123)
        Me.lstInsertOnStore.Name = "lstInsertOnStore"
        Me.lstInsertOnStore.Size = New System.Drawing.Size(206, 29)
        Me.lstInsertOnStore.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(108, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 30)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "On Store"
        '
        'lstInsertCategory
        '
        Me.lstInsertCategory.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInsertCategory.FormattingEnabled = True
        Me.lstInsertCategory.Items.AddRange(New Object() {"Cash", "Card", "EBT"})
        Me.lstInsertCategory.Location = New System.Drawing.Point(212, 165)
        Me.lstInsertCategory.Name = "lstInsertCategory"
        Me.lstInsertCategory.Size = New System.Drawing.Size(206, 29)
        Me.lstInsertCategory.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.btnInsertExit)
        Me.Panel1.Controls.Add(Me.btnInsertAdd)
        Me.Panel1.Location = New System.Drawing.Point(0, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 80)
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
        'txtInsertWholePrice
        '
        Me.txtInsertWholePrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertWholePrice.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertWholePrice.Location = New System.Drawing.Point(212, 207)
        Me.txtInsertWholePrice.Name = "txtInsertWholePrice"
        Me.txtInsertWholePrice.Size = New System.Drawing.Size(206, 29)
        Me.txtInsertWholePrice.TabIndex = 15
        '
        'txtInsertUPC
        '
        Me.txtInsertUPC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInsertUPC.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertUPC.Location = New System.Drawing.Point(212, 41)
        Me.txtInsertUPC.Name = "txtInsertUPC"
        Me.txtInsertUPC.Size = New System.Drawing.Size(206, 29)
        Me.txtInsertUPC.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(84, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(105, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(44, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Wholesale Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(153, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UPC"
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 395)
        Me.Controls.Add(Me.pnlHireEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Item"
        Me.Text = "Item"
        Me.pnlHireEmployee.ResumeLayout(False)
        Me.pnlHireEmployee.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHireEmployee As Panel
    Friend WithEvents lstInsertCategory As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInsertExit As Button
    Friend WithEvents btnInsertAdd As Button
    Friend WithEvents txtInsertWholePrice As TextBox
    Friend WithEvents txtInsertUPC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstInsertOnStore As ComboBox
    Friend WithEvents txtInsertRetailPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInsertDesc As TextBox
End Class
