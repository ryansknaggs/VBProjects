Public Class InvoiceApp
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        'Instantiate Object
        Dim invoice As New Invoice()
        Dim partNumber As String = partBox.Text
        Dim partDesc As String = dBox.Text
        Dim partPrice As Integer = priceBox.Text
        Dim partQuanity As Integer = qBox.Text

        'Set Invoice 
        invoice.itemQ = partQuanity
        invoice.itemP = partPrice
        invoice.partDes = partDesc
        invoice.partNum = partNumber

        'Display Invoice
        listBox.Items.Add(invoice.DisplayInvoiceAmount)
    End Sub
End Class
