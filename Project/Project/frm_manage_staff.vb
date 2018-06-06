Imports System.Data.OleDb
Public Class frm_manage_staff


    Friend Sub connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub


    Public Sub load_users()
        connect()
        oledb = "select users_username, users_firstname, users_lastname from users"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")
    End Sub

    Public Sub search_users()
        connect()
        oledb = "select users_username, users_firstname, users_lastname from users where users_username like '%" & txt_search.Text & "%' or users_password like '%" & txt_search.Text & "%' or users_firstname like '%" & txt_search.Text & "%' or users_lastname like '%" & txt_search.Text & "%' or users_tel like '%" & txt_search.Text & "%' or users_email like '%" & txt_search.Text & "%'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")
    End Sub



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_users()
    End Sub

    Private Sub frm_manage_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_users()
    End Sub



    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick
        On Error Resume Next


        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value


        connect()
        oledb = "select * from users where users_username ='" & key & "'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        Dim dts As DataTable = DS.Tables("table")


        txt_show_username.Text = dts.Rows(0)("users_username")
        txt_show_password.Text = dts.Rows(0)("users_password")
        txt_show_firstname.Text = dts.Rows(0)("users_firstname")
        txt_show_lastname.Text = dts.Rows(0)("users_lastname")
        txt_show_email.Text = dts.Rows(0)("users_email")
        txt_show_tel.Text = dts.Rows(0)("users_tel")




        txt_edit_username.Text = dts.Rows(0)("users_username")
        txt_edit_firstname.Text = dts.Rows(0)("users_firstname")
        txt_edit_password.Text = dts.Rows(0)("users_password")
        txt_edit_lastname.Text = dts.Rows(0)("users_lastname")
        txt_edit_email.Text = dts.Rows(0)("users_email")
        txt_edit_tel.Text = dts.Rows(0)("users_tel")

    End Sub

    Private Sub btn_add_save_Click(sender As Object, e As EventArgs) Handles btn_add_save.Click
        If txt_add_firstname.Text = "" Or txt_add_lastname.Text = "" Or txt_add_email.Text = "" Or txt_add_tel.Text = "" Or txt_add_username.Text = "" Or txt_add_password.Text = "" Then
            msg_error("Please fill in all blanks.")
            Return
        End If

        If confirm("Do you want to save?") = vbNo Then
            Return
        End If


        connect()
        Dim firstname As String = txt_add_firstname.Text
        Dim lastname As String = txt_add_lastname.Text
        Dim email As String = txt_add_email.Text
        Dim tel As String = txt_add_tel.Text
        Dim username As String = txt_add_username.Text
        Dim password As String = txt_add_password.Text

        oledb = "insert into users(users_username,users_password,users_firstname,users_lastname,users_email,users_tel) values(@users_username,@users_password,@users_firstname,@users_lastname,users_email,@users_tel)  "
        cmd = New OleDbCommand(oledb, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("users_username", username)
        cmd.Parameters.AddWithValue("users_password", password)
        cmd.Parameters.AddWithValue("users_firstname ", firstname)
        cmd.Parameters.AddWithValue("users_lastname", lastname)
        cmd.Parameters.AddWithValue("users_email", email)
        cmd.Parameters.AddWithValue("users_tel", tel)


        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("successfull")
            load_users()
            txt_add_username.Text = ""
            txt_add_password.Text = ""
            txt_add_firstname.Text = ""
            txt_add_lastname.Text = ""
            txt_add_email.Text = ""
            txt_add_tel.Text = ""


        Else
            msg_error("fail!")

        End If

    End Sub

    Private Sub btn_add_clear_Click(sender As Object, e As EventArgs) Handles btn_add_clear.Click
        txt_add_username.Text = ""
        txt_add_password.Text = ""
        txt_add_firstname.Text = ""
        txt_add_lastname.Text = ""
        txt_add_email.Text = ""
        txt_add_tel.Text = ""
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If confirm("Do you want to delete?") = vbNo Then
            Return
        End If


        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        connect()
        oledb = "delete from users where users_username ='" & key & "'"
        cmd = New OleDbCommand(oledb, cn)
        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("Deleting is successfull")
            load_users()
        Else
            msg_error("Deleting is fail!")

        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If confirm("Do you want to edit?") = vbNo Then
            Return
        End If


        connect()




        Dim firstname As String = txt_edit_firstname.Text
        Dim lastname As String = txt_edit_lastname.Text
        Dim email As String = txt_edit_email.Text
        Dim tel As String = txt_edit_tel.Text
        Dim username As String = txt_edit_username.Text
        Dim password As String = txt_edit_password.Text


        oledb = "update users set users_email=@users_email, users_password=@users_password, users_firstname=@users_firstname, users_lastname=@users_lastname, users_tel=@users_tel where users_username=@users_username"

        cmd = New OleDbCommand(oledb, cn)

        cmd.Parameters.Clear()


        cmd.Parameters.AddWithValue("users_email", txt_edit_email.Text)
        cmd.Parameters.AddWithValue("users_password", txt_edit_password.Text)
        cmd.Parameters.AddWithValue("users_firstname", txt_edit_firstname.Text)
        cmd.Parameters.AddWithValue("users_lastname", txt_edit_lastname.Text)
        cmd.Parameters.AddWithValue("users_tel", txt_edit_tel.Text)
        cmd.Parameters.AddWithValue("users_username", txt_edit_username.Text)


        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("Edit is successfull")
            load_users()
            txt_edit_username.Text = ""
            txt_edit_password.Text = ""
            txt_edit_firstname.Text = ""
            txt_edit_lastname.Text = ""
            txt_edit_email.Text = ""
            txt_edit_tel.Text = ""



        Else

            msg_error("fail!")

        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub


End Class