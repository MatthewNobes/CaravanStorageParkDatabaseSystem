<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenewalManagement
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
		Me.dgdUpcomingRenewals = New System.Windows.Forms.DataGridView()
		Me.GroupBox1.SuspendLayout()
		CType(Me.dgdUpcomingRenewals, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dgdUpcomingRenewals)
		Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox1.Size = New System.Drawing.Size(641, 471)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Upcoming Renewals"
		'
		'dgdUpcomingRenewals
		'
		Me.dgdUpcomingRenewals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgdUpcomingRenewals.Location = New System.Drawing.Point(5, 17)
		Me.dgdUpcomingRenewals.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.dgdUpcomingRenewals.Name = "dgdUpcomingRenewals"
		Me.dgdUpcomingRenewals.RowTemplate.Height = 28
		Me.dgdUpcomingRenewals.Size = New System.Drawing.Size(633, 450)
		Me.dgdUpcomingRenewals.TabIndex = 0
		'
		'frmRenewalManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(658, 484)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmRenewalManagement"
		Me.Text = "frmRenewalManagement"
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.dgdUpcomingRenewals, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgdUpcomingRenewals As DataGridView
End Class
