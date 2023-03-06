<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.txtpID = New System.Windows.Forms.TextBox()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.txtsprice = New System.Windows.Forms.TextBox()
        Me.cmbcat = New System.Windows.Forms.ComboBox()
        Me.cmbstat = New System.Windows.Forms.ComboBox()
        Me.cmbintype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.txtusID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtpID
        '
        Me.txtpID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpID.Location = New System.Drawing.Point(53, 100)
        Me.txtpID.Name = "txtpID"
        Me.txtpID.ReadOnly = True
        Me.txtpID.Size = New System.Drawing.Size(180, 26)
        Me.txtpID.TabIndex = 0
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpname.Location = New System.Drawing.Point(53, 151)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(180, 26)
        Me.txtpname.TabIndex = 1
        '
        'txtsprice
        '
        Me.txtsprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtsprice.Location = New System.Drawing.Point(53, 202)
        Me.txtsprice.Name = "txtsprice"
        Me.txtsprice.Size = New System.Drawing.Size(180, 26)
        Me.txtsprice.TabIndex = 2
        '
        'cmbcat
        '
        Me.cmbcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Protein", "Drinks"})
        Me.cmbcat.Location = New System.Drawing.Point(53, 254)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(180, 27)
        Me.cmbcat.TabIndex = 3
        '
        'cmbstat
        '
        Me.cmbstat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbstat.FormattingEnabled = True
        Me.cmbstat.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbstat.Location = New System.Drawing.Point(53, 360)
        Me.cmbstat.Name = "cmbstat"
        Me.cmbstat.Size = New System.Drawing.Size(180, 27)
        Me.cmbstat.TabIndex = 4
        '
        'cmbintype
        '
        Me.cmbintype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbintype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbintype.FormattingEnabled = True
        Me.cmbintype.Items.AddRange(New Object() {"Inventory", "Service"})
        Me.cmbintype.Location = New System.Drawing.Point(53, 306)
        Me.cmbintype.Name = "cmbintype"
        Me.cmbintype.Size = New System.Drawing.Size(180, 27)
        Me.cmbintype.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(53, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(53, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Selling Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(53, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(53, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Inventory Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(53, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Status:"
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncreate.Location = New System.Drawing.Point(53, 403)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(77, 32)
        Me.btncreate.TabIndex = 12
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncancel.Location = New System.Drawing.Point(108, 455)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(77, 32)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnupd
        '
        Me.btnupd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnupd.Location = New System.Drawing.Point(156, 403)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(77, 32)
        Me.btnupd.TabIndex = 14
        Me.btnupd.Text = "Update"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'txtusID
        '
        Me.txtusID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtusID.Location = New System.Drawing.Point(53, 49)
        Me.txtusID.Name = "txtusID"
        Me.txtusID.ReadOnly = True
        Me.txtusID.Size = New System.Drawing.Size(180, 26)
        Me.txtusID.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(53, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "User ID:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(297, 492)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtusID)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbintype)
        Me.Controls.Add(Me.cmbstat)
        Me.Controls.Add(Me.cmbcat)
        Me.Controls.Add(Me.txtsprice)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.txtpID)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpID As TextBox
    Friend WithEvents txtpname As TextBox
    Friend WithEvents txtsprice As TextBox
    Friend WithEvents cmbcat As ComboBox
    Friend WithEvents cmbstat As ComboBox
    Friend WithEvents cmbintype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btncreate As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnupd As Button
    Friend WithEvents txtusID As TextBox
    Friend WithEvents Label7 As Label
End Class
