Public Class Form1
    Dim retailprice, wholesalecost, grossprofit, storagecharges, netprofit As Decimal
    Dim Quantity As Integer
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RetailPriceTooltip_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            'Declaring Varialbles


            Const percentvalue As Single = 0.05


            'Accepting and Parsing values
            retailprice = Decimal.Parse(RetailTextbox.Text)
            wholesalecost = Decimal.Parse(WholesaleTextbox.Text)
            Quantity = Integer.Parse(QuantityTextbox.Text)

            'Calculations
            grossprofit = Quantity * (retailprice - wholesalecost)
            storagecharges = percentvalue * grossprofit
            netprofit = grossprofit - storagecharges

            'storing calculated values
            GrossTextbox.Text = grossprofit.ToString("C2")
            StorageTextbox.Text = storagecharges.ToString("C2")
            NetProfitTextbox.Text = netprofit.ToString("C2")

            ComputeButton.Enabled = False
            ResetButton.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error in Retail Price,Wholesale Price or Quantity.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        PartIdentifierTextbox.Clear()
        PartDescriptionTextbox.Clear()
        RetailTextbox.Clear()
        WholesaleTextbox.Clear()
        QuantityTextbox.Clear()
        GrossTextbox.Clear()
        StorageTextbox.Clear()
        NetProfitTextbox.Clear()

        ComputeButton.Enabled = True
        ResetButton.Enabled = False
        PartIdentifierTextbox.Focus()



    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Try
            Dim avgNetpay As Decimal
            Dim msgString As String

            avgNetpay = netprofit / Quantity

            msgString = "Total Net Profit : " & netprofit.ToString("c2") & ControlChars.NewLine & "Total Quantity of Parts :" &
                Quantity.ToString("N0") & ControlChars.NewLine & "Average Netpay: " & avgNetpay.ToString("C2")

            MessageBox.Show(msgString, "Totals and Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ArithmeticException
            MessageBox.Show("No parts estimates have been made yet!", "Invalid estimation", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error with total net profit button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
