Public Class RetailPriceCalculator
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub GetRetailPriceButton_Click(sender As Object, e As EventArgs) Handles GetRetailPriceButton.Click
        ' Declare variables
        Dim WholesaleCost As Double
        Dim PercentMarkup As Double
        ' check inputs
        If Double.TryParse(WholesalePriceTextBox.Text, WholesaleCost) Then
            If Double.TryParse(PercentMarkupTextBox.Text, PercentMarkup) Then
                ' if user puts in a decimal value less than 1, convert it.
                If (PercentMarkup < 1) Then
                    MessageBox.Show("Enter the markup as 10 for 10%, etc.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                RetailPriceLabel.Text = CalculateRetailPrice(WholesaleCost, PercentMarkup).ToString("c")
            Else
                MessageBox.Show("Enter the markup price as a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Enter the wholesale price as a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function CalculateRetailPrice(WholesalePrice As Double, Percent As Double) As Double
        Dim Markup As Double = WholesalePrice * (Percent / 100)
        Return WholesalePrice + Markup
    End Function
End Class
