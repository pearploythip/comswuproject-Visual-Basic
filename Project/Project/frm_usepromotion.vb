Imports System.Data.OleDb

Public Class frm_usepromotion
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_active_Click(sender As Object, e As EventArgs) Handles btn_active.Click
        oledb = "select * from promotion where promotion_coupon = '" & txt_coupon.Text & "' AND promotion_count>=1"
        Dim dts As DataTable = cmd_excuteToDataTable()
        If dts.Rows.Count = 0 Then
            msg_error("Not found or Coupon have used.")
            Return
        End If
        lbl_condition.Text = dts.Rows(0)("promotion_condition")
        lbl_discount.Text = dts.Rows(0)("promotion_discount")

        txt_coupon.Enabled = False
        btn_active.Enabled = False

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        oledb = "UPDATE promotion set promotion_count= promotion_count-1 where promotion_coupon ='" & txt_coupon.Text & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("Not found.")
        Else
            msg_ok("Used coupons success.")
            frm_coffeeSale.lbl_discount.Text = lbl_discount.Text
            frm_coffeeSale.lbl_condition.Text = lbl_condition.Text

            Me.Close()

        End If
    End Sub

    Private Sub btn_use_point_Click(sender As Object, e As EventArgs) Handles btn_use_point.Click
        If txt_use_point.Text = "" Then
            msg_error("กรุณาระบุจำนวน Point ที่ต้องการใช้")
            txt_use_point.Select()
            Return
        End If

        Dim all_point As Integer = lbl_point.Text
        Dim use_point As Integer = txt_use_point.Text
        If use_point > all_point Then
            msg_error("Points not enough.")
            Return

        End If
        Dim new_point As Integer = all_point - use_point


        If confirm("Do you want to use point?") = vbNo Then Return


        connect_open()

        oledb = "UPDATE customer set point=point-" & txt_use_point.Text & " where customer_username ='" & frm_coffeeSale.lbl_username.Text & "'"
        cmd = New OleDbCommand(oledb, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("Used points success.")


            Randomize()
            Dim rand_code As String = 999999 * Rnd()
            txt_coupon_code.Text = rand_code

            rand_code = rand_code.PadLeft(6, "0")


            oledb = "insert into promotion(promotion_coupon, promotion_condition, promotion_discount, promotion_count ,promotion_user) values(@promotion_coupon,@promotion_condition,@promotion_discount,@promotion_count,@promotion_user)"
            cmd = New OleDbCommand(oledb, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("promotion_coupon", rand_code)
            cmd.Parameters.AddWithValue("promotion_coudition", "รับส่วนลดจากการแลกแต้มสะลมจำนวน " & txt_use_point.Text)
            cmd.Parameters.AddWithValue("promotion_discount", txt_use_point.Text)
            cmd.Parameters.AddWithValue("promotion_count", 1)
            cmd.Parameters.AddWithValue("promotion_user", frm_coffeeSale.lbl_username.Text)
            If cmd.ExecuteNonQuery >= 1 Then
                msg_ok("Adding coupon success.")
                lbl_point.Text = new_point
                frm_coffeeSale.lbl_point.Text = new_point

            Else
                msg_error("Adding coupon fail!")
            End If



        Else
            msg_error("Used points fail!")

        End If


    End Sub

    Private Sub frm_usepromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class