<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustMang
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.grbMainCustInfo = New System.Windows.Forms.GroupBox()
        Me.cmbRenewalLengthOne = New System.Windows.Forms.ComboBox()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdbSecoundPitch = New System.Windows.Forms.RadioButton()
        Me.cmbRenewalLengthTwo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRemainingRenewalsTwo = New System.Windows.Forms.TextBox()
        Me.txtRenewalDateTwo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemainingRenewals = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRenewalDateOne = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtTelphoneNo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddressOne = New System.Windows.Forms.TextBox()
        Me.txtAddressTwo = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.btnNextInvoice = New System.Windows.Forms.Button()
        Me.dgdCustomers = New System.Windows.Forms.DataGridView()
        Me.grbOuputCommands = New System.Windows.Forms.GroupBox()
        Me.btnFormInvoice = New System.Windows.Forms.Button()
        Me.btnContract = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grbMainCustInfo.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbOuputCommands.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnAddCust)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 740)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(640, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commands"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(487, 25)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 28)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update Customer"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(324, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(141, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search Customers"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(163, 25)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(141, 28)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove Customer"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAddCust
        '
        Me.btnAddCust.Location = New System.Drawing.Point(9, 25)
        Me.btnAddCust.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(131, 28)
        Me.btnAddCust.TabIndex = 0
        Me.btnAddCust.Text = "Add Customer"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(667, 740)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(179, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Email"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(9, 25)
        Me.btnEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(153, 28)
        Me.btnEmail.TabIndex = 0
        Me.btnEmail.Text = "Email"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'grbMainCustInfo
        '
        Me.grbMainCustInfo.Controls.Add(Me.cmbRenewalLengthOne)
        Me.grbMainCustInfo.Controls.Add(Me.cmbTitle)
        Me.grbMainCustInfo.Controls.Add(Me.Label17)
        Me.grbMainCustInfo.Controls.Add(Me.GroupBox5)
        Me.grbMainCustInfo.Controls.Add(Me.Label2)
        Me.grbMainCustInfo.Controls.Add(Me.txtRemainingRenewals)
        Me.grbMainCustInfo.Controls.Add(Me.Label11)
        Me.grbMainCustInfo.Controls.Add(Me.txtRenewalDateOne)
        Me.grbMainCustInfo.Controls.Add(Me.Label12)
        Me.grbMainCustInfo.Controls.Add(Me.cmbCounty)
        Me.grbMainCustInfo.Controls.Add(Me.cmbCity)
        Me.grbMainCustInfo.Controls.Add(Me.txtEmailAdd)
        Me.grbMainCustInfo.Controls.Add(Me.Label21)
        Me.grbMainCustInfo.Controls.Add(Me.txtMobileNo)
        Me.grbMainCustInfo.Controls.Add(Me.txtTelphoneNo)
        Me.grbMainCustInfo.Controls.Add(Me.Label20)
        Me.grbMainCustInfo.Controls.Add(Me.Label19)
        Me.grbMainCustInfo.Controls.Add(Me.txtCustomerID)
        Me.grbMainCustInfo.Controls.Add(Me.txtFName)
        Me.grbMainCustInfo.Controls.Add(Me.txtSurname)
        Me.grbMainCustInfo.Controls.Add(Me.txtAddressOne)
        Me.grbMainCustInfo.Controls.Add(Me.txtAddressTwo)
        Me.grbMainCustInfo.Controls.Add(Me.txtPostCode)
        Me.grbMainCustInfo.Controls.Add(Me.Label10)
        Me.grbMainCustInfo.Controls.Add(Me.Label9)
        Me.grbMainCustInfo.Controls.Add(Me.Label8)
        Me.grbMainCustInfo.Controls.Add(Me.Label7)
        Me.grbMainCustInfo.Controls.Add(Me.Label6)
        Me.grbMainCustInfo.Controls.Add(Me.Label5)
        Me.grbMainCustInfo.Controls.Add(Me.Label4)
        Me.grbMainCustInfo.Controls.Add(Me.Label1)
        Me.grbMainCustInfo.Location = New System.Drawing.Point(19, 14)
        Me.grbMainCustInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbMainCustInfo.Name = "grbMainCustInfo"
        Me.grbMainCustInfo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbMainCustInfo.Size = New System.Drawing.Size(412, 642)
        Me.grbMainCustInfo.TabIndex = 1
        Me.grbMainCustInfo.TabStop = False
        Me.grbMainCustInfo.Text = "Main Customer Information"
        '
        'cmbRenewalLengthOne
        '
        Me.cmbRenewalLengthOne.FormattingEnabled = True
        Me.cmbRenewalLengthOne.Items.AddRange(New Object() {"Not Specified", "Year", "Six Months"})
        Me.cmbRenewalLengthOne.Location = New System.Drawing.Point(163, 455)
        Me.cmbRenewalLengthOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbRenewalLengthOne.Name = "cmbRenewalLengthOne"
        Me.cmbRenewalLengthOne.Size = New System.Drawing.Size(233, 24)
        Me.cmbRenewalLengthOne.TabIndex = 56
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs ", "Miss ", "Ms", "Dr "})
        Me.cmbTitle.Location = New System.Drawing.Point(163, 48)
        Me.cmbTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(233, 24)
        Me.cmbTitle.TabIndex = 55
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 50)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Title:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdbSecoundPitch)
        Me.GroupBox5.Controls.Add(Me.cmbRenewalLengthTwo)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtRemainingRenewalsTwo)
        Me.GroupBox5.Controls.Add(Me.txtRenewalDateTwo)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 482)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(397, 151)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Secound Pitch (if applicable)"
        '
        'rdbSecoundPitch
        '
        Me.rdbSecoundPitch.AutoSize = True
        Me.rdbSecoundPitch.Location = New System.Drawing.Point(9, 25)
        Me.rdbSecoundPitch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbSecoundPitch.Name = "rdbSecoundPitch"
        Me.rdbSecoundPitch.Size = New System.Drawing.Size(228, 21)
        Me.rdbSecoundPitch.TabIndex = 61
        Me.rdbSecoundPitch.TabStop = True
        Me.rdbSecoundPitch.Text = "Customer has a secound pitch?"
        Me.rdbSecoundPitch.UseVisualStyleBackColor = True
        '
        'cmbRenewalLengthTwo
        '
        Me.cmbRenewalLengthTwo.FormattingEnabled = True
        Me.cmbRenewalLengthTwo.Items.AddRange(New Object() {"Not Specified", "Year", "Six Months"})
        Me.cmbRenewalLengthTwo.Location = New System.Drawing.Point(155, 117)
        Me.cmbRenewalLengthTwo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbRenewalLengthTwo.Name = "cmbRenewalLengthTwo"
        Me.cmbRenewalLengthTwo.Size = New System.Drawing.Size(233, 24)
        Me.cmbRenewalLengthTwo.TabIndex = 57
        Me.cmbRenewalLengthTwo.Text = "Not Specified"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 119)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Renewal Length 2:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Renewal Date 2:"
        '
        'txtRemainingRenewalsTwo
        '
        Me.txtRemainingRenewalsTwo.Location = New System.Drawing.Point(155, 82)
        Me.txtRemainingRenewalsTwo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemainingRenewalsTwo.Name = "txtRemainingRenewalsTwo"
        Me.txtRemainingRenewalsTwo.Size = New System.Drawing.Size(233, 22)
        Me.txtRemainingRenewalsTwo.TabIndex = 59
        Me.txtRemainingRenewalsTwo.Text = "0"
        '
        'txtRenewalDateTwo
        '
        Me.txtRenewalDateTwo.Location = New System.Drawing.Point(155, 50)
        Me.txtRenewalDateTwo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRenewalDateTwo.Name = "txtRenewalDateTwo"
        Me.txtRenewalDateTwo.Size = New System.Drawing.Size(233, 22)
        Me.txtRenewalDateTwo.TabIndex = 55
        Me.txtRenewalDateTwo.Text = "10/10/18"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 86)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 17)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Remaining Renewals 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 460)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Renewal Length:"
        '
        'txtRemainingRenewals
        '
        Me.txtRemainingRenewals.Location = New System.Drawing.Point(163, 423)
        Me.txtRemainingRenewals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemainingRenewals.Name = "txtRemainingRenewals"
        Me.txtRemainingRenewals.Size = New System.Drawing.Size(233, 22)
        Me.txtRemainingRenewals.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 428)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Remaining Renewals:"
        '
        'txtRenewalDateOne
        '
        Me.txtRenewalDateOne.Location = New System.Drawing.Point(163, 396)
        Me.txtRenewalDateOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRenewalDateOne.Name = "txtRenewalDateOne"
        Me.txtRenewalDateOne.Size = New System.Drawing.Size(233, 22)
        Me.txtRenewalDateOne.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 400)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 17)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Renewal Date 1:"
        '
        'cmbCounty
        '
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Items.AddRange(New Object() {"Avon", "Bedfordshire", "Berkshire", "Borders", "Buckinghamshire", "Cambridgeshire", "Central", "Cheshire", "Cleveland", "Clwyd", "Cornwall", "County Antrim", "County Armagh", "County Down", "County Fermanagh", "County Londonderry", "County Tyrone", "Cumbria", "Derbyshire", "Devon", "Dorset", "Dumfries and Galloway", "Durham", "Dyfed", "East Sussex", "Essex", "Fife", "Gloucestershire", "Grampian", "Greater Manchester", "Gwent", "Gwynedd County", "Hampshire", "Herefordshire", "Hertfordshire", "Highlands and Islands", "Humberside", "Isle of Wight", "Kent", "Lancashire", "Leicestershire", "Lincolnshire", "Lothian", "Merseyside", "Mid Glamorgan", "Norfolk", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottinghamshire", "Oxfordshire", "Powys", "Rutland", "Shropshire", "Somerset", "South Glamorgan", "South Yorkshire", "Staffordshire", "Strathclyde", "Suffolk", "Surrey", "Tayside", "Tyne and Wear", "Warwickshire", "West Glamorgan", "West Midlands", "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire"})
        Me.cmbCounty.Location = New System.Drawing.Point(163, 238)
        Me.cmbCounty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(233, 24)
        Me.cmbCounty.TabIndex = 44
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Items.AddRange(New Object() {"Abbotts Ann", "Aldershot", "Alton", "Ampfield", "Amport", "Andover", "Appleshaw", "Ashley", "Ashmansworth", "Awbridge", "Barton on Sea", "Barton Stacey", "Bashley", "Basingstoke", "Baughurst", "Beaulieu", "Beauworth", "Bedhampton", "Beech", "Bentley", "Bentworth", "Bighton", "Binsted", "Bishop’s Waltham", "Bishops Sutton", "Bishopstoke", "Boarhunt", "Boldre", "Bordon", "Bossington", "Botley", "Bramshaw", "Bransgore", "Breamore", "Brockenhurst", "Broughton", "Brown Candover", "Bullington", "Bursledon", "Catherington", "Charlton", "Chawton", "Cheriton", "Chichester", "Chilbolton", "Chilcomb", "Chilton Candover", "Church Crookham", "Clanfield", "Cliddesden", "Colden Common", "Corhampton", "Cove", "Cowplain", "Crofton", "Crondall", "Crookham", "Curdridge", "Damerham", "Deane", "Denmead", "Dogmersfield", "Durley", "East Stratton", "East Tisted", "East Woodhay", "East Woodhay", "Eastleigh", "Ellisfield", "Emsworth", "Enham Alamein", "Eversley", "Ewshot", "Exton", "Faccombe", "Fair Oak", "Fareham", "Farnborough", "Fawley", "Fleet", "Fordingbridge", "Froxfield", "Fyfield", "Godshill", "Goodworth Clatford", "Gosport", "Grateley", "Grayshott", "Greywell", "Hale", "Hambledon", "Hamble-le-Rice", "Hannington", "Hart Plain", "Hartley Wespall", "Hartley Wintney", "Havant", "Hawkley", "Heckfield", "Hedge End", "Herriard", "Highclere", "Hightown", "Hordle", "Horndean", "Hound", "Hursley", "Hyde", "Itchen Stoke", "Kilmeston", "Kimbridge", "Kimpton", "Kimpton", "King’s Somborne", "Kings Worthy", "Kingsclere", "Langrish", "Lasham", "Laverstoke", "Leckford", "Lee-on-the-Solent", "Lindford", "Linkenholt", "Liphook", "Liss", "Lymington", "Mapledurwell", "Marchwood", "Martin", "Martyr Worthy", "Mattingley", "Medstead", "Meonstoke", "Micheldever", "Michelmersh", "Minstead", "Monk Sherborne", "Monxton", "Mortimer West End", "Mottisfont", "New Alresford", "New Milton", "Northington", "Oakley", "Odiham", "Old Alresford", "Old Basing", "Otterbourne", "Over Wallop", "Overton", "Owslebury", "Pennington", "Penton Grafton", "Penton Mewsey", "Petersfield", "Portchester", "Portsmouth", "Purbrook", "Quarley", "Ringwood", "Rockbourne", "Romsey", "Ropley", "Rotherwick", "Sandleheath", "Sarisbury", "Selborne", "Shalden", "Shedfield", "Soberton", "Southampton", "St Mary Bourne", "Stockbridge", "Swanmore", "Tadley", "Tangley", "Tichborne", "Totton and Eling", "Upton Grey", "Warsash", "Waterlooville", "Welborne", "Whitchurch", "Yateley"})
        Me.cmbCity.Location = New System.Drawing.Point(163, 206)
        Me.cmbCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(233, 24)
        Me.cmbCity.TabIndex = 43
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Location = New System.Drawing.Point(163, 366)
        Me.txtEmailAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(233, 22)
        Me.txtEmailAdd.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 370)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 17)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Email:"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(163, 332)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(233, 22)
        Me.txtMobileNo.TabIndex = 39
        '
        'txtTelphoneNo
        '
        Me.txtTelphoneNo.Location = New System.Drawing.Point(163, 299)
        Me.txtTelphoneNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelphoneNo.Name = "txtTelphoneNo"
        Me.txtTelphoneNo.Size = New System.Drawing.Size(233, 22)
        Me.txtTelphoneNo.TabIndex = 38
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 302)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 17)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Telephone Number:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 336)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Mobile Number:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(163, 16)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(233, 22)
        Me.txtCustomerID.TabIndex = 27
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(163, 80)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(233, 22)
        Me.txtFName.TabIndex = 25
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(163, 110)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(233, 22)
        Me.txtSurname.TabIndex = 24
        '
        'txtAddressOne
        '
        Me.txtAddressOne.Location = New System.Drawing.Point(163, 142)
        Me.txtAddressOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddressOne.Name = "txtAddressOne"
        Me.txtAddressOne.Size = New System.Drawing.Size(233, 22)
        Me.txtAddressOne.TabIndex = 23
        '
        'txtAddressTwo
        '
        Me.txtAddressTwo.Location = New System.Drawing.Point(163, 176)
        Me.txtAddressTwo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddressTwo.Name = "txtAddressTwo"
        Me.txtAddressTwo.Size = New System.Drawing.Size(233, 22)
        Me.txtAddressTwo.TabIndex = 22
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(163, 267)
        Me.txtPostCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(233, 22)
        Me.txtPostCode.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "First Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Surname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address Line 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address Line 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "County"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Post Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox4.Controls.Add(Me.btnNextInvoice)
        Me.GroupBox4.Location = New System.Drawing.Point(852, 740)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(439, 64)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoices"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 23)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Next Invoice:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(107, 20)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(132, 22)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'btnNextInvoice
        '
        Me.btnNextInvoice.Location = New System.Drawing.Point(248, 18)
        Me.btnNextInvoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNextInvoice.Name = "btnNextInvoice"
        Me.btnNextInvoice.Size = New System.Drawing.Size(139, 28)
        Me.btnNextInvoice.TabIndex = 0
        Me.btnNextInvoice.Text = "Next Invoice"
        Me.btnNextInvoice.UseVisualStyleBackColor = True
        '
        'dgdCustomers
        '
        Me.dgdCustomers.AllowUserToAddRows = False
        Me.dgdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdCustomers.Location = New System.Drawing.Point(437, 14)
        Me.dgdCustomers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgdCustomers.Name = "dgdCustomers"
        Me.dgdCustomers.Size = New System.Drawing.Size(859, 718)
        Me.dgdCustomers.TabIndex = 3
        '
        'grbOuputCommands
        '
        Me.grbOuputCommands.Controls.Add(Me.btnFormInvoice)
        Me.grbOuputCommands.Controls.Add(Me.btnContract)
        Me.grbOuputCommands.Location = New System.Drawing.Point(19, 658)
        Me.grbOuputCommands.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbOuputCommands.Name = "grbOuputCommands"
        Me.grbOuputCommands.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbOuputCommands.Size = New System.Drawing.Size(411, 75)
        Me.grbOuputCommands.TabIndex = 4
        Me.grbOuputCommands.TabStop = False
        Me.grbOuputCommands.Text = "Output Commands"
        '
        'btnFormInvoice
        '
        Me.btnFormInvoice.Location = New System.Drawing.Point(204, 21)
        Me.btnFormInvoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormInvoice.Name = "btnFormInvoice"
        Me.btnFormInvoice.Size = New System.Drawing.Size(191, 38)
        Me.btnFormInvoice.TabIndex = 1
        Me.btnFormInvoice.Text = "Invoice Information"
        Me.btnFormInvoice.UseVisualStyleBackColor = True
        '
        'btnContract
        '
        Me.btnContract.Location = New System.Drawing.Point(9, 21)
        Me.btnContract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnContract.Name = "btnContract"
        Me.btnContract.Size = New System.Drawing.Size(191, 38)
        Me.btnContract.TabIndex = 0
        Me.btnContract.Text = "Contract Information"
        Me.btnContract.UseVisualStyleBackColor = True
        '
        'frmCustMang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 809)
        Me.Controls.Add(Me.grbOuputCommands)
        Me.Controls.Add(Me.dgdCustomers)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grbMainCustInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCustMang"
        Me.Text = "Customer Management "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grbMainCustInfo.ResumeLayout(False)
        Me.grbMainCustInfo.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbOuputCommands.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents grbMainCustInfo As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAddressOne As TextBox
    Friend WithEvents txtAddressTwo As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAddCust As Button
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtTelphoneNo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbCounty As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents btnNextInvoice As Button
    Friend WithEvents dgdCustomers As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRemainingRenewalsTwo As TextBox
    Friend WithEvents txtRenewalDateTwo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemainingRenewals As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRenewalDateOne As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents cmbRenewalLengthOne As ComboBox
    Friend WithEvents cmbRenewalLengthTwo As ComboBox
    Friend WithEvents rdbSecoundPitch As RadioButton
    Friend WithEvents grbOuputCommands As GroupBox
    Friend WithEvents btnFormInvoice As Button
    Friend WithEvents btnContract As Button
End Class
