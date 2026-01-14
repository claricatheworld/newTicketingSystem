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
        Label1 = New Label()
        viewOrder = New LinkLabel()
        viewUser = New LinkLabel()
        viewEvent = New LinkLabel()
        homepage = New LinkLabel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addEvent
        ' 
        addEvent.AutoSize = True
        addEvent.BackColor = Color.Transparent
        addEvent.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addEvent.Location = New Point(707, 90)
        addEvent.Name = "addEvent"
        addEvent.Size = New Size(68, 15)
        addEvent.TabIndex = 28
        addEvent.TabStop = True
        addEvent.Text = "Add Event"
        ' 
        ' editEvent
        ' 
        editEvent.AutoSize = True
        editEvent.Font = New Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editEvent.Location = New Point(781, 90)
        editEvent.Name = "editEvent"
        editEvent.Size = New Size(68, 15)
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
        Label3.Font = New Font("Helvetica", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 24)
        Label3.TabIndex = 25
        Label3.Text = "EVENT LIST"
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
        LinkLabel5.TabIndex = 24
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
        Label1.TabIndex = 23
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
        viewOrder.TabIndex = 22
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
        viewUser.TabIndex = 21
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
        viewEvent.TabIndex = 20
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
        homepage.TabIndex = 19
        homepage.TabStop = True
        homepage.Text = "Home"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 611)
        Controls.Add(addEvent)
        Controls.Add(editEvent)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel5)
        Controls.Add(Label1)
        Controls.Add(viewOrder)
        Controls.Add(viewUser)
        Controls.Add(viewEvent)
        Controls.Add(homepage)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addEvent As LinkLabel
    Friend WithEvents editEvent As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents viewOrder As LinkLabel
    Friend WithEvents viewUser As LinkLabel
    Friend WithEvents viewEvent As LinkLabel
    Friend WithEvents homepage As LinkLabel
End Class
