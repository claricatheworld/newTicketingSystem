Imports MySql.Data.MySqlClient

Public Class Form12
    Dim userType As String
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        Dim usernameInput As String = username.Text
        Dim passwordInput As String = password.Text
        Dim adapter As New MySqlDataAdapter

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM useraccount WHERE username=@username AND password=@password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", usernameInput)
            cmd.Parameters.AddWithValue("@password", passwordInput)

            adapter.SelectCommand = cmd

            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim accountType As String = table.Rows(0)("type").ToString()

                If accountType = "Admin" Then

                    userType = "Admin"
                    MessageBox.Show("Welcome Admin" & usernameInput & " !")
                    con.Close()


                    Form5.Show()
                    Me.Hide()


                ElseIf accountType = "Cashier" Then


                    userType = "Cashier"
                    MessageBox.Show("Welcome User" & usernameInput & " !")
                    con.Close()

                    Form7.Show()
                    Me.Hide()
                End If


            Else
                MessageBox.Show("Username/ Password is incorrect.")

            End If



            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



End Class