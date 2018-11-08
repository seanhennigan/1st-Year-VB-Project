<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdvance2 = New System.Windows.Forms.Button()
        Me.lblHeadingInvoice = New System.Windows.Forms.Label()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.prntDocument = New System.Drawing.Printing.PrintDocument()
        Me.pdlgInvoice = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'btnAdvance2
        '
        Me.btnAdvance2.Location = New System.Drawing.Point(80, 424)
        Me.btnAdvance2.Name = "btnAdvance2"
        Me.btnAdvance2.Size = New System.Drawing.Size(136, 27)
        Me.btnAdvance2.TabIndex = 0
        Me.btnAdvance2.Text = "Advance And Print"
        Me.btnAdvance2.UseVisualStyleBackColor = True
        '
        'lblHeadingInvoice
        '
        Me.lblHeadingInvoice.AutoSize = True
        Me.lblHeadingInvoice.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingInvoice.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingInvoice.Location = New System.Drawing.Point(-4, 9)
        Me.lblHeadingInvoice.Name = "lblHeadingInvoice"
        Me.lblHeadingInvoice.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingInvoice.TabIndex = 26
        Me.lblHeadingInvoice.Text = "OnlyTheBest.com"
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 15
        Me.lstInvoice.Location = New System.Drawing.Point(21, 76)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(252, 319)
        Me.lstInvoice.TabIndex = 27
        '
        'prntDocument
        '
        '
        'pdlgInvoice
        '
        Me.pdlgInvoice.UseEXDialog = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(299, 463)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.lblHeadingInvoice)
        Me.Controls.Add(Me.btnAdvance2)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmInvoice"
        Me.Text = "Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdvance2 As System.Windows.Forms.Button
    Friend WithEvents lblHeadingInvoice As System.Windows.Forms.Label
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox
    Friend WithEvents prntDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents pdlgInvoice As System.Windows.Forms.PrintDialog
End Class
