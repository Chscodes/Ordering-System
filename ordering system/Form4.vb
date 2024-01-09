Imports MySql.Data.MySqlClient 'mysql datbase
Imports System.Net
Imports System.Net.Mail
Public Class Form4
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=ordering_db;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim randomCode As String
    Public Shared toUser As String

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnverify_Click_1(sender As Object, e As EventArgs) Handles btnverify.Click
        If txtname.Text = Nothing Or txtEmail.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            connection.Close()
            connection.Open()
            command = New MySqlCommand("select * from admin where col_name='" & txtname.Text & "' and col_bday='" & DateTimePicker1.Text & "'
            and col_email='" & txtEmail.Text & "'", connection)
            dataReader = command.ExecuteReader
            Dim ACC As Integer
            ACC = 0
            While dataReader.Read
                ACC = ACC + 1
            End While

            If ACC = 1 Then

                txtus.Text = dataReader.GetString("username")
                txtpass.Text = dataReader.GetString("password")
                MessageBox.Show("Username: " + txtus.Text + vbNewLine + "Password: " + txtpass.Text, "Your Username and Password is", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Quest As Integer = MessageBox.Show("Do you Want to change your username and password?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Quest = DialogResult.Yes Then
                    grb1.Enabled = False
                    grb2.Visible = True
                Else
                    txtname.Text = Nothing
                    txtEmail.Text = Nothing
                    Me.Close()
                    Form1.Show()
                End If

            Else
                MessageBox.Show("Account Not Exist in Database!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        End If

    End Sub



    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtU_us.Text = Nothing Or txtU_pass.Text = Nothing Or txtU_cpass.Text = Nothing Then
            MessageBox.Show("Please fill the needed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtU_pass.text <> txtU_cpass.Text Then
            MessageBox.Show("Please confirm your password properly!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                grb2.Visible = False
                grb3.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        If txtcode.Text = Nothing Then
            MessageBox.Show("Please input a verification code here", "VERIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If (txtcode.Text.Equals(randomCode)) Then


                connection.Close()
                connection.Open()
                command = New MySqlCommand("UPDATE admin SET username='" & txtU_us.Text & "', password='" & txtU_pass.Text & "'  where username='" & txtus.Text & "'", connection)
                dataReader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("You successfully updated your account!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)



                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "A admin named  '" & txtname.Text.ToUpper & "' has change its username and password!"
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
    Public Sub clear()
        txtname.Text = Nothing
        txtEmail.Text = Nothing
        txtU_pass.Text = Nothing
        txtU_us.Text = Nothing
        txtU_cpass.Text = Nothing
        txtcode.Text = Nothing
    End Sub


End Class