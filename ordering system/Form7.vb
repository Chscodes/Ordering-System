Imports MySql.Data.MySqlClient 'mysql datbase
Imports System.IO
Imports System.Drawing
Public Class Form7
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim imgpath As String
    Dim arimage() As Byte
    Dim ms As New System.IO.MemoryStream()
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()

        Dim row As DataGridViewRow = dgv1.Rows(0)
        Dim col As DataGridViewColumn = dgv1.Columns(6)
        row.Height = 100
        col.Width = 100
        CType(dgv1.Columns(6), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom


        cmb_cat.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select categoryName from category ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colname = dataReader.GetString("categoryName")
            cmb_cat.Items.Add(colname)
            ComboBox1.Items.Add(colname)
        End While
        connection.Close()
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtname.Text = Nothing Or cmb_cat.Text = Nothing Or txtdesc.Text = Nothing Or txtstock.Text = Nothing Or txtprice.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'REGISTRATION

            Try
                ' PB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                PB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                arimage = ms.GetBuffer()
                Dim fs As UInt32
                fs = ms.Length
                ms.Close()


                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into products (category, productName, productPrice, productDescription, productAvailability, productImage1) 
                values (@cat, @name, @price, @desc, @stocks, @image)", connection)
                command.Parameters.Add(New MySqlParameter("@cat", MySqlDbType.VarChar, 50)).Value = cmb_cat.Text
                command.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50)).Value = txtname.Text
                command.Parameters.Add(New MySqlParameter("@price", MySqlDbType.VarChar, 50)).Value = txtprice.Text
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 50)).Value = txtdesc.Text
                command.Parameters.Add(New MySqlParameter("@stocks", MySqlDbType.VarChar, 50)).Value = txtstock.Text
                command.Parameters.AddWithValue("@image", arimage)
                command.ExecuteNonQuery()
                MessageBox.Show("You Successfully ADD a product!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()


                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has ADDED a new PRODUCT named '" & txtname.Text.ToUpper & "' from '" & cmb_cat.Text.ToUpper & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()

                loadgdv()
                clear()
            Catch ex As Exception
                MessageBox.Show("PLEASE SELECT ANOTHER PICTURE")
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As FileDialog = New OpenFileDialog
        c.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
        If c.ShowDialog() = DialogResult.OK Then
            imgpath = c.FileName
            PB.ImageLocation = imgpath
        End If
        c = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PB.Image = Nothing
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        dgv1.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        txtb_ID.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        cmb_cat.Text = dgv1.Item(1, e.RowIndex).Value.ToString
        txtname.Text = dgv1.Item(2, e.RowIndex).Value.ToString
        txtprice.Text = dgv1.Item(3, e.RowIndex).Value.ToString
        txtdesc.Text = dgv1.Item(4, e.RowIndex).Value.ToString
        txtstock.Text = dgv1.Item(5, e.RowIndex).Value.ToString
        'FOR CLICK BACK TO PICTURE BOX
        Dim bytes As Byte() = dgv1.CurrentRow.Cells(6).Value
        Using ms As New MemoryStream(bytes)
            PB.Image = Image.FromStream(ms)
        End Using
    End Sub
    Public Sub loadgdv()
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select id as 'ID', category as 'Category', productName as 'Product Name', productPrice as 'Price', productDescription 'Description', productAvailability as 'Remaining Stocks', productImage1 as 'Image' from products", connection)
        adptr.SelectCommand = command
        table.Clear()

        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click


        Dim mster As New MemoryStream
        PB.Image.Save(mster, PB.Image.RawFormat)
        Dim i() As Byte
        i = mster.ToArray()

        If txtname.Text = Nothing Or txtdesc.Text = Nothing Or txtstock.Text = Nothing Or txtprice.Text = Nothing Or cmb_cat.Text = Nothing Then
            MessageBox.Show("Please fill the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim update As Integer = MessageBox.Show("Are you sure want to UPDATE this?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If update = DialogResult.Yes Then
                connection.Close()
                connection.Open()
                command = New MySqlCommand("update products SET category='" & cmb_cat.Text & "', productName='" & txtname.Text & "' ,productPrice= '" & txtprice.Text & "',productAvailability= '" & txtstock.Text & "', productDescription='" & txtdesc.Text & "', productImage1= @img where id='" & txtb_ID.Text & "'", connection)
                command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = i
                dataReader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Your Data is  Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has UPDATED a PRODUCT where ID is '" & txtb_ID.Text & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()

                loadgdv()
                clear()

            End If
        End If
    End Sub
    Public Sub clear()
        txtname.Text = Nothing
        txtprice.Text = Nothing
        txtstock.Clear()
        cmb_cat.Text = Nothing
        txtdesc.Clear()
        PB.Image = Nothing
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtname.Text = Nothing Or txtdesc.Text = Nothing Or txtstock.Text = Nothing Or txtprice.Text = Nothing Or cmb_cat.Text = Nothing Then
            MessageBox.Show("Please fill the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim update As Integer = MessageBox.Show("Are you sure want to DELETE this?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If update = DialogResult.Yes Then
                connection.Open()
                command = New MySqlCommand("Delete from products where id ='" & txtb_ID.Text & "'", connection)
                dataReader = command.ExecuteReader
                MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has DELETED the PRODUCT named'" & txtname.Text.ToUpper & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()

                loadgdv()
                clear()

            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select id as 'ID', category as 'Category', productName as 'Product Name', productPrice as 'Price', productDescription 'Description', productAvailability as 'Remaining Stocks', productImage1 as 'Image' from products where category = '" & ComboBox1.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()

        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub


End Class