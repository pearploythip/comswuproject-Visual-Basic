<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_usepromotion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_coupon_code = New System.Windows.Forms.Label()
        Me.txt_coupon_code = New System.Windows.Forms.TextBox()
        Me.btn_active = New System.Windows.Forms.Button()
        Me.txt_coupon = New System.Windows.Forms.TextBox()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_point = New System.Windows.Forms.Label()
        Me.lbl_show_point = New System.Windows.Forms.Label()
        Me.btn_use_point = New System.Windows.Forms.Button()
        Me.txt_use_point = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Ivory
        Me.GroupBox1.Controls.Add(Me.lbl_coupon_code)
        Me.GroupBox1.Controls.Add(Me.txt_coupon_code)
        Me.GroupBox1.Controls.Add(Me.btn_active)
        Me.GroupBox1.Controls.Add(Me.txt_coupon)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(48, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coupon"
        '
        'lbl_coupon_code
        '
        Me.lbl_coupon_code.AutoSize = True
        Me.lbl_coupon_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coupon_code.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_coupon_code.Location = New System.Drawing.Point(120, 172)
        Me.lbl_coupon_code.Name = "lbl_coupon_code"
        Me.lbl_coupon_code.Size = New System.Drawing.Size(129, 24)
        Me.lbl_coupon_code.TabIndex = 3
        Me.lbl_coupon_code.Text = "Coupon Code"
        '
        'txt_coupon_code
        '
        Me.txt_coupon_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_coupon_code.Location = New System.Drawing.Point(132, 199)
        Me.txt_coupon_code.Multiline = True
        Me.txt_coupon_code.Name = "txt_coupon_code"
        Me.txt_coupon_code.Size = New System.Drawing.Size(100, 35)
        Me.txt_coupon_code.TabIndex = 2
        Me.txt_coupon_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_active
        '
        Me.btn_active.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_active.ForeColor = System.Drawing.Color.White
        Me.btn_active.Location = New System.Drawing.Point(144, 140)
        Me.btn_active.Name = "btn_active"
        Me.btn_active.Size = New System.Drawing.Size(75, 24)
        Me.btn_active.TabIndex = 1
        Me.btn_active.Text = "Active"
        Me.btn_active.UseVisualStyleBackColor = False
        '
        'txt_coupon
        '
        Me.txt_coupon.Location = New System.Drawing.Point(31, 19)
        Me.txt_coupon.Multiline = True
        Me.txt_coupon.Name = "txt_coupon"
        Me.txt_coupon.Size = New System.Drawing.Size(308, 106)
        Me.txt_coupon.TabIndex = 1
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.ForeColor = System.Drawing.Color.Teal
        Me.lbl_condition.Location = New System.Drawing.Point(134, 66)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(27, 13)
        Me.lbl_condition.TabIndex = 3
        Me.lbl_condition.Text = "xxxx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(67, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Discount :"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.ForeColor = System.Drawing.Color.Teal
        Me.lbl_discount.Location = New System.Drawing.Point(135, 91)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(27, 13)
        Me.lbl_discount.TabIndex = 4
        Me.lbl_discount.Text = "xxxx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(181, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Baht"
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Gold
        Me.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_confirm.Location = New System.Drawing.Point(78, 126)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(87, 38)
        Me.btn_confirm.TabIndex = 6
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Gold
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_close.Location = New System.Drawing.Point(174, 126)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(87, 38)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_point
        '
        Me.lbl_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_point.ForeColor = System.Drawing.Color.Red
        Me.lbl_point.Location = New System.Drawing.Point(78, 5)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(60, 36)
        Me.lbl_point.TabIndex = 30
        Me.lbl_point.Text = "0"
        Me.lbl_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_show_point
        '
        Me.lbl_show_point.AutoSize = True
        Me.lbl_show_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_show_point.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_show_point.Location = New System.Drawing.Point(17, 11)
        Me.lbl_show_point.Name = "lbl_show_point"
        Me.lbl_show_point.Size = New System.Drawing.Size(62, 24)
        Me.lbl_show_point.TabIndex = 29
        Me.lbl_show_point.Text = "Point :"
        '
        'btn_use_point
        '
        Me.btn_use_point.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_use_point.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_use_point.Location = New System.Drawing.Point(244, 14)
        Me.btn_use_point.Name = "btn_use_point"
        Me.btn_use_point.Size = New System.Drawing.Size(75, 23)
        Me.btn_use_point.TabIndex = 31
        Me.btn_use_point.Text = "use point"
        Me.btn_use_point.UseVisualStyleBackColor = False
        '
        'txt_use_point
        '
        Me.txt_use_point.Location = New System.Drawing.Point(153, 16)
        Me.txt_use_point.Name = "txt_use_point"
        Me.txt_use_point.Size = New System.Drawing.Size(78, 20)
        Me.txt_use_point.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox2.Controls.Add(Me.txt_use_point)
        Me.GroupBox2.Controls.Add(Me.btn_use_point)
        Me.GroupBox2.Controls.Add(Me.lbl_point)
        Me.GroupBox2.Controls.Add(Me.lbl_show_point)
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_confirm)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_discount)
        Me.GroupBox2.Controls.Add(Me.lbl_condition)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 176)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'frm_usepromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.carrots_pattern
        Me.ClientSize = New System.Drawing.Size(465, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_usepromotion"
        Me.Text = "Promotion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_active As Button
    Friend WithEvents txt_coupon As TextBox
    Friend WithEvents lbl_condition As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents lbl_point As Label
    Friend WithEvents lbl_show_point As Label
    Friend WithEvents btn_use_point As Button
    Friend WithEvents txt_use_point As TextBox
    Friend WithEvents lbl_coupon_code As Label
    Friend WithEvents txt_coupon_code As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
