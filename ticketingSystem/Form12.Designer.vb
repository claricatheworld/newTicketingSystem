<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        password = New TextBox()
        username = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        login = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(226, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(408, 46)
        Label3.TabIndex = 9
        Label3.Text = "TICKETING SYSTEM"
        ' 
        ' password
        ' 
        password.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        password.Font = New Font("Arial", 9F)
        password.Location = New Point(303, 316)
        password.Name = "password"
        password.PlaceholderText = "Enter password"
        password.Size = New Size(256, 21)
        password.TabIndex = 31
        ' 
        ' username
        ' 
        username.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        username.Font = New Font("Arial", 9F)
        username.Location = New Point(303, 239)
        username.Name = "username"
        username.PlaceholderText = "Enter username"
        username.Size = New Size(256, 21)
        username.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(303, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 24)
        Label4.TabIndex = 32
        Label4.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(303, 289)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 24)
        Label1.TabIndex = 33
        Label1.Text = "Password:"
        ' 
        ' login
        ' 
        login.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        login.Location = New Point(386, 378)
        login.Name = "login"
        login.Size = New Size(89, 32)
        login.TabIndex = 35
        login.Text = "LOG IN"
        login.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(51, 561)
        Label2.Name = "Label2"
        Label2.Size = New Size(758, 19)
        Label2.TabIndex = 36
        Label2.Text = "James Patrick Austria | Anabel Buta | Clarica Clamor | Benson Delos Reyes | John Landscape Ubando"
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 611)
        Controls.Add(Label2)
        Controls.Add(login)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label3)
        Name = "Form12"
        Text = "Form12"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents login As Button
    Friend WithEvents Label2 As Label
End Class
