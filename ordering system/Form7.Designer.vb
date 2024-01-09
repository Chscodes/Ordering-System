<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtb_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 50)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(701, 220)
        Me.dgv1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtb_ID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 44)
        Me.Panel1.TabIndex = 3
        '
        'txtb_ID
        '
        Me.txtb_ID.Location = New System.Drawing.Point(348, 21)
        Me.txtb_ID.Name = "txtb_ID"
        Me.txtb_ID.ReadOnly = True
        Me.txtb_ID.Size = New System.Drawing.Size(101, 20)
        Me.txtb_ID.TabIndex = 19
        Me.txtb_ID.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ADDING PRODUCTS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 39)
        Me.Panel2.TabIndex = 17
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(484, 0)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(242, 39)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnupdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnupdate.Location = New System.Drawing.Point(242, 0)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(242, 39)
        Me.btnupdate.TabIndex = 16
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(0, 0)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(242, 39)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CATEGORY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "PRODUCT NAME:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(35, 341)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(160, 20)
        Me.txtname.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "PRODUCT PRICE"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(35, 387)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(160, 20)
        Me.txtprice.TabIndex = 22
        '
        'cmb_cat
        '
        Me.cmb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(35, 294)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(160, 21)
        Me.cmb_cat.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "PRODUCT DESCRIPTION:"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(302, 294)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(328, 72)
        Me.txtdesc.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "STOCKS:"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(35, 427)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(160, 20)
        Me.txtstock.TabIndex = 27
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(426, 372)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(204, 75)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 29
        Me.PB.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "PRODUCT IMAGE:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(319, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 19)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(319, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 19)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(553, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox1.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(446, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "ADVANCE FILTER:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 492)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.cmb_cat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtb_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents cmb_cat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents PB As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
End Class
