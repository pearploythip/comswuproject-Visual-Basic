Public Class frm_coffeeSale
    Private Sub frm_coffeeSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_select_type.SelectedIndex = 0
        refresh_coffee()
        generate_saleID()
        get_datenow()





    End Sub

    Public Sub total_price()
        txt_total.Text = Sum_Column_Currency(listview_sale, 6)
    End Sub
    Public Sub get_datenow()
        lbl_date_sale.Text = Date.Today
    End Sub



    Public Sub generate_saleID()
        Try
            oledb = "select max(sale_id) from sale_table"
            Dim i As Integer = cmd_excuteScalar()
            i = i + 1
            'IV-2559/00001'
            lbl_sale_ID.Text = "IV." & Date.Now.Year + 543 & "/" & i.ToString.PadLeft(5, "0")


        Catch ex As Exception
            lbl_sale_ID.Text = "IV." & Date.Now.Year & "/00001"
        End Try



    End Sub






    Public Sub refresh_coffee()
        If cbx_select_type.SelectedIndex = 0 Then
            oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee"
        Else
            oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee where coffee_category = '" & cbx_select_type.SelectedItem.ToString & "'"
        End If
        Dim data_table As DataTable = cmd_excuteToDataTable()
        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub

    Private Sub cbx_select_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_select_type.SelectedIndexChanged
        refresh_coffee()
    End Sub
    Public Sub search_coffee()
        If cbx_select_type.SelectedIndex = 0 Then
            oledb = String.Format("select coffee_id, coffee_name, coffee_category,coffee_image from coffee where coffee_id like '%{0}%' OR coffee_name like '%{0}%'", txt_search.Text)
        Else
            oledb = String.Format("select coffee_id, coffee_name, coffee_category,coffee_image from coffee where coffee_category = '" & cbx_select_type.SelectedItem.ToString & "' AND coffee_id like '%{0}%'OR coffee_name like '%{0}%'", txt_search.Text)
        End If
        Dim data_table As DataTable = cmd_excuteToDataTable()
        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub



    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyData = Keys.Enter Then
            search_coffee()
        End If
    End Sub

    Private Sub listview_coffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_coffee.SelectedIndexChanged
        Dim select_coffee As String = listview_coffee.FocusedItem.Text
        Dim coffee_split() As String = select_coffee.Split("|")
        coffee_split(0) = coffee_split(0).ToString.Trim


        oledb = "select * from coffee where coffee_id = '" & coffee_split(0) & "'"
        Dim data_table As DataTable = cmd_excuteToDataTable()

        Dim price As Integer = data_table.Rows(0)("coffee_price")
        Dim coffee_id, coffee_name, coffee_type As String
        coffee_id = data_table.Rows(0)("coffee_id")
        coffee_name = data_table.Rows(0)("coffee_name")
        coffee_type = data_table.Rows(0)("coffee_category")

        With frm_select_price
            .lbl_price.Text = price
            .lbl_coffee_id.Text = coffee_id
            .lbl_coffee_name.Text = coffee_name
            .lbl_coffee_type.Text = coffee_type
        End With

        frm_select_price.TopMost = True
        frm_select_price.Show()
        frm_select_price.txt_amount.Text = ""




    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_coffee_id.Text = "" Or txt_coffee_amount.Text = "" Then
            msg_error("Please fill in ID & amount")
            Return
        End If
        oledb = "select * from coffee where coffee_id = '" & txt_coffee_id.Text & "'"
        Dim dts As DataTable = cmd_excuteToDataTable()
        Dim coffee_type As String = dts.Rows(0)("coffee_category")

        Dim arr(7) As String
        arr(0) = listview_coffee.Items.Count + 1
        arr(1) = dts.Rows(0)("coffee_id")
        arr(2) = dts.Rows(0)("coffee_name")
        If coffee_type = "Sweet Bakery" Then
            arr(3) = "Pieces"
        Else
            arr(3) = "Cups"
        End If
        arr(4) = Val(txt_coffee_amount.Text)
        arr(5) = dts.Rows(0)("coffee_price")
        arr(6) = arr(4) * arr(5)
        Dim itm As New ListViewItem(arr)
        listview_sale.Items.Add(itm)
        total_price()


    End Sub

    Private Sub txt_coffee_id_Leave(sender As Object, e As EventArgs) Handles txt_coffee_id.Leave
        oledb = "select * from coffee where coffee_id = '" & txt_coffee_id.Text & "'"
        Dim i As Integer = cmd_excuteScalar()
        If i <= 0 And txt_coffee_id.Text <> "" Then
            msg_error("Your ID is invalid , Please correct the id or leave blank.")
            txt_coffee_id.Select()
        End If


    End Sub

    Private Sub txt_coffee_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_coffee_id.KeyDown
        If e.KeyData = Keys.Enter Then txt_coffee_amount.Select()

    End Sub

    Private Sub btn_deleteall_Click(sender As Object, e As EventArgs) Handles btn_deleteall.Click
        If confirm("Do you want to delete all list?") = vbNo Then Return
        listview_sale.Items.Clear()
        txt_total.Text = "0.00"
    End Sub

    Private Sub btn_selectdelete_Click(sender As Object, e As EventArgs) Handles btn_selectdelete.Click
        If confirm("Do you want to delete selected row?") = vbYes Then
            listview_sale.Items.Remove(listview_sale.FocusedItem)
            total_price()

        End If
    End Sub

    Private Sub btn_purchase_Click(sender As Object, e As EventArgs) Handles btn_purchase.Click
        With frm_total
            .txt_total.Text = txt_total.Text
            .txt_discount.Text = lbl_discount.Text
            .txt_net.Text = txt_total.Text - Val(.txt_discount.Text)

            Dim point As Integer = .txt_net.Text / 100
            .lbl_point.Text = point

            If lbl_username.Text = "xxxx" Or lbl_name.Text = "xxxx" Then
                .lbl_point.Visible = False
                .lbl_show_point.Visible = False

            Else
                .lbl_point.Visible = True
                .lbl_show_point.Visible = True
            End If


            .txt_receive.Text = ""
            .txt_receive.Select()
            .Show()
            .Activate()
        End With



    End Sub

    Private Sub btn_promotion_Click(sender As Object, e As EventArgs) Handles btn_promotion.Click
        With frm_usepromotion


            If lbl_username.Text = "xxxx" Or lbl_name.Text = "xxxx" Then
                .lbl_point.Visible = False
                .lbl_show_point.Visible = False
                .btn_use_point.Visible = False
                .txt_use_point.Visible = False
                .txt_coupon_code.Visible = False
                .lbl_coupon_code.Visible = False


            Else
                .lbl_point.Visible = True
                .lbl_show_point.Visible = True
                .btn_use_point.Visible = True
                .txt_use_point.Visible = True
                .txt_coupon_code.Visible = True
                .lbl_coupon_code.Visible = True

            End If
            .Show()
            .Activate()
            .txt_coupon.Select()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub link_select_customer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_select_customer.LinkClicked
        frm_select_customer.Show()
        frm_select_customer.Activate()
    End Sub

    Private Sub link_clear_customer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_clear_customer.LinkClicked
        lbl_username.Text = "xxxx"
        lbl_name.Text = "xxxx"
        lbl_point.Text = "0"
    End Sub


End Class