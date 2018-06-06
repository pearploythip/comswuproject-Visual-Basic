Imports System.Data.OleDb

Public Class frm_select_customer

    Public Sub load_customer()
        connect_open()
        oledb = "select * from customer"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")

    End Sub

    Public Sub search_customer()
        connect_open()
        oledb = "select customer_username, customer_name from customer where customer_username like '%" & txt_search.Text & "%' or customer_password like '%" & txt_search.Text & "%' or customer_name like '%" & txt_search.Text & "%' or customer_nickname like '%" & txt_search.Text & "%' or customer_address like '%" & txt_search.Text & "%' or customer_email like '%" & txt_search.Text & "%' or customer_tel like '%" & txt_search.Text & "%'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")

        datagrid_search.DataSource = DS.Tables("table")
    End Sub



    Private Sub frm_select_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_customer()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_customer()
    End Sub

    Public Sub customer_select()
        On Error Resume Next
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim username = datagrid_search.Item(1, i).Value
        Dim name = datagrid_search.Item(3, i).Value
        Dim point = datagrid_search.Item(9, i).Value

        With frm_coffeeSale
            .lbl_username.Text = username
            .lbl_name.Text = name
            .lbl_point.Text = point

        End With
        frm_usepromotion.lbl_point.Text = point
        Me.Close()


    End Sub



    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        customer_select()
    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellContentClick

    End Sub

    Private Sub datagrid_search_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellDoubleClick
        customer_select()
    End Sub
End Class