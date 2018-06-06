<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_promotion
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_coupon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_coupon_add = New System.Windows.Forms.Button()
        Me.txt_coupon_add = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbl_total_1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datagrid_all = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbl_total_2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datagrid_expire = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.datagrid_all, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.datagrid_expire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(467, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(341, 327)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_condition)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btn_add)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_count)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_discount)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_coupon)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(333, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Coupon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(90, 90)
        Me.txt_condition.MaxLength = 50
        Me.txt_condition.Multiline = True
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.Size = New System.Drawing.Size(205, 67)
        Me.txt_condition.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Condition :"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Orange
        Me.btn_add.ForeColor = System.Drawing.Color.Linen
        Me.btn_add.Location = New System.Drawing.Point(136, 245)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(62, 23)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "รอบ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Baht"
        '
        'txt_count
        '
        Me.txt_count.Location = New System.Drawing.Point(90, 202)
        Me.txt_count.Multiline = True
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(108, 20)
        Me.txt_count.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จำนวนรอบ :"
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(90, 169)
        Me.txt_discount.Multiline = True
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(108, 20)
        Me.txt_discount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Discount :"
        '
        'txt_coupon
        '
        Me.txt_coupon.Location = New System.Drawing.Point(90, 14)
        Me.txt_coupon.MaxLength = 50
        Me.txt_coupon.Multiline = True
        Me.txt_coupon.Name = "txt_coupon"
        Me.txt_coupon.Size = New System.Drawing.Size(205, 67)
        Me.txt_coupon.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coupon :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Controls.Add(Me.btn_coupon_add)
        Me.TabPage2.Controls.Add(Me.txt_coupon_add)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(333, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit Coupon"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Project.My.Resources.Resources.gudetama_by_proto_netop_d8v772t
        Me.PictureBox3.Location = New System.Drawing.Point(73, 81)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 160)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 80
        Me.PictureBox3.TabStop = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.ForeColor = System.Drawing.Color.Linen
        Me.btn_delete.Location = New System.Drawing.Point(126, 247)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 36)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_coupon_add
        '
        Me.btn_coupon_add.Location = New System.Drawing.Point(240, 35)
        Me.btn_coupon_add.Name = "btn_coupon_add"
        Me.btn_coupon_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_coupon_add.TabIndex = 2
        Me.btn_coupon_add.Text = "confirm"
        Me.btn_coupon_add.UseVisualStyleBackColor = True
        '
        'txt_coupon_add
        '
        Me.txt_coupon_add.Location = New System.Drawing.Point(99, 37)
        Me.txt_coupon_add.Name = "txt_coupon_add"
        Me.txt_coupon_add.Size = New System.Drawing.Size(118, 20)
        Me.txt_coupon_add.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "เพิ่มรอบคูปอง"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 23)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(430, 327)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbl_total_1)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.datagrid_all)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(422, 301)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "All Coupon"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbl_total_1
        '
        Me.lbl_total_1.AutoSize = True
        Me.lbl_total_1.Location = New System.Drawing.Point(74, 270)
        Me.lbl_total_1.Name = "lbl_total_1"
        Me.lbl_total_1.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total_1.TabIndex = 5
        Me.lbl_total_1.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total :"
        '
        'datagrid_all
        '
        Me.datagrid_all.AllowUserToAddRows = False
        Me.datagrid_all.AllowUserToDeleteRows = False
        Me.datagrid_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_all.Location = New System.Drawing.Point(9, 13)
        Me.datagrid_all.Name = "datagrid_all"
        Me.datagrid_all.ReadOnly = True
        Me.datagrid_all.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_all.Size = New System.Drawing.Size(407, 237)
        Me.datagrid_all.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lbl_total_2)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.datagrid_expire)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(422, 301)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Coupon expires"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lbl_total_2
        '
        Me.lbl_total_2.AutoSize = True
        Me.lbl_total_2.Location = New System.Drawing.Point(73, 270)
        Me.lbl_total_2.Name = "lbl_total_2"
        Me.lbl_total_2.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total_2.TabIndex = 3
        Me.lbl_total_2.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total"
        '
        'datagrid_expire
        '
        Me.datagrid_expire.AllowUserToAddRows = False
        Me.datagrid_expire.AllowUserToDeleteRows = False
        Me.datagrid_expire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_expire.Location = New System.Drawing.Point(8, 14)
        Me.datagrid_expire.Name = "datagrid_expire"
        Me.datagrid_expire.ReadOnly = True
        Me.datagrid_expire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_expire.Size = New System.Drawing.Size(408, 235)
        Me.datagrid_expire.TabIndex = 1
        '
        'frm_promotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.rrrchev_butter_mirror_preview
        Me.ClientSize = New System.Drawing.Size(820, 407)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_promotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Promotion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.datagrid_all, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.datagrid_expire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents datagrid_all As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents datagrid_expire As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_count As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_coupon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_total_1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_coupon_add As Button
    Friend WithEvents txt_coupon_add As TextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
