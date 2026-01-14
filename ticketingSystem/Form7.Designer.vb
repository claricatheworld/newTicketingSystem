<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        logOut = New LinkLabel()
        viewOrders = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvents = New LinkLabel()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        refreshSelect = New LinkLabel()
        selectedEvent = New GroupBox()
        orderTicket = New Button()
        statusLabel = New Label()
        statusEvent = New Label()
        ticketPrice = New Label()
        errorNotice = New Label()
        customeremail = New TextBox()
        labelemail = New Label()
        labelcustomernumber = New Label()
        customercontactnumber = New MaskedTextBox()
        customername = New TextBox()
        labelcustomername = New Label()
        ticketVerifier = New Label()
        eventID = New Label()
        quantity = New NumericUpDown()
        detailsText = New Label()
        dateEvent = New Label()
        showDetails = New Label()
        capacityDisplay = New Label()
        endtime = New Label()
        starttime = New Label()
        venueEvent = New Label()
        nameEvent = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        selectedEvent.SuspendLayout()
        CType(quantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logOut
        ' 
        logOut.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        logOut.AutoSize = True
        logOut.BackColor = Color.Transparent
        logOut.Font = New Font("Arial", 10F)
        logOut.LinkColor = Color.White
        logOut.Location = New Point(791, 8)
        logOut.Name = "logOut"
        logOut.Size = New Size(58, 16)
        logOut.TabIndex = 12
        logOut.TabStop = True
        logOut.Text = "Log Out"
        ' 
        ' viewOrders
        ' 
        viewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrders.AutoSize = True
        viewOrders.BackColor = Color.Transparent
        viewOrders.Font = New Font("Arial", 9.75F)
        viewOrders.LinkColor = Color.White
        viewOrders.Location = New Point(66, 8)
        viewOrders.Name = "viewOrders"
        viewOrders.Size = New Size(46, 16)
        viewOrders.TabIndex = 10
        viewOrders.TabStop = True
        viewOrders.Text = "Orders"
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
        viewUser.TabIndex = 9
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewEvents
        ' 
        viewEvents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvents.AutoSize = True
        viewEvents.BackColor = Color.Transparent
        viewEvents.Font = New Font("Arial", 9.75F)
        viewEvents.LinkColor = Color.White
        viewEvents.Location = New Point(12, 8)
        viewEvents.Name = "viewEvents"
        viewEvents.Size = New Size(46, 16)
        viewEvents.TabIndex = 8
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 24)
        Label2.TabIndex = 27
        Label2.Text = "UPCOMING EVENTS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 87)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(434, 512)
        DataGridView1.TabIndex = 28
        ' 
        ' refreshSelect
        ' 
        refreshSelect.AutoSize = True
        refreshSelect.BackColor = Color.Transparent
        refreshSelect.ForeColor = Color.White
        refreshSelect.LinkColor = Color.White
        refreshSelect.Location = New Point(400, 57)
        refreshSelect.Name = "refreshSelect"
        refreshSelect.Size = New Size(46, 15)
        refreshSelect.TabIndex = 78
        refreshSelect.TabStop = True
        refreshSelect.Text = "Refresh"
        ' 
        ' selectedEvent
        ' 
        selectedEvent.BackColor = Color.Transparent
        selectedEvent.Controls.Add(orderTicket)
        selectedEvent.Controls.Add(statusLabel)
        selectedEvent.Controls.Add(statusEvent)
        selectedEvent.Controls.Add(ticketPrice)
        selectedEvent.Controls.Add(errorNotice)
        selectedEvent.Controls.Add(customeremail)
        selectedEvent.Controls.Add(labelemail)
        selectedEvent.Controls.Add(labelcustomernumber)
        selectedEvent.Controls.Add(customercontactnumber)
        selectedEvent.Controls.Add(customername)
        selectedEvent.Controls.Add(labelcustomername)
        selectedEvent.Controls.Add(ticketVerifier)
        selectedEvent.Controls.Add(eventID)
        selectedEvent.Controls.Add(quantity)
        selectedEvent.Controls.Add(detailsText)
        selectedEvent.Controls.Add(dateEvent)
        selectedEvent.Controls.Add(showDetails)
        selectedEvent.Controls.Add(capacityDisplay)
        selectedEvent.Controls.Add(endtime)
        selectedEvent.Controls.Add(starttime)
        selectedEvent.Controls.Add(venueEvent)
        selectedEvent.Controls.Add(nameEvent)
        selectedEvent.FlatStyle = FlatStyle.Flat
        selectedEvent.Location = New Point(452, 79)
        selectedEvent.Name = "selectedEvent"
        selectedEvent.Size = New Size(397, 520)
        selectedEvent.TabIndex = 79
        selectedEvent.TabStop = False
        ' 
        ' orderTicket
        ' 
        orderTicket.Anchor = AnchorStyles.None
        orderTicket.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        orderTicket.Location = New Point(273, 484)
        orderTicket.Name = "orderTicket"
        orderTicket.Size = New Size(118, 32)
        orderTicket.TabIndex = 115
        orderTicket.Text = "ADD ORDER"
        orderTicket.UseVisualStyleBackColor = True
        ' 
        ' statusLabel
        ' 
        statusLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        statusLabel.AutoSize = True
        statusLabel.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusLabel.ForeColor = Color.White
        statusLabel.Location = New Point(273, 165)
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(59, 16)
        statusLabel.TabIndex = 114
        statusLabel.Text = "STATUS:"
        ' 
        ' statusEvent
        ' 
        statusEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        statusEvent.AutoSize = True
        statusEvent.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusEvent.ForeColor = Color.Chartreuse
        statusEvent.Location = New Point(346, 165)
        statusEvent.Name = "statusEvent"
        statusEvent.Size = New Size(15, 16)
        statusEvent.TabIndex = 113
        statusEvent.Text = "[]"
        statusEvent.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ticketPrice
        ' 
        ticketPrice.AutoSize = True
        ticketPrice.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ticketPrice.ForeColor = Color.White
        ticketPrice.Location = New Point(3, 250)
        ticketPrice.Name = "ticketPrice"
        ticketPrice.Size = New Size(40, 16)
        ticketPrice.TabIndex = 112
        ticketPrice.Text = "Price"
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(5, 456)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(15, 16)
        errorNotice.TabIndex = 111
        errorNotice.Text = "[]"
        ' 
        ' customeremail
        ' 
        customeremail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customeremail.Font = New Font("Arial", 9F)
        customeremail.Location = New Point(5, 431)
        customeremail.Name = "customeremail"
        customeremail.PlaceholderText = "Enter email"
        customeremail.Size = New Size(386, 21)
        customeremail.TabIndex = 110
        ' 
        ' labelemail
        ' 
        labelemail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelemail.AutoSize = True
        labelemail.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelemail.ForeColor = Color.White
        labelemail.Location = New Point(5, 413)
        labelemail.Name = "labelemail"
        labelemail.Size = New Size(47, 16)
        labelemail.TabIndex = 109
        labelemail.Text = "Email:"
        ' 
        ' labelcustomernumber
        ' 
        labelcustomernumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelcustomernumber.AutoSize = True
        labelcustomernumber.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcustomernumber.ForeColor = Color.White
        labelcustomernumber.Location = New Point(5, 369)
        labelcustomernumber.Name = "labelcustomernumber"
        labelcustomernumber.Size = New Size(113, 16)
        labelcustomernumber.TabIndex = 108
        labelcustomernumber.Text = "Contact Number:"
        ' 
        ' customercontactnumber
        ' 
        customercontactnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customercontactnumber.Location = New Point(5, 387)
        customercontactnumber.Mask = "00000000000"
        customercontactnumber.Name = "customercontactnumber"
        customercontactnumber.Size = New Size(386, 23)
        customercontactnumber.TabIndex = 107
        ' 
        ' customername
        ' 
        customername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customername.Font = New Font("Arial", 9F)
        customername.Location = New Point(5, 344)
        customername.Name = "customername"
        customername.PlaceholderText = "Enter name"
        customername.Size = New Size(386, 21)
        customername.TabIndex = 106
        ' 
        ' labelcustomername
        ' 
        labelcustomername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelcustomername.AutoSize = True
        labelcustomername.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcustomername.ForeColor = Color.White
        labelcustomername.Location = New Point(5, 326)
        labelcustomername.Name = "labelcustomername"
        labelcustomername.Size = New Size(112, 16)
        labelcustomername.TabIndex = 105
        labelcustomername.Text = "Customer Name:"
        ' 
        ' ticketVerifier
        ' 
        ticketVerifier.AutoSize = True
        ticketVerifier.BackColor = Color.Transparent
        ticketVerifier.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        ticketVerifier.ForeColor = Color.Red
        ticketVerifier.Location = New Point(3, 304)
        ticketVerifier.Name = "ticketVerifier"
        ticketVerifier.Size = New Size(15, 16)
        ticketVerifier.TabIndex = 104
        ticketVerifier.Text = "[]"
        ' 
        ' eventID
        ' 
        eventID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventID.AutoSize = True
        eventID.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventID.ForeColor = Color.White
        eventID.Location = New Point(339, 37)
        eventID.Name = "eventID"
        eventID.Size = New Size(49, 16)
        eventID.TabIndex = 103
        eventID.Text = "eventID"
        ' 
        ' quantity
        ' 
        quantity.Location = New Point(3, 278)
        quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        quantity.Name = "quantity"
        quantity.Size = New Size(120, 23)
        quantity.TabIndex = 102
        quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' detailsText
        ' 
        detailsText.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        detailsText.AutoSize = True
        detailsText.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        detailsText.ForeColor = Color.White
        detailsText.Location = New Point(5, 165)
        detailsText.Name = "detailsText"
        detailsText.Size = New Size(45, 16)
        detailsText.TabIndex = 101
        detailsText.Text = "details"
        ' 
        ' dateEvent
        ' 
        dateEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dateEvent.AutoSize = True
        dateEvent.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dateEvent.ForeColor = Color.White
        dateEvent.Location = New Point(5, 99)
        dateEvent.Name = "dateEvent"
        dateEvent.Size = New Size(32, 16)
        dateEvent.TabIndex = 100
        dateEvent.Text = "date"
        ' 
        ' showDetails
        ' 
        showDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        showDetails.AutoSize = True
        showDetails.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        showDetails.ForeColor = Color.White
        showDetails.Location = New Point(5, 191)
        showDetails.Name = "showDetails"
        showDetails.Size = New Size(70, 16)
        showDetails.TabIndex = 99
        showDetails.Text = "description"
        ' 
        ' capacityDisplay
        ' 
        capacityDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        capacityDisplay.AutoSize = True
        capacityDisplay.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        capacityDisplay.ForeColor = Color.White
        capacityDisplay.Location = New Point(5, 129)
        capacityDisplay.Name = "capacityDisplay"
        capacityDisplay.Size = New Size(92, 16)
        capacityDisplay.TabIndex = 98
        capacityDisplay.Text = "available seats"
        ' 
        ' endtime
        ' 
        endtime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        endtime.AutoSize = True
        endtime.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        endtime.ForeColor = Color.White
        endtime.Location = New Point(238, 99)
        endtime.Name = "endtime"
        endtime.Size = New Size(28, 16)
        endtime.TabIndex = 97
        endtime.Text = "end"
        ' 
        ' starttime
        ' 
        starttime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        starttime.AutoSize = True
        starttime.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        starttime.ForeColor = Color.White
        starttime.Location = New Point(160, 99)
        starttime.Name = "starttime"
        starttime.Size = New Size(33, 16)
        starttime.TabIndex = 96
        starttime.Text = "start"
        ' 
        ' venueEvent
        ' 
        venueEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        venueEvent.AutoSize = True
        venueEvent.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        venueEvent.ForeColor = Color.White
        venueEvent.Location = New Point(5, 69)
        venueEvent.Name = "venueEvent"
        venueEvent.Size = New Size(40, 16)
        venueEvent.TabIndex = 95
        venueEvent.Text = "venue"
        ' 
        ' nameEvent
        ' 
        nameEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nameEvent.AutoSize = True
        nameEvent.BackColor = Color.Transparent
        nameEvent.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameEvent.ForeColor = Color.White
        nameEvent.Location = New Point(5, 30)
        nameEvent.Name = "nameEvent"
        nameEvent.Size = New Size(115, 24)
        nameEvent.TabIndex = 94
        nameEvent.Text = "nameEvent"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 611)
        Controls.Add(selectedEvent)
        Controls.Add(refreshSelect)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(logOut)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Name = "Form7"
        Text = "TICKETING SYSTEM - Order Tickets"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        selectedEvent.ResumeLayout(False)
        selectedEvent.PerformLayout()
        CType(quantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logOut As LinkLabel
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvents As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents eventDetails As RichTextBox
    Friend WithEvents refreshSelect As LinkLabel
    Friend WithEvents selectedEvent As GroupBox
    Friend WithEvents statusLabel As Label
    Friend WithEvents statusEvent As Label
    Friend WithEvents ticketPrice As Label
    Friend WithEvents errorNotice As Label
    Friend WithEvents customeremail As TextBox
    Friend WithEvents labelemail As Label
    Friend WithEvents labelcustomernumber As Label
    Friend WithEvents customercontactnumber As MaskedTextBox
    Friend WithEvents customername As TextBox
    Friend WithEvents labelcustomername As Label
    Friend WithEvents ticketVerifier As Label
    Friend WithEvents eventID As Label
    Friend WithEvents quantity As NumericUpDown
    Friend WithEvents detailsText As Label
    Friend WithEvents dateEvent As Label
    Friend WithEvents showDetails As Label
    Friend WithEvents capacityDisplay As Label
    Friend WithEvents endtime As Label
    Friend WithEvents starttime As Label
    Friend WithEvents venueEvent As Label
    Friend WithEvents nameEvent As Label
    Friend WithEvents orderTicket As Button
End Class
