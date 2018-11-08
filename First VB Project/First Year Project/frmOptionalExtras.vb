Public Class frmExtras
    Dim dblPrice As Double
    Private Sub btnPrices_Click(sender As Object, e As EventArgs) Handles btnPrices.Click

        If chkDryCleaning.Checked Then
            dblPrice += 40
        End If

        If chkSuits.Checked Then
            dblPrice += 19.5
        End If

        If chkShirts.Checked Then
            dblPrice += 9.25
        End If

        If chkOther.Checked Then
            dblPrice += 11.25
        End If

        If chkLaundry.Checked Then
            dblPrice += 15.5
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 3.23
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 6.23
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 4.13
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 7.88
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 4.5
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 9
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 2.7
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 4.95
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cow Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 5.4
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cow Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 10.65
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 7.5
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 15
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 4.28
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 15
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 8.25
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 18.75
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 2.25
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 4.5
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 4.95
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 9.45
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 6.15
        End If

        If chkContinental.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 12.15
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 5.3
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 10.3
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 6.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 12.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 6.8
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 12.8
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 3.9
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 6.9
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cown Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 7.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cown Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 14.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 11
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 22
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 6.7
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 12.7
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 12.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 27.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 3.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 6.5
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 7
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 14
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 8.9
        End If

        If chkFullIrish.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 16.9
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 15.75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Langher Lodge (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 30.75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 18.75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Pana Palace (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 36.25
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 20
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Coal Quay Hotel (3*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 40
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 11.5
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Jackeen Ville (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 21.5
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cow Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 20.5
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Blue Cow Inn (2*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 40.5
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 32.5
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Stellabourne Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 65
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 19.25
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "Simply The Best Hotel (4*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 36.75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 40
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "BallyRocks Hotel (5*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*)" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 10
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Checked And My.Forms.frmHotelsAndPricing.radHotels1.Text = "The Docks Motel (1*" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 20
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 20
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Checked And My.Forms.frmHotelsAndPricing.radHotels2.Text = "Shannon Lodge (3*" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 40
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            dblPrice += 24.75
        End If

        If chkEvening.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Checked And My.Forms.frmHotelsAndPricing.radHotels3.Text = "Clohessy Court Hotel (4*" And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            dblPrice += 47.25
        End If

        txtPrices.Text = FormatCurrency(dblPrice)

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Hide()

        frmInvoice.Show()

        'Transferring the total price to lstInvoice.
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total Extras Price: " & (Me.txtPrices.Text))

        Dim A As Double = txtPrices.Text
        Dim B As Double = txtCurrentPrice.Text
        Dim C As Double


        C = A + B

        My.Forms.frmInvoice.lstInvoice.Items.Add(("Total Price: " & C))

    End Sub

    Private Sub chkAdditionalPersons2_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdditionalPersons2.CheckedChanged

        If chkAdditionalPersons2.Checked Then
            frmAdditionalPersons.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub frmExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Forms.frmAdditionalPersons.chkOptionalExtras2.Checked Then
            Me.chkAdditionalPersons2.Hide()
        End If

    End Sub
End Class