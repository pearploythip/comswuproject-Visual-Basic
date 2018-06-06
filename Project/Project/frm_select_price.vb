Public Class frm_select_price
    Private Sub frm_select_price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_amount.Select()

    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If txt_amount.Text = "" Or Not IsNumeric(txt_amount.Text) Then
            msg_error("Please fill in amount only numberic.")
            Return
        End If
        Dim array_item(7) As String
        With frm_coffeeSale
            array_item(0) = .listview_sale.Items.Count + 1
            array_item(1) = lbl_coffee_id.Text
            array_item(2) = lbl_coffee_name.Text
            If lbl_coffee_type.Text = "Sweet Bakery" Then
                array_item(3) = "Pieces"
            Else
                array_item(3) = "Cups"
            End If
            array_item(4) = txt_amount.Text
            array_item(5) = lbl_price.Text
            array_item(6) = array_item(4) * array_item(5)

        End With

        Dim itm As New ListViewItem(array_item)
        frm_coffeeSale.listview_sale.Items.Add(itm)
        Me.Hide()
        frm_coffeeSale.total_price()
    End Sub
End Class