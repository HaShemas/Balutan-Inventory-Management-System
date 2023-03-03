<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfmname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.txtdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello and Welcome,"
        '
        'txtfmname
        '
        Me.txtfmname.AutoSize = True
        Me.txtfmname.Location = New System.Drawing.Point(91, 45)
        Me.txtfmname.Name = "txtfmname"
        Me.txtfmname.Size = New System.Drawing.Size(29, 15)
        Me.txtfmname.TabIndex = 1
        Me.txtfmname.Text = "N/A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Today is"
        '
        'btnproduct
        '
        Me.btnproduct.Location = New System.Drawing.Point(12, 120)
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.Size = New System.Drawing.Size(75, 23)
        Me.btnproduct.TabIndex = 3
        Me.btnproduct.Text = "Product"
        Me.btnproduct.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(12, 205)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 4
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'txtdate
        '
        Me.txtdate.AutoSize = True
        Me.txtdate.Location = New System.Drawing.Point(138, 73)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(29, 15)
        Me.txtdate.TabIndex = 5
        Me.txtdate.Text = "N/A"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 240)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnproduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfmname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfmname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnproduct As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents txtdate As Label
End Class
