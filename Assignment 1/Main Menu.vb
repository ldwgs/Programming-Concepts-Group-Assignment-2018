Public Class formMainMenu
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        formLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        formAddStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        formEditStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        formDeleteStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        formViewStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        formSearchStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrintStudent_Click(sender As Object, e As EventArgs) Handles btnPrintStudent.Click
        formPrintStudent.Show()
        Me.Hide()
    End Sub
End Class