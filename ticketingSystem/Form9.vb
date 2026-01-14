Imports MySql.Data.MySqlClient

Public Class Form9
    Public table As New DataTable


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub viewEvents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvents.LinkClicked
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub viewOrders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrders.LinkClicked
        loadTable()
        Me.Show()
    End Sub
    Private Sub addOrder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addOrder.LinkClicked
        Form10.loadTable()
        Form7.Show()
        Me.Hide()
    End Sub


    Private Sub editOrder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles editOrder.LinkClicked

        Form10.loadTable()
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Public Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT t.orderID, e.eventname , t.quantity, t.total, 
t.customername, t.customercontactnumber, t.customeremail, e.status
FROM ticketorder t 
INNER JOIN
event e ON t.eventID = e.eventID"


            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub


End Class