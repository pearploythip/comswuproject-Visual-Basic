Imports System.Data.OleDb

Public Class frm_manage_customer
    Private Sub frm_manage_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_customer()
    End Sub

    Public Sub load_customer()
        connect()
        oledb = "select customer_username, customer_name from customer"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")
    End Sub

    Public Sub search_customer()
        connect()
        oledb = "select customer_username, customer_name from customer where customer_username like '%" & txt_search.Text & "%' or customer_password like '%" & txt_search.Text & "%' or customer_name like '%" & txt_search.Text & "%' or customer_nickname like '%" & txt_search.Text & "%' or customer_address like '%" & txt_search.Text & "%' or customer_email like '%" & txt_search.Text & "%' or customer_tel like '%" & txt_search.Text & "%'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_customer()
    End Sub



    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick
        On Error Resume Next


        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value


        connect()
        oledb = "select * from customer where customer_username ='" & key & "'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        Dim dts As DataTable = DS.Tables("table")

        txt_show_ID.Text = dts.Rows(0)("customer_id")
        txt_show_username.Text = dts.Rows(0)("customer_username")
        txt_show_password.Text = dts.Rows(0)("customer_password")
        txt_show_name.Text = dts.Rows(0)("customer_name")
        txt_show_nickname.Text = dts.Rows(0)("customer_nickname")
        txt_show_address.Text = dts.Rows(0)("customer_address")
        txt_show_email.Text = dts.Rows(0)("customer_email")
        txt_show_tel.Text = dts.Rows(0)("customer_tel")
        txt_show_date.Text = dts.Rows(0)("customer_born")
        txt_show_point.Text = dts.Rows(0)("point")



        txt_edit_username.Text = dts.Rows(0)("customer_username")
        txt_edit_password.Text = dts.Rows(0)("customer_password")
        txt_edit_name.Text = dts.Rows(0)("customer_name")
        txt_edit_nickname.Text = dts.Rows(0)("customer_nickname")
        txt_edit_address.Text = dts.Rows(0)("customer_address")
        txt_edit_email.Text = dts.Rows(0)("customer_email")
        txt_edit_tel.Text = dts.Rows(0)("customer_tel")
        txt_edit_date.Text = dts.Rows(0)("customer_born")
        txt_edit_point.Text = dts.Rows(0)("point")




    End Sub

    Friend Sub connect()
        If cn.State = ConnectionState.Closed Then cn.Open()


    End Sub


    Private Sub btn_add_save_Click(sender As Object, e As EventArgs) Handles btn_add_save.Click
        If txt_add_name.Text = "" Or txt_add_nickname.Text = "" Or txt_add_date.Text = "" Or txt_add_address.Text = "" Or txt_add_email.Text = "" Or txt_add_tel.Text = "" Or txt_add_username.Text = "" Or txt_add_password.Text = "" Then
            msg_error("Please fill in all blanks.")
            Return
        End If

        If confirm("Do you want to save?") = vbNo Then
            Return
        End If


        connect()
        Dim name As String = txt_add_name.Text
        Dim nickname As String = txt_add_nickname.Text
        Dim born As Date = txt_add_date.Text
        Dim address As String = txt_add_address.Text
        Dim email As String = txt_add_email.Text
        Dim tel As String = txt_add_tel.Text
        Dim username As String = txt_add_username.Text
        Dim password As String = txt_add_password.Text

        oledb = "insert into customer(customer_username,customer_password,customer_name,customer_nickname,customer_born,customer_address,customer_email,customer_tel,point) values(@customer_username,@customer_password,@customer_name,@customer_nickname,@customer_born,@customer_address,@customer_email,@customer_tel,@point)  "
        cmd = New OleDbCommand(oledb, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("customer_username", username)
        cmd.Parameters.AddWithValue("customer_password", password)
        cmd.Parameters.AddWithValue("customer_name ", name)
        cmd.Parameters.AddWithValue("customer_nickname", nickname)
        cmd.Parameters.AddWithValue("customer_born", born)
        cmd.Parameters.AddWithValue("customer_address", address)
        cmd.Parameters.AddWithValue("customer_email", email)
        cmd.Parameters.AddWithValue("customer_tel", tel)
        cmd.Parameters.AddWithValue("point", 0)


        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("successfull")
            load_customer()
            txt_add_username.Text = ""
            txt_add_password.Text = ""
            txt_add_name.Text = ""
            txt_add_nickname.Text = ""
            txt_add_address.Text = ""
            txt_add_email.Text = ""
            txt_add_tel.Text = ""
            txt_add_date.Text = ""

        Else
            msg_error("fail!")

        End If



    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If confirm("Do you want to delete?") = vbNo Then
            Return
        End If


        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        connect()
        oledb = "delete from customer where customer_username ='" & key & "'"
        cmd = New OleDbCommand(oledb, cn)
        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("Deleting is successfull")
            load_customer()
        Else
            msg_error("Deleting is fail!")

        End If


    End Sub

    Private Sub btn_add_clear_Click(sender As Object, e As EventArgs) Handles btn_add_clear.Click
        txt_add_username.Text = ""
        txt_add_password.Text = ""
        txt_add_name.Text = ""
        txt_add_nickname.Text = ""
        txt_add_address.Text = ""
        txt_add_email.Text = ""
        txt_add_tel.Text = ""
        txt_add_date.Text = ""
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click


        If confirm("Do you want to edit?") = vbNo Then
            Return
        End If

        connect()

        Dim name As String = txt_edit_name.Text
        Dim nickname As String = txt_edit_nickname.Text
        Dim born As String = txt_edit_date.Text
        Dim address As String = txt_edit_address.Text
        Dim email As String = txt_edit_email.Text
        Dim tel As String = txt_edit_tel.Text
        Dim username As String = txt_edit_username.Text
        Dim password As String = txt_edit_password.Text
        Dim point As Integer = txt_edit_point.Text


        oledb = "update customer set customer_password=@customer_password, customer_name=@customer_name, customer_nickname=@customer_nickname, customer_born=@customer_born, customer_address=@customer_address, customer_email=@customer_email, customer_tel=@customer_tel, point=@point where customer_username=@customer_username"







        cmd = New OleDbCommand(oledb, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("customer_password", txt_edit_password.Text)
        cmd.Parameters.AddWithValue("customer_name ", txt_edit_name.Text)
        cmd.Parameters.AddWithValue("customer_nickname", txt_edit_nickname.Text)
        cmd.Parameters.AddWithValue("customer_born", txt_edit_date.Text)
        cmd.Parameters.AddWithValue("customer_address", txt_edit_address.Text)
        cmd.Parameters.AddWithValue("customer_email", txt_edit_email.Text)
        cmd.Parameters.AddWithValue("customer_tel", txt_edit_tel.Text)
        cmd.Parameters.AddWithValue("point", txt_edit_point.Text)
        cmd.Parameters.AddWithValue("customer_username", txt_edit_username.Text)


        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("Edit is successfull")
            load_customer()
            txt_edit_username.Text = ""
            txt_edit_password.Text = ""
            txt_edit_name.Text = ""
            txt_edit_nickname.Text = ""
            txt_edit_address.Text = ""
            txt_edit_email.Text = ""
            txt_edit_tel.Text = ""
            txt_edit_date.Text = ""
            txt_edit_point.Text = ""


        Else
            msg_error("fail!")

        End If
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        frm_history.Show()
        frm_history.Activate()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class