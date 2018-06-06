Imports System.Text

Public Class frm_promotion

    Dim sb As New StringBuilder()

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_count.Text = "" Or txt_coupon.Text = "" Or txt_discount.Text = "" Then
            msg_error("Please fill in all blanks.")
            Return
        End If
        If confirm("Do you want to add coupon?") = vbNo Then Return
        oledb = String.Format("insert into promotion(promotion_coupon,promotion_condition,promotion_discount,promotion_count) values('{0}','{1}','{2}','{3}')", txt_coupon.Text, txt_condition.Text, txt_discount.Text, txt_count.Text)

        If cmd_excuteNonquery() = 0 Then
            msg_error("Adding coupon is fail!")
        Else
            msg_ok("Adding coupon is successfull")
            cmd = New OleDb.OleDbCommand(oledb, cn)

            txt_coupon.Text = ""
            txt_condition.Text = ""
            txt_count.Text = ""
            txt_discount.Text = ""

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("condition", txt_condition.Text)
                .Parameters.AddWithValue("count", txt_count.Text)
                .Parameters.AddWithValue("coupon", txt_coupon.Text)
                .Parameters.AddWithValue("discount", txt_discount.Text)
                refresh_coupon()
            End With
        End If

    End Sub


    Public Sub refresh_coupon()
        oledb = "Select promotion_id,promotion_coupon,promotion_condition,promotion_discount,promotion_count from promotion "
        datagrid_all.DataSource = cmd_excuteToDataTable()
        oledb = "Select promotion_id,promotion_coupon,promotion_condition,promotion_discount,promotion_count from promotion where promotion_count=0 "
        datagrid_expire.DataSource = cmd_excuteToDataTable()
        head_change()

        lbl_total_1.Text = datagrid_all.RowCount
        lbl_total_2.Text = datagrid_expire.RowCount

    End Sub

    Public Sub head_change()
        Dim head() As String = {"id", "coupon", "count", "discount", "Remain"}
        For i As Integer = 0 To head.Length - 1
            datagrid_all.Columns(i).HeaderText = head(i)
            datagrid_expire.Columns(i).HeaderText = head(i)
        Next

    End Sub


    Private Sub frm_promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coupon()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim i As Integer = datagrid_all.CurrentRow.Index
        Dim coupon As String = datagrid_all.Item(1, i).Value

        oledb = "delete from promotion where promotion_coupon = '" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Deleting coupon is fail!")
        Else
            msg_ok("Deleting coupon is successfull.")
            refresh_coupon()


        End If
    End Sub



    Private Sub btn_coupon_add_Click(sender As Object, e As EventArgs) Handles btn_coupon_add.Click
        Dim i As Integer = datagrid_all.CurrentRow.Index
        Dim coupon As String = datagrid_all.Item(1, i).Value

        ' oledb = "UPDATE from promotion set promotion_count = promotion_count+" & txt_coupon_add.Text & " where promotion_coupon '" & coupon & "'"
        oledb = "UPDATE promotion set promotion_count= promotion_count+" & txt_coupon_add.Text & " where promotion_coupon ='" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Edit coupon is fail!")
        Else
            msg_ok("Edit coupon is successfull.")

            refresh_coupon()


        End If


    End Sub


End Class