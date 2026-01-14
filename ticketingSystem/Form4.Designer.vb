<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        logOut = New LinkLabel()
        Label1 = New Label()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        homepage = New LinkLabel()
        eventName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        eventDate = New MaskedTextBox()
        eventVenue = New TextBox()
        Label6 = New Label()
        capacity = New MaskedTextBox()
        Label7 = New Label()
        eventDetails = New RichTextBox()
        Label9 = New Label()
        addEvent = New Button()
        clearForm = New Button()
        errorNotice = New Label()
        Label2 = New Label()
        timeStart = New MaskedTextBox()
        timeEnd = New MaskedTextBox()
        GroupBox1 = New GroupBox()
        eventInactive = New RadioButton()
        eventActive = New RadioButton()
        ticketPrice = New MaskedTextBox()
        Label8 = New Label()
        eventCode = New TextBox()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
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
        logOut.TabIndex = 12
        logOut.TabStop = True
        logOut.Text = "Log Out"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(777, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 24)
        Label1.TabIndex = 11
        Label1.Text = "Hello! "
        ' 
        ' viewOrder
        ' 
        viewOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrder.AutoSize = True
        viewOrder.BackColor = Color.Transparent
        viewOrder.Font = New Font("Helvetica", 9.75F)
        viewOrder.Location = New Point(113, 9)
        viewOrder.Name = "viewOrder"
        viewOrder.Size = New Size(46, 15)
        viewOrder.TabIndex = 10
        viewOrder.TabStop = True
        viewOrder.Text = "Orders"
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
        viewUser.TabIndex = 9
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewEvent
        ' 
        viewEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvent.AutoSize = True
        viewEvent.BackColor = Color.Transparent
        viewEvent.Font = New Font("Helvetica", 9.75F)
        viewEvent.Location = New Point(59, 9)
        viewEvent.Name = "viewEvent"
        viewEvent.Size = New Size(48, 15)
        viewEvent.TabIndex = 8
        viewEvent.TabStop = True
        viewEvent.Text = "Events"
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
        homepage.TabIndex = 7
        homepage.TabStop = True
        homepage.Text = "Home"
        ' 
        ' eventName
        ' 
        eventName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventName.Font = New Font("Helvetica", 9F)
        eventName.Location = New Point(180, 144)
        eventName.Name = "eventName"
        eventName.PlaceholderText = "Enter event name"
        eventName.Size = New Size(379, 22)
        eventName.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(180, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 14
        Label4.Text = "Event name:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(346, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 24)
        Label3.TabIndex = 13
        Label3.Text = "EVENT DETAILS"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(180, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 17
        Label5.Text = "Date:"
        ' 
        ' eventDate
        ' 
        eventDate.Location = New Point(180, 202)
        eventDate.Mask = "00/00/0000"
        eventDate.Name = "eventDate"
        eventDate.Size = New Size(240, 23)
        eventDate.TabIndex = 18
        eventDate.ValidatingType = GetType(Date)
        ' 
        ' eventVenue
        ' 
        eventVenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventVenue.Font = New Font("Helvetica", 9F)
        eventVenue.Location = New Point(180, 262)
        eventVenue.Name = "eventVenue"
        eventVenue.PlaceholderText = "Enter venue"
        eventVenue.Size = New Size(240, 22)
        eventVenue.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(180, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 21
        Label6.Text = "Venue:"
        ' 
        ' capacity
        ' 
        capacity.Location = New Point(440, 261)
        capacity.Mask = "000"
        capacity.Name = "capacity"
        capacity.Size = New Size(119, 23)
        capacity.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(440, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 23
        Label7.Text = "Capacity:"
        ' 
        ' eventDetails
        ' 
        eventDetails.BorderStyle = BorderStyle.FixedSingle
        eventDetails.Location = New Point(180, 320)
        eventDetails.Name = "eventDetails"
        eventDetails.Size = New Size(500, 96)
        eventDetails.TabIndex = 25
        eventDetails.Text = ""
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(180, 302)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 15)
        Label9.TabIndex = 27
        Label9.Text = "Details:"
        ' 
        ' addEvent
        ' 
        addEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        addEvent.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        addEvent.Location = New Point(591, 524)
        addEvent.Name = "addEvent"
        addEvent.Size = New Size(89, 32)
        addEvent.TabIndex = 31
        addEvent.Text = "ADD"
        addEvent.UseVisualStyleBackColor = True
        ' 
        ' clearForm
        ' 
        clearForm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        clearForm.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        clearForm.Location = New Point(180, 524)
        clearForm.Name = "clearForm"
        clearForm.Size = New Size(89, 32)
        clearForm.TabIndex = 32
        clearForm.Text = "CLEAR"
        clearForm.UseVisualStyleBackColor = True
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Helvetica", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(180, 493)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(0, 15)
        errorNotice.TabIndex = 53
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(440, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 15)
        Label2.TabIndex = 19
        Label2.Text = "Time (Start/ End):"
        ' 
        ' timeStart
        ' 
        timeStart.Location = New Point(444, 202)
        timeStart.Mask = "00:00 >LL"
        timeStart.Name = "timeStart"
        timeStart.Size = New Size(115, 23)
        timeStart.TabIndex = 56
        ' 
        ' timeEnd
        ' 
        timeEnd.Location = New Point(565, 202)
        timeEnd.Mask = "00:00 >LL"
        timeEnd.Name = "timeEnd"
        timeEnd.Size = New Size(115, 23)
        timeEnd.TabIndex = 57
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(eventInactive)
        GroupBox1.Controls.Add(eventActive)
        GroupBox1.Location = New Point(180, 427)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(500, 53)
        GroupBox1.TabIndex = 58
        GroupBox1.TabStop = False
        GroupBox1.Text = "Status"
        ' 
        ' eventInactive
        ' 
        eventInactive.AutoSize = True
        eventInactive.BackColor = Color.Transparent
        eventInactive.Location = New Point(260, 22)
        eventInactive.Name = "eventInactive"
        eventInactive.Size = New Size(66, 19)
        eventInactive.TabIndex = 1
        eventInactive.TabStop = True
        eventInactive.Text = "Inactive"
        eventInactive.UseVisualStyleBackColor = False
        ' 
        ' eventActive
        ' 
        eventActive.AutoSize = True
        eventActive.BackColor = Color.Transparent
        eventActive.Location = New Point(76, 22)
        eventActive.Name = "eventActive"
        eventActive.Size = New Size(58, 19)
        eventActive.TabIndex = 0
        eventActive.TabStop = True
        eventActive.Text = "Active"
        eventActive.UseVisualStyleBackColor = False
        ' 
        ' ticketPrice
        ' 
        ticketPrice.Location = New Point(565, 261)
        ticketPrice.Mask = "00000"
        ticketPrice.Name = "ticketPrice"
        ticketPrice.Size = New Size(115, 23)
        ticketPrice.TabIndex = 60
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(565, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 59
        Label8.Text = "Ticket Price:"
        ' 
        ' eventCode
        ' 
        eventCode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventCode.CharacterCasing = CharacterCasing.Upper
        eventCode.Font = New Font("Helvetica", 9F)
        eventCode.Location = New Point(565, 144)
        eventCode.Name = "eventCode"
        eventCode.PlaceholderText = "Enter event code"
        eventCode.Size = New Size(115, 22)
        eventCode.TabIndex = 62
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(565, 126)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 15)
        Label10.TabIndex = 61
        Label10.Text = "Event code:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 611)
        Controls.Add(eventCode)
        Controls.Add(Label10)
        Controls.Add(ticketPrice)
        Controls.Add(Label8)
        Controls.Add(GroupBox1)
        Controls.Add(timeEnd)
        Controls.Add(timeStart)
        Controls.Add(errorNotice)
        Controls.Add(clearForm)
        Controls.Add(addEvent)
        Controls.Add(Label9)
        Controls.Add(eventDetails)
        Controls.Add(capacity)
        Controls.Add(Label7)
        Controls.Add(eventVenue)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(eventDate)
        Controls.Add(Label5)
        Controls.Add(eventName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(logOut)
        Controls.Add(Label1)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Controls.Add(homepage)
        Name = "Form4"
        Text = "Form4"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logOut As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
    Friend WithEvents homepage As LinkLabel
    Friend WithEvents eventName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents eventDate As MaskedTextBox
    Friend WithEvents eventVenue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents capacity As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents eventDetails As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents addEvent As Button
    Protected WithEvents clearForm As Button
    Friend WithEvents errorNotice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents timeStart As MaskedTextBox
    Friend WithEvents timeEnd As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents eventInactive As RadioButton
    Friend WithEvents eventActive As RadioButton
    Friend WithEvents ticketPrice As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents eventCode As TextBox
    Friend WithEvents Label10 As Label
End Class
