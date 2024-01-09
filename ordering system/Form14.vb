Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form14
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Public Sub loadgdv() ' para mag load ng data sa datgrid at mag refresh pag nag add
        connection.Open()
        command = New MySqlCommand("select Date as 'DATE and TIME', Description as 'LOGS' from history", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()
    End Sub



End Class