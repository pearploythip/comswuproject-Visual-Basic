Imports System.Data.OleDb

Module code


#Region "ประกาศตัวแปร"

    Friend cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Project.mdb;")
    Friend cmd As New OleDbCommand
    Friend DA As New OleDbDataAdapter
    Friend DS As New DataSet
    Friend DR As OleDbDataReader
    Friend oledb As String = ""
    Friend password_login As String


#End Region


#Region "Code ที่ใช้เกี่ยวกับฐานข้อมูล"

    ' fn เปิดใช้งานฐานข้อมูล
    Friend Sub connect_open()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("Fail to connect Database. Plesae check value in cn variable,Try again", vbCritical + vbOKOnly, "Error")
            MsgBox(ex.Message)
        End Try

    End Sub

    'fn  รับค่า Return จากฐานข้อมูล เป็นผลการดำเนินการคำสั่ง oledb  ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    Friend Function cmd_excuteNonquery()
        connect_open()
        cmd = New OleDbCommand(oledb, cn)
        Return cmd.ExecuteNonQuery
    End Function

    ' รับข้อมูล Return จากฐานข้อมูล เป็นข้อมูลค่าเดียว ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New OleDbCommand(oledb, cn)
        Return cmd.ExecuteScalar()
    End Function
    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูลไปแสดงใน DataGridView ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    ''' </summary>
    ''' <param name="your_datagridView">ชื่อของ DataGrid ที่จะให้แสดงข้อมูล</param>
    ''' <remarks> ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน</remarks>
    Friend Sub cmd_excuteToDataGridView(ByVal your_datagridView As DataGridView)
        connect_open()
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        your_datagridView.DataSource = DS.Tables("table")
    End Sub
    ''' <summary>
    ''' fn return ดึงข้อมูลจากฐานข้อมูลมาเก็บไว้ ใน DataTable ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    ''' </summary>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Friend Function cmd_excuteToDataTable()
        connect_open()
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function
    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูลมาเก็บไว้ ใน DataSet ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function cmd_excuteToDataSet()
        connect_open()
        DA = New OleDbDataAdapter(oledb, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS
    End Function

    ''' <summary>
    ''' ดึงข้อมูลในฐานข้อมูลมาแสดงใน ComboBox หรือ Listbox ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    ''' </summary>
    ''' <param name="your_comboBox_or_ListBox">ชื่อ combobox หรือ listbox ที่ต้องการให้แสดงข้อมูล</param>
    ''' <remarks></remarks>
    Friend Sub cmd_excuteComboBoxAndListBox(ByVal your_comboBox_or_ListBox As Object)
        connect_open()
        cmd = New OleDbCommand(oledb, cn)
        DR = cmd.ExecuteReader()
        your_comboBox_or_ListBox.Items.Clear()
        While DR.Read
            your_comboBox_or_ListBox.Items.Add(DR(0))
        End While
        DR.Close()
    End Sub

    ''' <summary>
    ''' ดึงรูปภาพออกมาจากฐานข้อมูล และแสดงไปยัง PictureBox ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน
    ''' </summary>
    ''' <param name="Your_PictureBox">ชื่อของ Picture ที่คุณจะให้รูปภาพแสดง</param>
    ''' <remarks></remarks>
    Friend Sub cmd_excuteImageToPictureBox(ByVal Your_PictureBox As PictureBox)
        connect_open()
        cmd = New OleDbCommand(oledb, cn)
        Dim imageData() As Byte = cmd.ExecuteScalar()
        Your_PictureBox.Image = Image.FromStream(New IO.MemoryStream(CType(imageData, Byte())))
    End Sub

    ''' <summary>
    ''' ดึงรูปภาพออกมาจากฐานข้อมูล ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร oledb ก่อน"
    ''' </summary>
    ''' <returns>Image</returns>
    ''' <remarks></remarks>
    Friend Function cmd_excuteImage() As Image
        connect_open()
        Dim imageData() As Byte = cmd_excuteScalar(oledb)
        Return Image.FromStream(New IO.MemoryStream(CType(imageData, Byte())))
    End Function
    ''' <summary>
    ''' แปลงภาพใน PictureBox เพื่อบันทึกลงฐานข้อมูล ต้องใช้ผ่าน Parameters.AddWithValue
    ''' </summary>
    ''' <param name="your_pictureBox">ชื่อ PictureBox ของคุณที่จะแปลงภาพ</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function convert_PictureBox_toDatabase(ByVal your_pictureBox As PictureBox)
        Dim memmory As New IO.MemoryStream
        your_pictureBox.Image.Save(memmory, Imaging.ImageFormat.Bmp)
        Dim pic_ready() As Byte = memmory.ToArray()
        Return pic_ready.ToArray()
    End Function


#End Region


#Region "function อื่นๆ"


    ' fn random number security code
    Friend Function rnd_security_code()
        Randomize()
        Dim i As Integer = 99999 * Rnd()
        Return i.ToString.PadLeft(5, "0")
    End Function

    Friend Sub msg_error(text As String, Optional title As String = "Error")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub

    Friend Sub msg_ok(text As String, Optional title As String = "Successful")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub

    Friend Function confirm(text As String, Optional title As String = "Comfirm")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function



#End Region



End Module
