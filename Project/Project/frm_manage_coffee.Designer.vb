<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manage_coffee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_coffee = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.addmenu = New System.Windows.Forms.TabPage()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_select_pic = New System.Windows.Forms.Button()
        Me.pic_add = New System.Windows.Forms.PictureBox()
        Me.cbx_add_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_add_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_select_edit_pic = New System.Windows.Forms.Button()
        Me.pic_edit = New System.Windows.Forms.PictureBox()
        Me.cbx_edit_type = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_edit_price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_edit_id = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_confirm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFile_coffee = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_select_type = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_coffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.addmenu.SuspendLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_coffee
        '
        Me.dgv_coffee.AllowUserToAddRows = False
        Me.dgv_coffee.AllowUserToDeleteRows = False
        Me.dgv_coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_coffee.GridColor = System.Drawing.SystemColors.Info
        Me.dgv_coffee.Location = New System.Drawing.Point(12, 68)
        Me.dgv_coffee.Name = "dgv_coffee"
        Me.dgv_coffee.ReadOnly = True
        Me.dgv_coffee.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_coffee.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_coffee.RowTemplate.Height = 80
        Me.dgv_coffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_coffee.Size = New System.Drawing.Size(410, 471)
        Me.dgv_coffee.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(65, 31)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(222, 27)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.addmenu)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(440, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 438)
        Me.TabControl1.TabIndex = 3
        '
        'addmenu
        '
        Me.addmenu.Controls.Add(Me.btn_addnew)
        Me.addmenu.Controls.Add(Me.btn_select_pic)
        Me.addmenu.Controls.Add(Me.pic_add)
        Me.addmenu.Controls.Add(Me.cbx_add_type)
        Me.addmenu.Controls.Add(Me.Label5)
        Me.addmenu.Controls.Add(Me.txt_add_price)
        Me.addmenu.Controls.Add(Me.Label4)
        Me.addmenu.Controls.Add(Me.txt_add_name)
        Me.addmenu.Controls.Add(Me.Label3)
        Me.addmenu.Controls.Add(Me.txt_add_id)
        Me.addmenu.Controls.Add(Me.Label2)
        Me.addmenu.Location = New System.Drawing.Point(4, 22)
        Me.addmenu.Name = "addmenu"
        Me.addmenu.Padding = New System.Windows.Forms.Padding(3)
        Me.addmenu.Size = New System.Drawing.Size(358, 412)
        Me.addmenu.TabIndex = 0
        Me.addmenu.Text = "Add Menu"
        Me.addmenu.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(125, 344)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(99, 30)
        Me.btn_addnew.TabIndex = 10
        Me.btn_addnew.Text = "Save"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'btn_select_pic
        '
        Me.btn_select_pic.Location = New System.Drawing.Point(222, 240)
        Me.btn_select_pic.Name = "btn_select_pic"
        Me.btn_select_pic.Size = New System.Drawing.Size(75, 42)
        Me.btn_select_pic.TabIndex = 9
        Me.btn_select_pic.Text = "Select Image"
        Me.btn_select_pic.UseVisualStyleBackColor = True
        '
        'pic_add
        '
        Me.pic_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_add.Location = New System.Drawing.Point(76, 205)
        Me.pic_add.Name = "pic_add"
        Me.pic_add.Size = New System.Drawing.Size(100, 100)
        Me.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_add.TabIndex = 8
        Me.pic_add.TabStop = False
        '
        'cbx_add_type
        '
        Me.cbx_add_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_add_type.FormattingEnabled = True
        Me.cbx_add_type.Items.AddRange(New Object() {"Hot Drinks", "Coolers", "Tea&Greentea", "Sweet Bakery"})
        Me.cbx_add_type.Location = New System.Drawing.Point(87, 144)
        Me.cbx_add_type.Name = "cbx_add_type"
        Me.cbx_add_type.Size = New System.Drawing.Size(160, 21)
        Me.cbx_add_type.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Type  :"
        '
        'txt_add_price
        '
        Me.txt_add_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_price.Location = New System.Drawing.Point(87, 102)
        Me.txt_add_price.Multiline = True
        Me.txt_add_price.Name = "txt_add_price"
        Me.txt_add_price.Size = New System.Drawing.Size(160, 25)
        Me.txt_add_price.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price  :"
        '
        'txt_add_name
        '
        Me.txt_add_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_name.Location = New System.Drawing.Point(87, 61)
        Me.txt_add_name.Multiline = True
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(160, 25)
        Me.txt_add_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name  :"
        '
        'txt_add_id
        '
        Me.txt_add_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_id.Location = New System.Drawing.Point(87, 21)
        Me.txt_add_id.Multiline = True
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(160, 25)
        Me.txt_add_id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Controls.Add(Me.btn_select_edit_pic)
        Me.TabPage2.Controls.Add(Me.pic_edit)
        Me.TabPage2.Controls.Add(Me.cbx_edit_type)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_edit_price)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_edit_name)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_edit_id)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(358, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit Menu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(124, 344)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(99, 30)
        Me.btn_edit.TabIndex = 21
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_select_edit_pic
        '
        Me.btn_select_edit_pic.Location = New System.Drawing.Point(264, 183)
        Me.btn_select_edit_pic.Name = "btn_select_edit_pic"
        Me.btn_select_edit_pic.Size = New System.Drawing.Size(75, 42)
        Me.btn_select_edit_pic.TabIndex = 20
        Me.btn_select_edit_pic.Text = "Select Image"
        Me.btn_select_edit_pic.UseVisualStyleBackColor = True
        '
        'pic_edit
        '
        Me.pic_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_edit.Location = New System.Drawing.Point(87, 183)
        Me.pic_edit.Name = "pic_edit"
        Me.pic_edit.Size = New System.Drawing.Size(156, 127)
        Me.pic_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_edit.TabIndex = 19
        Me.pic_edit.TabStop = False
        '
        'cbx_edit_type
        '
        Me.cbx_edit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_edit_type.FormattingEnabled = True
        Me.cbx_edit_type.Items.AddRange(New Object() {"Hot Drinks", "Coolers", "Tea&Greentea", "Sweet Bakery"})
        Me.cbx_edit_type.Location = New System.Drawing.Point(87, 144)
        Me.cbx_edit_type.Name = "cbx_edit_type"
        Me.cbx_edit_type.Size = New System.Drawing.Size(160, 21)
        Me.cbx_edit_type.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Type  :"
        '
        'txt_edit_price
        '
        Me.txt_edit_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_price.Location = New System.Drawing.Point(87, 102)
        Me.txt_edit_price.Multiline = True
        Me.txt_edit_price.Name = "txt_edit_price"
        Me.txt_edit_price.Size = New System.Drawing.Size(160, 25)
        Me.txt_edit_price.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price  :"
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_name.Location = New System.Drawing.Point(87, 61)
        Me.txt_edit_name.Multiline = True
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(160, 25)
        Me.txt_edit_name.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Name  :"
        '
        'txt_edit_id
        '
        Me.txt_edit_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_id.Location = New System.Drawing.Point(87, 21)
        Me.txt_edit_id.Multiline = True
        Me.txt_edit_id.Name = "txt_edit_id"
        Me.txt_edit_id.ReadOnly = True
        Me.txt_edit_id.Size = New System.Drawing.Size(160, 25)
        Me.txt_edit_id.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "ID :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Controls.Add(Me.txt_confirm)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(358, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delete Menu"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project.My.Resources.Resources._1140440391
        Me.PictureBox1.Location = New System.Drawing.Point(13, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Location = New System.Drawing.Point(132, 297)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(99, 30)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_confirm
        '
        Me.txt_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_confirm.Location = New System.Drawing.Point(98, 156)
        Me.txt_confirm.Multiline = True
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirm.Size = New System.Drawing.Size(160, 25)
        Me.txt_confirm.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(256, 44)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Please fill ""confirm"" to delete menu."
        '
        'OpenFile_coffee
        '
        Me.OpenFile_coffee.Filter = "JPEG|*.jpg"
        '
        'cbx_select_type
        '
        Me.cbx_select_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_select_type.FormattingEnabled = True
        Me.cbx_select_type.Items.AddRange(New Object() {"All", "Hot Drinks", "Coolers", "Tea&Greentea", "Sweet Bakery"})
        Me.cbx_select_type.Location = New System.Drawing.Point(293, 35)
        Me.cbx_select_type.Name = "cbx_select_type"
        Me.cbx_select_type.Size = New System.Drawing.Size(116, 21)
        Me.cbx_select_type.TabIndex = 11
        '
        'frm_manage_coffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.pastel_pink_cyan_pattern_37
        Me.ClientSize = New System.Drawing.Size(818, 551)
        Me.Controls.Add(Me.cbx_select_type)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.dgv_coffee)
        Me.Name = "frm_manage_coffee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Coffee"
        CType(Me.dgv_coffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.addmenu.ResumeLayout(False)
        Me.addmenu.PerformLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_coffee As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents addmenu As TabPage
    Friend WithEvents cbx_add_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_add_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_addnew As Button
    Friend WithEvents btn_select_pic As Button
    Friend WithEvents pic_add As PictureBox
    Friend WithEvents OpenFile_coffee As OpenFileDialog
    Friend WithEvents cbx_select_type As ComboBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_select_edit_pic As Button
    Friend WithEvents pic_edit As PictureBox
    Friend WithEvents cbx_edit_type As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_edit_price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_edit_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_confirm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
