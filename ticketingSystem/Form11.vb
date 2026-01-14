Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Mysqlx.XDevAPI.Relational

Public Class Form11
    Public table As New DataTable

    'the properties to receive data from Form+10
    Public propNameEvent As String
    Public propOrderID As Integer
    Public propCustomerName As String
    Public propQty As Integer
    Public propTotalAmount As Integer

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nameofthevent.Text = propNameEvent
        displayOrderID.Text = propOrderID
        displayCustomerName.Text = propCustomerName
        displayQty.Text = propQty.ToString
        displayTotalAmount.Text = propTotalAmount


        loadTable()

    End Sub

    Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT ticketcodes FROM ticketcode WHERE orderID =  '" & displayOrderID.Text & "'  "
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)



            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub closeReceipt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closeReceipt.LinkClicked
        table.Clear()
        Me.Hide()

    End Sub
End Class