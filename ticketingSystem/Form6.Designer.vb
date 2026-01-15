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
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
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
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 348)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 24)
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
        LinkLabel5.Font = New Font("Arial", 10F)
        LinkLabel5.LinkColor = Color.White
        LinkLabel5.Location = New Point(791, 8)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(58, 16)
        LinkLabel5.TabIndex = 39
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
        viewOrder.Location = New Point(66, 8)
        viewOrder.Name = "viewOrder"
        viewOrder.Size = New Size(46, 16)
        viewOrder.TabIndex = 37
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
        viewUser.Location = New Point(118, 8)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 36
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
        viewEvent.Location = New Point(12, 8)
        viewEvent.Name = "viewEvent"
        viewEvent.Size = New Size(46, 16)
        viewEvent.TabIndex = 35
        viewEvent.TabStop = True
        viewEvent.Text = "Events"
        ' 
        ' eventName
        ' 
        eventName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventName.Font = New Font("Arial", 9F)
        eventName.Location = New Point(12, 400)
        eventName.Name = "eventName"
        eventName.PlaceholderText = "Enter event name"
        eventName.Size = New Size(454, 21)
        eventName.TabIndex = 43
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 382)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 16)
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
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(600, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 16)
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
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(472, 382)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 16)
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
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(271, 430)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 16)
        Label7.TabIndex = 65
        Label7.Text = "Capacity:"
        ' 
        ' eventVenue
        ' 
        eventVenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventVenue.Font = New Font("Arial", 9F)
        eventVenue.Location = New Point(12, 449)
        eventVenue.Name = "eventVenue"
        eventVenue.PlaceholderText = "Enter venue"
        eventVenue.Size = New Size(240, 21)
        eventVenue.TabIndex = 64
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 430)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 16)
        Label4.TabIndex = 63
        Label4.Text = "Venue:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(eventInactive)
        GroupBox1.Controls.Add(eventActive)
        GroupBox1.ForeColor = Color.White
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
        returnViewUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
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
        updateUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
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
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(12, 483)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 16)
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
        errorNotice.Font = New Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 573)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(0, 16)
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
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(600, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 16)
        Label8.TabIndex = 76
        Label8.Text = "Ticket Price:"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
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
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Name = "Form6"
        Text = "TICKETING SYSTEM - Edit Event Details"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
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
