<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtuserID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.cmbcat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPname = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstocks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btndown = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtProdID)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtuserID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 46)
        Me.Panel1.TabIndex = 18
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(568, 13)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.ReadOnly = True
        Me.txtProdID.Size = New System.Drawing.Size(26, 20)
        Me.txtProdID.TabIndex = 49
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(534, 12)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(26, 20)
        Me.txtname.TabIndex = 48
        '
        'txtuserID
        '
        Me.txtuserID.Location = New System.Drawing.Point(489, 11)
        Me.txtuserID.Name = "txtuserID"
        Me.txtuserID.ReadOnly = True
        Me.txtuserID.Size = New System.Drawing.Size(26, 20)
        Me.txtuserID.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "WELCOME TO MJC TRADING & MANUFACTURING"
        '
        'dgv1
        '
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(77, 80)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(703, 191)
        Me.dgv1.TabIndex = 19
        '
        'cmbcat
        '
        Me.cmbcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Location = New System.Drawing.Point(611, 53)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(169, 21)
        Me.cmbcat.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(531, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "CATEGORY:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Window
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 557)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(85, 28)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Log Out"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(430, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "TOTAL"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(372, 540)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(158, 20)
        Me.txttotal.TabIndex = 52
        '
        'txtquan
        '
        Me.txtquan.Location = New System.Drawing.Point(172, 387)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.ReadOnly = True
        Me.txtquan.Size = New System.Drawing.Size(123, 20)
        Me.txtquan.TabIndex = 65
        Me.txtquan.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "QUANTITY:"
        '
        'lblid
        '
        Me.lblid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(493, 489)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(14, 15)
        Me.lblid.TabIndex = 63
        Me.lblid.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "PRODUCT ID #:"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(583, 387)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(158, 20)
        Me.txtprice.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(546, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "PRICE:"
        '
        'lblPname
        '
        Me.lblPname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPname.AutoSize = True
        Me.lblPname.Font = New System.Drawing.Font("Night DEMO", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPname.Location = New System.Drawing.Point(492, 511)
        Me.lblPname.Name = "lblPname"
        Me.lblPname.Size = New System.Drawing.Size(0, 23)
        Me.lblPname.TabIndex = 59
        Me.lblPname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(169, 320)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.Size = New System.Drawing.Size(161, 44)
        Me.txtdesc.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "DESCRIPTION:"
        '
        'txtstocks
        '
        Me.txtstocks.Location = New System.Drawing.Point(583, 344)
        Me.txtstocks.Name = "txtstocks"
        Me.txtstocks.ReadOnly = True
        Me.txtstocks.Size = New System.Drawing.Size(158, 20)
        Me.txtstocks.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "STOCKS:"
        '
        'btnorder
        '
        Me.btnorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnorder.Location = New System.Drawing.Point(355, 444)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(190, 36)
        Me.btnorder.TabIndex = 54
        Me.btnorder.Text = "PLACE ORDER"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(357, 277)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(184, 160)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 53
        Me.PB.TabStop = False
        '
        'btnup
        '
        Me.btnup.Image = CType(resources.GetObject("btnup.Image"), System.Drawing.Image)
        Me.btnup.Location = New System.Drawing.Point(301, 371)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(22, 21)
        Me.btnup.TabIndex = 66
        Me.btnup.UseVisualStyleBackColor = True
        '
        'btndown
        '
        Me.btndown.Image = CType(resources.GetObject("btndown.Image"), System.Drawing.Image)
        Me.btndown.Location = New System.Drawing.Point(301, 398)
        Me.btndown.Name = "btndown"
        Me.btndown.Size = New System.Drawing.Size(22, 19)
        Me.btndown.TabIndex = 67
        Me.btndown.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(777, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(37, 44)
        Me.Button1.TabIndex = 68
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(733, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(38, 46)
        Me.Button2.TabIndex = 69
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 583)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndown)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPname)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstocks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbcat)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form12"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents cmbcat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtuserID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtquan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPname As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtstocks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnorder As Button
    Friend WithEvents PB As PictureBox
    Friend WithEvents btnup As Button
    Friend WithEvents btndown As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtProdID As TextBox
End Class
