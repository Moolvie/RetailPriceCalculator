<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetailPriceCalculator
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
        Me.WholesaleLabel = New System.Windows.Forms.Label()
        Me.WholesalePriceTextBox = New System.Windows.Forms.TextBox()
        Me.MarkupLabel = New System.Windows.Forms.Label()
        Me.PercentMarkupTextBox = New System.Windows.Forms.TextBox()
        Me.RetailLabel = New System.Windows.Forms.Label()
        Me.RetailPriceLabel = New System.Windows.Forms.Label()
        Me.GetRetailPriceButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WholesaleLabel
        '
        Me.WholesaleLabel.AutoSize = True
        Me.WholesaleLabel.Location = New System.Drawing.Point(47, 21)
        Me.WholesaleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WholesaleLabel.Name = "WholesaleLabel"
        Me.WholesaleLabel.Size = New System.Drawing.Size(167, 18)
        Me.WholesaleLabel.TabIndex = 0
        Me.WholesaleLabel.Text = "Wholesale Cost of Item:"
        '
        'WholesalePriceTextBox
        '
        Me.WholesalePriceTextBox.Location = New System.Drawing.Point(221, 21)
        Me.WholesalePriceTextBox.Name = "WholesalePriceTextBox"
        Me.WholesalePriceTextBox.Size = New System.Drawing.Size(100, 24)
        Me.WholesalePriceTextBox.TabIndex = 1
        '
        'MarkupLabel
        '
        Me.MarkupLabel.AutoSize = True
        Me.MarkupLabel.Location = New System.Drawing.Point(139, 76)
        Me.MarkupLabel.Name = "MarkupLabel"
        Me.MarkupLabel.Size = New System.Drawing.Size(75, 18)
        Me.MarkupLabel.TabIndex = 2
        Me.MarkupLabel.Text = "Markup %"
        '
        'PercentMarkupTextBox
        '
        Me.PercentMarkupTextBox.Location = New System.Drawing.Point(221, 70)
        Me.PercentMarkupTextBox.Name = "PercentMarkupTextBox"
        Me.PercentMarkupTextBox.Size = New System.Drawing.Size(100, 24)
        Me.PercentMarkupTextBox.TabIndex = 3
        '
        'RetailLabel
        '
        Me.RetailLabel.AutoSize = True
        Me.RetailLabel.Location = New System.Drawing.Point(127, 131)
        Me.RetailLabel.Name = "RetailLabel"
        Me.RetailLabel.Size = New System.Drawing.Size(87, 18)
        Me.RetailLabel.TabIndex = 4
        Me.RetailLabel.Text = "Retail Price:"
        '
        'RetailPriceLabel
        '
        Me.RetailPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RetailPriceLabel.Location = New System.Drawing.Point(221, 121)
        Me.RetailPriceLabel.Name = "RetailPriceLabel"
        Me.RetailPriceLabel.Size = New System.Drawing.Size(100, 28)
        Me.RetailPriceLabel.TabIndex = 5
        Me.RetailPriceLabel.Text = " "
        '
        'GetRetailPriceButton
        '
        Me.GetRetailPriceButton.Location = New System.Drawing.Point(63, 193)
        Me.GetRetailPriceButton.Name = "GetRetailPriceButton"
        Me.GetRetailPriceButton.Size = New System.Drawing.Size(101, 46)
        Me.GetRetailPriceButton.TabIndex = 6
        Me.GetRetailPriceButton.Text = "Get Retail"
        Me.GetRetailPriceButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(220, 193)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 46)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RetailPriceCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 264)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GetRetailPriceButton)
        Me.Controls.Add(Me.RetailPriceLabel)
        Me.Controls.Add(Me.RetailLabel)
        Me.Controls.Add(Me.PercentMarkupTextBox)
        Me.Controls.Add(Me.MarkupLabel)
        Me.Controls.Add(Me.WholesalePriceTextBox)
        Me.Controls.Add(Me.WholesaleLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RetailPriceCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WholesaleLabel As System.Windows.Forms.Label
    Friend WithEvents WholesalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkupLabel As System.Windows.Forms.Label
    Friend WithEvents PercentMarkupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RetailLabel As System.Windows.Forms.Label
    Friend WithEvents RetailPriceLabel As System.Windows.Forms.Label
    Friend WithEvents GetRetailPriceButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
