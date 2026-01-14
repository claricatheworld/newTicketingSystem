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
        homepage = New LinkLabel()
        viewEvents = New LinkLabel()
        viewUser = New LinkLabel()
        viewOrders = New LinkLabel()
        Label1 = New Label()
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
        ' homepage
        ' 
        homepage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        homepage.AutoSize = True
        homepage.BackColor = Color.Transparent
        homepage.Font = New Font("Helvetica", 9.75F)
        homepage.Location = New Point(12, 9)
        homepage.Name = "homepage"
        homepage.Size = New Size(41, 15)
        homepage.TabIndex = 0
        homepage.TabStop = True
        homepage.Text = "Home"
        ' 
        ' viewEvents
        ' 
        viewEvents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvents.AutoSize = True
        viewEvents.BackColor = Color.Transparent
        viewEvents.Font = New Font("Helvetica", 9.75F)
        viewEvents.Location = New Point(59, 9)
        viewEvents.Name = "viewEvents"
        viewEvents.Size = New Size(48, 15)
        viewEvents.TabIndex = 1
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
        ' 
        ' viewUser
        ' 
        viewUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewUser.AutoSize = True
        viewUser.BackColor = Color.Transparent
        viewUser.Font = New Font("Helvetica", 9.75F)
        viewUser.Location = New Point(165, 9)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 15)
        viewUser.TabIndex = 2
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewOrders
        ' 
        viewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrders.AutoSize = True
        viewOrders.BackColor = Color.Transparent
        viewOrders.Font = New Font("Helvetica", 9.75F)
        viewOrders.Location = New Point(113, 9)
        viewOrders.Name = "viewOrders"
        viewOrders.Size = New Size(46, 15)
        viewOrders.TabIndex = 3
        viewOrders.TabStop = True
        viewOrders.Text = "Orders"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(777, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 24)
        Label1.TabIndex = 5
        Label1.Text = "Hello! "
        ' 
        ' logOut
        ' 
        logOut.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        logOut.AutoSize = True
        logOut.BackColor = Color.Transparent
        logOut.Font = New Font("Helvetica", 10F)
        logOut.Location = New Point(791, 8)
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
        Label3.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(274, 24)
        Label3.TabIndex = 8
        Label3.Text = "PERSONAL INFORMATION"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 9
        Label4.Text = "Name:"
        ' 
        ' firstname
        ' 
        firstname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        firstname.Font = New Font("Helvetica", 9F)
        firstname.Location = New Point(12, 138)
        firstname.Name = "firstname"
        firstname.PlaceholderText = "Enter first name"
        firstname.Size = New Size(274, 22)
        firstname.TabIndex = 10
        ' 
        ' middlename
        ' 
        middlename.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        middlename.Font = New Font("Helvetica", 9F)
        middlename.Location = New Point(293, 138)
        middlename.Name = "middlename"
        middlename.PlaceholderText = "Enter middle name"
        middlename.Size = New Size(274, 22)
        middlename.TabIndex = 11
        ' 
        ' lastname
        ' 
        lastname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lastname.Font = New Font("Helvetica", 9F)
        lastname.Location = New Point(574, 138)
        lastname.Name = "lastname"
        lastname.PlaceholderText = "Enter last name"
        lastname.Size = New Size(274, 22)
        lastname.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 14
        Label5.Text = "Age:"
        ' 
        ' age
        ' 
        age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        age.Location = New Point(12, 196)
        age.Mask = "00"
        age.Name = "age"
        age.Size = New Size(274, 23)
        age.TabIndex = 15
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(female)
        GroupBox1.Controls.Add(nonbinary)
        GroupBox1.Controls.Add(male)
        GroupBox1.Location = New Point(293, 178)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 41)
        GroupBox1.TabIndex = 16
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
        ' contactnumber
        ' 
        contactnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contactnumber.Location = New Point(12, 255)
        contactnumber.Mask = "00000000000"
        contactnumber.Name = "contactnumber"
        contactnumber.Size = New Size(415, 23)
        contactnumber.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 15)
        Label6.TabIndex = 19
        Label6.Text = "Contact Number:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(433, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 20
        Label2.Text = "Email address:"
        ' 
        ' email
        ' 
        email.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        email.Font = New Font("Helvetica", 9F)
        email.Location = New Point(433, 255)
        email.Name = "email"
        email.PlaceholderText = "Enter email address"
        email.Size = New Size(415, 22)
        email.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 329)
        Label8.Name = "Label8"
        Label8.Size = New Size(222, 24)
        Label8.TabIndex = 23
        Label8.Text = "REGISTRATION TYPE"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(cashierAccount)
        GroupBox2.Controls.Add(adminAccount)
        GroupBox2.Font = New Font("Helvetica", 9F)
        GroupBox2.Location = New Point(12, 380)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(415, 56)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Type"
        ' 
        ' cashierAccount
        ' 
        cashierAccount.AutoSize = True
        cashierAccount.BackColor = Color.Transparent
        cashierAccount.Location = New Point(191, 17)
        cashierAccount.Name = "cashierAccount"
        cashierAccount.Size = New Size(68, 18)
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
        adminAccount.Size = New Size(60, 18)
        adminAccount.TabIndex = 26
        adminAccount.TabStop = True
        adminAccount.Text = "Admin"
        adminAccount.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(userInactive)
        GroupBox3.Controls.Add(userActive)
        GroupBox3.Font = New Font("Helvetica", 9F)
        GroupBox3.Location = New Point(433, 380)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(415, 56)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Status"
        ' 
        ' userInactive
        ' 
        userInactive.AutoSize = True
        userInactive.BackColor = Color.Transparent
        userInactive.Location = New Point(160, 17)
        userInactive.Name = "userInactive"
        userInactive.Size = New Size(67, 18)
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
        userActive.Size = New Size(58, 18)
        userActive.TabIndex = 28
        userActive.TabStop = True
        userActive.Text = "Active"
        userActive.UseVisualStyleBackColor = False
        ' 
        ' username
        ' 
        username.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        username.Font = New Font("Helvetica", 9F)
        username.Location = New Point(12, 457)
        username.Name = "username"
        username.PlaceholderText = "Enter username"
        username.Size = New Size(415, 22)
        username.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 439)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 26
        Label7.Text = "Username:"
        ' 
        ' password
        ' 
        password.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        password.Font = New Font("Helvetica", 9F)
        password.Location = New Point(433, 457)
        password.Name = "password"
        password.PlaceholderText = "Enter password"
        password.Size = New Size(415, 22)
        password.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(433, 439)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 15)
        Label9.TabIndex = 28
        Label9.Text = "Password:"
        ' 
        ' addUser
        ' 
        addUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        addUser.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        addUser.Location = New Point(760, 567)
        addUser.Name = "addUser"
        addUser.Size = New Size(89, 32)
        addUser.TabIndex = 30
        addUser.Text = "REGISTER"
        addUser.UseVisualStyleBackColor = True
        ' 
        ' clearForm
        ' 
        clearForm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        clearForm.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        clearForm.Location = New Point(12, 567)
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
        errorNotice.Font = New Font("Helvetica", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 494)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(52, 15)
        errorNotice.TabIndex = 32
        errorNotice.Text = "Label10"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 611)
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
        Controls.Add(Label1)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Controls.Add(homepage)
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

    Friend WithEvents homepage As LinkLabel
    Friend WithEvents viewEvents As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents Label1 As Label
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
