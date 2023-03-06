<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Create_Acc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(76, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(76, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(76, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(76, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Admin", "Warehouse User"})
        Me.cmbtype.Location = New System.Drawing.Point(115, 308)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(142, 27)
        Me.cmbtype.TabIndex = 4
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncreate.Location = New System.Drawing.Point(73, 352)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 35)
        Me.btncreate.TabIndex = 5
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncancel.Location = New System.Drawing.Point(142, 391)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 35)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(86, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Create Account"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtfname.Location = New System.Drawing.Point(76, 119)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(214, 22)
        Me.txtfname.TabIndex = 8
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtlname.Location = New System.Drawing.Point(76, 163)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(214, 22)
        Me.txtlname.TabIndex = 9
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtuser.Location = New System.Drawing.Point(76, 208)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(214, 22)
        Me.txtuser.TabIndex = 10
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpass.Location = New System.Drawing.Point(76, 253)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(214, 22)
        Me.txtpass.TabIndex = 11
        '
        'btnupd
        '
        Me.btnupd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnupd.Location = New System.Drawing.Point(215, 352)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(75, 35)
        Me.btnupd.TabIndex = 12
        Me.btnupd.Text = "Update"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'txtUID
        '
        Me.txtUID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUID.Location = New System.Drawing.Point(76, 74)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.ReadOnly = True
        Me.txtUID.Size = New System.Drawing.Size(214, 22)
        Me.txtUID.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(76, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(86, 281)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 19)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Create_Acc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(370, 449)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Create_Acc"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents btncreate As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnupd As Button
    Friend WithEvents txtUID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
