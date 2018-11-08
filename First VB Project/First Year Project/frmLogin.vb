Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'If the text of Username is Admin and the text of Password is password,
        'Then they are logged in, otherwise they can't and a messagebox will appear.
        If txtUsername.Text = My.Settings.User And txtPassword.Text = My.Settings.Pass Then
            frmWelcome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Access Denied.")
            ErrorCount()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'If this button is clicked, the form will be hidden.
        Me.Hide()
    End Sub

    Private Sub lnkForget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked
        'If this link is clicked, then this MessageBox will appear. 
        frmUsernameAndPassword.Show()
        Me.Hide()
    End Sub

End Class
