<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddRecipient = New System.Windows.Forms.Button()
        Me.btnRemoveRecipient = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.dgdRecipients = New System.Windows.Forms.DataGridView()
        Me.txtRecipientList = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgdRecipients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSubject)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(569, 471)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 430)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(55, 32)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(78, 53)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(481, 410)
        Me.txtMessage.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Message:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(78, 21)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(481, 22)
        Me.txtSubject.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddRecipient)
        Me.GroupBox2.Controls.Add(Me.btnRemoveRecipient)
        Me.GroupBox2.Controls.Add(Me.btnRemoveAll)
        Me.GroupBox2.Controls.Add(Me.btnAddAll)
        Me.GroupBox2.Controls.Add(Me.dgdRecipients)
        Me.GroupBox2.Controls.Add(Me.txtRecipientList)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(588, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(795, 471)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recipients"
        '
        'btnAddRecipient
        '
        Me.btnAddRecipient.Location = New System.Drawing.Point(278, 55)
        Me.btnAddRecipient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddRecipient.Name = "btnAddRecipient"
        Me.btnAddRecipient.Size = New System.Drawing.Size(100, 28)
        Me.btnAddRecipient.TabIndex = 8
        Me.btnAddRecipient.Text = "Add"
        Me.btnAddRecipient.UseVisualStyleBackColor = True
        '
        'btnRemoveRecipient
        '
        Me.btnRemoveRecipient.Location = New System.Drawing.Point(415, 55)
        Me.btnRemoveRecipient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemoveRecipient.Name = "btnRemoveRecipient"
        Me.btnRemoveRecipient.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveRecipient.TabIndex = 7
        Me.btnRemoveRecipient.Text = "Remove"
        Me.btnRemoveRecipient.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(148, 55)
        Me.btnRemoveAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveAll.TabIndex = 4
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(12, 55)
        Me.btnAddAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(100, 28)
        Me.btnAddAll.TabIndex = 3
        Me.btnAddAll.Text = "Add All"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'dgdRecipients
        '
        Me.dgdRecipients.AllowUserToAddRows = False
        Me.dgdRecipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdRecipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdRecipients.Location = New System.Drawing.Point(7, 91)
        Me.dgdRecipients.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgdRecipients.Name = "dgdRecipients"
        Me.dgdRecipients.Size = New System.Drawing.Size(780, 373)
        Me.dgdRecipients.TabIndex = 2
        '
        'txtRecipientList
        '
        Me.txtRecipientList.Location = New System.Drawing.Point(195, 25)
        Me.txtRecipientList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecipientList.Name = "txtRecipientList"
        Me.txtRecipientList.ReadOnly = True
        Me.txtRecipientList.Size = New System.Drawing.Size(591, 22)
        Me.txtRecipientList.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Recipient list:"
        '
        'frmEmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 502)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEmailForm"
        Me.Text = "frmEmailForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgdRecipients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRecipientList As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgdRecipients As DataGridView
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnAddAll As Button
    Friend WithEvents btnAddRecipient As Button
    Friend WithEvents btnRemoveRecipient As Button
    Friend WithEvents btnSend As Button
End Class
