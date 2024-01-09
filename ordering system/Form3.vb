Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form3
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        If txtPass.Text <> txtCpass.Text Then
            MessageBox.Show("Please confirm your password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtUS.Text = Nothing Or txtPass.Text = Nothing Or txtname.Text = Nothing Or txtEmail.Text = Nothing Or txtCpass.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'REGISTRATION
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into admin (username, password, col_name, col_email, col_bday) values (@us, @pass, @name, @email, @bday)", connection)
            command.Parameters.Add(New MySqlParameter("@us", MySqlDbType.VarChar, 50)).Value = txtUS.Text.ToUpper
            command.Parameters.Add(New MySqlParameter("@pass", MySqlDbType.VarChar, 50)).Value = txtPass.Text
            command.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50)).Value = txtname.Text
            command.Parameters.Add(New MySqlParameter("@email", MySqlDbType.VarChar, 50)).Value = txtEmail.Text
            command.Parameters.Add(New MySqlParameter("@bday", DateTimePicker1.Value.Date))
            command.ExecuteNonQuery()
            MessageBox.Show("You Successfully Register as Admin!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "A new admin named  '" & txtname.Text.ToUpper & "' has been successfully registered an account!"
            command.ExecuteNonQuery()
            connection.Close()
            Form14.loadgdv()

            clear()
            Me.Close()
            Form1.Show()
        End If

    End Sub
    Public Sub clear()
        txtUS.Text = Nothing
        txtPass.Text = Nothing
        txtname.Text = Nothing
        txtEmail.Text = Nothing
        txtCpass.Text = Nothing
    End Sub
End Class