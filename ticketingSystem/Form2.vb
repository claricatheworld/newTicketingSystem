Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class Form2

    Public table As New DataTable
    Dim empty As Integer
    Dim gender As String
    Dim status As String

    Private Sub viewEvents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvents.LinkClicked
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub viewOrders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrders.LinkClicked
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked

        Me.Show()
    End Sub

    Private Sub addUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addUser.LinkClicked
        Form1.Show()

        Me.Hide()

    End Sub

    Private Sub editUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles editUser.LinkClicked
        Form3.Show()

        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        DataGridView1.ReadOnly = True
        Err()
    End Sub

    Public Sub loadTable()

        Dim adapter As New MySqlDataAdapter(cmd)


        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM useraccount"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class