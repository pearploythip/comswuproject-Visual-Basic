<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_coffeeSale
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.link_clear_customer = New System.Windows.Forms.LinkLabel()
        Me.link_select_customer = New System.Windows.Forms.LinkLabel()
        Me.lbl_point = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbx_select_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.listview_coffee = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.listview_sale = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_promotion = New System.Windows.Forms.Button()
        Me.btn_purchase = New System.Windows.Forms.Button()
        Me.btn_deleteall = New System.Windows.Forms.Button()
        Me.btn_selectdelete = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_date_sale = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_sale_ID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_coffee_amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_coffee_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Pink
        Me.Panel1.BackgroundImage = Global.Project.My.Resources.Resources._403659ebd49a6913f73465535d895039
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.listview_coffee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(501, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 551)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Pink
        Me.Panel7.BackgroundImage = Global.Project.My.Resources.Resources._403659ebd49a6913f73465535d895039
        Me.Panel7.Controls.Add(Me.link_clear_customer)
        Me.Panel7.Controls.Add(Me.link_select_customer)
        Me.Panel7.Controls.Add(Me.lbl_point)
        Me.Panel7.Controls.Add(Me.lbl_name)
        Me.Panel7.Controls.Add(Me.lbl_username)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 451)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(389, 100)
        Me.Panel7.TabIndex = 2
        '
        'link_clear_customer
        '
        Me.link_clear_customer.AutoSize = True
        Me.link_clear_customer.BackColor = System.Drawing.Color.Transparent
        Me.link_clear_customer.LinkColor = System.Drawing.Color.DeepPink
        Me.link_clear_customer.Location = New System.Drawing.Point(165, 76)
        Me.link_clear_customer.Name = "link_clear_customer"
        Me.link_clear_customer.Size = New System.Drawing.Size(31, 13)
        Me.link_clear_customer.TabIndex = 8
        Me.link_clear_customer.TabStop = True
        Me.link_clear_customer.Text = "Clear"
        '
        'link_select_customer
        '
        Me.link_select_customer.AutoSize = True
        Me.link_select_customer.BackColor = System.Drawing.Color.Transparent
        Me.link_select_customer.LinkColor = System.Drawing.Color.DeepPink
        Me.link_select_customer.Location = New System.Drawing.Point(113, 76)
        Me.link_select_customer.Name = "link_select_customer"
        Me.link_select_customer.Size = New System.Drawing.Size(37, 13)
        Me.link_select_customer.TabIndex = 7
        Me.link_select_customer.TabStop = True
        Me.link_select_customer.Text = "Select"
        '
        'lbl_point
        '
        Me.lbl_point.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_point.ForeColor = System.Drawing.Color.Red
        Me.lbl_point.Location = New System.Drawing.Point(294, 13)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(78, 57)
        Me.lbl_point.TabIndex = 6
        Me.lbl_point.Text = "0"
        Me.lbl_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(169, 52)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(32, 16)
        Me.lbl_name.TabIndex = 5
        Me.lbl_name.Text = "xxxx"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(169, 24)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(32, 16)
        Me.lbl_username.TabIndex = 4
        Me.lbl_username.Text = "xxxx"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(259, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Point :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(113, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Username :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Project.My.Resources.Resources.Customer
        Me.PictureBox1.Location = New System.Drawing.Point(19, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Project.My.Resources.Resources._403659ebd49a6913f73465535d895039
        Me.Panel2.Controls.Add(Me.cbx_select_type)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 65)
        Me.Panel2.TabIndex = 1
        '
        'cbx_select_type
        '
        Me.cbx_select_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_select_type.FormattingEnabled = True
        Me.cbx_select_type.Items.AddRange(New Object() {"All", "Hot Drinks", "Coolers", "Tea&Greentea", "Sweet Bakery"})
        Me.cbx_select_type.Location = New System.Drawing.Point(261, 31)
        Me.cbx_select_type.Name = "cbx_select_type"
        Me.cbx_select_type.Size = New System.Drawing.Size(116, 21)
        Me.cbx_select_type.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(72, 26)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(180, 29)
        Me.txt_search.TabIndex = 0
        '
        'listview_coffee
        '
        Me.listview_coffee.LargeImageList = Me.ImageList1
        Me.listview_coffee.Location = New System.Drawing.Point(19, 95)
        Me.listview_coffee.Name = "listview_coffee"
        Me.listview_coffee.Size = New System.Drawing.Size(353, 347)
        Me.listview_coffee.TabIndex = 0
        Me.listview_coffee.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(100, 70)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.listview_sale)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 551)
        Me.Panel3.TabIndex = 1
        '
        'listview_sale
        '
        Me.listview_sale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listview_sale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listview_sale.FullRowSelect = True
        Me.listview_sale.GridLines = True
        Me.listview_sale.Location = New System.Drawing.Point(0, 194)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(501, 317)
        Me.listview_sale.TabIndex = 1
        Me.listview_sale.UseCompatibleStateImageBehavior = False
        Me.listview_sale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 43
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Menu"
        Me.ColumnHeader3.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit"
        Me.ColumnHeader4.Width = 68
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "@Price"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 53
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Totalprice"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 73
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel6.Controls.Add(Me.btn_promotion)
        Me.Panel6.Controls.Add(Me.btn_purchase)
        Me.Panel6.Controls.Add(Me.btn_deleteall)
        Me.Panel6.Controls.Add(Me.btn_selectdelete)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 511)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(501, 40)
        Me.Panel6.TabIndex = 11
        '
        'btn_promotion
        '
        Me.btn_promotion.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_promotion.ForeColor = System.Drawing.Color.Ivory
        Me.btn_promotion.Location = New System.Drawing.Point(195, 6)
        Me.btn_promotion.Name = "btn_promotion"
        Me.btn_promotion.Size = New System.Drawing.Size(75, 23)
        Me.btn_promotion.TabIndex = 5
        Me.btn_promotion.Text = "Promotion"
        Me.btn_promotion.UseVisualStyleBackColor = False
        '
        'btn_purchase
        '
        Me.btn_purchase.BackColor = System.Drawing.Color.HotPink
        Me.btn_purchase.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_purchase.Location = New System.Drawing.Point(396, 6)
        Me.btn_purchase.Name = "btn_purchase"
        Me.btn_purchase.Size = New System.Drawing.Size(75, 23)
        Me.btn_purchase.TabIndex = 4
        Me.btn_purchase.Text = " Calculate"
        Me.btn_purchase.UseVisualStyleBackColor = False
        '
        'btn_deleteall
        '
        Me.btn_deleteall.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_deleteall.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_deleteall.Location = New System.Drawing.Point(103, 6)
        Me.btn_deleteall.Name = "btn_deleteall"
        Me.btn_deleteall.Size = New System.Drawing.Size(75, 23)
        Me.btn_deleteall.TabIndex = 3
        Me.btn_deleteall.Text = "Clear"
        Me.btn_deleteall.UseVisualStyleBackColor = False
        '
        'btn_selectdelete
        '
        Me.btn_selectdelete.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_selectdelete.ForeColor = System.Drawing.Color.Lavender
        Me.btn_selectdelete.Location = New System.Drawing.Point(11, 6)
        Me.btn_selectdelete.Name = "btn_selectdelete"
        Me.btn_selectdelete.Size = New System.Drawing.Size(75, 23)
        Me.btn_selectdelete.TabIndex = 2
        Me.btn_selectdelete.Text = "Delete"
        Me.btn_selectdelete.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel5.Controls.Add(Me.lbl_condition)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lbl_discount)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lbl_date_sale)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_sale_ID)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.btn_add)
        Me.Panel5.Controls.Add(Me.txt_coffee_amount)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txt_coffee_id)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(501, 94)
        Me.Panel5.TabIndex = 10
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_condition.Location = New System.Drawing.Point(273, 67)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(27, 13)
        Me.lbl_condition.TabIndex = 18
        Me.lbl_condition.Text = "xxxx"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Condition:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Baht"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_discount.Location = New System.Drawing.Point(88, 67)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(13, 13)
        Me.lbl_discount.TabIndex = 15
        Me.lbl_discount.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Discount:"
        '
        'lbl_date_sale
        '
        Me.lbl_date_sale.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date_sale.Location = New System.Drawing.Point(198, 39)
        Me.lbl_date_sale.Name = "lbl_date_sale"
        Me.lbl_date_sale.Size = New System.Drawing.Size(92, 26)
        Me.lbl_date_sale.TabIndex = 13
        Me.lbl_date_sale.Text = "xxxx"
        Me.lbl_date_sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(150, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DATE :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_sale_ID
        '
        Me.lbl_sale_ID.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_sale_ID.Location = New System.Drawing.Point(60, 39)
        Me.lbl_sale_ID.Name = "lbl_sale_ID"
        Me.lbl_sale_ID.Size = New System.Drawing.Size(84, 26)
        Me.lbl_sale_ID.TabIndex = 11
        Me.lbl_sale_ID.Text = "xxxx"
        Me.lbl_sale_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sale ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(396, 9)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_coffee_amount
        '
        Me.txt_coffee_amount.Location = New System.Drawing.Point(276, 9)
        Me.txt_coffee_amount.Multiline = True
        Me.txt_coffee_amount.Name = "txt_coffee_amount"
        Me.txt_coffee_amount.Size = New System.Drawing.Size(44, 23)
        Me.txt_coffee_amount.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(220, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_coffee_id
        '
        Me.txt_coffee_id.Location = New System.Drawing.Point(30, 12)
        Me.txt_coffee_id.MaxLength = 8
        Me.txt_coffee_id.Name = "txt_coffee_id"
        Me.txt_coffee_id.Size = New System.Drawing.Size(137, 20)
        Me.txt_coffee_id.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_total)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(501, 100)
        Me.Panel4.TabIndex = 0
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.SandyBrown
        Me.txt_total.Location = New System.Drawing.Point(0, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(501, 98)
        Me.txt_total.TabIndex = 0
        Me.txt_total.Text = "0.00"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_coffeeSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 551)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_coffeeSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoffeeSale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents listview_coffee As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_coffee_amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_coffee_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_purchase As Button
    Friend WithEvents btn_deleteall As Button
    Friend WithEvents btn_selectdelete As Button
    Friend WithEvents listview_sale As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cbx_select_type As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_date_sale As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_sale_ID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_promotion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents link_select_customer As LinkLabel
    Friend WithEvents lbl_point As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents link_clear_customer As LinkLabel
End Class
