<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnLog = New System.Windows.Forms.Button()
        Me.txtsID = New System.Windows.Forms.TextBox()
        Me.btnvall = New System.Windows.Forms.Button()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecords
        '
        Me.dgvRecords.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Location = New System.Drawing.Point(27, 78)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowTemplate.Height = 25
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(1049, 279)
        Me.dgvRecords.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(28, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 31)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreate.Location = New System.Drawing.Point(803, 38)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(87, 31)
        Me.btnCreate.TabIndex = 14
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(896, 38)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 31)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(989, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 31)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BtnLog
        '
        Me.BtnLog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLog.Location = New System.Drawing.Point(989, 374)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(87, 32)
        Me.BtnLog.TabIndex = 17
        Me.BtnLog.Text = "Logout"
        Me.BtnLog.UseVisualStyleBackColor = True
        '
        'txtsID
        '
        Me.txtsID.Location = New System.Drawing.Point(121, 46)
        Me.txtsID.Name = "txtsID"
        Me.txtsID.Size = New System.Drawing.Size(204, 23)
        Me.txtsID.TabIndex = 18
        '
        'btnvall
        '
        Me.btnvall.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnvall.Location = New System.Drawing.Point(27, 374)
        Me.btnvall.Name = "btnvall"
        Me.btnvall.Size = New System.Drawing.Size(83, 32)
        Me.btnvall.TabIndex = 19
        Me.btnvall.Text = "View All"
        Me.btnvall.UseVisualStyleBackColor = True
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1091, 423)
        Me.Controls.Add(Me.btnvall)
        Me.Controls.Add(Me.txtsID)
        Me.Controls.Add(Me.BtnLog)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvRecords)
        Me.Name = "Product"
        Me.Text = "Form4"
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnLog As Button
    Friend WithEvents txtsID As TextBox
    Friend WithEvents btnvall As Button
End Class
