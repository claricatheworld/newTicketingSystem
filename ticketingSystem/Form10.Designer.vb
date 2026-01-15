<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        orderID = New TextBox()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        LinkLabel5 = New LinkLabel()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        Label2 = New Label()
        orderQuantity = New NumericUpDown()
        Label4 = New Label()
        ticketVerifier = New Label()
        errorNotice = New Label()
        customeremail = New TextBox()
        labelemail = New Label()
        labelcustomernumber = New Label()
        customercontactnumber = New MaskedTextBox()
        customername = New TextBox()
        labelcustomername = New Label()
        returnViewUser = New Button()
        deleteOrder = New Button()
        updateOrder = New Button()
        eventName = New TextBox()
        eventID = New TextBox()
        Label5 = New Label()
        eventCapacity = New Label()
        eventPrice = New Label()
        Label6 = New Label()
        Label8 = New Label()
        eventStatus = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(orderQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' orderID
        ' 
        orderID.Location = New Point(791, 352)
        orderID.Name = "orderID"
        orderID.PlaceholderText = "Order ID"
        orderID.ReadOnly = True
        orderID.Size = New Size(58, 23)
        orderID.TabIndex = 83
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
        Label3.Size = New Size(169, 24)
        Label3.TabIndex = 82
        Label3.Text = "ORDER DETAILS"
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
        DataGridView1.TabIndex = 81
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
        LinkLabel5.TabIndex = 80
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
        viewOrder.Location = New Point(66, 9)
        viewOrder.Name = "viewOrder"
        viewOrder.Size = New Size(46, 16)
        viewOrder.TabIndex = 78
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
        viewUser.Location = New Point(118, 9)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 77
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
        viewEvent.Location = New Point(12, 9)
        viewEvent.Name = "viewEvent"
        viewEvent.Size = New Size(46, 16)
        viewEvent.TabIndex = 76
        viewEvent.TabStop = True
        viewEvent.Text = "Events"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(113, 386)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 16)
        Label2.TabIndex = 97
        Label2.Text = "Event Name:"
        ' 
        ' orderQuantity
        ' 
        orderQuantity.Location = New Point(688, 405)
        orderQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        orderQuantity.Name = "orderQuantity"
        orderQuantity.Size = New Size(161, 23)
        orderQuantity.TabIndex = 103
        orderQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(688, 387)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 16)
        Label4.TabIndex = 104
        Label4.Text = "Quantity:"
        ' 
        ' ticketVerifier
        ' 
        ticketVerifier.AutoSize = True
        ticketVerifier.BackColor = Color.Transparent
        ticketVerifier.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        ticketVerifier.ForeColor = Color.Red
        ticketVerifier.Location = New Point(688, 431)
        ticketVerifier.Name = "ticketVerifier"
        ticketVerifier.Size = New Size(15, 16)
        ticketVerifier.TabIndex = 109
        ticketVerifier.Text = "[]"
        ' 
        ' errorNotice
        ' 
        errorNotice.AutoSize = True
        errorNotice.BackColor = Color.Transparent
        errorNotice.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic)
        errorNotice.ForeColor = Color.Red
        errorNotice.Location = New Point(12, 540)
        errorNotice.Name = "errorNotice"
        errorNotice.Size = New Size(15, 16)
        errorNotice.TabIndex = 118
        errorNotice.Text = "[]"
        ' 
        ' customeremail
        ' 
        customeremail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customeremail.Font = New Font("Arial", 9F)
        customeremail.Location = New Point(580, 515)
        customeremail.Name = "customeremail"
        customeremail.PlaceholderText = "Enter email"
        customeremail.Size = New Size(269, 21)
        customeremail.TabIndex = 117
        ' 
        ' labelemail
        ' 
        labelemail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelemail.AutoSize = True
        labelemail.BackColor = Color.Transparent
        labelemail.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelemail.ForeColor = Color.White
        labelemail.Location = New Point(580, 497)
        labelemail.Name = "labelemail"
        labelemail.Size = New Size(47, 16)
        labelemail.TabIndex = 116
        labelemail.Text = "Email:"
        ' 
        ' labelcustomernumber
        ' 
        labelcustomernumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelcustomernumber.AutoSize = True
        labelcustomernumber.BackColor = Color.Transparent
        labelcustomernumber.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcustomernumber.ForeColor = Color.White
        labelcustomernumber.Location = New Point(296, 496)
        labelcustomernumber.Name = "labelcustomernumber"
        labelcustomernumber.Size = New Size(113, 16)
        labelcustomernumber.TabIndex = 115
        labelcustomernumber.Text = "Contact Number:"
        ' 
        ' customercontactnumber
        ' 
        customercontactnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customercontactnumber.Location = New Point(296, 514)
        customercontactnumber.Mask = "00000000000"
        customercontactnumber.Name = "customercontactnumber"
        customercontactnumber.Size = New Size(269, 23)
        customercontactnumber.TabIndex = 114
        ' 
        ' customername
        ' 
        customername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        customername.Font = New Font("Arial", 9F)
        customername.Location = New Point(12, 515)
        customername.Name = "customername"
        customername.PlaceholderText = "Enter name"
        customername.Size = New Size(269, 21)
        customername.TabIndex = 113
        ' 
        ' labelcustomername
        ' 
        labelcustomername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        labelcustomername.AutoSize = True
        labelcustomername.BackColor = Color.Transparent
        labelcustomername.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelcustomername.ForeColor = Color.White
        labelcustomername.Location = New Point(12, 497)
        labelcustomername.Name = "labelcustomername"
        labelcustomername.Size = New Size(112, 16)
        labelcustomername.TabIndex = 112
        labelcustomername.Text = "Customer Name:"
        ' 
        ' returnViewUser
        ' 
        returnViewUser.Anchor = AnchorStyles.None
        returnViewUser.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        returnViewUser.Location = New Point(12, 617)
        returnViewUser.Name = "returnViewUser"
        returnViewUser.Size = New Size(89, 32)
        returnViewUser.TabIndex = 121
        returnViewUser.Text = "BACK"
        returnViewUser.UseVisualStyleBackColor = True
        ' 
        ' deleteOrder
        ' 
        deleteOrder.Anchor = AnchorStyles.None
        deleteOrder.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        deleteOrder.Location = New Point(648, 617)
        deleteOrder.Name = "deleteOrder"
        deleteOrder.Size = New Size(89, 32)
        deleteOrder.TabIndex = 120
        deleteOrder.Text = "DELETE"
        deleteOrder.UseVisualStyleBackColor = True
        ' 
        ' updateOrder
        ' 
        updateOrder.Anchor = AnchorStyles.None
        updateOrder.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        updateOrder.Location = New Point(760, 617)
        updateOrder.Name = "updateOrder"
        updateOrder.Size = New Size(89, 32)
        updateOrder.TabIndex = 119
        updateOrder.Text = "UPDATE"
        updateOrder.UseVisualStyleBackColor = True
        ' 
        ' eventName
        ' 
        eventName.Location = New Point(113, 404)
        eventName.Name = "eventName"
        eventName.PlaceholderText = "Event Name"
        eventName.ReadOnly = True
        eventName.Size = New Size(454, 23)
        eventName.TabIndex = 122
        ' 
        ' eventID
        ' 
        eventID.Location = New Point(12, 404)
        eventID.Name = "eventID"
        eventID.PlaceholderText = "Event ID"
        eventID.ReadOnly = True
        eventID.Size = New Size(89, 23)
        eventID.TabIndex = 123
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 16)
        Label5.TabIndex = 124
        Label5.Text = "EventID:"
        ' 
        ' eventCapacity
        ' 
        eventCapacity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventCapacity.AutoSize = True
        eventCapacity.BackColor = Color.Transparent
        eventCapacity.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventCapacity.ForeColor = Color.White
        eventCapacity.Location = New Point(643, 407)
        eventCapacity.Name = "eventCapacity"
        eventCapacity.Size = New Size(0, 16)
        eventCapacity.TabIndex = 110
        eventCapacity.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' eventPrice
        ' 
        eventPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventPrice.AutoSize = True
        eventPrice.BackColor = Color.Transparent
        eventPrice.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventPrice.ForeColor = Color.White
        eventPrice.Location = New Point(161, 431)
        eventPrice.Name = "eventPrice"
        eventPrice.Size = New Size(0, 16)
        eventPrice.TabIndex = 126
        eventPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(573, 407)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 16)
        Label6.TabIndex = 127
        Label6.Text = "Available:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(113, 431)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 16)
        Label8.TabIndex = 129
        Label8.Text = "Price:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' eventStatus
        ' 
        eventStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventStatus.AutoSize = True
        eventStatus.BackColor = Color.Transparent
        eventStatus.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eventStatus.ForeColor = Color.Chartreuse
        eventStatus.Location = New Point(521, 385)
        eventStatus.Name = "eventStatus"
        eventStatus.Size = New Size(44, 16)
        eventStatus.TabIndex = 130
        eventStatus.Text = "Price:"
        eventStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 661)
        Controls.Add(eventStatus)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(eventPrice)
        Controls.Add(Label5)
        Controls.Add(eventID)
        Controls.Add(eventName)
        Controls.Add(returnViewUser)
        Controls.Add(deleteOrder)
        Controls.Add(updateOrder)
        Controls.Add(errorNotice)
        Controls.Add(customeremail)
        Controls.Add(labelemail)
        Controls.Add(labelcustomernumber)
        Controls.Add(customercontactnumber)
        Controls.Add(customername)
        Controls.Add(labelcustomername)
        Controls.Add(eventCapacity)
        Controls.Add(ticketVerifier)
        Controls.Add(Label4)
        Controls.Add(orderQuantity)
        Controls.Add(Label2)
        Controls.Add(orderID)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(LinkLabel5)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Name = "Form10"
        Text = "TICKETING SYSTEM - Edit Order Details"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(orderQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents orderID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents orderQuantity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ticketVerifier As Label
    Friend WithEvents errorNotice As Label
    Friend WithEvents customeremail As TextBox
    Friend WithEvents labelemail As Label
    Friend WithEvents labelcustomernumber As Label
    Friend WithEvents customercontactnumber As MaskedTextBox
    Friend WithEvents customername As TextBox
    Friend WithEvents labelcustomername As Label
    Friend WithEvents returnViewUser As Button
    Friend WithEvents deleteOrder As Button
    Friend WithEvents updateOrder As Button
    Friend WithEvents eventName As TextBox
    Friend WithEvents eventID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents eventCapacity As Label
    Friend WithEvents eventPrice As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents eventStatus As Label
End Class
