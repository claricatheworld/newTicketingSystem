Imports MySql.Data.MySqlClient

Public Class Form10
    Public table As New DataTable

    Private Sub viewEvent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvent.LinkClicked
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub viewOrder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrder.LinkClicked
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
        DataGridView1.ReadOnly = True
    End Sub

    Public Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT t.orderID, 
       e.eventID, e.eventname, e.capacity, e.price, e.eventcode, e.status,
       t.quantity, t.total,
       t.customername, t.customercontactnumber, t.customeremail,
       c.ticketcodeID, c.ticketcodes
FROM ticketorder t
INNER JOIN `event` e ON t.eventID = e.eventID
INNER JOIN ticketcode c ON t.orderID = c.orderID 
WHERE e.status = 'Active'
GROUP BY t.orderID
"


            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.Columns("eventID").Visible = False
            DataGridView1.Columns("capacity").Visible = False
            DataGridView1.Columns("ticketcodeID").Visible = False
            DataGridView1.Columns("ticketcodes").Visible = False

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()




        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick



        orderID.Text = DataGridView1.Item("orderID", DataGridView1.CurrentRow.Index).Value
        eventID.Text = DataGridView1.Item("eventID", DataGridView1.CurrentRow.Index).Value
        eventName.Text = DataGridView1.Item("eventname", DataGridView1.CurrentRow.Index).Value
        eventPrice.Text = DataGridView1.Item("price", DataGridView1.CurrentRow.Index).Value
        orderQuantity.Value = DataGridView1.Item("quantity", DataGridView1.CurrentRow.Index).Value
        orderID.Tag = DataGridView1.Item("total", DataGridView1.CurrentRow.Index).Value
        eventID.Tag = DataGridView1.Item("eventcode", DataGridView1.CurrentRow.Index).Value
        eventCapacity.Text = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value
        eventStatus.Text = DataGridView1.Item("status", DataGridView1.CurrentRow.Index).Value


        customername.Text = DataGridView1.Item("customername", DataGridView1.CurrentRow.Index).Value
        customercontactnumber.Text = DataGridView1.Item("customercontactnumber", DataGridView1.CurrentRow.Index).Value
        customeremail.Text = DataGridView1.Item("customeremail", DataGridView1.CurrentRow.Index).Value

    End Sub

    Private Sub returnViewUser_Click(sender As Object, e As EventArgs) Handles returnViewUser.Click

        eventID.Clear()
        eventName.Clear()
        Dim eventAvailability As Integer = 0
        orderQuantity.Value = 1

        customername.Clear()
        customercontactnumber.Clear()
        customeremail.Clear()


        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub deleteOrder_Click(sender As Object, e As EventArgs) Handles deleteOrder.Click
        openCon()
        Try
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM ticketcode where orderID = '" & orderID.Text & "' "
            cmd.ExecuteNonQuery()

            Dim returnCapacity As Integer = orderQuantity.Value + DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value
            cmd.CommandText = "UPDATE event SET capacity =  " & returnCapacity & " WHERE eventID = '" & eventID.Text & "' "
            cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE FROM ticketorder where orderID = '" & orderID.Text & "' "
            cmd.ExecuteNonQuery()



            MessageBox.Show("Order successfully deleted!")


            Call loadTable()

            con.Close()

            eventID.Clear()
            eventName.Clear()
            Dim eventAvailability As Integer = 0
            orderQuantity.Value = 1

            customername.Clear()
            customercontactnumber.Clear()
            customeremail.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateOrder_Click(sender As Object, e As EventArgs) Handles updateOrder.Click
        openCon()
        Try

            cmd.Connection = con

            ticketVerifier.Text = " "
            errorNotice.Text = ""

            'the capacity of the event
            Dim oldCapacity As Integer = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value

            'the number in the number up down
            Dim newQuantity As Integer = orderQuantity.Value

            'the quantity of the order
            Dim oldQuantity As Integer = DataGridView1.Item("quantity", DataGridView1.CurrentRow.Index).Value


            'orderQuantity.Value = 5 - capacity that is 2 = 3 need to add
            Dim need As Integer = newQuantity - oldQuantity

            'if capacity is 2 - need 3 = -1 not enough
            Dim availability As Integer = oldCapacity - need



            'FOR CAPACITY RANGE CHECKING-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            If need > oldCapacity Then
                ticketVerifier.Text = "Only " & oldCapacity & " tickets are available!"
                ticketVerifier.Refresh()
                orderQuantity.Value = oldQuantity

                con.Close()

                'ADD MORE TICKETS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ElseIf need > 0 Then
                If String.IsNullOrWhiteSpace(customername.Text) OrElse 'form validation
                        Not customercontactnumber.MaskCompleted OrElse
                        String.IsNullOrWhiteSpace(customeremail.Text) Then

                    errorNotice.Text = "Please complete form."
                    errorNotice.Refresh()

                    Exit Sub

                Else


                    'proceed to update (add more) order 

                    Dim code1 As String = orderID.Text
                    Dim code2 As String = eventID.Text
                    Dim code3 As String = (orderQuantity.Value).ToString

                    Dim ticketHolder As String = ""

                    For i = 1 To need
                        Dim generateCode As String = eventID.Tag & code1 & i & code3 & code2 & i
                        cmd.CommandText = "INSERT INTO ticketcode (
`orderID`, `eventID` , `eventname`,  `ticketcodes`, 
`customername`, `status`
)

VALUES (
'" & orderID.Text & "','" & eventID.Text & "', '" & eventName.Text & "', '" & generateCode & "',
'" & customername.Text & "', '" & eventStatus.Text & "'
)
"
                        cmd.ExecuteNonQuery()

                        ticketHolder &= generateCode & vbCrLf


                    Next

                    'update capacity of the event
                    Dim newCapacity As Integer = oldCapacity - need
                    cmd.CommandText = "UPDATE event SET capacity =  " & newCapacity & "
WHERE eventID = '" & eventID.Text & "' "
                    cmd.ExecuteNonQuery()

                    'update total amount and order qty
                    Dim oldTotal As Integer = orderID.Tag
                    Dim newTotal As Integer = eventPrice.Text * newQuantity

                    cmd.CommandText = "UPDATE ticketorder SET quantity = " & newQuantity & ", total =  " & newTotal & " ,
customername = '" & customername.Text & "', customercontactnumber = '" & customercontactnumber.Text & "',  customeremail = '" & customeremail.Text & "'
WHERE orderID = '" & orderID.Text & "' "
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE ticketcode SET  customername = '" & customername.Text & "'
WHERE orderID = '" & orderID.Text & "' "

                    cmd.ExecuteNonQuery()



                    Dim printReceipt As New Form8()

                    'prop short for property
                    printReceipt.propNameEvent = eventName.Text
                    printReceipt.propOrderID = orderID.Text
                    printReceipt.propCustomerName = customername.Text
                    printReceipt.propQty = newQuantity.ToString()
                    printReceipt.propTicketCodes = ticketHolder
                    printReceipt.propTotalAmount = (newTotal).ToString()
                    printReceipt.Show()

                    MessageBox.Show("Order successfully updated!")
                    con.Close()

                    eventID.Clear()
                    eventName.Clear()
                    Dim eventAvailability As Integer = 0
                    orderQuantity.Value = 1

                    customername.Clear()
                    customercontactnumber.Clear()
                    customeremail.Clear()


                    Form9.Show()
                    Me.Hide()




                End If

                ' REFUND TICKETS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ElseIf need < 0 Then
                If String.IsNullOrWhiteSpace(customername.Text) OrElse 'form validation
                           Not customercontactnumber.MaskCompleted OrElse
                           String.IsNullOrWhiteSpace(customeremail.Text) Then
                    errorNotice.Text = "Please complete form."
                    errorNotice.Refresh()

                    Exit Sub

                Else  'proceed to remove ticket codes for refund

                    'if there's any changes in customer name
                    cmd.CommandText = "UPDATE ticketcode SET customername = '" & customername.Text & "'
WHERE orderID = '" & orderID.Text & "' "
                    cmd.ExecuteNonQuery()


                    Dim refundTimes As Integer = Math.Abs(need)
                    cmd.CommandText = "DELETE FROM ticketcode 
where orderID = '" & orderID.Text & "' 
ORDER BY ticketCodeID DESC 
                        LIMIT " & refundTimes
                    cmd.ExecuteNonQuery()


                    'update customer order (qty and total)
                    Dim ticketPrice As Integer = DataGridView1.Item("price", DataGridView1.CurrentRow.Index).Value
                    Dim refundedTotal = ticketPrice * newQuantity
                    cmd.CommandText = "UPDATE ticketorder SET quantity = " & newQuantity & ", total =  " & refundedTotal & " ,
customername = '" & customername.Text & "', customercontactnumber = '" & customercontactnumber.Text & "',  customeremail = '" & customeremail.Text & "'
WHERE orderID = '" & orderID.Text & "' "
                    cmd.ExecuteNonQuery()

                    'return the capacity back to the event
                    Dim returnCapacity As Integer = oldCapacity + refundTimes
                    cmd.CommandText = "UPDATE event SET capacity =  " & returnCapacity & " WHERE eventID = '" & eventID.Text & "' "
                    cmd.ExecuteNonQuery()




                    MessageBox.Show("Ticket Codes successfully remove!")

                    eventID.Clear()
                    eventName.Clear()
                    Dim eventAvailability As Integer = 0
                    orderQuantity.Value = 1

                    customername.Clear()
                    customercontactnumber.Clear()
                    customeremail.Clear()
                    con.Close()

                    Form9.Show()
                    Me.Hide()
                End If



            Else
                ticketVerifier.Text = "Only " & oldCapacity & " tickets are available!"
                ticketVerifier.Refresh()

                orderQuantity.Value = oldQuantity
            con.Close()


            End If
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)



        End Try

    End Sub

End Class