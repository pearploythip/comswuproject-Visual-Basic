Public Class frm_manage_coffee
    Private Sub refresh_coffee()
        cbx_select_type.SelectedIndex = 0
        oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee"
        dgv_coffee.DataSource = cmd_excuteToDataTable()
        change_datagrid_column()
    End Sub

    Public Sub change_datagrid_column()
        Dim column_text() As String = {"ID", "Name", "Type", "Image"}
        For i As Integer = 0 To dgv_coffee.ColumnCount - 1
            dgv_coffee.Columns(i).HeaderText = column_text(i)
        Next
    End Sub

    Public Sub clear_form()
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_price.Text = ""
        cbx_add_type.SelectedItem = Nothing
        txt_search.Text = ""
        pic_add.Image = Nothing
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If confirm("Do you want to add new menu?") = vbNo Then Return

        If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_price.Text = "" Or cbx_add_type.SelectedItem Is Nothing Then
            msg_error("Please fill in all blanks.")
            Return
        End If
        If Not IsNumeric(txt_add_price.Text) Then
            msg_error("Please fill only numberic.")
            Return
        End If


        If pic_add.Image Is Nothing Then
            oledb = "insert into coffee(coffee_id, coffee_name, coffee_category,coffee_price) values(@id,@name,@cat,@price)"
        Else
            oledb = "insert into coffee(coffee_id, coffee_name, coffee_category,coffee_price,coffee_image) values(@id,@name,@cat,@price,@img)"
        End If
        cmd = New OleDb.OleDbCommand(oledb, cn)
        With cmd
            .Parameters.Clear()
            .Parameters.AddWithValue("id", txt_add_id.Text)
            .Parameters.AddWithValue("name", txt_add_name.Text)
            .Parameters.AddWithValue("cat", cbx_add_type.SelectedItem.ToString)
            .Parameters.AddWithValue("price", txt_add_price.Text)
            If Not pic_add.Image Is Nothing Then
                .Parameters.AddWithValue("img", convert_PictureBox_toDatabase(pic_add))
            End If
            If .ExecuteNonQuery = 0 Then
                msg_error("Adding menu is fail!")
            Else
                msg_ok("Adding menu is successfull")
                refresh_coffee()
                clear_form()
                frm_coffeeSale.refresh_coffee()
            End If
        End With

    End Sub

    Private Sub btn_select_pic_Click(sender As Object, e As EventArgs) Handles btn_select_pic.Click
        If OpenFile_coffee.ShowDialog = DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFile_coffee.FileName)
            pic_add.Image = img
        End If
    End Sub



    Private Sub frm_manage_coffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_coffeeSale.cbx_select_type.SelectedIndex = 0
        refresh_coffee()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If cbx_select_type.SelectedIndex = 0 Then
            oledb = "select coffee_id, coffee_name, coffee_category, coffee_image from coffee where coffee_id like '%" & txt_search.Text & "%' or coffee_name like '%" & txt_search.Text & "%'"
            dgv_coffee.DataSource = cmd_excuteToDataTable()
            change_datagrid_column()
        Else
            oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee where coffee_category = '%" & cbx_select_type.SelectedItem.ToString & "%' AND coffee_id like '%" & txt_search.Text & "%' OR coffee_name like '%" & txt_search.Text & "%'"
            dgv_coffee.DataSource = cmd_excuteToDataTable()
            change_datagrid_column()
        End If
    End Sub

    Private Sub cbo_select_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_select_type.SelectedIndexChanged
        If cbx_select_type.SelectedIndex = 0 Then
            oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee"
            dgv_coffee.DataSource = cmd_excuteToDataTable()
            change_datagrid_column()
        Else
            oledb = "select coffee_id, coffee_name, coffee_category,coffee_image from coffee where coffee_category = '" & cbx_select_type.SelectedItem.ToString & "'"
            dgv_coffee.DataSource = cmd_excuteToDataTable()
            change_datagrid_column()
        End If
    End Sub

    Private Sub dgv_coffee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_coffee.CellClick
        Dim select_row As Integer = dgv_coffee.CurrentRow.Index
        Dim coffee_id As String = dgv_coffee.Item(0, select_row).Value
        oledb = "select * from coffee where coffee_id='" & coffee_id & "'"
        Dim data_keep As DataTable = cmd_excuteToDataTable()
        txt_edit_id.Text = data_keep.Rows(0)("coffee_id")
        txt_edit_name.Text = data_keep.Rows(0)("coffee_name")
        txt_edit_price.Text = data_keep.Rows(0)("coffee_price")

        If data_keep.Rows(0)("coffee_category").ToString = "Hot Drinks" Then
            cbx_edit_type.SelectedIndex = 0
        ElseIf data_keep.Rows(0)("coffee_category").ToString = "Coolers" Then
            cbx_edit_type.SelectedIndex = 1
        ElseIf data_keep.Rows(0)("coffee_category").ToString = "Tea&Greentea" Then
            cbx_edit_type.SelectedIndex = 2
        ElseIf data_keep.Rows(0)("coffee_category").ToString = "Sweet Bakery" Then
            cbx_edit_type.SelectedIndex = 3
        End If

        Dim img() As Byte = data_keep.Rows(0)("coffee_image")
        pic_edit.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))

    End Sub

    Private Sub btn_select_edit_pic_Click(sender As Object, e As EventArgs) Handles btn_select_edit_pic.Click
        If OpenFile_coffee.ShowDialog = DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(OpenFile_coffee.FileName)
            pic_edit.Image = img
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If confirm("Do you want to edit menu?") = vbNo Then Return
        If txt_edit_id.Text = "" Or txt_edit_name.Text = "" Or txt_edit_price.Text = "" Then
            msg_error("Please fill in all blanks.")
            Return
        End If

        If Not IsNumeric(txt_edit_price.Text) Then
            msg_error("Please fill only numberic.")
            Return
        End If

        If pic_edit.Image Is Nothing Then
            MessageBox.Show("Please select image.", "Coffee", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        oledb = "update coffee set coffee_name=@name, coffee_price=@price, coffee_category=@cat, coffee_image=@img where coffee_id=@id"

        cmd = New OleDb.OleDbCommand(oledb, cn)
        With cmd

            .Parameters.AddWithValue("name", txt_edit_name.Text)
            .Parameters.AddWithValue("price", txt_edit_price.Text)
            .Parameters.AddWithValue("cat", cbx_edit_type.SelectedItem.ToString)
            .Parameters.AddWithValue("img", convert_PictureBox_toDatabase(pic_edit))
            .Parameters.AddWithValue("id", txt_edit_id.Text)

            If .ExecuteNonQuery() = 0 Then
                MsgBox("Editing menu is fail!")
            Else
                msg_ok("Editing menu is successfull")
                refresh_coffee()
                frm_coffeeSale.refresh_coffee()

            End If
        End With


    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_confirm.Text <> "confirm" Then
            msg_error("Please fill 'comfirm' in textbox")
            txt_confirm.Text = ""
            txt_confirm.Select()
            Return
        End If
        Dim select_id As Integer = dgv_coffee.CurrentRow.Index
        Dim coffee_id As String = dgv_coffee.Item(0, select_id).Value
        oledb = "delete from coffee where coffee_id='" & coffee_id & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Deleting menu is fail!")
        Else
            msg_ok("Deleting menu is successfull")
            txt_confirm.Text = ""
            refresh_coffee()
            frm_coffeeSale.refresh_coffee()
        End If



    End Sub


End Class