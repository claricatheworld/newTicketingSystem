<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        addEvent = New LinkLabel()
        editEvent = New LinkLabel()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        LinkLabel5 = New LinkLabel()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addEvent
        ' 
        addEvent.AutoSize = True
        addEvent.BackColor = Color.Transparent
        addEvent.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addEvent.LinkColor = Color.White
        addEvent.Location = New Point(707, 90)
        addEvent.Name = "addEvent"
        addEvent.Size = New Size(66, 16)
        addEvent.TabIndex = 28
        addEvent.TabStop = True
        addEvent.Text = "Add Event"
        ' 
        ' editEvent
        ' 
        editEvent.AutoSize = True
        editEvent.BackColor = Color.Transparent
        editEvent.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editEvent.LinkColor = Color.White
        editEvent.Location = New Point(781, 90)
        editEvent.Name = "editEvent"
        editEvent.Size = New Size(66, 16)
        editEvent.TabIndex = 27
        editEvent.TabStop = True
        editEvent.Text = "Edit Event"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(837, 491)
        DataGridView1.TabIndex = 26
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
        Label3.Size = New Size(125, 24)
        Label3.TabIndex = 25
        Label3.Text = "EVENT LIST"
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
        LinkLabel5.TabIndex = 24
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
        viewOrder.TabIndex = 22
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
        viewUser.TabIndex = 21
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
        viewEvent.TabIndex = 20
        viewEvent.TabStop = True
        viewEvent.Text = "Events"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0011
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 611)
        Controls.Add(addEvent)
        Controls.Add(editEvent)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel5)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Name = "Form5"
        Text = "TICKETING SYSTEM - Event List"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addEvent As LinkLabel
    Friend WithEvents editEvent As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
End Class
