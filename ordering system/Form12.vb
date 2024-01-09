Imports MySql.Data.MySqlClient 'mysql datbase
Imports System.IO
Imports System.Drawing
Public Class Form12
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()

        Dim row As DataGridViewRow = dgv1.Rows(0)
        Dim col As DataGridViewColumn = dgv1.Columns(6)
        row.Height = 100
        col.Width = 100
        CType(dgv1.Columns(6), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom


        cmbcat.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select categoryName from category ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colname = dataReader.GetString("categoryName")
            cmbcat.Items.Add(colname)
        End While
        connection.Close()
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

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        dgv1.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        lblid.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        txtProdID.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        cmbcat.Text = dgv1.Item(1, e.RowIndex).Value.ToString
        lblPname.Text = dgv1.Item(2, e.RowIndex).Value
        txtprice.Text = dgv1.Item(3, e.RowIndex).Value.ToString
        txtdesc.Text = dgv1.Item(4, e.RowIndex).Value.ToString
        txtstocks.Text = dgv1.Item(5, e.RowIndex).Value.ToString
        'FOR CLICK BACK TO PICTURE BOX
        Dim bytes As Byte() = dgv1.CurrentRow.Cells(6).Value
        Using ms As New MemoryStream(bytes)
            PB.Image = Image.FromStream(ms)
        End Using

        txttotal.Text = dgv1.Item(3, e.RowIndex).Value.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form9.TextBox1.Clear()
        Form9.TextBox2.Clear()
        Me.Close()
        Form1.Show()
    End Sub
    Public Sub clear()
        cmbcat.Text = Nothing
        txtdesc.Clear()
        txtquan.Text = "1"
        txtprice.Clear()
        txtstocks.Clear()
        txttotal.Clear()
        PB.Image = Nothing
        lblid.Text = "0"
        lblPname.Text = Nothing
    End Sub
    Private Sub btnorder_Click_1(sender As Object, e As EventArgs) Handles btnorder.Click
        If lblPname.Text = Nothing Or txtprice.Text = Nothing Or txtstocks.Text = Nothing Or txttotal.Text = Nothing Then
            MessageBox.Show("Please select an item!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim update As Integer = MessageBox.Show("You are about to place an order! Please click YES to proceed?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If update = DialogResult.Yes Then
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into orders (userId,productId, quantity, amount) values (@ID, @pID, @quan, @amount)", connection)
                command.Parameters.Add(New MySqlParameter("@ID", MySqlDbType.VarChar, 50)).Value = txtuserID.Text
                'command.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50)).Value = lblPname.Text
                command.Parameters.Add(New MySqlParameter("@pID", MySqlDbType.VarChar, 50)).Value = txtProdID.Text
                command.Parameters.Add(New MySqlParameter("@quan", MySqlDbType.VarChar, 50)).Value = txtquan.Text
                command.Parameters.Add(New MySqlParameter("@amount", MySqlDbType.VarChar, 50)).Value = txttotal.Text
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("You Successfully Place an Order", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'FOR UPDATING STOCKS
                connection.Open()
                command = New MySqlCommand("update products SET productAvailability='" & txtstocks.Text - txtquan.Text & "' where id='" & lblid.Text & "'", connection)
                dataReader = command.ExecuteReader

                connection.Close()

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "A customer named  '" & txtname.Text.ToUpper & "' has successfully purchased '" & txtquan.Text & "' pcs of '" & lblPname.Text.ToUpper & "' from '" & cmbcat.Text.ToUpper & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()




                clear()
                loadgdv()
                Form13.loadgdv()
                Form7.loadgdv()
            Else
            End If
        End If
    End Sub

    Private Sub btndown_Click(sender As Object, e As EventArgs) Handles btndown.Click
        If txtquan.Text = 1.ToString Then

        Else
            Dim min As Integer = Integer.Parse(txtquan.Text)
            min += -1
            txtquan.Text = min

            Dim total As Integer = Integer.Parse(txttotal.Text)
            total -= txtprice.Text

            txttotal.Text = total
        End If

    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click

        If txtquan.Text = txtstocks.Text Then

        Else

            Dim max As Integer = Integer.Parse(txtquan.Text)
            max += 1
            txtquan.Text = max

            Dim price As Integer = Integer.Parse(txtprice.Text)
            price *= txtquan.Text

            txttotal.Text = price
        End If

    End Sub

    Private Sub cmbcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select id as 'ID', category as 'Category', productName as 'Product Name', productPrice as 'Price', productDescription 'Description', productAvailability as 'Remaining Stocks', productImage1 as 'Image' from products where category = '" & cmbcat.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()

        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form15.ShowDialog()
    End Sub
End Class