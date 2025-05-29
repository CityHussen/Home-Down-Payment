<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homedownpayment
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnudownpayment = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btninformation = New System.Windows.Forms.Button()
        Me.listinformation = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.Lblsl = New System.Windows.Forms.Label()
        Me.mnudownpayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.YellowGreen
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitle.Location = New System.Drawing.Point(377, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(451, 48)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Home down payment"
        '
        'mnudownpayment
        '
        Me.mnudownpayment.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnudownpayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnudownpayment.Location = New System.Drawing.Point(0, 0)
        Me.mnudownpayment.Name = "mnudownpayment"
        Me.mnudownpayment.Size = New System.Drawing.Size(861, 33)
        Me.mnudownpayment.TabIndex = 1
        Me.mnudownpayment.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(135, 30)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(135, 30)
        Me.mnuExit.Text = "E&xit"
        '
        'btninformation
        '
        Me.btninformation.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninformation.Location = New System.Drawing.Point(475, 84)
        Me.btninformation.Name = "btninformation"
        Me.btninformation.Size = New System.Drawing.Size(271, 117)
        Me.btninformation.TabIndex = 2
        Me.btninformation.Text = "* Enter down payment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Interest rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Number of years" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btninformation.UseVisualStyleBackColor = True
        '
        'listinformation
        '
        Me.listinformation.FormattingEnabled = True
        Me.listinformation.ItemHeight = 20
        Me.listinformation.Location = New System.Drawing.Point(541, 207)
        Me.listinformation.Name = "listinformation"
        Me.listinformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listinformation.Size = New System.Drawing.Size(120, 164)
        Me.listinformation.TabIndex = 3
        Me.listinformation.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 4
        '
        'lbloutput
        '
        Me.lbloutput.AutoSize = True
        Me.lbloutput.Location = New System.Drawing.Point(405, 310)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(0, 20)
        Me.lbloutput.TabIndex = 5
        '
        'Lblsl
        '
        Me.Lblsl.AutoSize = True
        Me.Lblsl.BackColor = System.Drawing.Color.YellowGreen
        Me.Lblsl.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsl.ForeColor = System.Drawing.Color.DarkRed
        Me.Lblsl.Location = New System.Drawing.Point(55, 374)
        Me.Lblsl.Name = "Lblsl"
        Me.Lblsl.Size = New System.Drawing.Size(530, 34)
        Me.Lblsl.TabIndex = 6
        Me.Lblsl.Text = "The total amount of money is $xxx.x"
        '
        'Homedownpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Home_Down_Payment.My.Resources.Resources.down_payment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(861, 421)
        Me.Controls.Add(Me.Lblsl)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listinformation)
        Me.Controls.Add(Me.btninformation)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnudownpayment)
        Me.Name = "Homedownpayment"
        Me.Text = "Home down payment"
        Me.mnudownpayment.ResumeLayout(False)
        Me.mnudownpayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents mnudownpayment As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btninformation As Button
    Friend WithEvents listinformation As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbloutput As Label
    Friend WithEvents Lblsl As Label
End Class
