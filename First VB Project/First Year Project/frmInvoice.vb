Imports System.Drawing.Printing
Public Class frmInvoice
    'Declaring variables
    Dim printsettings As New PageSettings
    Dim usefont As New Font("Candara", 10)
    Dim strToPrint As String

    Private Sub btnAdvance2_Click(sender As Object, e As EventArgs) Handles btnAdvance2.Click
        'The usual showing the next form and hiding this form
        Me.Hide()
        frmOutro.Show()

        'Printing
        Try
            prntDocument.DefaultPageSettings = printsettings

            strToPrint = lstInvoice.Text

            pdlgInvoice.Document = prntDocument

            Dim result As DialogResult = pdlgInvoice.ShowDialog

            If result = Windows.Forms.DialogResult.OK Then
                prntDocument.Print()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub prntDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles prntDocument.PrintPage
        'Declaring variables
        Dim numchar As Integer
        Dim numlines As Integer
        Dim strForPage As String
        Dim stringformat As New StringFormat

        Dim recDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim sizemeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - usefont.GetHeight(e.Graphics))
        stringformat.Trimming = StringTrimming.Word
        e.Graphics.MeasureString(strToPrint, usefont, sizemeasure, stringformat, numchar, numlines)
        strForPage = stringformat.ToString.Substring(0, numchar)
        e.Graphics.DrawString(strForPage, usefont, Brushes.Black, recDraw, stringformat)

        If numchar < strToPrint.Length Then
            strToPrint = strToPrint.Substring(numchar)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            strToPrint = lstInvoice.Text
        End If
    End Sub

End Class