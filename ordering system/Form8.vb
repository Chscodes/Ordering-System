Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form8
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv
    End Sub
    Public Sub loadgdv() ' para mag load ng data sa datgrid at mag refresh pag nag add
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select id as 'ID', name as 'Customer Name', email as 'Email', contactno as 'Contact Number', shippingAddress as 'Address', regDate as 'Date Register' from users", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        dgv1.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        txtb_ID.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        txtname.Text = dgv1.Item(1, e.RowIndex).Value.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim update As Integer = MessageBox.Show("Are you sure want to DELETE this?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If update = DialogResult.Yes Then
            connection.Open()
            command = New MySqlCommand("Delete from users where id ='" & txtb_ID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has DELETED a CUSTOMER named'" & txtname.Text & "'"
            command.ExecuteNonQuery()
            connection.Close()
            Form14.loadgdv()

            loadgdv()


        End If
    End Sub

End Class