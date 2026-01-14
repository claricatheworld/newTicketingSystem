<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        LinkLabel5 = New LinkLabel()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        DataGridView1 = New DataGridView()
        errorNotice = New Label()
        password = New TextBox()
        Label9 = New Label()
        username = New TextBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        userInactive = New RadioButton()
        userActive = New RadioButton()
        GroupBox2 = New GroupBox()
        cashierAccount = New RadioButton()
        adminAccount = New RadioButton()
        Label8 = New Label()
        email = New TextBox()
        Label2 = New Label()
        Label6 = New Label()
        contactnumber = New MaskedTextBox()
        GroupBox1 = New GroupBox()
        female = New RadioButton()
        nonbinary = New RadioButton()
        male = New RadioButton()
        age = New MaskedTextBox()
        Label5 = New Label()
        lastname = New TextBox()
        middlename = New TextBox()
        firstname = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        deleteUser = New Button()
        updateUser = New Button()
        returnViewUser = New Button()
        userID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Arial", 10F)
        LinkLabel5.LinkColor = Color.White
        LinkLabel5.Location = New Point(791, 8)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(58, 16)
        LinkLabel5.TabIndex = 20
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Log Out"
        ' 
        ' viewOrder
        ' 
        viewOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrder.AutoSize = True
        viewOrder.BackColor = Color.Transparent
        viewOrder.Font = New Font("Arial", 9.75F)
        viewOrder.LinkColor = Color.White
        viewOrder.Location = New Point(113, 9)
        viewOrder.Name = "viewOrder"
        viewOrder.Size = New Size(46, 16)
        viewOrder.TabIndex = 18
        viewOrder.TabStop = True
        viewOrder.Text = "Orders"
        ' 
        ' viewUser
        ' 
        viewUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewUser.AutoSize = True
        viewUser.BackColor = Color.Transparent
        viewUser.Font = New Font("Arial", 9.75F)
        viewUser.LinkColor = Color.White
        viewUser.Location = New Point(165, 9)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 17
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewEvent
        ' 
        viewEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvent.AutoSize = True
        viewEvent.BackColor = Color.Transparent
        viewEvent.Font = New Font("Arial", 9.75F)
        viewEvent.LinkColor = Color.White
        viewEvent.Location = New Point(59, 9)
        viewEvent.Name = "viewEvent"
        viewEvent.Size = New Size(46, 16)
        viewEvent.TabIndex = 16
        viewEvent.TabStop = True
        viewEvent.Text = "Events"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 60)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 268)
        DataGridView1.TabIndex = 21
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 729)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(0, 16)
        errorNotice.TabIndex = 52
        ' 
        ' password
        ' 
        password.Font = New Font("Arial", 9F)
        password.Location = New Point(433, 703)
        password.Name = "password"
        password.PlaceholderText = "Enter password"
        password.Size = New Size(415, 21)
        password.TabIndex = 51
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(433, 685)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 16)
        Label9.TabIndex = 50
        Label9.Text = "Password:"
        ' 
        ' username
        ' 
        username.Font = New Font("Arial", 9F)
        username.Location = New Point(12, 703)
        username.Name = "username"
        username.PlaceholderText = "Enter username"
        username.Size = New Size(415, 21)
        username.TabIndex = 49
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 685)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 16)
        Label7.TabIndex = 48
        Label7.Text = "Username:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(userInactive)
        GroupBox3.Controls.Add(userActive)
        GroupBox3.Font = New Font("Arial", 9F)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(433, 615)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(415, 56)
        GroupBox3.TabIndex = 47
        GroupBox3.TabStop = False
        GroupBox3.Text = "Status"
        ' 
        ' userInactive
        ' 
        userInactive.AutoSize = True
        userInactive.BackColor = Color.Transparent
        userInactive.Location = New Point(160, 17)
        userInactive.Name = "userInactive"
        userInactive.Size = New Size(66, 19)
        userInactive.TabIndex = 29
        userInactive.TabStop = True
        userInactive.Text = "Inactive"
        userInactive.UseVisualStyleBackColor = False
        ' 
        ' userActive
        ' 
        userActive.AutoSize = True
        userActive.BackColor = Color.Transparent
        userActive.Location = New Point(66, 17)
        userActive.Name = "userActive"
        userActive.Size = New Size(56, 19)
        userActive.TabIndex = 28
        userActive.TabStop = True
        userActive.Text = "Active"
        userActive.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(cashierAccount)
        GroupBox2.Controls.Add(adminAccount)
        GroupBox2.Font = New Font("Arial", 9F)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(12, 615)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(415, 56)
        GroupBox2.TabIndex = 46
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Type"
        ' 
        ' cashierAccount
        ' 
        cashierAccount.AutoSize = True
        cashierAccount.BackColor = Color.Transparent
        cashierAccount.Location = New Point(191, 17)
        cashierAccount.Name = "cashierAccount"
        cashierAccount.Size = New Size(69, 19)
        cashierAccount.TabIndex = 27
        cashierAccount.TabStop = True
        cashierAccount.Text = "Cashier"
        cashierAccount.UseVisualStyleBackColor = False
        ' 
        ' adminAccount
        ' 
        adminAccount.AutoSize = True
        adminAccount.BackColor = Color.Transparent
        adminAccount.Location = New Point(83, 17)
        adminAccount.Name = "adminAccount"
        adminAccount.Size = New Size(60, 19)
        adminAccount.TabIndex = 26
        adminAccount.TabStop = True
        adminAccount.Text = "Admin"
        adminAccount.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 564)
        Label8.Name = "Label8"
        Label8.Size = New Size(196, 24)
        Label8.TabIndex = 45
        Label8.Text = "ACCOUNT DETAILS"
        ' 
        ' email
        ' 
        email.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        email.Font = New Font("Arial", 9F)
        email.Location = New Point(433, 521)
        email.Name = "email"
        email.PlaceholderText = "Enter email address"
        email.Size = New Size(415, 21)
        email.TabIndex = 44
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(433, 503)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 16)
        Label2.TabIndex = 43
        Label2.Text = "Email address:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(12, 503)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 16)
        Label6.TabIndex = 42
        Label6.Text = "Contact Number:"
        ' 
        ' contactnumber
        ' 
        contactnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contactnumber.Location = New Point(12, 521)
        contactnumber.Mask = "00000000000"
        contactnumber.Name = "contactnumber"
        contactnumber.Size = New Size(415, 23)
        contactnumber.TabIndex = 41
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(female)
        GroupBox1.Controls.Add(nonbinary)
        GroupBox1.Controls.Add(male)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(293, 444)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 41)
        GroupBox1.TabIndex = 40
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.BackColor = Color.Transparent
        female.Location = New Point(54, 18)
        female.Name = "female"
        female.Size = New Size(63, 19)
        female.TabIndex = 17
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = False
        ' 
        ' nonbinary
        ' 
        nonbinary.AutoSize = True
        nonbinary.BackColor = Color.Transparent
        nonbinary.Location = New Point(380, 18)
        nonbinary.Name = "nonbinary"
        nonbinary.Size = New Size(111, 19)
        nonbinary.TabIndex = 19
        nonbinary.TabStop = True
        nonbinary.Text = "Prefer not to say"
        nonbinary.UseVisualStyleBackColor = False
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.BackColor = Color.Transparent
        male.Location = New Point(223, 18)
        male.Name = "male"
        male.Size = New Size(51, 19)
        male.TabIndex = 18
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = False
        ' 
        ' age
        ' 
        age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        age.Location = New Point(12, 462)
        age.Mask = "00"
        age.Name = "age"
        age.Size = New Size(274, 23)
        age.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 444)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 16)
        Label5.TabIndex = 38
        Label5.Text = "Age:"
        ' 
        ' lastname
        ' 
        lastname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lastname.Font = New Font("Arial", 9F)
        lastname.Location = New Point(574, 404)
        lastname.Name = "lastname"
        lastname.PlaceholderText = "Enter last name"
        lastname.Size = New Size(274, 21)
        lastname.TabIndex = 37
        ' 
        ' middlename
        ' 
        middlename.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        middlename.Font = New Font("Arial", 9F)
        middlename.Location = New Point(293, 404)
        middlename.Name = "middlename"
        middlename.PlaceholderText = "Enter middle name"
        middlename.Size = New Size(274, 21)
        middlename.TabIndex = 36
        ' 
        ' firstname
        ' 
        firstname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        firstname.Font = New Font("Arial", 9F)
        firstname.Location = New Point(12, 404)
        firstname.Name = "firstname"
        firstname.PlaceholderText = "Enter first name"
        firstname.Size = New Size(274, 21)
        firstname.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 386)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 16)
        Label4.TabIndex = 34
        Label4.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 347)
        Label3.Name = "Label3"
        Label3.Size = New Size(262, 24)
        Label3.TabIndex = 33
        Label3.Text = "PERSONAL INFORMATION"
        ' 
        ' deleteUser
        ' 
        deleteUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        deleteUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        deleteUser.Location = New Point(593, 767)
        deleteUser.Name = "deleteUser"
        deleteUser.Size = New Size(89, 32)
        deleteUser.TabIndex = 54
        deleteUser.Text = "DELETE"
        deleteUser.UseVisualStyleBackColor = True
        ' 
        ' updateUser
        ' 
        updateUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        updateUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        updateUser.Location = New Point(760, 767)
        updateUser.Name = "updateUser"
        updateUser.Size = New Size(89, 32)
        updateUser.TabIndex = 53
        updateUser.Text = "UPDATE"
        updateUser.UseVisualStyleBackColor = True
        ' 
        ' returnViewUser
        ' 
        returnViewUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        returnViewUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        returnViewUser.Location = New Point(12, 767)
        returnViewUser.Name = "returnViewUser"
        returnViewUser.Size = New Size(89, 32)
        returnViewUser.TabIndex = 55
        returnViewUser.Text = "BACK"
        returnViewUser.UseVisualStyleBackColor = True
        ' 
        ' userID
        ' 
        userID.BackColor = SystemColors.Window
        userID.CharacterCasing = CharacterCasing.Lower
        userID.Location = New Point(748, 375)
        userID.Name = "userID"
        userID.PlaceholderText = "User ID"
        userID.ReadOnly = True
        userID.Size = New Size(100, 23)
        userID.TabIndex = 56
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 811)
        Controls.Add(userID)
        Controls.Add(returnViewUser)
        Controls.Add(deleteUser)
        Controls.Add(updateUser)
        Controls.Add(errorNotice)
        Controls.Add(password)
        Controls.Add(Label9)
        Controls.Add(username)
        Controls.Add(Label7)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label8)
        Controls.Add(email)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(contactnumber)
        Controls.Add(GroupBox1)
        Controls.Add(age)
        Controls.Add(Label5)
        Controls.Add(lastname)
        Controls.Add(middlename)
        Controls.Add(firstname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(LinkLabel5)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Name = "Form3"
        Text = "TICKETING SYSTEM - Edit User Information"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents errorNotice As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents userInactive As RadioButton
    Friend WithEvents userActive As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cashierAccount As RadioButton
    Friend WithEvents adminAccount As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents contactnumber As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents female As RadioButton
    Friend WithEvents nonbinary As RadioButton
    Friend WithEvents male As RadioButton
    Friend WithEvents age As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents middlename As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents deleteUser As Button
    Friend WithEvents updateUser As Button
    Friend WithEvents returnViewUser As Button
    Friend WithEvents userID As TextBox
End Class
