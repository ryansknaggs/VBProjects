Public Class Invoice
    Public partNumber As String
    Public partDes As String
    Public itemQuanity As Integer
    Public itemPrice As Integer

    Public Sub New()
        partNumber = 0
        partDes = 0
        itemQuanity = 0
        itemPrice = 0
    End Sub

    'ItemPrice
    Public Property itemP() As Integer
        Get
            Return itemPrice
        End Get
        Set(newItemPrice As Integer)
            If newItemPrice < 0 Then
                itemPrice = 0
            Else itemPrice = newItemPrice
            End If
        End Set
    End Property

    'Item Quanity
    Public Property itemQ() As Integer
        Get
            Return itemQuanity
        End Get
        Set(newItemQuanity As Integer)
            If newItemQuanity < 0 Then
                itemQuanity = 0
            Else itemQuanity = newItemQuanity
            End If
        End Set
    End Property

    'Part Description
    Public Property partDescription() As String
        Get
            Return partDes
        End Get
        Set(newPartDes As String)
            partDes = newPartDes
        End Set
    End Property

    'Part Number
    Public Property partNum() As String
        Get
            Return partNumber
        End Get
        Set(newPartNum As String)
            partNumber = newPartNum
        End Set
    End Property

    Public Function DisplayInvoiceAmount()
        Dim total As Integer = itemPrice * itemQuanity
        Return "Part Number: " & partNumber & " Part Description: " & partDes & " Total Cost: " & FormatCurrency(total)
    End Function
End Class
