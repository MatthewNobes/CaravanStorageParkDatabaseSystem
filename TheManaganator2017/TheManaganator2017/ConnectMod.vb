Imports System.Data.OleDb
Module ConnectMod

	'Declares variables used for the sql statements
	Public dbProvider As String
    Public dbsource As String
    Public Connect As New OleDbConnection

	'All the datasets I will use thoughout my project are declared here.
	Public AllCustomerDs As New DataSet
	Public EmailDs As New DataSet
	Public NextInvoiceDs As New DataSet
	Public UserDs As New DataSet
	Public RateDs As New DataSet
	Public PitchDs As New DataSet
    Public SearchResultDs As New DataSet
    Public SearchPitchDs As New DataSet
    Public AddPitchDs As New DataSet
    Public ResetInvoiceDs As New DataSet
    Public SearchUserDs As New DataSet
    Public SearchRateDs As New DataSet
    Public AddUserDs As New DataSet
    Public EmailSendDs As New DataSet
    Public RateCollectSpecificDs As New DataSet
    Public UpdateRateDs As New DataSet
    Public UserCollectionSpecificDs As New DataSet
    Public UpdateUserDs As New DataSet
    Public CusotmerSpecficDs As New DataSet
    Public UpdateCustDs As New DataSet
    Public PitchSpecificDs As New DataSet
    Public UpdatePitchDs As New DataSet
    Public LoginDs As New DataSet
    Public PassDs As New DataSet

    Public RemoveDs As New DataSet

    'Used to identify if the user is an admin or not 
    Public IsAdmin As Boolean = False



    'Used for dtabase communcation 
    Public da As New OleDbDataAdapter

	'Used to store the SQL statements
	Public Sql As String

	'Creates a globally avilable list used to sotre the number of recipents. 
	Public RecipientList As New List(Of Integer)()

	''' <summary>
	''' This provides my inital connection to the database. 
	''' </summary>
	Public Sub DBConnect()
		'Used to connect to the database
		dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"


        'dbSource points to where the database is located
        dbsource = "Data Source = G:\Old Archived\College USB Stick Backup\CloudStation\CourseWork BackUps\CourseWork\5.0 PostPrototype\ActualCode\Caravan Storage Park Database 1.0.accdb"
        'join the above 2 lines together to define the db connection
        Connect.ConnectionString = dbProvider & dbsource

		'open the database connection
		Connect.Open()

	End Sub
End Module
