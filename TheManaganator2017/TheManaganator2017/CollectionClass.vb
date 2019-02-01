Public Class CollectionClass
	Public Sub CustomerInfoGet()
		'Clears the dataset
		AllCustomerDs.Clear()


		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(AllCustomerDs, "tblAll")

		'closes the database connection.
		Connect.Close()

	End Sub

	''' <summary>
	''' This sub is used to collect the users from the user table with the username and password
	''' </summary>
	Public Sub UserCollect()
		'Clears the dataset
		LoginDs.Clear()

		'gets some fo the users information from the database
		Sql = "select UserID, UserName, PasswordStore from tblUser"

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		da.Fill(LoginDs, "tblAll")

		'closes the database connection.
		Connect.Close()

	End Sub

	Public Sub CustomerInfoForEmailForm()
        'Put in code to load data grid info
        Sql = "select CustomerID, FirstName, Surname, EmailAdd from tblCustOne"

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(EmailDs, "tblAll")

		'closes the database connection.
		Connect.Close()
    End Sub

    Public Sub UsersCollection()
		'Clears the dataset
		UserDs.Clear()

		'makes an sql statemtn to get the users
		Sql = "Select * from tblUser"

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(UserDs, "tblAll")

		'closes the database connection.
		Connect.Close()
    End Sub

    ''' <summary>
    ''' This sub is used to collect the rates table for 
    ''' </summary>
    Public Sub RateCollection()
		'Clears the dataset
		RateDs.Clear()

		'makes an sql statement to get the rates
		Sql = "Select * from tblRates"

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(RateDs, "tblAll")

		'closes the database connection.
		Connect.Close()
    End Sub

	''' <summary>
	''' this collects all the pitches from the database. 
	''' </summary>
	Public Sub PitchCollection()

		'This clear the pitch dataset
		PitchDs.Clear()

		'Makes an sql statement to get pitch information
		Sql = "Select * from tblPitch"

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(PitchDs, "tblAll")

		'closes the database connection.
		Connect.Close()
	End Sub

	''' <summary>
	''' This sub collects a specific rates information
	''' </summary>
	Public Sub LoadRateSpecific()
		'Clears the dataset
		RateCollectSpecificDs.Clear()

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(RateCollectSpecificDs, "tblAll")

		'closes the database connection.
		Connect.Close()
    End Sub

	''' <summary>
	''' This sub collects a specific users information.
	''' </summary>
	Public Sub LoadUserSpecific()
		'Clears the dataset
		UserCollectionSpecificDs.Clear()

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(UserCollectionSpecificDs, "tblAll")

		'closes the database connection.
		Connect.Close()
    End Sub

	''' <summary>
	''' collects a specific customers information for updating customers information. 
	''' </summary>
	Public Sub LoadCustomerSpecific()
		'Clears the dataset
		CusotmerSpecficDs.Clear()

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(CusotmerSpecficDs, "tblAll")
		'closes the database connection.
		Connect.Close()
	End Sub


	''' <summary>
	''' This sub collects the passwords from the database
	''' </summary>
	Public Sub CollectPassword()
		'Clears the dataset
		PassDs.Clear()

		'sets the data adapter with the sql statement and connection.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the data in tblALL
		Dim resultsAffected As Integer = da.Fill(PassDs, "tblAll")

		'closes the database connection.
		Connect.Close()
	End Sub
End Class