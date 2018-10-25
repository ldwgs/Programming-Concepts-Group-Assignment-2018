Public Class formLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        formMainMenu.Show()
        Me.Hide() 'is .Hide() the same as closing the form?'
    End Sub
End Class
