Public Class Form5
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim log As Integer = MessageBox.Show("Are you sure want to LOG OUT?", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If log = DialogResult.Yes Then
            Form2.TextBox1.Clear()
            Form2.TextBox2.Clear()
            Me.Close()
            Form1.Show()
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Form6
            .TopLevel = False
            pnlfill.Controls.Add(Form6)
            .BringToFront()
            .Show()
            Form6.Size = pnlfill.Size
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Form7
            .TopLevel = False
            pnlfill.Controls.Add(Form7)
            .BringToFront()
            .Show()
            Form7.Size = pnlfill.Size
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Form8
            .TopLevel = False
            pnlfill.Controls.Add(Form8)
            .BringToFront()
            .Show()
            Form8.Size = pnlfill.Size
        End With
    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        With Form13
            .TopLevel = False
            pnlfill.Controls.Add(Form13)
            .BringToFront()
            .Show()
            Form13.Size = pnlfill.Size
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Form14
            .TopLevel = False
            pnlfill.Controls.Add(Form14)
            .BringToFront()
            .Show()
            Form14.Size = pnlfill.Size
        End With
    End Sub
End Class