Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_security_code.Text = rnd_security_code()
        txt_username.Text = My.Settings.username
        If My.Settings.username = "" Then
            chk_remember.Checked = False
        Else
            chk_remember.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If confirm("Do you want to close this program?") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Or txt_security_code.Text = "" Then
            msg_error("Please fill in all blanks.")
            Return
        End If

        If txt_security_code.Text <> lbl_security_code.Text Then
            msg_error("Security code invalid")
            lbl_security_code.Text = rnd_security_code()
            txt_security_code.Text = ""
            Return
        End If

        oledb = "select count (*) from users where users_username='" & txt_username.Text & "'and users_password='" & txt_password.Text & "'"
        Dim count_user As Integer = cmd_excuteScalar()

        If count_user <= 0 Then
            msg_error("Login fail !")
            txt_username.Text = ""
            txt_password.Text = ""
            txt_username.Select()
            Dim i As Integer = lbl_count.Text
            i += 1
            If i > 3 Then
                msg_error("You have already Login fail 3 times!")
                End
            End If
            lbl_count.Text = i
            btn_login.Enabled = False
            Timer1.Enabled = True
            Label4.Visible = True
            Label6.Visible = True
            lbl_wait.Visible = True
        Else
            msg_ok("Login Successfull")
            frm_main.Show()
            Me.Hide()

            oledb = "select * from users where users_username='" & txt_username.Text & "'and users_password='" & txt_password.Text & "'"
            Dim dts As DataTable = cmd_excuteToDataTable()
            With frm_main
                .lbl_username.Text = dts.Rows(0)("users_username")
                .lbl_fullname.Text = dts.Rows(0)("users_firstname") & " " & dts.Rows(0)("users_lastname")
                .lbl_tel.Text = dts.Rows(0)("users_tel")
                .lbl_email.Text = dts.Rows(0)("users_email")
                .lbl_timelogin.Text = Date.Now
            End With

            password_login = dts.Rows(0)("users_password")


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub lbl_security_code_DoubleClick(sender As Object, e As EventArgs) Handles lbl_security_code.DoubleClick
        lbl_security_code.Text = rnd_security_code()
    End Sub

    Private Sub chk_remember_CheckedChanged(sender As Object, e As EventArgs) Handles chk_remember.CheckedChanged
        If chk_remember.Checked = True Then
            My.Settings.username = txt_username.Text
        Else
            My.Settings.username = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = lbl_wait.Text
        i -= 1
        lbl_wait.Text = i
        If i <= 0 Then
            lbl_wait.Text = 5
            btn_login.Enabled = True
            Timer1.Enabled = False
            Label4.Visible = False
            Label6.Visible = False
            lbl_wait.Visible = False
        End If
    End Sub
End Class
