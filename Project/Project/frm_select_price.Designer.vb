<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_price
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_coffee_name = New System.Windows.Forms.Label()
        Me.lbl_coffee_id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.lbl_coffee_type = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_select.Location = New System.Drawing.Point(118, 253)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(113, 55)
        Me.btn_select.TabIndex = 0
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID :"
        '
        'lbl_price
        '
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(131, 138)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(148, 31)
        Me.lbl_price.TabIndex = 4
        Me.lbl_price.Text = "0"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_coffee_name
        '
        Me.lbl_coffee_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_coffee_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coffee_name.Location = New System.Drawing.Point(80, 48)
        Me.lbl_coffee_name.Name = "lbl_coffee_name"
        Me.lbl_coffee_name.Size = New System.Drawing.Size(250, 31)
        Me.lbl_coffee_name.TabIndex = 5
        Me.lbl_coffee_name.Text = "0"
        Me.lbl_coffee_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_coffee_id
        '
        Me.lbl_coffee_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_coffee_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coffee_id.Location = New System.Drawing.Point(131, 9)
        Me.lbl_coffee_id.Name = "lbl_coffee_id"
        Me.lbl_coffee_id.Size = New System.Drawing.Size(148, 31)
        Me.lbl_coffee_id.TabIndex = 6
        Me.lbl_coffee_id.Text = "0"
        Me.lbl_coffee_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 31)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Amount :"
        '
        'txt_amount
        '
        Me.txt_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(152, 194)
        Me.txt_amount.Multiline = True
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(107, 31)
        Me.txt_amount.TabIndex = 9
        '
        'lbl_coffee_type
        '
        Me.lbl_coffee_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_coffee_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_coffee_type.Location = New System.Drawing.Point(131, 94)
        Me.lbl_coffee_type.Name = "lbl_coffee_type"
        Me.lbl_coffee_type.Size = New System.Drawing.Size(148, 31)
        Me.lbl_coffee_type.TabIndex = 11
        Me.lbl_coffee_type.Text = "0"
        Me.lbl_coffee_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Price :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 31)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Baht"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_select_price
        '
        Me.AcceptButton = Me.btn_select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.tumblr_inline_n9gfz60SBh1qa3mpb
        Me.ClientSize = New System.Drawing.Size(356, 320)
        Me.Controls.Add(Me.lbl_coffee_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_coffee_id)
        Me.Controls.Add(Me.lbl_coffee_name)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_select)
        Me.Name = "frm_select_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "select price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_select As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_coffee_name As Label
    Friend WithEvents lbl_coffee_id As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents lbl_coffee_type As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
