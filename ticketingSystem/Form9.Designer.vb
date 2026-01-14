<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        addOrder = New LinkLabel()
        editOrder = New LinkLabel()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        LinkLabel5 = New LinkLabel()
        viewOrders = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvents = New LinkLabel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addOrder
        ' 
        addOrder.AutoSize = True
        addOrder.BackColor = Color.Transparent
        addOrder.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addOrder.ForeColor = Color.White
        addOrder.LinkColor = Color.White
        addOrder.Location = New Point(707, 90)
        addOrder.Name = "addOrder"
        addOrder.Size = New Size(66, 16)
        addOrder.TabIndex = 38
        addOrder.TabStop = True
        addOrder.Text = "Add Order"
        ' 
        ' editOrder
        ' 
        editOrder.AutoSize = True
        editOrder.BackColor = Color.Transparent
        editOrder.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editOrder.ForeColor = Color.White
        editOrder.LinkColor = Color.White
        editOrder.Location = New Point(781, 90)
        editOrder.Name = "editOrder"
        editOrder.Size = New Size(66, 16)
        editOrder.TabIndex = 37
        editOrder.TabStop = True
        editOrder.Text = "Edit Order"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 491)
        DataGridView1.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 24)
        Label3.TabIndex = 35
        Label3.Text = "ORDER LIST"
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
        LinkLabel5.TabIndex = 34
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Log Out"
        ' 
        ' viewOrders
        ' 
        viewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrders.AutoSize = True
        viewOrders.BackColor = Color.Transparent
        viewOrders.Font = New Font("Arial", 9.75F)
        viewOrders.LinkColor = Color.White
        viewOrders.Location = New Point(66, 9)
        viewOrders.Name = "viewOrders"
        viewOrders.Size = New Size(46, 16)
        viewOrders.TabIndex = 32
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
        viewUser.Location = New Point(118, 9)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 31
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
        viewEvents.Location = New Point(12, 9)
        viewEvents.Name = "viewEvents"
        viewEvents.Size = New Size(46, 16)
        viewEvents.TabIndex = 30
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 611)
        Controls.Add(addOrder)
        Controls.Add(editOrder)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel5)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Name = "Form9"
        Text = "TICKETING SYSTEM - List Of Orders"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addOrder As LinkLabel
    Friend WithEvents editOrder As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvents As LinkLabel
End Class
