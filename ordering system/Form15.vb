Imports MySql.Data.MySqlClient
Public Class Form15
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.Close()
        Form12.Show()
    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                                     WHERE orders.userId = '" & Form12.txtuserID.Text & "'", connection)

        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class