<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        displayNameEvent = New Label()
        seperator = New Label()
        Label1 = New Label()
        displayCustomerName = New Label()
        Label3 = New Label()
        Label4 = New Label()
        displayQty = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        displayTotalAmount = New Label()
        PictureBox1 = New PictureBox()
        displayOrderID = New Label()
        closeReceipt = New LinkLabel()
        nameofthevent = New Label()
        displayTicketCodes = New RichTextBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' displayNameEvent
        ' 
        displayNameEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        displayNameEvent.AutoSize = True
        displayNameEvent.BackColor = Color.Transparent
        displayNameEvent.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        displayNameEvent.ImageAlign = ContentAlignment.MiddleLeft
        displayNameEvent.Location = New Point(18, -184)
        displayNameEvent.Name = "displayNameEvent"
        displayNameEvent.Size = New Size(118, 24)
        displayNameEvent.TabIndex = 30
        displayNameEvent.Text = "nameEvent"
        displayNameEvent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' seperator
        ' 
        seperator.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        seperator.AutoSize = True
        seperator.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        seperator.Location = New Point(16, 49)
        seperator.Name = "seperator"
        seperator.Size = New Size(251, 15)
        seperator.TabIndex = 35
        seperator.Text = "-------------------------------------------------------------"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 36
        Label1.Text = "Customer Name:"
        ' 
        ' displayCustomerName
        ' 
        displayCustomerName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        displayCustomerName.AutoSize = True
        displayCustomerName.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        displayCustomerName.Location = New Point(16, 107)
        displayCustomerName.Name = "displayCustomerName"
        displayCustomerName.Size = New Size(109, 15)
        displayCustomerName.TabIndex = 37
        displayCustomerName.Text = "nameofcustomer"
        displayCustomerName.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 38
        Label3.Text = "QTY:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(251, 15)
        Label4.TabIndex = 39
        Label4.Text = "-------------------------------------------------------------"
        ' 
        ' displayQty
        ' 
        displayQty.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        displayQty.AutoSize = True
        displayQty.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        displayQty.Location = New Point(236, 152)
        displayQty.Name = "displayQty"
        displayQty.Size = New Size(28, 15)
        displayQty.TabIndex = 40
        displayQty.Text = "000"
        displayQty.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 188)
        Label6.Name = "Label6"
        Label6.Size = New Size(251, 15)
        Label6.TabIndex = 41
        Label6.Text = "-------------------------------------------------------------"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(16, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 15)
        Label8.TabIndex = 43
        Label8.Text = "TICKET CODE:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 367)
        Label9.Name = "Label9"
        Label9.Size = New Size(251, 15)
        Label9.TabIndex = 47
        Label9.Text = "-------------------------------------------------------------"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(16, 173)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 48
        Label10.Text = "Total:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' displayTotalAmount
        ' 
        displayTotalAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        displayTotalAmount.AutoSize = True
        displayTotalAmount.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        displayTotalAmount.Location = New Point(227, 173)
        displayTotalAmount.Name = "displayTotalAmount"
        displayTotalAmount.Size = New Size(37, 15)
        displayTotalAmount.TabIndex = 49
        displayTotalAmount.Text = "QTY:"
        displayTotalAmount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 408)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 50)
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' displayOrderID
        ' 
        displayOrderID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        displayOrderID.AutoSize = True
        displayOrderID.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        displayOrderID.Location = New Point(76, 64)
        displayOrderID.Name = "displayOrderID"
        displayOrderID.Size = New Size(49, 15)
        displayOrderID.TabIndex = 51
        displayOrderID.Text = "orderID"
        displayOrderID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' closeReceipt
        ' 
        closeReceipt.AutoSize = True
        closeReceipt.Location = New Point(122, 475)
        closeReceipt.Name = "closeReceipt"
        closeReceipt.Size = New Size(36, 15)
        closeReceipt.TabIndex = 52
        closeReceipt.TabStop = True
        closeReceipt.Text = "Close"
        ' 
        ' nameofthevent
        ' 
        nameofthevent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nameofthevent.AutoSize = True
        nameofthevent.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameofthevent.Location = New Point(17, 19)
        nameofthevent.Name = "nameofthevent"
        nameofthevent.Size = New Size(123, 24)
        nameofthevent.TabIndex = 53
        nameofthevent.Text = "event name"
        nameofthevent.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' displayTicketCodes
        ' 
        displayTicketCodes.Location = New Point(17, 236)
        displayTicketCodes.Name = "displayTicketCodes"
        displayTicketCodes.Size = New Size(247, 128)
        displayTicketCodes.TabIndex = 54
        displayTicketCodes.Text = ""
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 55
        Label2.Text = "orderID:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(280, 499)
        Controls.Add(Label2)
        Controls.Add(displayTicketCodes)
        Controls.Add(nameofthevent)
        Controls.Add(closeReceipt)
        Controls.Add(displayOrderID)
        Controls.Add(PictureBox1)
        Controls.Add(displayTotalAmount)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(displayQty)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(displayCustomerName)
        Controls.Add(Label1)
        Controls.Add(seperator)
        Controls.Add(displayNameEvent)
        Name = "Form8"
        Text = "CUSTOMER RECEIPT"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents displayNameEvent As Label
    Friend WithEvents seperator As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents displayCustomerName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents displayQty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents displayTotalAmount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents displayOrderID As Label
    Friend WithEvents closeReceipt As LinkLabel
    Friend WithEvents nameofthevent As Label
    Friend WithEvents displayTicketCodes As RichTextBox
    Friend WithEvents Label2 As Label
End Class
