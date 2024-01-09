Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form2
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Hide()
        Form3.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Hide()
        Form4.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then

            MessageBox.Show("Please fill the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            connection.Open()
            command = New MySqlCommand("select * from admin where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", connection)
            dataReader = command.ExecuteReader
            Dim Login As Integer
            Login = 0
            While dataReader.Read
                Login = Login + 1
            End While

            If Login = 1 Then
                Me.Hide()
                Form5.ShowDialog()

            Else
                MessageBox.Show("Username and Password don't Match!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            connection.Close()
        End If


    End Sub
End Class