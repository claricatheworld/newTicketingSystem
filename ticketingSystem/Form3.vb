
Imports MySql.Data.MySqlClient

Public Class Form3

    Public table As New DataTable
    Dim empty As Integer
    Dim gender As String
    Dim type As String
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


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        DataGridView1.ReadOnly = True
        errorNotice.Text = ""
    End Sub

    Sub loadTable()

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick



        userID.Text = DataGridView1.Item("userID", DataGridView1.CurrentRow.Index).Value
        firstname.Text = DataGridView1.Item("firstname", DataGridView1.CurrentRow.Index).Value
        middlename.Text = DataGridView1.Item("middlename", DataGridView1.CurrentRow.Index).Value
        lastname.Text = DataGridView1.Item("lastname", DataGridView1.CurrentRow.Index).Value

        age.Text = DataGridView1.Item("age", DataGridView1.CurrentRow.Index).Value

        Dim gender As String
        gender = DataGridView1.Item("gender", DataGridView1.CurrentRow.Index).Value

        If gender = "Male" Then
            male.Checked = True
        ElseIf gender = "Female" Then
            female.Checked = True
        Else
            nonbinary.Checked = True

        End If

        contactnumber.Text = DataGridView1.Item("contactnumber", DataGridView1.CurrentRow.Index).Value
        email.Text = DataGridView1.Item("email", DataGridView1.CurrentRow.Index).Value

        If type = "Admin" Then
            adminAccount.Checked = True
        Else
            cashierAccount.Checked = True

        End If

        username.Text = DataGridView1.Item("username", DataGridView1.CurrentRow.Index).Value
        password.Text = DataGridView1.Item("password", DataGridView1.CurrentRow.Index).Value


        Dim status As String
        status = DataGridView1.Item("status", DataGridView1.CurrentRow.Index).Value

        If status = "Active" Then
            userActive.Checked = True
        Else
            userInactive.Checked = True

        End If

    End Sub

    Private Sub returnViewUser_Click(sender As Object, e As EventArgs) Handles returnViewUser.Click
        Dim viewUser As New Form2

        viewUser.Show()
        Me.Hide()
    End Sub

    Private Sub deleteUser_Click(sender As Object, e As EventArgs) Handles deleteUser.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM useraccount where userID = '" & userID.Text & "' "
            cmd.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("User successfully removed!")

            Call loadTable()

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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateUser_Click(sender As Object, e As EventArgs) Handles updateUser.Click
        Try
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

                'status

                If userActive.Checked Then
                    status = "Active"

                ElseIf userInactive.Checked Then
                    status = "Inactive"
                Else
                    errorNotice.Text = "Please complete the form."

                End If

                cmd.Connection = con
                cmd.CommandText = "UPDATE useraccount SET 
            firstname = '" & firstname.Text & "',
            middlename = '" & middlename.Text & "',
            lastname = '" & lastname.Text & "',    
            age = '" & age.Text & "',
            gender = '" & gender & "',
            contactnumber = '" & contactnumber.Text & "',
            email = '" & email.Text & "',
            type = '" & type & "',
            username = '" & username.Text & "',
            password = '" & password.Text & "',
            status = '" & status & "'
            WHERE userID = '" & userID.Text & "' 
            "

                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("User successfully updated!")

                Call loadTable()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form12.Show()
        Me.Close()
    End Sub
End Class