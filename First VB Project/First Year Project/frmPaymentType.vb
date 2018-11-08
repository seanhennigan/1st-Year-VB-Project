Public Class frmPaymentType

    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress
        'Only allows numbers to be entered into the the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If

    End Sub

    Private Sub btnContinue2_Click(sender As Object, e As EventArgs) Handles btnContinue2.Click
        'Calling the sub procedure NoEntry
        NoEntry()

        'If Cork is selected then the following hotels will appear
        If cboCounty2.SelectedItem = "Cork" Then
            My.Forms.frmHotelsAndPricing.radHotels1.Text = ("Langher Lodge (2*)")
            My.Forms.frmHotelsAndPricing.radHotels2.Text = ("Pana Palace (3*)")
            My.Forms.frmHotelsAndPricing.radHotels3.Text = ("Coal-Quay Hotel (3*)")
        End If

        'If Dublin is selected then the following hotels will appear
        If cboCounty2.SelectedItem = "Dublin" Then
            My.Forms.frmHotelsAndPricing.radHotels1.Text = ("Jackeen Ville (1*)")
            My.Forms.frmHotelsAndPricing.radHotels2.Text = ("Blue Cow Inn (2*)")
            My.Forms.frmHotelsAndPricing.radHotels3.Text = ("Stellabourne Hotel (4*)")
        End If

        'If Kerry is selected then the following hotels will appear
        If cboCounty2.SelectedItem = "Kerry" Then
            My.Forms.frmHotelsAndPricing.radHotels1.Text = ("Simply-The-Best Hotel (4*)")
            My.Forms.frmHotelsAndPricing.radHotels2.Text = ("BallyRocks Hotel (5*)")
            My.Forms.frmHotelsAndPricing.radHotels3.Hide()
        End If

        'If Limerick is selected then the following hotels will appear
        If cboCounty2.SelectedItem = "Limerick" Then
            My.Forms.frmHotelsAndPricing.radHotels1.Text = ("The Docks Motel (1*)")
            My.Forms.frmHotelsAndPricing.radHotels2.Text = ("Shannon Lodge (3*)")
            My.Forms.frmHotelsAndPricing.radHotels3.Text = ("Clohessy Court Hotel (4*)")
        End If

        'Transferring data from this form to the next
        My.Forms.frmInvoice.lstInvoice.Items.Add("Card Number: " & Me.txtCardNumber.Text)

        My.Forms.frmInvoice.lstInvoice.Items.Add("Payment Type: " & Me.cboPaymentType.SelectedItem)

    End Sub

    Private Sub txtPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPIN.KeyPress
        'Only allows numbers to be entered.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    'If the text hasn't been entered into the textboxes, or the length of text is not equal to 8 and 4 then a messagebox will appear.
    Sub NoEntry()
        If cboCounty2.SelectedIndex = -1 Then
            ErrorCount()
            MessageBox.Show("Please Choose a County", "Invalid County Choice", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf cboPaymentType.SelectedIndex = -1 Then
            ErrorCount()
            MessageBox.Show("Please Choose a Payment type.", "Invalid Choice of Payment", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Len(txtCardNumber.Text) <> 8 Then
            ErrorCount()
            MessageBox.Show("Please Re-enter Card Number", "Invalid Card Number", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Len(txtPIN.Text) <> 4 Then
            ErrorCount()
            MessageBox.Show("Please Re-enter PIN.", "Invalid PIN Number", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Hide()
            frmHotelsAndPricing.Show()
        End If
    End Sub

End Class