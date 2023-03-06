<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.dgvRecords3 = New System.Windows.Forms.DataGridView()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.btnbk = New System.Windows.Forms.Button()
        CType(Me.dgvRecords3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(238, 25)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(79, 35)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'dgvRecords3
        '
        Me.dgvRecords3.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvRecords3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords3.Location = New System.Drawing.Point(18, 86)
        Me.dgvRecords3.Name = "dgvRecords3"
        Me.dgvRecords3.RowTemplate.Height = 25
        Me.dgvRecords3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords3.Size = New System.Drawing.Size(416, 215)
        Me.dgvRecords3.TabIndex = 14
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Items.AddRange(New Object() {"Protein", "Drinks"})
        Me.cmbCat.Location = New System.Drawing.Point(52, 29)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(180, 27)
        Me.cmbCat.TabIndex = 15
        '
        'btnbk
        '
        Me.btnbk.Location = New System.Drawing.Point(323, 25)
        Me.btnbk.Name = "btnbk"
        Me.btnbk.Size = New System.Drawing.Size(79, 35)
        Me.btnbk.TabIndex = 16
        Me.btnbk.Text = "Back"
        Me.btnbk.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(460, 318)
        Me.Controls.Add(Me.btnbk)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.dgvRecords3)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.dgvRecords3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents dgvRecords3 As DataGridView
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents btnbk As Button
End Class
