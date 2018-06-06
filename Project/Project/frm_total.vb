Imports System.Data.OleDb

Public Class frm_total


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_receive_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_receive.KeyDown
        If e.KeyData = Keys.Enter Then
            If Not IsNumeric(txt_receive.Text) Then
                msg_error("Please fill only numberic.")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If

            If Val(txt_receive.Text) < Val(txt_net.Text) Then
                msg_error("Receive is less that total")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If

            Dim net As Double = txt_net.Text
            Dim receive As Double = txt_receive.Text
            Dim change As Double = receive - net
            txt_change.Text = change

        End If

    End Sub

    Private Sub Link_resize_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_resize.LinkClicked
        If Link_resize.Text = "Show Cash" Then
            Me.Width = 1056
            Link_resize.Text = "Hide Cash"
        Else
            Me.Width = 611
            Link_resize.Text = "Show Cash"
        End If
    End Sub

    Public Sub add_receive(money As Integer)
        Dim recieve As Double
        Try
            recieve = txt_receive.Text
        Catch ex As Exception
            recieve = 0
        End Try
        recieve += money
        txt_receive.Text = recieve
        txt_receive.Select()
    End Sub

    Private Sub pic_1000_Click(sender As Object, e As EventArgs) Handles pic_1000.Click
        add_receive(1000)
    End Sub

    Private Sub pic_500_Click(sender As Object, e As EventArgs) Handles pic_500.Click
        add_receive(500)
    End Sub

    Private Sub pic_100_Click(sender As Object, e As EventArgs) Handles pic_100.Click
        add_receive(100)
    End Sub

    Private Sub pic_50_Click(sender As Object, e As EventArgs) Handles pic_50.Click
        add_receive(50)
    End Sub

    Private Sub pic_20_Click(sender As Object, e As EventArgs) Handles pic_20.Click
        add_receive(20)
    End Sub

    Private Sub pic_10_Click(sender As Object, e As EventArgs) Handles pic_10.Click
        add_receive(10)
    End Sub

    Private Sub pic_5_Click(sender As Object, e As EventArgs) Handles pic_5.Click
        add_receive(5)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim i As Integer = frm_coffeeSale.listview_sale.Items.Count - 1

        For j As Integer = 0 To i
            Dim coffee_id As String = frm_coffeeSale.listview_sale.Items(j).SubItems(1).Text

            Dim coffee_amount As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(4).Text

            Dim coffee_total As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(6).Text

            Dim date_sale As String = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day

            oledb = String.Format("Insert into sale_table(sale_full_id,coffee_id,coffee_amount,coffee_total,date_sale)values('{0}','{1}','{2}','{3}','{4}')", frm_coffeeSale.lbl_sale_ID.Text, coffee_id, coffee_amount, coffee_total, date_sale)



            cmd = New OleDb.OleDbCommand(oledb, cn)
            cmd.ExecuteNonQuery()

        Next


        oledb = "Insert into sale_detail(sale_full_id,sale_total,discount,discount_condition,sale_net,customer) Values(@sale_full_id, @sale_total,@discount,@discount_condition,@sale_net,@customer)"

        cmd = New OleDb.OleDbCommand(oledb, cn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("sale_full_id", frm_coffeeSale.lbl_sale_ID.Text)

        cmd.Parameters.AddWithValue("sale_total", txt_total.Text)

        cmd.Parameters.AddWithValue("discount", txt_discount.Text)

        cmd.Parameters.AddWithValue("discount_condition", frm_coffeeSale.lbl_condition.Text)

        cmd.Parameters.AddWithValue("sale_net", txt_total.Text)

        cmd.Parameters.AddWithValue("customer", frm_coffeeSale.lbl_username.Text)


        If cmd.ExecuteNonQuery = 0 Then

            msg_error("Adding is fail.")

        Else
            msg_ok("Adding Successfull.")





            Dim add_point As Integer = lbl_point.Text
            Dim all_point As Integer = frm_coffeeSale.lbl_point.Text
            Dim new_point As Integer = all_point + add_point
            If frm_coffeeSale.lbl_username.Text = "xxxx" Or frm_coffeeSale.lbl_name.Text = "xxxx" Then
                frm_coffeeSale.lbl_point.Text = "0"
            Else


                connect_open()
                oledb = "update customer set point=point+" & lbl_point.Text & " where customer_username = '" & frm_coffeeSale.lbl_username.Text & "'"
                cmd = New OleDbCommand(oledb, cn)
                If cmd_excuteNonquery() = 0 Then
                    msg_error("Add point is fail!")
                End If
                msg_ok("Add point is successfull.")
                frm_coffeeSale.lbl_point.Text = new_point
            End If

        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()



        Me.Close()
        frm_coffeeSale.txt_total.Text = "0.00"
        frm_coffeeSale.generate_saleID()
        frm_coffeeSale.lbl_discount.Text = ""
        frm_coffeeSale.listview_sale.Items.Clear()
        frm_coffeeSale.lbl_condition.Text = "xxxx"
        frm_coffeeSale.lbl_discount.Text = 0


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim col(8) As Integer
        col(1) = 10
        col(2) = 70
        col(3) = 140
        col(4) = 300
        col(5) = 400
        col(6) = 490
        col(7) = 560

        Dim fnt As New Font("Cordia New", 16)
        Dim fnt_bold As New Font("Cordia New", 30, FontStyle.Bold)
        e.Graphics.DrawString("TamaTama Coffee & Bakery", fnt_bold, Brushes.HotPink, col(1), 20)
        e.Graphics.DrawLine(Pens.Black, col(1), 80, 650, 80)

        Dim line As Integer = 100


        e.Graphics.DrawString("Order", fnt, Brushes.Black, col(1), line)
        e.Graphics.DrawString("ID", fnt, Brushes.Black, col(2), line)
        e.Graphics.DrawString("Menu", fnt, Brushes.Black, col(3), line)
        e.Graphics.DrawString("Unit", fnt, Brushes.Black, col(4), line)
        e.Graphics.DrawString("Amount", fnt, Brushes.Black, col(5), line)
        e.Graphics.DrawString("@Price", fnt, Brushes.Black, col(6), line)
        e.Graphics.DrawString("TotalPrice", fnt, Brushes.Black, col(7), line)



        For i As Integer = 0 To frm_coffeeSale.listview_sale.Items.Count - 1
            line += 30
            Dim print_out(8) As String
            With frm_coffeeSale.listview_sale
                print_out(1) = .Items(i).SubItems(0).Text
                print_out(2) = .Items(i).SubItems(1).Text
                print_out(3) = .Items(i).SubItems(2).Text
                print_out(4) = .Items(i).SubItems(3).Text
                print_out(5) = .Items(i).SubItems(4).Text
                print_out(6) = .Items(i).SubItems(5).Text
                print_out(7) = .Items(i).SubItems(6).Text

            End With


            e.Graphics.DrawString(print_out(1), fnt, Brushes.Black, col(1), line)
            e.Graphics.DrawString(print_out(2), fnt, Brushes.Black, col(2), line)
            e.Graphics.DrawString(print_out(3), fnt, Brushes.Black, col(3), line)
            e.Graphics.DrawString(print_out(4), fnt, Brushes.Black, col(4), line)
            e.Graphics.DrawString(print_out(5), fnt, Brushes.Black, col(5), line)
            e.Graphics.DrawString(print_out(6), fnt, Brushes.Black, col(6), line)
            e.Graphics.DrawString(print_out(7), fnt, Brushes.Black, col(7), line)

        Next

        line += 35
        e.Graphics.DrawString("Total  " & frm_coffeeSale.txt_total.Text & "  Baht", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Discount  " & frm_coffeeSale.lbl_discount.Text & "  Baht", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Net  " & txt_net.Text & "  Baht", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Point  " & lbl_point.Text & "  point", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Receive  " & txt_receive.Text & "  Baht", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Change  " & txt_change.Text & "  Baht", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("Customer  " & frm_coffeeSale.lbl_name.Text, fnt, Brushes.Black, col(1), line)
        line += 20
        e.Graphics.DrawString("Point  " & frm_coffeeSale.lbl_point.Text, fnt, Brushes.Black, col(1), line)


    End Sub

    Private Sub frm_total_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class