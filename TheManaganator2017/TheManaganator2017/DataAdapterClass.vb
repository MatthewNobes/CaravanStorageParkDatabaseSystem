Public Class DataAdapterClass

    ''' <summary>
    ''' This calls the data adpter stuff for the customer information, this is ran everytime customer
    ''' information is pulled out of the table, tblCustOne.
    ''' </summary>
    Public Sub DataAdapter()

		'clears the dataset
		AllCustomerDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(AllCustomerDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' Calls the data adpater stuff and runs the sql for the getting the invoice number from the
	''' database, specifcally the table tblInvoice
	''' </summary>
	Public Sub InvoiceDataAdpt()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(NextInvoiceDs, "tblAll")

		'closes the connection module
		Connect.Close()
	End Sub

	''' <summary>
	''' Calls the data adapter for searching and filling the results of the customer search
	''' </summary>
	Public Sub SearchCustDataAdpt()

		'clears the dataset
		SearchResultDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		Dim resultsAffected As Integer = da.Fill(SearchResultDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

    ''' <summary>
    ''' This calls the data adpter and fills the search pitch dataset with the correctly searched data.
    ''' </summary>
    Public Sub SearchPitchDataAdpt()

		'clears the dataset
		SearchPitchDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		Dim resultsAffected As Integer = da.Fill(SearchPitchDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

    ''' <summary>
    ''' This Sub is used to run the insert statement for adding a new pitch to the system
    ''' </summary>
    Public Sub AddingPitchDa()

		'clears the dataset
		AddPitchDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(AddPitchDs, "tblAll")

		'closes the connection module
		Connect.Close()

    End Sub

	''' <summary>
	''' used to get remove a pitch from the dataset
	''' </summary>
	Public Sub RemovePitchDa()

		'clears the dataset
		PitchDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(PitchDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to run the insert for the invoice counter.
	''' </summary>
	Public Sub ResetInvoiceCountDa()

		'clears the dataset
		ResetInvoiceDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(ResetInvoiceDs, "tblAll")

		'closes the connection module
		Connect.Close()
	End Sub


	''' <summary>
	''' used to run the search select for the users.
	''' </summary>
	Public Sub SearchUserDa()

		'clears the dataset
		SearchUserDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(SearchUserDs, "tblAll")

		'closes the connection module
		Connect.Close()

    End Sub


	''' <summary>
	''' used to run the inserts for new users.
	''' </summary>
	Public Sub AddUserDa()

		'clears the dataset
		AddUserDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(AddUserDs, "tblAll")

		'closes the connection module
		Connect.Close()
	End Sub

	''' <summary>
	''' used to remove various things
	''' </summary>
	Public Sub RemoveDataAdapter()

		'clears the dataset
		RemoveDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(RemoveDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to run update rates
	''' </summary>
	Public Sub UpdateRateDa()

		'clears the dataset
		UpdateRateDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(UpdateRateDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to update user information.
	''' </summary>
	Public Sub UpdateUserDa()

		'clears the dataset
		UpdateUserDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(UpdateUserDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to run customer update statements.
	''' </summary>
	Public Sub UpdateCustDa()

		'clears the dataset
		UpdateCustDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(UpdateCustDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to get specific pitch information.
	''' </summary>
	Public Sub PitchSpecificDa()

		'clears the dataset
		PitchSpecificDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(PitchSpecificDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub

	''' <summary>
	''' used to run pitch update statments.
	''' </summary>
	Public Sub UpdatePitchDa()

		'clears the dataset
		UpdatePitchDs.Clear()

		'fills the data adapter with the sql statement and the connect module.
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset
		da.Fill(UpdatePitchDs, "tblAll")

		'closes the connection module
		Connect.Close()
    End Sub
End Class