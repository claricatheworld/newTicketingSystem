<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        DataGridView1 = New DataGridView()
        LinkLabel5 = New LinkLabel()
        Label1 = New Label()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        homepage = New LinkLabel()
        eventName = New TextBox()
        Label2 = New Label()
        timeEnd = New MaskedTextBox()
        timeStart = New MaskedTextBox()
        Label5 = New Label()
        eventDate = New MaskedTextBox()
        Label6 = New Label()
        capacity = New MaskedTextBox()
        Label7 = New Label()
        eventVenue = New TextBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        eventInactive = New RadioButton()
        eventActive = New RadioButton()
        returnViewUser = New Button()
        updateUser = New Button()
        eventDetails = New RichTextBox()
        Label9 = New Label()
        eventID = New TextBox()
        errorNotice = New Label()
        ticketPrice = New MaskedTextBox()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 348)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 24)
        Label3.TabIndex = 41
        Label3.Text = "EVENT DETAILS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 61)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 268)
        DataGridView1.TabIndex = 40
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Helvetica", 10F)
        LinkLabel5.Location = New Point(791, 8)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(58, 16)
        LinkLabel5.TabIndex = 39
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Log Out"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(777, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 24)
        Label1.TabIndex = 38
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
        viewOrder.TabIndex = 37
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
        viewUser.TabIndex = 36
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
        viewEvent.TabIndex = 35
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
        homepage.TabIndex = 34
        homepage.TabStop = True
        homepage.Text = "Home"
        ' 
        ' eventName
        ' 
        eventName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventName.Font = New Font("Helvetica", 9F)
        eventName.Location = New Point(12, 400)
        eventName.Name = "eventName"
        eventName.PlaceholderText = "Enter event name"
        eventName.Size = New Size(454, 22)
        eventName.TabIndex = 43
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 382)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 44
        Label2.Text = "Event name:"
        ' 
        ' timeEnd
        ' 
        timeEnd.Location = New Point(734, 400)
        timeEnd.Mask = "00:00 >LL"
        timeEnd.Name = "timeEnd"
        timeEnd.Size = New Size(115, 23)
        timeEnd.TabIndex = 62
        ' 
        ' timeStart
        ' 
        timeStart.Location = New Point(601, 400)
        timeStart.Mask = "00:00 >LL"
        timeStart.Name = "timeStart"
        timeStart.Size = New Size(115, 23)
        timeStart.TabIndex = 61
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(600, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 15)
        Label5.TabIndex = 60
        Label5.Text = "Time (Start/ End):"
        ' 
        ' eventDate
        ' 
        eventDate.Location = New Point(472, 400)
        eventDate.Mask = "00/00/0000"
        eventDate.Name = "eventDate"
        eventDate.Size = New Size(114, 23)
        eventDate.TabIndex = 59
        eventDate.ValidatingType = GetType(Date)
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(472, 382)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 58
        Label6.Text = "Date:"
        ' 
        ' capacity
        ' 
        capacity.Location = New Point(271, 448)
        capacity.Mask = "000"
        capacity.Name = "capacity"
        capacity.Size = New Size(315, 23)
        capacity.TabIndex = 66
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(271, 430)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 65
        Label7.Text = "Capacity:"
        ' 
        ' eventVenue
        ' 
        eventVenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventVenue.Font = New Font("Helvetica", 9F)
        eventVenue.Location = New Point(12, 449)
        eventVenue.Name = "eventVenue"
        eventVenue.PlaceholderText = "Enter venue"
        eventVenue.Size = New Size(240, 22)
        eventVenue.TabIndex = 64
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 430)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 63
        Label4.Text = "Venue:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(eventInactive)
        GroupBox1.Controls.Add(eventActive)
        GroupBox1.Location = New Point(472, 501)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(377, 41)
        GroupBox1.TabIndex = 67
        GroupBox1.TabStop = False
        GroupBox1.Text = "Status"
        ' 
        ' eventInactive
        ' 
        eventInactive.AutoSize = True
        eventInactive.BackColor = Color.Transparent
        eventInactive.Location = New Point(199, 15)
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
        eventActive.Location = New Point(86, 15)
        eventActive.Name = "eventActive"
        eventActive.Size = New Size(58, 19)
        eventActive.TabIndex = 0
        eventActive.TabStop = True
        eventActive.Text = "Active"
        eventActive.UseVisualStyleBackColor = False
        ' 
        ' returnViewUser
        ' 
        returnViewUser.Anchor = AnchorStyles.None
        returnViewUser.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        returnViewUser.Location = New Point(12, 608)
        returnViewUser.Name = "returnViewUser"
        returnViewUser.Size = New Size(89, 32)
        returnViewUser.TabIndex = 70
        returnViewUser.Text = "BACK"
        returnViewUser.UseVisualStyleBackColor = True
        ' 
        ' updateUser
        ' 
        updateUser.Anchor = AnchorStyles.None
        updateUser.Font = New Font("Helvetica", 9.75F, FontStyle.Bold)
        updateUser.Location = New Point(760, 608)
        updateUser.Name = "updateUser"
        updateUser.Size = New Size(89, 32)
        updateUser.TabIndex = 68
        updateUser.Text = "UPDATE"
        updateUser.UseVisualStyleBackColor = True
        ' 
        ' eventDetails
        ' 
        eventDetails.Location = New Point(12, 501)
        eventDetails.Name = "eventDetails"
        eventDetails.Size = New Size(454, 67)
        eventDetails.TabIndex = 71
        eventDetails.Text = ""
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 483)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 15)
        Label9.TabIndex = 73
        Label9.Text = "Details:"
        ' 
        ' eventID
        ' 
        eventID.Location = New Point(791, 352)
        eventID.Name = "eventID"
        eventID.PlaceholderText = "Event ID"
        eventID.ReadOnly = True
        eventID.Size = New Size(58, 23)
        eventID.TabIndex = 74
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Helvetica", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 573)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(0, 15)
        errorNotice.TabIndex = 75
        ' 
        ' ticketPrice
        ' 
        ticketPrice.Location = New Point(600, 448)
        ticketPrice.Mask = "00000"
        ticketPrice.Name = "ticketPrice"
        ticketPrice.Size = New Size(249, 23)
        ticketPrice.TabIndex = 77
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(600, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 76
        Label8.Text = "Ticket Price:"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 661)
        Controls.Add(ticketPrice)
        Controls.Add(Label8)
        Controls.Add(errorNotice)
        Controls.Add(eventID)
        Controls.Add(Label9)
        Controls.Add(eventDetails)
        Controls.Add(returnViewUser)
        Controls.Add(updateUser)
        Controls.Add(GroupBox1)
        Controls.Add(capacity)
        Controls.Add(Label7)
        Controls.Add(eventVenue)
        Controls.Add(Label4)
        Controls.Add(timeEnd)
        Controls.Add(timeStart)
        Controls.Add(Label5)
        Controls.Add(eventDate)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(eventName)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(LinkLabel5)
        Controls.Add(Label1)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Controls.Add(homepage)
        Name = "Form6"
        Text = "Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
    Friend WithEvents homepage As LinkLabel
    Friend WithEvents eventName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents timeEnd As MaskedTextBox
    Friend WithEvents timeStart As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents eventDate As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents capacity As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents eventVenue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents eventInactive As RadioButton
    Friend WithEvents eventActive As RadioButton
    Friend WithEvents returnViewUser As Button
    Friend WithEvents updateUser As Button
    Friend WithEvents eventDetails As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents eventID As TextBox
    Friend WithEvents errorNotice As Label
    Friend WithEvents ticketPrice As MaskedTextBox
    Friend WithEvents Label8 As Label
End Class
