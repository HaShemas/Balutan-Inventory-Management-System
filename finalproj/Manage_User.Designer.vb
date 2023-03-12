<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_User
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
        Me.dgvRecords4 = New System.Windows.Forms.DataGridView()
        Me.btnCreateacc = New System.Windows.Forms.Button()
        Me.btnUpdateacc = New System.Windows.Forms.Button()
        Me.btnDelacc = New System.Windows.Forms.Button()
        Me.txtsID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnbk = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        CType(Me.dgvRecords4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecords4
        '
        Me.dgvRecords4.AllowUserToAddRows = False
        Me.dgvRecords4.AllowUserToDeleteRows = False
        Me.dgvRecords4.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvRecords4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords4.Location = New System.Drawing.Point(18, 86)
        Me.dgvRecords4.Name = "dgvRecords4"
        Me.dgvRecords4.ReadOnly = True
        Me.dgvRecords4.RowTemplate.Height = 25
        Me.dgvRecords4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords4.Size = New System.Drawing.Size(741, 279)
        Me.dgvRecords4.TabIndex = 14
        '
        'btnCreateacc
        '
        Me.btnCreateacc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateacc.Location = New System.Drawing.Point(486, 33)
        Me.btnCreateacc.Name = "btnCreateacc"
        Me.btnCreateacc.Size = New System.Drawing.Size(87, 31)
        Me.btnCreateacc.TabIndex = 15
        Me.btnCreateacc.Text = "Create"
        Me.btnCreateacc.UseVisualStyleBackColor = True
        '
        'btnUpdateacc
        '
        Me.btnUpdateacc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateacc.Location = New System.Drawing.Point(579, 33)
        Me.btnUpdateacc.Name = "btnUpdateacc"
        Me.btnUpdateacc.Size = New System.Drawing.Size(87, 31)
        Me.btnUpdateacc.TabIndex = 16
        Me.btnUpdateacc.Text = "Update"
        Me.btnUpdateacc.UseVisualStyleBackColor = True
        '
        'btnDelacc
        '
        Me.btnDelacc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelacc.Location = New System.Drawing.Point(672, 33)
        Me.btnDelacc.Name = "btnDelacc"
        Me.btnDelacc.Size = New System.Drawing.Size(87, 31)
        Me.btnDelacc.TabIndex = 17
        Me.btnDelacc.Text = "Delete"
        Me.btnDelacc.UseVisualStyleBackColor = True
        '
        'txtsID
        '
        Me.txtsID.Location = New System.Drawing.Point(111, 38)
        Me.txtsID.Name = "txtsID"
        Me.txtsID.Size = New System.Drawing.Size(204, 23)
        Me.txtsID.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(18, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 31)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search ID"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnbk
        '
        Me.btnbk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnbk.Location = New System.Drawing.Point(18, 406)
        Me.btnbk.Name = "btnbk"
        Me.btnbk.Size = New System.Drawing.Size(87, 32)
        Me.btnbk.TabIndex = 21
        Me.btnbk.Text = "Back"
        Me.btnbk.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnclr.Location = New System.Drawing.Point(321, 33)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(87, 31)
        Me.btnclr.TabIndex = 22
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'Manage_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnbk)
        Me.Controls.Add(Me.txtsID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelacc)
        Me.Controls.Add(Me.btnUpdateacc)
        Me.Controls.Add(Me.btnCreateacc)
        Me.Controls.Add(Me.dgvRecords4)
        Me.Name = "Manage_User"
        Me.Text = "Manage_User"
        CType(Me.dgvRecords4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecords4 As DataGridView
    Friend WithEvents btnCreateacc As Button
    Friend WithEvents btnUpdateacc As Button
    Friend WithEvents btnDelacc As Button
    Friend WithEvents txtsID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnbk As Button
    Friend WithEvents btnclr As Button
End Class
