<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtus = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnverify = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.grb2 = New System.Windows.Forms.GroupBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtU_cpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtU_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtU_us = New System.Windows.Forms.TextBox()
        Me.grb3 = New System.Windows.Forms.GroupBox()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.grb1.SuspendLayout()
        Me.grb2.SuspendLayout()
        Me.grb3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtus
        '
        Me.txtus.Location = New System.Drawing.Point(537, 79)
        Me.txtus.Name = "txtus"
        Me.txtus.Size = New System.Drawing.Size(134, 20)
        Me.txtus.TabIndex = 25
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(537, 113)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(134, 20)
        Me.txtpass.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "FORGOT PASSWORD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 44)
        Me.Panel1.TabIndex = 1
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.btncancel)
        Me.grb1.Controls.Add(Me.btnverify)
        Me.grb1.Controls.Add(Me.DateTimePicker1)
        Me.grb1.Controls.Add(Me.Label4)
        Me.grb1.Controls.Add(Me.Label5)
        Me.grb1.Controls.Add(Me.Label6)
        Me.grb1.Controls.Add(Me.txtEmail)
        Me.grb1.Controls.Add(Me.txtname)
        Me.grb1.Location = New System.Drawing.Point(12, 50)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(388, 219)
        Me.grb1.TabIndex = 27
        Me.grb1.TabStop = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btncancel.Location = New System.Drawing.Point(198, 177)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(190, 36)
        Me.btncancel.TabIndex = 40
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnverify
        '
        Me.btnverify.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnverify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnverify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnverify.Location = New System.Drawing.Point(0, 177)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(190, 36)
        Me.btnverify.TabIndex = 39
        Me.btnverify.Text = "VERIFY"
        Me.btnverify.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(53, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 38
        Me.DateTimePicker1.Value = New Date(2021, 12, 2, 12, 59, 5, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "BIRTHDATE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "EMAIL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "NAME:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(53, 82)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(211, 20)
        Me.txtEmail.TabIndex = 34
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(53, 32)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(211, 20)
        Me.txtname.TabIndex = 33
        '
        'grb2
        '
        Me.grb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.grb2.Controls.Add(Me.btnupdate)
        Me.grb2.Controls.Add(Me.Label3)
        Me.grb2.Controls.Add(Me.txtU_cpass)
        Me.grb2.Controls.Add(Me.Label2)
        Me.grb2.Controls.Add(Me.txtU_pass)
        Me.grb2.Controls.Add(Me.Label1)
        Me.grb2.Controls.Add(Me.txtU_us)
        Me.grb2.Location = New System.Drawing.Point(217, 36)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(192, 185)
        Me.grb2.TabIndex = 28
        Me.grb2.TabStop = False
        Me.grb2.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnupdate.Location = New System.Drawing.Point(64, 154)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(68, 22)
        Me.btnupdate.TabIndex = 41
        Me.btnupdate.Text = "SEND CODE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "CONFIRM PASSWORD"
        '
        'txtU_cpass
        '
        Me.txtU_cpass.Location = New System.Drawing.Point(32, 128)
        Me.txtU_cpass.Name = "txtU_cpass"
        Me.txtU_cpass.Size = New System.Drawing.Size(130, 20)
        Me.txtU_cpass.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "PASSWORD"
        '
        'txtU_pass
        '
        Me.txtU_pass.Location = New System.Drawing.Point(32, 80)
        Me.txtU_pass.Name = "txtU_pass"
        Me.txtU_pass.Size = New System.Drawing.Size(130, 20)
        Me.txtU_pass.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "USERNAME"
        '
        'txtU_us
        '
        Me.txtU_us.Location = New System.Drawing.Point(32, 33)
        Me.txtU_us.Name = "txtU_us"
        Me.txtU_us.Size = New System.Drawing.Size(130, 20)
        Me.txtU_us.TabIndex = 46
        '
        'grb3
        '
        Me.grb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.grb3.Controls.Add(Me.btnlast)
        Me.grb3.Controls.Add(Me.Label8)
        Me.grb3.Controls.Add(Me.txtcode)
        Me.grb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.grb3.Location = New System.Drawing.Point(217, 13)
        Me.grb3.Name = "grb3"
        Me.grb3.Size = New System.Drawing.Size(202, 81)
        Me.grb3.TabIndex = 29
        Me.grb3.TabStop = False
        Me.grb3.Text = "ENTER THE VERIFICATION CODE"
        Me.grb3.Visible = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnlast.Location = New System.Drawing.Point(64, 49)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(68, 22)
        Me.btnlast.TabIndex = 54
        Me.btnlast.Text = "VERIFY"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 53
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(30, 23)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(130, 20)
        Me.txtcode.TabIndex = 52
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 281)
        Me.Controls.Add(Me.grb3)
        Me.Controls.Add(Me.grb2)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtus)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        Me.grb2.ResumeLayout(False)
        Me.grb2.PerformLayout()
        Me.grb3.ResumeLayout(False)
        Me.grb3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtus As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grb1 As GroupBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnverify As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents grb2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtU_cpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtU_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtU_us As TextBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents grb3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents btnlast As Button
End Class
