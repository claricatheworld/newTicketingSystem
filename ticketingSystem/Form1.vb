Public Class Form1


    Dim gender As String
    Dim type As String
    Dim status As String

    Public propAccountType As String

    Private Sub viewEvents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewEvents.LinkClicked
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub viewOrders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewOrders.LinkClicked
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub viewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewUser.LinkClicked
        Form2.loadTable()
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        firstname.Clear()
        middlename.Clear()
        lastname.Clear()


        age.Clear()

        male.Checked = False
        female.Checked = False
        nonbinary.Checked = False


        contactnumber.Clear()
        email.Clear()

        adminAccount.Checked = False
        cashierAccount.Checked = False


        username.Clear()
        password.Clear()

        userActive.Checked = False
        userInactive.Checked = False

        errorNotice.Refresh()

    End Sub

    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click

        Try
            'Gender

            If male.Checked Then
                gender = "Male"

            ElseIf female.Checked Then
                gender = "Female"

            ElseIf nonbinary.Checked Then
                gender = "Prefer not to say"
            Else
                errorNotice.Text = "Please complete the form."
            End If

            'type

            If adminAccount.Checked Then
                type = "Admin"
            ElseIf cashierAccount.Checked Then
                type = "Cashier"
            Else
                errorNotice.Text = "Please complete the form."
            End If

            'Status

            If userActive.Checked Then
                status = "Active"

            ElseIf userInactive.Checked Then
                status = "Inactive"

            Else
                errorNotice.Text = "Please complete the form."
            End If



            If String.IsNullOrWhiteSpace(firstname.Text) OrElse
                 String.IsNullOrWhiteSpace(lastname.Text) OrElse
                 String.IsNullOrWhiteSpace(age.Text) OrElse
                 Not (male.Checked Or female.Checked Or nonbinary.Checked) OrElse
                 Not contactnumber.MaskCompleted OrElse
                 String.IsNullOrWhiteSpace(email.Text) OrElse
                 Not (adminAccount.Checked Or cashierAccount.Checked) OrElse
                 String.IsNullOrWhiteSpace(username.Text) OrElse
                 String.IsNullOrWhiteSpace(password.Text) OrElse
                 Not (userActive.Checked Or userInactive.Checked) Then


                errorNotice.Text = "Please complete the form."


            Else

                openCon()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO useraccount (
`firstname` , `middlename`, `lastname`,
`age`, `gender`,
`contactnumber`, `email`,
`type`, `username`, `password`, `status`
)

VALUES (
 '" & firstname.Text & "', '" & middlename.Text & "', '" & lastname.Text & "', 
          '" & age.Text & "', '" & gender & "',
          '" & contactnumber.Text & "', '" & email.Text & "', 
          '" & type & "', '" & username.Text & "', '" & password.Text & "' ,'" & status & "'
)"

                cmd.ExecuteNonQuery()
                errorNotice.Text = " "
                MessageBox.Show("User succesfully registered!")
                con.Close()

                Form2.loadTable()
                Form2.Show()
                Me.Hide()

                'CLEAR FORM AFTER REGISTERED A USER
                firstname.Clear()
                middlename.Clear()
                lastname.Clear()


                age.Clear()

                male.Checked = False
                female.Checked = False
                nonbinary.Checked = False


                contactnumber.Clear()
                email.Clear()

                adminAccount.Checked = False
                cashierAccount.Checked = False


                username.Clear()
                password.Clear()

                userActive.Checked = False
                userInactive.Checked = False

                errorNotice.Refresh()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    Private Sub clearForm_Click(sender As Object, e As EventArgs) Handles clearForm.Click
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()


        age.Clear()

        male.Checked = False
        female.Checked = False
        nonbinary.Checked = False


        contactnumber.Clear()
        email.Clear()

        adminAccount.Checked = False
        cashierAccount.Checked = False


        username.Clear()
        password.Clear()

        userActive.Checked = False
        userInactive.Checked = False

        errorNotice.Refresh()
    End Sub

    Private Sub errorNotice_Click(sender As Object, e As EventArgs) Handles errorNotice.Click

    End Sub
End Class
