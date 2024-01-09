Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form6
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtname.Text = Nothing Or txtdesc.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'REGISTRATION
            connection.Open()
            command = New MySqlCommand("Insert into category (categoryName, categoryDescription) values (@name, @desc)", connection)
            command.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50)).Value = txtname.Text.ToUpper
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 50)).Value = txtdesc.Text
            command.ExecuteNonQuery()
            MessageBox.Show("You Successfully Register a Category!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()


            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has ADDED a new CATEGORY named '" & txtname.Text.ToUpper & "'"
            command.ExecuteNonQuery()
            connection.Close()
            Form14.loadgdv()



            loadgdv()

            clear()
            ai()
        End If
    End Sub

    Public Sub loadgdv() ' para mag load ng data sa datgrid at mag refresh pag nag add
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select id as 'ID', categoryName as 'Category Name', categoryDescription as 'Description' from category", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub
    Public Sub ai()
        Dim ai As Integer
        connection.Open()
        command = New MySqlCommand("Select Max(ID) from category", connection)
        If IsDBNull(command.ExecuteScalar()) Then
            ai = 1
        Else
            ai = command.ExecuteScalar.ToString
            ai = ai + 1
        End If
        txtid.Text = ai
        connection.Close()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()

        ai()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtname.Text = Nothing Or txtdesc.Text = Nothing Then
            MessageBox.Show("Please fill the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim update As Integer = MessageBox.Show("Are you sure want to UPDATE this?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If update = DialogResult.Yes Then
                connection.Open()
                command = New MySqlCommand("update category SET id='" & txtid.Text & "', categoryName='" & txtname.Text & "' , categoryDescription='" & txtdesc.Text & "' where id='" & txtb_ID.Text & "'", connection)
                dataReader = command.ExecuteReader
                MessageBox.Show("Your Data is  Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connection.Close()


                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has UPDATED a CATEGORY where ID is '" & txtb_ID.Text & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()

                loadgdv()

                clear()
                ai()
            End If
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        dgv1.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        txtid.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        txtb_ID.Text = dgv1.Item(0, e.RowIndex).Value.ToString
        txtname.Text = dgv1.Item(1, e.RowIndex).Value.ToString
        txtdesc.Text = dgv1.Item(2, e.RowIndex).Value.ToString
    End Sub

    Public Sub clear()
        txtname.Text = Nothing
        txtdesc.Text = Nothing
        txtid.Text = Nothing
        txtb_ID.Text = Nothing
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtname.Text = Nothing Or txtdesc.Text = Nothing Then
            MessageBox.Show("Please fill the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim update As Integer = MessageBox.Show("Are you sure want to DELETE this?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If update = DialogResult.Yes Then
                connection.Open()
                command = New MySqlCommand("Delete from category where id ='" & txtb_ID.Text & "'", connection)
                dataReader = command.ExecuteReader
                MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "An admin username '" & Form2.TextBox1.Text.ToUpper & "' has DELETED the CATEGORY named'" & txtname.Text.ToUpper & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()

                loadgdv()
                clear()
                ai()
            End If
        End If
    End Sub
End Class