<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPitchMang
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
        Me.chbOccupied = New System.Windows.Forms.CheckBox()
        Me.cmbSite = New System.Windows.Forms.ComboBox()
        Me.txtPitchID = New System.Windows.Forms.TextBox()
        Me.txtOccupantID = New System.Windows.Forms.TextBox()
        Me.txtPitchLength = New System.Windows.Forms.TextBox()
        Me.txtPitchType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchPitch = New System.Windows.Forms.Button()
        Me.btnUpdatePitch = New System.Windows.Forms.Button()
        Me.btnRemovePitch = New System.Windows.Forms.Button()
        Me.btnAddPitch = New System.Windows.Forms.Button()
        Me.dgdPitches = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgdPitches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbOccupied)
        Me.GroupBox1.Controls.Add(Me.cmbSite)
        Me.GroupBox1.Controls.Add(Me.txtPitchID)
        Me.GroupBox1.Controls.Add(Me.txtOccupantID)
        Me.GroupBox1.Controls.Add(Me.txtPitchLength)
        Me.GroupBox1.Controls.Add(Me.txtPitchType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(520, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pitch Information"
        '
        'chbOccupied
        '
        Me.chbOccupied.AutoSize = True
        Me.chbOccupied.Location = New System.Drawing.Point(11, 164)
        Me.chbOccupied.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chbOccupied.Name = "chbOccupied"
        Me.chbOccupied.Size = New System.Drawing.Size(133, 21)
        Me.chbOccupied.TabIndex = 15
        Me.chbOccupied.Text = "Pitch Occupied?"
        Me.chbOccupied.UseVisualStyleBackColor = True
        '
        'cmbSite
        '
        Me.cmbSite.FormattingEnabled = True
        Me.cmbSite.Items.AddRange(New Object() {"site1", "site2", "site3"})
        Me.cmbSite.Location = New System.Drawing.Point(125, 134)
        Me.cmbSite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSite.Name = "cmbSite"
        Me.cmbSite.Size = New System.Drawing.Size(384, 24)
        Me.cmbSite.TabIndex = 14
        '
        'txtPitchID
        '
        Me.txtPitchID.Location = New System.Drawing.Point(125, 18)
        Me.txtPitchID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPitchID.Name = "txtPitchID"
        Me.txtPitchID.ReadOnly = True
        Me.txtPitchID.Size = New System.Drawing.Size(384, 22)
        Me.txtPitchID.TabIndex = 11
        '
        'txtOccupantID
        '
        Me.txtOccupantID.Location = New System.Drawing.Point(125, 46)
        Me.txtOccupantID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOccupantID.Name = "txtOccupantID"
        Me.txtOccupantID.Size = New System.Drawing.Size(384, 22)
        Me.txtOccupantID.TabIndex = 10
        '
        'txtPitchLength
        '
        Me.txtPitchLength.Location = New System.Drawing.Point(125, 105)
        Me.txtPitchLength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPitchLength.Name = "txtPitchLength"
        Me.txtPitchLength.Size = New System.Drawing.Size(384, 22)
        Me.txtPitchLength.TabIndex = 8
        '
        'txtPitchType
        '
        Me.txtPitchType.Location = New System.Drawing.Point(125, 78)
        Me.txtPitchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPitchType.Name = "txtPitchType"
        Me.txtPitchType.Size = New System.Drawing.Size(384, 22)
        Me.txtPitchType.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Site:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pitch Length:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pitch Type ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Occupant ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pitch ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchPitch)
        Me.GroupBox2.Controls.Add(Me.btnUpdatePitch)
        Me.GroupBox2.Controls.Add(Me.btnRemovePitch)
        Me.GroupBox2.Controls.Add(Me.btnAddPitch)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(520, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pitch Commands"
        '
        'btnSearchPitch
        '
        Me.btnSearchPitch.Location = New System.Drawing.Point(396, 21)
        Me.btnSearchPitch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchPitch.Name = "btnSearchPitch"
        Me.btnSearchPitch.Size = New System.Drawing.Size(113, 26)
        Me.btnSearchPitch.TabIndex = 3
        Me.btnSearchPitch.Text = "Search Pitches"
        Me.btnSearchPitch.UseVisualStyleBackColor = True
        '
        'btnUpdatePitch
        '
        Me.btnUpdatePitch.Location = New System.Drawing.Point(265, 21)
        Me.btnUpdatePitch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdatePitch.Name = "btnUpdatePitch"
        Me.btnUpdatePitch.Size = New System.Drawing.Size(113, 26)
        Me.btnUpdatePitch.TabIndex = 2
        Me.btnUpdatePitch.Text = "Update Pitch"
        Me.btnUpdatePitch.UseVisualStyleBackColor = True
        '
        'btnRemovePitch
        '
        Me.btnRemovePitch.Location = New System.Drawing.Point(139, 21)
        Me.btnRemovePitch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemovePitch.Name = "btnRemovePitch"
        Me.btnRemovePitch.Size = New System.Drawing.Size(113, 26)
        Me.btnRemovePitch.TabIndex = 1
        Me.btnRemovePitch.Text = "Remove Pitch"
        Me.btnRemovePitch.UseVisualStyleBackColor = True
        '
        'btnAddPitch
        '
        Me.btnAddPitch.Location = New System.Drawing.Point(7, 21)
        Me.btnAddPitch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddPitch.Name = "btnAddPitch"
        Me.btnAddPitch.Size = New System.Drawing.Size(113, 26)
        Me.btnAddPitch.TabIndex = 0
        Me.btnAddPitch.Text = "Add Pitch"
        Me.btnAddPitch.UseVisualStyleBackColor = True
        '
        'dgdPitches
        '
        Me.dgdPitches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdPitches.Location = New System.Drawing.Point(540, 10)
        Me.dgdPitches.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdPitches.Name = "dgdPitches"
        Me.dgdPitches.Size = New System.Drawing.Size(1236, 257)
        Me.dgdPitches.TabIndex = 2
        '
        'frmPitchMang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1710, 276)
        Me.Controls.Add(Me.dgdPitches)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPitchMang"
        Me.Text = "Pitch Managment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgdPitches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPitchID As TextBox
    Friend WithEvents txtOccupantID As TextBox
    Friend WithEvents txtPitchLength As TextBox
    Friend WithEvents txtPitchType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchPitch As Button
    Friend WithEvents btnUpdatePitch As Button
    Friend WithEvents btnRemovePitch As Button
    Friend WithEvents btnAddPitch As Button
    Friend WithEvents cmbSite As ComboBox
    Friend WithEvents dgdPitches As DataGridView
    Friend WithEvents chbOccupied As CheckBox
End Class
