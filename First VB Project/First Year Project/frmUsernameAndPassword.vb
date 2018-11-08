Public Class frmUsernameAndPassword

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'This will allow any text entered into txtUsername2 and txtPassword2 to act as the Username and Password in frmLogin.
        My.Settings.User = txtUsername2.Text
        My.Settings.Pass = txtPassword2.Text
        My.Settings.Save()
        MessageBox.Show("Admin Registered.")
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        'This will hide this form and open the previous form, frmLogin.
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class