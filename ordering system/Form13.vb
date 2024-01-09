Imports MySql.Data.MySqlClient
Public Class Form13
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()

        Dim row As DataGridViewRow = dgv1.Rows(0)
        Dim col As DataGridViewColumn = dgv1.Columns(2)
        row.Height = 100
        col.Width = 100
        CType(dgv1.Columns(2), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom

    End Sub

    Public Sub loadgdv()
        connection.Close()
        connection.Open()
        command = New MySqlCommand("SELECT
                                        orders.id AS 'ID',
                                        users.name as 'Customer Name',
                                        products.productImage1 as 'Product Image',
                                        products.productName as 'Product Name',
                                        orders.quantity as 'Quantity',
                                        products.productPrice as 'Price',
                                        orders.amount as 'Total Amount',
                                        orders.orderDate as 'Date Purchased'
                                    FROM
                                        orders
                                    INNER JOIN users ON orders.userId = users.id
                                    INNER JOIN products ON orders.productId = products.id
                                     ", connection)

        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        dgv1.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        txtb_ID.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        txtname.Text = dgv1.Item(1, e.RowIndex).Value.ToString
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim update As Integer = MessageBox.Show("Are you sure want to DELETE this?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If update = DialogResult.Yes Then
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Delete from orders where id ='" & txtb_ID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has DELETED an ORDER of CUSTOMER named'" & txtname.Text & "'"
            command.ExecuteNonQuery()
            connection.Close()
            Form14.loadgdv()


            loadgdv()


        End If
    End Sub
End Class