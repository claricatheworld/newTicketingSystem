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
        Label1 = New Label()
        viewOrders = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvents = New LinkLabel()
        homepage = New LinkLabel()
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
        Label3.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 24)
        Label3.TabIndex = 15
        Label3.Text = "USER RECORDS"
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
        LinkLabel5.TabIndex = 14
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Log Out"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(777, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 24)
        Label1.TabIndex = 13
        Label1.Text = "Hello! "
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
        viewOrders.TabIndex = 12
        viewOrders.TabStop = True
        viewOrders.Text = "Orders"
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
        viewUser.TabIndex = 11
        viewUser.TabStop = True
        viewUser.Text = "Users"
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
        viewEvents.TabIndex = 10
        viewEvents.TabStop = True
        viewEvents.Text = "Events"
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
        homepage.TabIndex = 9
        homepage.TabStop = True
        homepage.Text = "Home"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 491)
        DataGridView1.TabIndex = 16
        ' 
        ' editUser
        ' 
        editUser.AutoSize = True
        editUser.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editUser.Location = New Point(788, 90)
        editUser.Name = "editUser"
        editUser.Size = New Size(61, 15)
        editUser.TabIndex = 17
        editUser.TabStop = True
        editUser.Text = "Edit User"
        ' 
        ' addUser
        ' 
        addUser.AutoSize = True
        addUser.BackColor = Color.Transparent
        addUser.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addUser.Location = New Point(708, 90)
        addUser.Name = "addUser"
        addUser.Size = New Size(61, 15)
        addUser.TabIndex = 18
        addUser.TabStop = True
        addUser.Text = "Add User"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 611)
        Controls.Add(addUser)
        Controls.Add(editUser)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel5)
        Controls.Add(Label1)
        Controls.Add(viewOrders)
        Controls.Add(viewUser)
        Controls.Add(viewEvents)
        Controls.Add(homepage)
        Name = "Form2"
        Text = "TICKETING SYSTEM - View Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents viewOrders As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvents As LinkLabel
    Friend WithEvents homepage As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents editUser As LinkLabel
    Friend WithEvents addUser As LinkLabel
End Class
