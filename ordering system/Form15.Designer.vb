﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtb_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtb_ID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 44)
        Me.Panel1.TabIndex = 20
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(353, 0)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(101, 20)
        Me.txtname.TabIndex = 20
        Me.txtname.Visible = False
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
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CUSTOMER's HISTORY"
        '
        'dgv1
        '
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(56, 50)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(701, 308)
        Me.dgv1.TabIndex = 19
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(599, 364)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(158, 39)
        Me.btndelete.TabIndex = 21
        Me.btndelete.Text = "BACK"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btndelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form15"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtb_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents btndelete As Button
End Class
