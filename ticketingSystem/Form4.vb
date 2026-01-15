Public Class Form4

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




    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eventName.Clear()
        eventCode.Clear()
        eventDate.Clear()
        timeStart.Clear()
        timeEnd.Clear()
        eventVenue.Clear()
        capacity.Clear()
        ticketPrice.Clear()
        eventDetails.Clear()
        eventActive.Checked = False
        eventInactive.Checked = False

        errorNotice.Refresh()


    End Sub

    Private Sub addEvent_Click(sender As Object, e As EventArgs) Handles addEvent.Click
        Try


            'Status
            If eventActive.Checked Then
                status = "Active"

            ElseIf eventInactive.Checked Then
                status = "Inactive"

            Else
                errorNotice.Text = "Please complete the form."
            End If

            If String.IsNullOrWhiteSpace(eventName.Text) OrElse
            String.IsNullOrWhiteSpace(eventCode.Text) OrElse
            Not eventDate.MaskCompleted OrElse
            Not timeStart.MaskCompleted OrElse
            Not timeEnd.MaskCompleted OrElse
            String.IsNullOrWhiteSpace(eventVenue.Text) OrElse
            String.IsNullOrWhiteSpace(capacity.Text) OrElse
            String.IsNullOrWhiteSpace(eventDetails.Text) OrElse
            Not (eventActive.Checked Or eventInactive.Checked) Then

                errorNotice.Text = "Please complete the form."

            Else

                openCon()

                cmd.Connection = con
                cmd.CommandText = "INSERT INTO event (
`eventname` ,`eventcode` ,`date`, `starttime`,`endtime`,
`venue`, `capacity`, `price`, `details`, `status`)

VALUES (
'" & eventName.Text & "','" & eventCode.Text & "',  '" & eventDate.Text & "', 
'" & timeStart.Text & "', '" & timeEnd.Text & "',
'" & eventVenue.Text & "', '" & capacity.Text & "',  '" & ticketPrice.Text & "','" & eventDetails.Text & "',
'" & status & "'
)"

                cmd.ExecuteNonQuery()
                errorNotice.Text = " "
                MessageBox.Show("Event succesfully added!")

                con.Close()


                eventName.Clear()
                eventCode.Clear()
                eventDate.Clear()
                timeStart.Clear()
                timeEnd.Clear()
                eventVenue.Clear()
                capacity.Clear()
                ticketPrice.Clear()
                eventDetails.Clear()
                eventActive.Checked = False
                eventInactive.Checked = False

                errorNotice.Refresh()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try


        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub clearForm_Click(sender As Object, e As EventArgs) Handles clearForm.Click
        eventName.Clear()
        eventCode.Clear()
        eventDate.Clear()
        timeStart.Clear()
        timeEnd.Clear()
        eventVenue.Clear()
        capacity.Clear()
        ticketPrice.Clear()
        eventDetails.Clear()
        eventActive.Checked = False
        eventInactive.Checked = False

        errorNotice.Refresh()
    End Sub

    Private Sub logOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logOut.LinkClicked
        Form12.Show()
        Me.Close()
    End Sub
End Class