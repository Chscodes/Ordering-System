Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Form2
            .TopLevel = False
            pnlfill.Controls.Add(Form2)
            .BringToFront()
            .Show()
            Form2.Size = pnlfill.Size
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Form9
            .TopLevel = False
            pnlfill.Controls.Add(Form9)
            .BringToFront()
            .Show()
            Form9.Size = pnlfill.Size
        End With
    End Sub
End Class
