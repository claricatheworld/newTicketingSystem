Imports MySql.Data.MySqlClient

Public Class Form12
    Dim userType As String
    Dim status As String
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
                Dim status As String = table.Rows(0)("status").ToString()

                If accountType = "Admin" Then
                    userType = "Admin"

                    If status = "Active" Then
                        MessageBox.Show("Welcome Admin " & usernameInput & " !")
                        con.Close()

                        Form5.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Your account is inactive. Please contact the administrator.")
                    End If



                ElseIf accountType = "Cashier" Then
                    userType = "Cashier"

                    If status = "Active" Then
                        MessageBox.Show("Welcome User " & usernameInput & " !")
                        con.Close()

                        Form7.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Your account is inactive. Please contact the administrator.")
                    End If


                End If


            Else
                MessageBox.Show("Username/ Password is incorrect. ")

            End If



            con.Close()


            username.Clear()
            password.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Clear()
        password.Clear()

    End Sub
End Class