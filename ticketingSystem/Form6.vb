Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form6

    Public table As New DataTable
    Dim status As String

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





    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        DataGridView1.ReadOnly = True

        eventID.Clear()
        eventName.Clear()
        eventDate.Clear()
        timeStart.Clear()
        timeEnd.Clear()
        eventVenue.Clear()
        capacity.Clear()
        ticketPrice.Clear()
        eventDetails.Clear()
        eventActive.Checked = False
        eventInactive.Checked = False
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        eventID.Text = DataGridView1.Item("eventID", DataGridView1.CurrentRow.Index).Value
        eventName.Text = DataGridView1.Item("eventname", DataGridView1.CurrentRow.Index).Value
        eventDate.Text = DataGridView1.Item("date", DataGridView1.CurrentRow.Index).Value
        timeStart.Text = DataGridView1.Item("starttime", DataGridView1.CurrentRow.Index).Value
        timeEnd.Text = DataGridView1.Item("endtime", DataGridView1.CurrentRow.Index).Value
        eventVenue.Text = DataGridView1.Item("venue", DataGridView1.CurrentRow.Index).Value
        capacity.Text = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value
        ticketPrice.Text = DataGridView1.Item("capacity", DataGridView1.CurrentRow.Index).Value
        eventDetails.Text = DataGridView1.Item("details", DataGridView1.CurrentRow.Index).Value

        If status = "Active" Then
            eventActive.Checked = True
        ElseIf status = "Inactive" Then
            eventInactive.Checked = True

        End If

    End Sub

    Private Sub returnViewUser_Click(sender As Object, e As EventArgs) Handles returnViewUser.Click
        eventID.Clear()
        eventName.Clear()
        eventDate.Clear()
        timeStart.Clear()
        timeEnd.Clear()
        eventVenue.Clear()
        capacity.Clear()
        ticketPrice.Clear()
        eventDetails.Clear()
        eventActive.Checked = False
        eventInactive.Checked = False

        Form5.Show()
        Me.Hide()


    End Sub


    Private Sub updateUser_Click(sender As Object, e As EventArgs) Handles updateUser.Click
        openCon()
        Try


            'Status

            If eventActive.Checked Then
                status = "Active"

            ElseIf eventInactive.Checked Then
                status = "Inactive"

            Else
                errorNotice.Text = "Please complete the form."
            End If

            'complete form validation
            If String.IsNullOrWhiteSpace(eventName.Text) OrElse
            Not eventDate.MaskCompleted OrElse
            Not timeStart.MaskCompleted OrElse
            Not timeEnd.MaskCompleted OrElse
            String.IsNullOrWhiteSpace(eventVenue.Text) OrElse
            String.IsNullOrWhiteSpace(capacity.Text) OrElse
            String.IsNullOrWhiteSpace(ticketPrice.Text) OrElse
            String.IsNullOrWhiteSpace(eventDetails.Text) OrElse
            Not (eventActive.Checked Or eventInactive.Checked) Then

                errorNotice.Text = "Please complete the form."

            Else



                'status

                If eventActive.Checked Then
                    status = "Active"

                ElseIf eventInactive.Checked Then
                    status = "Inactive"
                Else
                    errorNotice.Text = "Please complete the form."

                End If

                cmd.Connection = con

                'update event details
                cmd.CommandText = "UPDATE event SET 
eventname = '" & eventName.Text & "',
date = '" & eventDate.Text & "', starttime = '" & timeStart.Text & "', endtime = '" & timeEnd.Text & "',
venue = '" & eventVenue.Text & "', capacity = '" & capacity.Text & "', price = '" & ticketPrice.Text & "',status = '" & status & "',
details = '" & eventDetails.Text & "'

WHERE eventID = '" & eventID.Text & "'  "
                cmd.ExecuteNonQuery()

                'update ticketcodes status
                cmd.CommandText = "UPDATE ticketcode SET eventID = '" & eventID.Text & "', eventname = '" & eventName.Text & "',
status =  ' " & status & " '
WHERE eventID = '" & eventID.Text & "' "
                cmd.ExecuteNonQuery()


                MessageBox.Show("Event successfully updated!")


                con.Close()


                eventID.Clear()
                eventName.Clear()
                eventDate.Clear()
                timeStart.Clear()
                timeEnd.Clear()
                eventVenue.Clear()
                capacity.Clear()
                ticketPrice.Clear()
                eventDetails.Clear()
                eventActive.Checked = False
                eventInactive.Checked = False

                Form5.loadTable()
                Form5.Show()
                'Me.loadTable()
                Me.Hide()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


End Class