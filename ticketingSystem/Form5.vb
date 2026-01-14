
Imports MySql.Data.MySqlClient
Public Class Form5


    Public table As New DataTable
    Dim status As String

    Private Sub viewEvents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvent.LinkClicked
        loadTable()
        Me.Show()


    End Sub

    Private Sub viewOrder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrder.LinkClicked
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub



    Private Sub addEvent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addEvent.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub editEvent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles editEvent.LinkClicked
        Form6.loadTable()
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        DataGridView1.ReadOnly = True

    End Sub

    Public Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM event"
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