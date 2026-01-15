<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        LinkLabel5 = New LinkLabel()
        viewOrders = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvents = New LinkLabel()
        DataGridView1 = New DataGridView()
        editUser = New LinkLabel()
        addUser = New LinkLabel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Label3.Size = New Size(168, 24)
        Label3.TabIndex = 15
        Label3.Text = "USER RECORDS"
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Arial", 10F)
        LinkLabel5.ForeColor = Color.White
        LinkLabel5.LinkColor = Color.White
        LinkLabel5.Location = New Point(791, 8)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(58, 16)
        LinkLabel5.TabIndex = 14
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Log Out"
        ' 
        ' viewOrders
        ' 
        viewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewOrders.AutoSize = True
        viewOrders.BackColor = Color.Transparent
        viewOrders.Font = New Font("Arial", 9.75F)
        viewOrders.ForeColor = Color.White
        viewOrders.LinkColor = Color.White
        viewOrders.Location = New Point(66, 8)
        viewOrders.Name = "viewOrders"
        viewOrders.Size = New Size(46, 16)
        viewOrders.TabIndex = 12
        viewOrders.TabStop = True
        viewOrders.Text = "Orders"
        ' 
        ' viewUser
        ' 
        viewUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewUser.AutoSize = True
        viewUser.BackColor = Color.Transparent
        viewUser.Font = New Font("Arial", 9.75F)
        viewUser.ForeColor = Color.White
        viewUser.LinkColor = Color.White
        viewUser.Location = New Point(118, 8)
        viewUser.Name = "viewUser"
        viewUser.Size = New Size(41, 16)
        viewUser.TabIndex = 11
        viewUser.TabStop = True
        viewUser.Text = "Users"
        ' 
        ' viewEvents
        ' 
        viewEvents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEvents.AutoSize = True
        viewEvents.BackColor = Color.Transparent
        viewEvents.Font = New Font("Arial", 9.75F)
        viewEvents.ForeColor = Color.White
        viewEvents.LinkColor = Color.White
        viewEvents.Location = New Point(12, 8)
        viewEvents.Name = "viewEvents"
        viewEvents.Size = New Size(46, 16)
        viewEvents.TabIndex = 10
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 491)
        DataGridView1.TabIndex = 16
        ' 
        ' editUser
        ' 
        editUser.AutoSize = True
        editUser.BackColor = Color.Transparent
        editUser.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editUser.LinkColor = Color.White
        editUser.Location = New Point(788, 90)
        editUser.Name = "editUser"
        editUser.Size = New Size(61, 16)
        editUser.TabIndex = 17
        editUser.TabStop = True
        editUser.Text = "Edit User"
        ' 
        ' addUser
        ' 
        addUser.AutoSize = True
        addUser.BackColor = Color.Transparent
        addUser.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addUser.LinkColor = Color.White
        addUser.Location = New Point(708, 90)
        addUser.Name = "addUser"
        addUser.Size = New Size(61, 16)
        addUser.TabIndex = 18
        addUser.TabStop = True
        addUser.Text = "Add User"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._001
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 611)
        Controls.Add(addUser)
        Controls.Add(editUser)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel5)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Name = "Form2"
        Text = "TICKETING SYSTEM - Manage Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvents As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents editUser As LinkLabel
    Friend WithEvents addUser As LinkLabel
End Class
