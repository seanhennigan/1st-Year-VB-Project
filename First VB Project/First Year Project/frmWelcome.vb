Public Class frmWelcome

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'If this button is clicked, then the next form will show and this form will hide.
        Me.Hide()
        frmDetails.Show()

    End Sub
End Class