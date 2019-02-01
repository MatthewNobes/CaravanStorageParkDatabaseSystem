<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchUser = New System.Windows.Forms.Button()
        Me.btnRemoveUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPasswordStore = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSearchRate = New System.Windows.Forms.Button()
        Me.btnRemoveRate = New System.Windows.Forms.Button()
        Me.btnUpdateRate = New System.Windows.Forms.Button()
        Me.btnAddRate = New System.Windows.Forms.Button()
        Me.txtRateID = New System.Windows.Forms.TextBox()
        Me.txtRateType = New System.Windows.Forms.TextBox()
        Me.txtHalfYearRate = New System.Windows.Forms.TextBox()
        Me.txtYearRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnInvoiceCounterReset = New System.Windows.Forms.Button()
        Me.dgdUsers = New System.Windows.Forms.DataGridView()
        Me.dgdRates = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbUserType)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPasswordStore)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(428, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Management"
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Location = New System.Drawing.Point(89, 47)
        Me.cmbUserType.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(325, 24)
        Me.cmbUserType.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchUser)
        Me.GroupBox2.Controls.Add(Me.btnRemoveUser)
        Me.GroupBox2.Controls.Add(Me.btnUpdateUser)
        Me.GroupBox2.Controls.Add(Me.btnAddUser)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 161)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox2.Size = New System.Drawing.Size(411, 129)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Commands"
        '
        'btnSearchUser
        '
        Me.btnSearchUser.Location = New System.Drawing.Point(201, 71)
        Me.btnSearchUser.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(173, 47)
        Me.btnSearchUser.TabIndex = 3
        Me.btnSearchUser.Text = "Search User"
        Me.btnSearchUser.UseVisualStyleBackColor = True
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.Location = New System.Drawing.Point(7, 73)
        Me.btnRemoveUser.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Size = New System.Drawing.Size(173, 47)
        Me.btnRemoveUser.TabIndex = 2
        Me.btnRemoveUser.Text = "Remove User"
        Me.btnRemoveUser.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Location = New System.Drawing.Point(201, 20)
        Me.btnUpdateUser.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(173, 47)
        Me.btnUpdateUser.TabIndex = 1
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(7, 21)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(173, 47)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(89, 17)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(325, 22)
        Me.txtUserID.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(89, 135)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(325, 22)
        Me.txtEmail.TabIndex = 7
        '
        'txtPasswordStore
        '
        Me.txtPasswordStore.Location = New System.Drawing.Point(89, 106)
        Me.txtPasswordStore.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtPasswordStore.Name = "txtPasswordStore"
        Me.txtPasswordStore.Size = New System.Drawing.Size(325, 22)
        Me.txtPasswordStore.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(88, 75)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(325, 22)
        Me.txtUserName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtRateID)
        Me.GroupBox3.Controls.Add(Me.txtRateType)
        Me.GroupBox3.Controls.Add(Me.txtHalfYearRate)
        Me.GroupBox3.Controls.Add(Me.txtYearRate)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 315)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox3.Size = New System.Drawing.Size(428, 241)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Caravan Rate Management:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSearchRate)
        Me.GroupBox4.Controls.Add(Me.btnRemoveRate)
        Me.GroupBox4.Controls.Add(Me.btnUpdateRate)
        Me.GroupBox4.Controls.Add(Me.btnAddRate)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 145)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox4.Size = New System.Drawing.Size(412, 91)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Commands"
        '
        'btnSearchRate
        '
        Me.btnSearchRate.Location = New System.Drawing.Point(215, 54)
        Me.btnSearchRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnSearchRate.Name = "btnSearchRate"
        Me.btnSearchRate.Size = New System.Drawing.Size(193, 28)
        Me.btnSearchRate.TabIndex = 3
        Me.btnSearchRate.Text = "Search Rate"
        Me.btnSearchRate.UseVisualStyleBackColor = True
        '
        'btnRemoveRate
        '
        Me.btnRemoveRate.Location = New System.Drawing.Point(7, 54)
        Me.btnRemoveRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnRemoveRate.Name = "btnRemoveRate"
        Me.btnRemoveRate.Size = New System.Drawing.Size(193, 28)
        Me.btnRemoveRate.TabIndex = 2
        Me.btnRemoveRate.Text = "Remove Rate"
        Me.btnRemoveRate.UseVisualStyleBackColor = True
        '
        'btnUpdateRate
        '
        Me.btnUpdateRate.Location = New System.Drawing.Point(215, 20)
        Me.btnUpdateRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnUpdateRate.Name = "btnUpdateRate"
        Me.btnUpdateRate.Size = New System.Drawing.Size(193, 28)
        Me.btnUpdateRate.TabIndex = 1
        Me.btnUpdateRate.Text = "Update Rate"
        Me.btnUpdateRate.UseVisualStyleBackColor = True
        '
        'btnAddRate
        '
        Me.btnAddRate.Location = New System.Drawing.Point(7, 21)
        Me.btnAddRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnAddRate.Name = "btnAddRate"
        Me.btnAddRate.Size = New System.Drawing.Size(193, 28)
        Me.btnAddRate.TabIndex = 0
        Me.btnAddRate.Text = "Add Rate"
        Me.btnAddRate.UseVisualStyleBackColor = True
        '
        'txtRateID
        '
        Me.txtRateID.Location = New System.Drawing.Point(117, 17)
        Me.txtRateID.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtRateID.Name = "txtRateID"
        Me.txtRateID.Size = New System.Drawing.Size(305, 22)
        Me.txtRateID.TabIndex = 7
        '
        'txtRateType
        '
        Me.txtRateType.Location = New System.Drawing.Point(117, 52)
        Me.txtRateType.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtRateType.Name = "txtRateType"
        Me.txtRateType.Size = New System.Drawing.Size(305, 22)
        Me.txtRateType.TabIndex = 6
        '
        'txtHalfYearRate
        '
        Me.txtHalfYearRate.Location = New System.Drawing.Point(117, 119)
        Me.txtHalfYearRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtHalfYearRate.Name = "txtHalfYearRate"
        Me.txtHalfYearRate.Size = New System.Drawing.Size(305, 22)
        Me.txtHalfYearRate.TabIndex = 5
        '
        'txtYearRate
        '
        Me.txtYearRate.Location = New System.Drawing.Point(117, 87)
        Me.txtYearRate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtYearRate.Name = "txtYearRate"
        Me.txtYearRate.Size = New System.Drawing.Size(305, 22)
        Me.txtYearRate.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "6 Month Rate:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "12 Month Rate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Rate Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Rate ID:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnInvoiceCounterReset)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 561)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox5.Size = New System.Drawing.Size(428, 54)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Reset Invoice Counter"
        '
        'btnInvoiceCounterReset
        '
        Me.btnInvoiceCounterReset.Location = New System.Drawing.Point(9, 20)
        Me.btnInvoiceCounterReset.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnInvoiceCounterReset.Name = "btnInvoiceCounterReset"
        Me.btnInvoiceCounterReset.Size = New System.Drawing.Size(407, 23)
        Me.btnInvoiceCounterReset.TabIndex = 0
        Me.btnInvoiceCounterReset.Text = "Reset Invoice Counter"
        Me.btnInvoiceCounterReset.UseVisualStyleBackColor = True
        '
        'dgdUsers
        '
        Me.dgdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdUsers.Location = New System.Drawing.Point(448, 10)
        Me.dgdUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgdUsers.Name = "dgdUsers"
        Me.dgdUsers.Size = New System.Drawing.Size(937, 292)
        Me.dgdUsers.TabIndex = 3
        '
        'dgdRates
        '
        Me.dgdRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdRates.Location = New System.Drawing.Point(448, 315)
        Me.dgdRates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgdRates.Name = "dgdRates"
        Me.dgdRates.Size = New System.Drawing.Size(937, 292)
        Me.dgdRates.TabIndex = 4
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1401, 623)
        Me.Controls.Add(Me.dgdRates)
        Me.Controls.Add(Me.dgdUsers)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Name = "frmAdminMenu"
        Me.Text = "Admin Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchUser As Button
    Friend WithEvents btnRemoveUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPasswordStore As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSearchRate As Button
    Friend WithEvents btnRemoveRate As Button
    Friend WithEvents btnUpdateRate As Button
    Friend WithEvents btnAddRate As Button
    Friend WithEvents txtRateID As TextBox
    Friend WithEvents txtRateType As TextBox
    Friend WithEvents txtHalfYearRate As TextBox
    Friend WithEvents txtYearRate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnInvoiceCounterReset As Button
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents dgdUsers As DataGridView
    Friend WithEvents dgdRates As DataGridView
End Class
