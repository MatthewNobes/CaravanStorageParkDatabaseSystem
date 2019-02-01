<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCustomerMng = New System.Windows.Forms.Button()
        Me.btnAdminMenu = New System.Windows.Forms.Button()
        Me.btnRenewalMng = New System.Windows.Forms.Button()
        Me.btnPitchMng = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomerMng
        '
        Me.btnCustomerMng.Location = New System.Drawing.Point(16, 15)
        Me.btnCustomerMng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCustomerMng.Name = "btnCustomerMng"
        Me.btnCustomerMng.Size = New System.Drawing.Size(259, 123)
        Me.btnCustomerMng.TabIndex = 0
        Me.btnCustomerMng.Text = "Customer Mangament Form"
        Me.btnCustomerMng.UseVisualStyleBackColor = True
        '
        'btnAdminMenu
        '
        Me.btnAdminMenu.Location = New System.Drawing.Point(321, 15)
        Me.btnAdminMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminMenu.Name = "btnAdminMenu"
        Me.btnAdminMenu.Size = New System.Drawing.Size(259, 123)
        Me.btnAdminMenu.TabIndex = 1
        Me.btnAdminMenu.Text = "Admin Form"
        Me.btnAdminMenu.UseVisualStyleBackColor = True
        '
        'btnRenewalMng
        '
        Me.btnRenewalMng.Location = New System.Drawing.Point(16, 164)
        Me.btnRenewalMng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRenewalMng.Name = "btnRenewalMng"
        Me.btnRenewalMng.Size = New System.Drawing.Size(259, 123)
        Me.btnRenewalMng.TabIndex = 2
        Me.btnRenewalMng.Text = "Renewal Mangament Form"
        Me.btnRenewalMng.UseVisualStyleBackColor = True
        '
        'btnPitchMng
        '
        Me.btnPitchMng.Location = New System.Drawing.Point(321, 164)
        Me.btnPitchMng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPitchMng.Name = "btnPitchMng"
        Me.btnPitchMng.Size = New System.Drawing.Size(259, 123)
        Me.btnPitchMng.TabIndex = 3
        Me.btnPitchMng.Text = "Pitch Mangament Form"
        Me.btnPitchMng.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 297)
        Me.Controls.Add(Me.btnPitchMng)
        Me.Controls.Add(Me.btnRenewalMng)
        Me.Controls.Add(Me.btnAdminMenu)
        Me.Controls.Add(Me.btnCustomerMng)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomerMng As Button
    Friend WithEvents btnAdminMenu As Button
    Friend WithEvents btnRenewalMng As Button
    Friend WithEvents btnPitchMng As Button
End Class
