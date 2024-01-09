Imports MySql.Data.MySqlClient 'mysql datbase
Imports System.Net
Imports System.Net.Mail
Public Class Form10
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim randomCode As String
    Public Shared toUser As String

    Public Sub clear()
        txtPass.Text = Nothing
        txtname.Text = Nothing
        txtEmail.Text = Nothing
        txtCpass.Text = Nothing
        txtadd.Clear()
        txtno.Clear()
    End Sub
    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        If txtPass.Text <> txtCpass.Text Then
            MessageBox.Show("Please confirm your password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtno.text = Nothing Or txtadd.Text = Nothing Or txtPass.Text = Nothing Or txtname.Text = Nothing Or txtEmail.Text = Nothing Or txtCpass.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim from, pass, messagebody As String
            Dim rand As Random = New Random()
            randomCode = (rand.Next(999999)).ToString()
            Dim message As MailMessage = New MailMessage()
            toUser = txtEmail.Text
            from = "shiro.acct@gmail.com"
            pass = "Admin_Account01"
            messagebody = " Your verification code is " & randomCode
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messagebody
            message.Subject = "Good Day Here is your verification code!"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New NetworkCredential(from, pass)
            Try
                smtp.Send(message)
                MessageBox.Show("Please check your email", "VERIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtadd.Enabled = False
                txtCpass.Enabled = False
                txtPass.Enabled = False
                txtname.Enabled = False
                txtEmail.Enabled = False
                txtadd.Enabled = False
                txtno.Enabled = False
                btncancel.Enabled = False
                btnreg.Enabled = False
                grp.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcode.Text = Nothing Then
            MessageBox.Show("Please input a verification code here", "VERIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If (txtcode.Text.Equals(randomCode)) Then
                'REGISTRATION
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into users (name, email, contactno, password, shippingAddress) values (@name, @email, @no, @pass, @sf)", connection)
                command.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50)).Value = txtname.Text.ToUpper
                command.Parameters.Add(New MySqlParameter("@email", MySqlDbType.VarChar, 50)).Value = txtEmail.Text
                command.Parameters.Add(New MySqlParameter("@no", MySqlDbType.VarChar, 50)).Value = txtno.Text
                command.Parameters.Add(New MySqlParameter("@pass", MySqlDbType.VarChar, 50)).Value = txtPass.Text
                command.Parameters.Add(New MySqlParameter("@sf", MySqlDbType.VarChar, 50)).Value = txtadd.Text
                command.ExecuteNonQuery()
                MessageBox.Show("You Successfully Register as Customer!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "A new customer named  '" & txtname.Text.ToUpper & "' has been successfully registered an account!"
                command.ExecuteNonQuery()
                connection.Close()
                Form14.loadgdv()



                clear()
                Me.Close()
                Form1.Show()
            Else
                MessageBox.Show("Please check verification code properly!", "VERIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If
    End Sub
End Class