<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_total
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_total))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pic_5 = New System.Windows.Forms.PictureBox()
        Me.pic_10 = New System.Windows.Forms.PictureBox()
        Me.pic_20 = New System.Windows.Forms.PictureBox()
        Me.pic_50 = New System.Windows.Forms.PictureBox()
        Me.pic_100 = New System.Windows.Forms.PictureBox()
        Me.pic_500 = New System.Windows.Forms.PictureBox()
        Me.pic_1000 = New System.Windows.Forms.PictureBox()
        Me.Cash = New System.Windows.Forms.GroupBox()
        Me.Link_resize = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_net = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lbl_show_point = New System.Windows.Forms.Label()
        Me.lbl_point = New System.Windows.Forms.Label()
        CType(Me.pic_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_1000, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cash.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total : "
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Silver
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_total.Location = New System.Drawing.Point(240, 24)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(275, 62)
        Me.txt_total.TabIndex = 1
        Me.txt_total.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(526, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "฿"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(526, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 65)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "฿"
        '
        'txt_receive
        '
        Me.txt_receive.BackColor = System.Drawing.Color.Silver
        Me.txt_receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receive.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_receive.Location = New System.Drawing.Point(240, 280)
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.Size = New System.Drawing.Size(275, 62)
        Me.txt_receive.TabIndex = 4
        Me.txt_receive.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 65)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Receive : "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(526, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 65)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "฿"
        '
        'txt_change
        '
        Me.txt_change.BackColor = System.Drawing.Color.DarkGray
        Me.txt_change.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_change.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_change.Location = New System.Drawing.Point(240, 374)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.ReadOnly = True
        Me.txt_change.Size = New System.Drawing.Size(275, 62)
        Me.txt_change.TabIndex = 7
        Me.txt_change.Text = "0"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 65)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Change : "
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Orange
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_save.Location = New System.Drawing.Point(94, 513)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(119, 54)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Confirm"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Orange
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_close.Location = New System.Drawing.Point(317, 513)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(119, 54)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'pic_5
        '
        Me.pic_5.BackColor = System.Drawing.Color.Transparent
        Me.pic_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_5.Image = Global.Project.My.Resources.Resources._5_baht
        Me.pic_5.Location = New System.Drawing.Point(312, 330)
        Me.pic_5.Name = "pic_5"
        Me.pic_5.Size = New System.Drawing.Size(80, 80)
        Me.pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_5.TabIndex = 17
        Me.pic_5.TabStop = False
        '
        'pic_10
        '
        Me.pic_10.BackColor = System.Drawing.Color.Transparent
        Me.pic_10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_10.Image = Global.Project.My.Resources.Resources._10_baht
        Me.pic_10.Location = New System.Drawing.Point(226, 330)
        Me.pic_10.Name = "pic_10"
        Me.pic_10.Size = New System.Drawing.Size(80, 80)
        Me.pic_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_10.TabIndex = 16
        Me.pic_10.TabStop = False
        '
        'pic_20
        '
        Me.pic_20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_20.Image = Global.Project.My.Resources.Resources._20
        Me.pic_20.Location = New System.Drawing.Point(26, 330)
        Me.pic_20.Name = "pic_20"
        Me.pic_20.Size = New System.Drawing.Size(180, 80)
        Me.pic_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_20.TabIndex = 15
        Me.pic_20.TabStop = False
        '
        'pic_50
        '
        Me.pic_50.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_50.Image = Global.Project.My.Resources.Resources._50s
        Me.pic_50.Location = New System.Drawing.Point(212, 193)
        Me.pic_50.Name = "pic_50"
        Me.pic_50.Size = New System.Drawing.Size(180, 80)
        Me.pic_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_50.TabIndex = 14
        Me.pic_50.TabStop = False
        '
        'pic_100
        '
        Me.pic_100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_100.Image = Global.Project.My.Resources.Resources._100
        Me.pic_100.Location = New System.Drawing.Point(26, 193)
        Me.pic_100.Name = "pic_100"
        Me.pic_100.Size = New System.Drawing.Size(180, 80)
        Me.pic_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_100.TabIndex = 13
        Me.pic_100.TabStop = False
        '
        'pic_500
        '
        Me.pic_500.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_500.Image = Global.Project.My.Resources.Resources._500s
        Me.pic_500.Location = New System.Drawing.Point(212, 81)
        Me.pic_500.Name = "pic_500"
        Me.pic_500.Size = New System.Drawing.Size(180, 80)
        Me.pic_500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_500.TabIndex = 12
        Me.pic_500.TabStop = False
        '
        'pic_1000
        '
        Me.pic_1000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_1000.Image = Global.Project.My.Resources.Resources._1000s
        Me.pic_1000.Location = New System.Drawing.Point(26, 81)
        Me.pic_1000.Name = "pic_1000"
        Me.pic_1000.Size = New System.Drawing.Size(180, 80)
        Me.pic_1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_1000.TabIndex = 11
        Me.pic_1000.TabStop = False
        '
        'Cash
        '
        Me.Cash.BackColor = System.Drawing.Color.Transparent
        Me.Cash.Controls.Add(Me.pic_5)
        Me.Cash.Controls.Add(Me.pic_10)
        Me.Cash.Controls.Add(Me.pic_20)
        Me.Cash.Controls.Add(Me.pic_50)
        Me.Cash.Controls.Add(Me.pic_100)
        Me.Cash.Controls.Add(Me.pic_500)
        Me.Cash.Controls.Add(Me.pic_1000)
        Me.Cash.Location = New System.Drawing.Point(625, 8)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(400, 499)
        Me.Cash.TabIndex = 18
        Me.Cash.TabStop = False
        Me.Cash.Text = "Cash"
        '
        'Link_resize
        '
        Me.Link_resize.AutoSize = True
        Me.Link_resize.BackColor = System.Drawing.Color.Transparent
        Me.Link_resize.Location = New System.Drawing.Point(490, 8)
        Me.Link_resize.Name = "Link_resize"
        Me.Link_resize.Size = New System.Drawing.Size(61, 13)
        Me.Link_resize.TabIndex = 19
        Me.Link_resize.TabStop = True
        Me.Link_resize.Text = "Show Cash"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(526, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 65)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "฿"
        '
        'txt_discount
        '
        Me.txt_discount.BackColor = System.Drawing.Color.Silver
        Me.txt_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_discount.Location = New System.Drawing.Point(240, 107)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.Size = New System.Drawing.Size(275, 62)
        Me.txt_discount.TabIndex = 21
        Me.txt_discount.Text = "0"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 65)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Discount : "
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(526, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 65)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "฿"
        '
        'txt_net
        '
        Me.txt_net.BackColor = System.Drawing.Color.DarkGray
        Me.txt_net.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_net.ForeColor = System.Drawing.Color.Gold
        Me.txt_net.Location = New System.Drawing.Point(240, 192)
        Me.txt_net.Name = "txt_net"
        Me.txt_net.ReadOnly = True
        Me.txt_net.Size = New System.Drawing.Size(275, 62)
        Me.txt_net.TabIndex = 24
        Me.txt_net.Text = "0"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(239, 65)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Net : "
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lbl_show_point
        '
        Me.lbl_show_point.AutoSize = True
        Me.lbl_show_point.BackColor = System.Drawing.Color.Transparent
        Me.lbl_show_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_show_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_show_point.Location = New System.Drawing.Point(391, 462)
        Me.lbl_show_point.Name = "lbl_show_point"
        Me.lbl_show_point.Size = New System.Drawing.Size(97, 33)
        Me.lbl_show_point.TabIndex = 26
        Me.lbl_show_point.Text = "Point :"
        '
        'lbl_point
        '
        Me.lbl_point.BackColor = System.Drawing.Color.White
        Me.lbl_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_point.ForeColor = System.Drawing.Color.Red
        Me.lbl_point.Location = New System.Drawing.Point(493, 450)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(90, 57)
        Me.lbl_point.TabIndex = 28
        Me.lbl_point.Text = "0"
        Me.lbl_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.pastel_diamond_pattern_vector
        Me.ClientSize = New System.Drawing.Size(595, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_point)
        Me.Controls.Add(Me.lbl_show_point)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_net)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Link_resize)
        Me.Controls.Add(Me.Cash)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_change)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_receive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_total"
        Me.Text = "Calculate"
        CType(Me.pic_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_1000, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cash.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_receive As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_change As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents pic_1000 As PictureBox
    Friend WithEvents pic_500 As PictureBox
    Friend WithEvents pic_50 As PictureBox
    Friend WithEvents pic_100 As PictureBox
    Friend WithEvents pic_10 As PictureBox
    Friend WithEvents pic_20 As PictureBox
    Friend WithEvents pic_5 As PictureBox
    Friend WithEvents Cash As GroupBox
    Friend WithEvents Link_resize As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_net As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lbl_show_point As Label
    Friend WithEvents lbl_point As Label
End Class
