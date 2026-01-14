
Public Class Form8
    'the properties to receive data from Form7
    Public propNameEvent As String
    Public propOrderID As Integer
    Public propCustomerName As String
    Public propQty As Integer
    Public propTicketCodes As String
    Public propTotalAmount As Integer



    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameofthevent.Text = propNameEvent
        displayOrderID.Text = propOrderID
        displayCustomerName.Text = propCustomerName
        displayQty.Text = propQty.ToString
        displayTicketCodes.Text = propTicketCodes
        displayTotalAmount.Text = propTotalAmount

    End Sub

    Private Sub closeReceipt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closeReceipt.LinkClicked
        Form9.loadTable()
        Form9.Show()
        Form7.Hide()

        Me.Hide()
    End Sub
End Class