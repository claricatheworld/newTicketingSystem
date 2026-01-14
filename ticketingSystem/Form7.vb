Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient


Public Class Form7

    Public table As New DataTable


    Private Sub viewEvents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvents.LinkClicked
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub viewOrders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrders.LinkClicked
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub refreshSelect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles refreshSelect.LinkClicked
        selectedEvent.Visible = False
        orderTicket.Visible = False

        quantity.Value = 1
        customername.Clear()
        customercontactnumber.Clear()
        customeremail.Clear()

        errorNotice.Text = ""
        ticketVerifier.Text = ""


        loadTable()

    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectedEvent.Visible = False
        orderTicket.Visible = False

        quantity.Value = 1
        customername.Clear()
        customercontactnumber.Clear()
        customeremail.Clear()

        loadTable()
        DataGridView1.ReadOnly = True

        errorNotice.Text = ""
        ticketVerifier.Text = ""
    End Sub



    Public Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM event WHERE capacity > 0 AND status = 'Active' "
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.Columns("eventID").Visible = False
            DataGridView1.Columns("eventcode").Visible = False
            DataGridView1.Columns("date").Visible = False
            DataGridView1.Columns("starttime").Visible = False
            DataGridView1.Columns("endtime").Visible = False
            DataGridView1.Columns("venue").Visible = False
            DataGridView1.Columns("capacity").Visible = False
            DataGridView1.Columns("price").Visible = False
            DataGridView1.Columns("details").Visible = False
            DataGridView1.Columns("status").Visible = False



            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedEvent.Visible = True
        orderTicket.Visible = True
        eventID.Text = DataGridView1.Item("eventID", DataGridView1.CurrentRow.Index).Value
        nameEvent.Text = DataGridView1.Item("eventname", DataGridView1.CurrentRow.Index).Value
        eventID.Tag = DataGridView1.Item("eventcode", DataGridView1.CurrentRow.Index).Value
        dateEvent.Text = "DATE: " & DataGridView1.Item("date", DataGridView1.CurrentRow.Index).Value
        starttime.Text = "TIME: " & DataGridView1.Item("starttime", DataGridView1.CurrentRow.Index).Value
        endtime.Text = "- " & DataGridView1.Item("endtime", DataGridView1.CurrentRow.Index).Value
        venueEvent.Text = "VENUE: " & DataGridView1.Item("venue", DataGridView1.CurrentRow.Index).Value
        capacityDisplay.Text = "AVAILABLE: " & DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value
        ticketPrice.Text = "PRICE: " & DataGridView1.Item("price", DataGridView1.CurrentRow.Index).Value
        detailsText.Text = "DETAILS: "
        showDetails.Text = DataGridView1.Item("details", DataGridView1.CurrentRow.Index).Value
        statusEvent.Text = DataGridView1.Item("status", DataGridView1.CurrentRow.Index).Value

    End Sub

    Private Sub orderTicket_Click(sender As Object, e As EventArgs) Handles orderTicket.Click

        Dim eventRow As Integer = DataGridView1.Item("eventID", DataGridView1.CurrentRow.Index).Value
        Dim total As Integer
        Dim price As Integer = DataGridView1.Item("price", DataGridView1.CurrentRow.Index).Value

        Dim qty As Integer = quantity.Value
        Dim available As Integer = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value



        Try
            If qty > available Then
                ticketVerifier.Text = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value & " ticket(s) are available."

            Else

                If String.IsNullOrWhiteSpace(customername.Text) OrElse
                 Not customercontactnumber.MaskCompleted OrElse
                 String.IsNullOrWhiteSpace(customeremail.Text) Then

                    errorNotice.Text = "Please complete form."

                Else
                    total = price * qty



                    openCon()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO ticketorder (
`eventID` , `quantity`, `total`, 
`customername`, `customercontactnumber`, `customeremail`
)

VALUES (
'" & eventID.Text & "', '" & quantity.Text & "', '" & total & "',
'" & customername.Text & "', '" & customercontactnumber.Text & "', '" & customeremail.Text & "'
)"

                    cmd.ExecuteNonQuery()
                    Dim recentOrder As Integer = cmd.LastInsertedId


                    available = available - qty
                    cmd.CommandText = "UPDATE event SET capacity = '" & available & "' WHERE eventID = '" & eventRow & "' "
                    cmd.ExecuteNonQuery()


                    quantity.Value = 1



                    Dim code1 As String = (recentOrder).ToString
                    Dim code2 As String = (eventID.Text).ToString
                    Dim code3 As String = (qty).ToString

                    Dim ticketHolder As String = ""


                    For i = 1 To qty
                        Dim generateCode As String = eventID.Tag & code1 & i & code2 & code3 & i


                        cmd.CommandText = "INSERT INTO ticketcode (
`orderID`, `eventID` , `eventname`,  `ticketcodes`, 
`customername`, `status`
)

VALUES (
'" & recentOrder & "','" & eventID.Text & "', '" & nameEvent.Text & "', '" & generateCode & "',
'" & customername.Text & "', '" & statusEvent.Text & "'
)"
                        cmd.ExecuteNonQuery()

                        ticketHolder &= generateCode & vbCrLf
                    Next

                    Dim printReceipt As New Form8()

                    'prop short for property
                    printReceipt.propNameEvent = nameEvent.Text
                    printReceipt.propOrderID = recentOrder.ToString()
                    printReceipt.propCustomerName = customername.Text
                    printReceipt.propQty = qty.ToString()
                    printReceipt.propTicketCodes = ticketHolder
                    printReceipt.propTotalAmount = total.ToString()

                    printReceipt.Show()


                    con.Close()


                    MessageBox.Show("Order Confirmed.")


                    loadTable()
                    customername.Clear()
                    customercontactnumber.Clear()
                    customeremail.Clear()
                    selectedEvent.Visible = False
                    orderTicket.Visible = False
                    quantity.Value = 1


                    ticketVerifier.Text = ""
                    errorNotice.Text = ""


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub




End Class