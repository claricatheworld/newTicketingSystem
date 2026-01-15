<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        viewEvents = New LinkLabel()
        viewUser = New LinkLabel()
        viewOrders = New LinkLabel()
        logOut = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        firstname = New TextBox()
        middlename = New TextBox()
        lastname = New TextBox()
        Label5 = New Label()
        age = New MaskedTextBox()
        GroupBox1 = New GroupBox()
        female = New RadioButton()
        nonbinary = New RadioButton()
        male = New RadioButton()
        contactnumber = New MaskedTextBox()
        Label6 = New Label()
        Label2 = New Label()
        email = New TextBox()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        cashierAccount = New RadioButton()
        adminAccount = New RadioButton()
        GroupBox3 = New GroupBox()
        userInactive = New RadioButton()
        userActive = New RadioButton()
        username = New TextBox()
        Label7 = New Label()
        password = New TextBox()
        Label9 = New Label()
        addUser = New Button()
        clearForm = New Button()
        errorNotice = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' viewEvents
        ' 
        viewEvents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvents.AutoSize = True
        viewEvents.BackColor = Color.Transparent
        viewEvents.Font = New Font("Arial", 9.75F)
        viewEvents.LinkColor = Color.White
        viewEvents.Location = New Point(12, 9)
        viewEvents.Margin = New Padding(4, 0, 4, 0)
        viewEvents.Name = "viewEvents"
        viewEvents.Size = New Size(46, 16)
        viewEvents.TabIndex = 1
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
        ' 
        ' viewUser
        ' 
        viewUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewUser.AutoSize = True
        viewUser.BackColor = Color.Transparent
        viewUser.Font = New Font("Arial", 9.75F)
        viewUser.LinkColor = Color.White
        viewUser.Location = New Point(117, 9)
        viewUser.Margin = New Padding(4, 0, 4, 0)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 2
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewOrders
        ' 
        viewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrders.AutoSize = True
        viewOrders.BackColor = Color.Transparent
        viewOrders.Font = New Font("Arial", 9.75F)
        viewOrders.LinkColor = Color.White
        viewOrders.Location = New Point(66, 9)
        viewOrders.Margin = New Padding(4, 0, 4, 0)
        viewOrders.Name = "viewOrders"
        viewOrders.Size = New Size(46, 16)
        viewOrders.TabIndex = 3
        viewOrders.TabStop = True
        viewOrders.Text = "Orders"
        ' 
        ' logOut
        ' 
        logOut.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        logOut.AutoSize = True
        logOut.BackColor = Color.Transparent
        logOut.Font = New Font("Arial", 10F)
        logOut.LinkColor = Color.White
        logOut.Location = New Point(791, 8)
        logOut.Margin = New Padding(4, 0, 4, 0)
        logOut.Name = "logOut"
        logOut.Size = New Size(58, 16)
        logOut.TabIndex = 6
        logOut.TabStop = True
        logOut.Text = "Log Out"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 81)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(262, 24)
        Label3.TabIndex = 8
        Label3.Text = "PERSONAL INFORMATION"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 120)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 16)
        Label4.TabIndex = 9
        Label4.Text = "Name:"
        ' 
        ' firstname
        ' 
        firstname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        firstname.Font = New Font("Arial", 9F)
        firstname.Location = New Point(12, 138)
        firstname.Margin = New Padding(4, 3, 4, 3)
        firstname.Name = "firstname"
        firstname.PlaceholderText = "Enter first name"
        firstname.Size = New Size(274, 21)
        firstname.TabIndex = 10
        ' 
        ' middlename
        ' 
        middlename.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        middlename.Font = New Font("Arial", 9F)
        middlename.Location = New Point(293, 138)
        middlename.Margin = New Padding(4, 3, 4, 3)
        middlename.Name = "middlename"
        middlename.PlaceholderText = "Enter middle name"
        middlename.Size = New Size(274, 21)
        middlename.TabIndex = 11
        ' 
        ' lastname
        ' 
        lastname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lastname.Font = New Font("Arial", 9F)
        lastname.Location = New Point(574, 138)
        lastname.Margin = New Padding(4, 3, 4, 3)
        lastname.Name = "lastname"
        lastname.PlaceholderText = "Enter last name"
        lastname.Size = New Size(274, 21)
        lastname.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 178)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 16)
        Label5.TabIndex = 14
        Label5.Text = "Age:"
        ' 
        ' age
        ' 
        age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        age.Location = New Point(12, 196)
        age.Margin = New Padding(4, 3, 4, 3)
        age.Mask = "00"
        age.Name = "age"
        age.Size = New Size(274, 23)
        age.TabIndex = 15
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(female)
        GroupBox1.Controls.Add(nonbinary)
        GroupBox1.Controls.Add(male)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(293, 178)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(556, 42)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.BackColor = Color.Transparent
        female.Location = New Point(54, 18)
        female.Margin = New Padding(4, 3, 4, 3)
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
        nonbinary.Margin = New Padding(4, 3, 4, 3)
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
        male.Margin = New Padding(4, 3, 4, 3)
        male.Name = "male"
        male.Size = New Size(51, 19)
        male.TabIndex = 18
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = False
        ' 
        ' contactnumber
        ' 
        contactnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contactnumber.Location = New Point(12, 255)
        contactnumber.Margin = New Padding(4, 3, 4, 3)
        contactnumber.Mask = "00000000000"
        contactnumber.Name = "contactnumber"
        contactnumber.Size = New Size(415, 23)
        contactnumber.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(12, 237)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 16)
        Label6.TabIndex = 19
        Label6.Text = "Contact Number:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(433, 237)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 16)
        Label2.TabIndex = 20
        Label2.Text = "Email address:"
        ' 
        ' email
        ' 
        email.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        email.Font = New Font("Arial", 9F)
        email.Location = New Point(433, 255)
        email.Margin = New Padding(4, 3, 4, 3)
        email.Name = "email"
        email.PlaceholderText = "Enter email address"
        email.Size = New Size(415, 21)
        email.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 329)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 24)
        Label8.TabIndex = 23
        Label8.Text = "REGISTRATION TYPE"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(cashierAccount)
        GroupBox2.Controls.Add(adminAccount)
        GroupBox2.Font = New Font("Arial", 9F)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(12, 380)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(415, 57)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Type"
        ' 
        ' cashierAccount
        ' 
        cashierAccount.AutoSize = True
        cashierAccount.BackColor = Color.Transparent
        cashierAccount.Location = New Point(191, 17)
        cashierAccount.Margin = New Padding(4, 3, 4, 3)
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
        adminAccount.Margin = New Padding(4, 3, 4, 3)
        adminAccount.Name = "adminAccount"
        adminAccount.Size = New Size(60, 19)
        adminAccount.TabIndex = 26
        adminAccount.TabStop = True
        adminAccount.Text = "Admin"
        adminAccount.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(userInactive)
        GroupBox3.Controls.Add(userActive)
        GroupBox3.Font = New Font("Arial", 9F)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(433, 380)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(415, 57)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Status"
        ' 
        ' userInactive
        ' 
        userInactive.AutoSize = True
        userInactive.BackColor = Color.Transparent
        userInactive.Location = New Point(160, 17)
        userInactive.Margin = New Padding(4, 3, 4, 3)
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
        userActive.Margin = New Padding(4, 3, 4, 3)
        userActive.Name = "userActive"
        userActive.Size = New Size(56, 19)
        userActive.TabIndex = 28
        userActive.TabStop = True
        userActive.Text = "Active"
        userActive.UseVisualStyleBackColor = False
        ' 
        ' username
        ' 
        username.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        username.Font = New Font("Arial", 9F)
        username.Location = New Point(12, 477)
        username.Margin = New Padding(4, 3, 4, 3)
        username.Name = "username"
        username.PlaceholderText = "Enter username"
        username.Size = New Size(415, 21)
        username.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 458)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 16)
        Label7.TabIndex = 26
        Label7.Text = "Username:"
        ' 
        ' password
        ' 
        password.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        password.Font = New Font("Arial", 9F)
        password.Location = New Point(433, 477)
        password.Margin = New Padding(4, 3, 4, 3)
        password.Name = "password"
        password.PlaceholderText = "Enter password"
        password.Size = New Size(415, 21)
        password.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(433, 458)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 16)
        Label9.TabIndex = 28
        Label9.Text = "Password:"
        ' 
        ' addUser
        ' 
        addUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        addUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        addUser.Location = New Point(760, 567)
        addUser.Margin = New Padding(4, 3, 4, 3)
        addUser.Name = "addUser"
        addUser.Size = New Size(89, 32)
        addUser.TabIndex = 30
        addUser.Text = "REGISTER"
        addUser.UseVisualStyleBackColor = True
        ' 
        ' clearForm
        ' 
        clearForm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        clearForm.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        clearForm.Location = New Point(12, 567)
        clearForm.Margin = New Padding(4, 3, 4, 3)
        clearForm.Name = "clearForm"
        clearForm.Size = New Size(89, 32)
        clearForm.TabIndex = 31
        clearForm.Text = "CLEAR"
        clearForm.UseVisualStyleBackColor = True
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 509)
        errorNotice.Margin = New Padding(4, 0, 4, 0)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(15, 16)
        errorNotice.TabIndex = 32
        errorNotice.Text = "[]"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 612)
        Controls.Add(errorNotice)
        Controls.Add(clearForm)
        Controls.Add(addUser)
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
        Controls.Add(logOut)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "TICKETING SYSTEM - Register User"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents viewEvents As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents logOut As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents middlename As TextBox
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents age As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents female As RadioButton
    Friend WithEvents nonbinary As RadioButton
    Friend WithEvents male As RadioButton
    Friend WithEvents contactnumber As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cashierAccount As RadioButton
    Friend WithEvents adminAccount As RadioButton
    Friend WithEvents userActive As RadioButton
    Friend WithEvents userInactive As RadioButton
    Friend WithEvents username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents addUser As Button
    Friend WithEvents clearForm As Button
    Friend WithEvents errorNotice As Label

End Class
