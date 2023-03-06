<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.btnmanage = New System.Windows.Forms.Button()
        Me.dgvRecords2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnrep = New System.Windows.Forms.Button()
        CType(Me.dgvRecords2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmanage
        '
        Me.btnmanage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnmanage.Location = New System.Drawing.Point(12, 53)
        Me.btnmanage.Name = "btnmanage"
        Me.btnmanage.Size = New System.Drawing.Size(74, 33)
        Me.btnmanage.TabIndex = 0
        Me.btnmanage.Text = "Manage"
        Me.btnmanage.UseVisualStyleBackColor = True
        '
        'dgvRecords2
        '
        Me.dgvRecords2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvRecords2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords2.Location = New System.Drawing.Point(12, 92)
        Me.dgvRecords2.Name = "dgvRecords2"
        Me.dgvRecords2.RowTemplate.Height = 25
        Me.dgvRecords2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords2.Size = New System.Drawing.Size(764, 279)
        Me.dgvRecords2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(275, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 43)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ALL PRODUCTS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(702, 405)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 33)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnrep
        '
        Me.btnrep.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnrep.Location = New System.Drawing.Point(702, 53)
        Me.btnrep.Name = "btnrep"
        Me.btnrep.Size = New System.Drawing.Size(74, 33)
        Me.btnrep.TabIndex = 17
        Me.btnrep.Text = "Report"
        Me.btnrep.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnrep)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvRecords2)
        Me.Controls.Add(Me.btnmanage)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.dgvRecords2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnmanage As Button
    Friend WithEvents dgvRecords2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnrep As Button
End Class
