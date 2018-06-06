Imports System.Data.OleDb

Public Class frm_history


    Public Sub load_history()
        connect_open()
        oledb = "select * from promotion where promotion_user='" & frm_manage_customer.txt_show_username.Text & "'"
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_history.DataSource = DS.Tables("table")

    End Sub

    Private Sub frm_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_history()
    End Sub
End Class