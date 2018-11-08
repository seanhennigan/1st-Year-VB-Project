Public Module GlobalVariables
    Public gErrorCount As Integer = 0

    Public Sub ErrorCount()
        'Public Sub Procedure named ErrorCount
        If gErrorCount = 0 Or (gErrorCount < 4 And gErrorCount > 0) Then
            'Increases the value of the error count by 1
            gErrorCount += 1

            MessageBox.Show("You have made " & gErrorCount & " error(s)")
        Else

            MessageBox.Show("You have exceeded your error limit.")
            'The error count is reset
            gErrorCount = 0
            'If you have global variables in your project you'll need
            'to reset them here too.
            'e.g. dblTotal = 0 etc, etc.

            frmLogin.Show()
            'Hide all your forms except the first one
            frmAdditionalPersons.Hide()
            frmDetails.Hide()
            frmExtras.Hide()
            frmHotelsAndPricing.Hide()
            frmInvoice.Hide()
            frmOutro.Hide()
            frmPaymentType.Hide()
            frmUsernameAndPassword.Hide()
            frmWelcome.Hide()

        End If
    End Sub
End Module
