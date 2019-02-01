Public Class frmAdminMenu

    ''' <summary>
    ''' This is used to call in all the information to fill the two data grids on this form. 
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads in the users information from the database into a dataset
        Dim UserCollectionObject As CollectionClass = New CollectionClass()
        UserCollectionObject.UsersCollection()

        'Loads the user data into the datagrid 
        dgdUsers.DataSource = UserDs.Tables("tblAll")

        'Loads in the rate infroamtion from the database into a dataset
        Dim RateCollectionObject As CollectionClass = New CollectionClass()
        RateCollectionObject.RateCollection()

        'Loads the rate table data into the datagrid 
        dgdRates.DataSource = RateDs.Tables("tblAll")
    End Sub

    ''' <summary>
    ''' This sub resets the invoice counter by making an invoice record that has a count set to zero and the time set
    ''' to the current time. When the counter is read, this new record will appear first and be used insted of the others.
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInvoiceCounterReset_Click(sender As Object, e As EventArgs) Handles btnInvoiceCounterReset.Click

        'Declears all the new variables needed for addin the new record to the database. 
        Dim InvoiceNoForNew As Integer = 0
        Dim TodaysDateForNew As Date = Format(Date.Now(), "ddMMMyyyy")


        'The sql statement to add a new record to the invoice table.
        Sql = "Insert Into tblInvoice ( InvoiceNo, DateStart) Values (" & InvoiceNoForNew & ", " & TodaysDateForNew & ");"


        'Calls the class for setting the data adapter for adding to the invoice table.
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        ToDAdapter.ResetInvoiceCountDa()

        'Loads in the users information from the database into a dataset
        Dim UserCollectionObject As CollectionClass = New CollectionClass()
        UserCollectionObject.UsersCollection()


    End Sub

    ''' <summary>
    ''' This is used to add a new user to the user table.
    ''' it works using an sql insert statement.
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

		'Only runs if the validation was sucessful
		If ValidateUserInfo() = True Then

            'Sets variables for the adding of a new user to the system 
            Dim UserType As String = cmbUserType.Text
            Dim UserName As String = txtUserName.Text
            Dim PasswordStore As String = txtPasswordStore.Text
            Dim Email As String = txtEmail.Text

            'This makes an SQL statement with all the user infromation correctly inserted into it.
            Sql = "INSERT INTO tblUser ( UserName, PasswordStore, Email, UserType) VALUES ('" & UserName & "', '" & PasswordStore & "', '" & Email & "', '" & UserType & "');"

            'Calls the sub to add new users. 
            Dim ToSearchCustDAdapter As DataAdapterClass = New DataAdapterClass()
            ToSearchCustDAdapter.AddUserDa()

            'Collects the data from the table with the new data in it
            Dim UserCollectionObject As CollectionClass = New CollectionClass()
            UserCollectionObject.UsersCollection()

            'Loads the refreshed data into the datgrid 
            dgdUsers.DataSource = UserDs.Tables("tblAll")
        End If

    End Sub

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click

        'Rsets the datagrid
        dgdUsers.DataSource = UserDs.Tables("tblAll")

        'Asks the user for the search criteria
        Dim SearchCriteria As String = InputBox("Please enter the search criertia", "Search Users")

        Dim AreAnyRecordFound As Boolean = False

        Dim RecordFound As Boolean = False

        Dim FoundInRecord As Boolean

        Dim FoundIDs As List(Of Integer) = New List(Of Integer)

        Dim CollumCounter As Integer = 0

        For Each row As DataRow In UserDs.Tables(0).Rows
            CollumCounter = CollumCounter + 1
            For i As Integer = 0 To UserDs.Tables(0).Columns.Count - 1
                If FoundInRecord = False Then
                    If row.Item(i).ToString() = SearchCriteria Then
                        MessageBox.Show("Found")
                        RecordFound = True
                        AreAnyRecordFound = True
                        FoundInRecord = True
                    End If
                    If RecordFound = True Then

                        'Add the ID of the record it was found on to a list
                        FoundIDs.Add(UserDs.Tables("tblAll").Rows(CollumCounter - 1)("UserID").ToString())


                    End If

                    'Resets the record found counter
                    RecordFound = False
                End If
            Next
            'Resets the found in record counter, so that it continuse to search the rest of the records.
            FoundInRecord = False
        Next



        'Only runs if some results have been found
        If AreAnyRecordFound = True Then


            Sql = "select * from tblUser Where UserID= " & FoundIDs(0)
            For a As Integer = 1 To FoundIDs.Count - 1
                'Adds to the sql statement in the event that their is more than one record that needs to be located.
                Sql &= " Or PitchID= " & FoundIDs(a)


            Next

            'The final end of the sql statement.
            Sql &= ";"

            'Calls the class for setting the data adapter for 
            Dim ToSearchCustDAdapter As DataAdapterClass = New DataAdapterClass()
            ToSearchCustDAdapter.SearchUserDa()

            'Fills the datagrid with the dataset that containes the serach results
            dgdUsers.DataSource = SearchUserDs.Tables("tblAll")

        End If
    End Sub

    ''' <summary>
    ''' This removes the user from the ID that the user of the system enters. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click

        'This asks the user for the ID of the user they wish to remove from the system
        Dim RemoveId As Integer = InputBox("Input the ID of the user you wish to remove from the database.", "Remove User")

        'The sql statement to remove a customer from the customer table.
        Sql = "delete from tblUser Where UserID= " & RemoveId & ";"


        'Calls the class for setting the data adapter for 
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        ToDAdapter.RemoveDataAdapter()

        'refreshes the datagrid with the newly updated data.
        Dim myObject As CollectionClass = New CollectionClass()
        myObject.UsersCollection()

        'fills the data set with the new tblCustOne with the removed customer no longer in it.
        dgdUsers.DataSource = UserDs.Tables("tblAll")
    End Sub


    ''' <summary>
    ''' This sub is used to remove rates from the rate table.
    ''' 
    ''' This does not fully function for jpined records.
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemoveRate_Click(sender As Object, e As EventArgs) Handles btnRemoveRate.Click

        'This asks the user for the ID of the user they wish to remove from the system
        Dim RemoveId As Integer = InputBox("Input the ID of the rate you wish to remove from the database.", "Remove Rate")

        'The sql statement to remove a customer from the customer table.
        Sql = "delete from tblRates Where PitchTypeID= " & RemoveId & ";"


        'Calls the class for setting the data adapter for 
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        ToDAdapter.RemoveDataAdapter()

        'refreshes the datagrid with the newly updated data.
        Dim myObject As CollectionClass = New CollectionClass()
        myObject.RateCollection()

        'fills the data set with the new tblCustOne with the removed customer no longer in it.
        dgdRates.DataSource = RateDs.Tables("tblAll")
    End Sub





    ''' <summary>
    ''' This sub is used to search though the rates to find the value that the user wants. 
    ''' 
    ''' Thos works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearchRate_Click(sender As Object, e As EventArgs) Handles btnSearchRate.Click

        'Rsets the datagrid
        dgdRates.DataSource = RateDs.Tables("tblAll")

        'Asks the user for the search criteria
        Dim SearchCriteria As String = InputBox("Please enter the search criertia", "Search Rates")

        Dim AreAnyRecordFound As Boolean = False

        Dim RecordFound As Boolean = False

        Dim FoundInRecord As Boolean

        Dim FoundIDs As List(Of Integer) = New List(Of Integer)

        Dim CollumCounter As Integer = 0

        For Each row As DataRow In RateDs.Tables(0).Rows
            CollumCounter = CollumCounter + 1
            For i As Integer = 0 To RateDs.Tables(0).Columns.Count - 1
                If FoundInRecord = False Then
                    If row.Item(i).ToString() = SearchCriteria Then
                        MessageBox.Show("Found")
                        RecordFound = True
                        AreAnyRecordFound = True
                        FoundInRecord = True
                    End If
                    If RecordFound = True Then

                        'Add the ID of the record it was found on to a list
                        FoundIDs.Add(RateDs.Tables("tblAll").Rows(CollumCounter - 1)("PitchTypeID").ToString())


                    End If

                    'Resets the record found counter
                    RecordFound = False
                End If
            Next
            'Resets the found in record counter, so that it continuse to search the rest of the records.
            FoundInRecord = False
        Next



        'Only runs if some results have been found
        If AreAnyRecordFound = True Then


            Sql = "select * from tblRates Where PitchTypeID= " & FoundIDs(0)
            For a As Integer = 1 To FoundIDs.Count - 1
                'Adds to the sql statement in the event that their is more than one record that needs to be located.
                Sql &= " Or PitchTypeID= " & FoundIDs(a)


            Next

            'The final end of the sql statement.
            Sql &= ";"

            'Calls the class for setting the data adapter for 
            Dim ToSearchCustDAdapter As DataAdapterClass = New DataAdapterClass()
            ToSearchCustDAdapter.SearchUserDa()

            'Fills the datagrid with the dataset that containes the serach results
            dgdRates.DataSource = SearchUserDs.Tables("tblAll")

        End If
    End Sub


    ''' <summary>
    ''' This is used to update rate information for existing records. 
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdateRate_Click(sender As Object, e As EventArgs) Handles btnUpdateRate.Click
		'Only runs if the valudation was sucessful
		If ValidateRateInfo() = True Then

			'Ses the ptich that needs to be updated.
			Dim PitchTypeIDToUpdate As Integer = txtRateID.Text

			'Sets the values it will be updates with.
			Dim TypeOfPitchUpdate As String = txtRateType.Text
            Dim PricePerYearUpdate As String = txtYearRate.Text
            Dim PricePerHalfYearUpdate As String = txtHalfYearRate.Text

			'makes the update statemtn for updating the rate.
			Sql = "Update tblRates Set TypeOfPitch = '" & TypeOfPitchUpdate & "', PricePerYear = " & PricePerYearUpdate & ", PricePerHalf = " &
            PricePerHalfYearUpdate & " Where PitchTypeID = " & PitchTypeIDToUpdate & ";"

			'Rusn the function to update rate
			Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            ToDAdapter.UpdateRateDa()

            'Loads in the rate infroamtion from the database into a dataset
            Dim RateCollectionObject As CollectionClass = New CollectionClass()
            RateCollectionObject.RateCollection()

            'This updates the datgrid with the newly updates data.
            dgdRates.DataSource = RateDs.Tables("tblAll")
        End If
    End Sub

    ''' <summary>
    ''' This sub is used to update users 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click

		'Only runs if the valudation was sucessful
		If ValidateUserInfo() = True Then

			'sets the user to update as an integer variable. 
			Dim UserIDToUpdate As Integer = txtUserID.Text

			'sets all the other variables for updating the user
			Dim UserTypeUpdate As String = cmbUserType.Text
            Dim UserNameUpdate As String = txtUserName.Text
            Dim PasswordUpdate As String = txtPasswordStore.Text
            Dim Email As String = txtEmail.Text

			'makes the update steamnt to update the user.
			Sql = "Update tblUser Set UserName = '" & UserNameUpdate & "', PasswordStore = '" &
            PasswordUpdate & "', Email = '" & Email & "', UserType = '" & UserTypeUpdate & "' Where UserID = " & UserIDToUpdate & ";"

			'runs the sub to run the sql statemtn. 
			Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            ToDAdapter.UpdateUserDa()

            'refreshes the datagrid with the newly updated data.
            Dim myObject As CollectionClass = New CollectionClass()
            myObject.UsersCollection()

            'fills the data set with the new tblCustOne with the removed customer no longer in it.
            dgdUsers.DataSource = UserDs.Tables("tblAll")
        End If
    End Sub

    ''' <summary>
    ''' This sub is used to add new rates to the rate table.
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddRate_Click(sender As Object, e As EventArgs) Handles btnAddRate.Click
		'Only runs if the valudation was sucessful
		If ValidateRateInfo() = True Then

            'Decleares all the variables for adding to the database.
            Dim RateType As String = txtRateType.Text
            Dim YearRate As Double = txtYearRate.Text
            Dim HalfYearRate As Double = txtHalfYearRate.Text

            'The sql statement to insert new reocrds into the rate table.
            Sql = "Insert Into tblRates ( TypeOfPitch, PricePerYear, PricePerHalf) VALUES ('" & RateType & "', " & YearRate & ", " & HalfYearRate & ");"

            'This sets up the sql stament to be ran adding the new ptich to the table. 
            Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            ToDAdapter.AddingPitchDa()

            'Loads in the rate infroamtion from the database into a dataset
            Dim RateCollectionObject As CollectionClass = New CollectionClass()
            RateCollectionObject.RateCollection()

            'This updates the datgrid with the newly updates data.
            dgdRates.DataSource = RateDs.Tables("tblAll")
        End If
    End Sub

    ''' <summary>
    ''' This is used to load a rate from the datagrid into the text boxes on the left side. 
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgdRates_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdRates.CellClick

		'gets the specific rate that is slected from the database.
		Sql = "Select * From tblRates Where PitchTypeID=" & dgdRates(0, dgdRates.CurrentCell.RowIndex).Value() & ";"

        Dim RateCollectionObject As CollectionClass = New CollectionClass()
        RateCollectionObject.LoadRateSpecific()

		'sets the values from the dataset to variables.
		Dim PitchTypeID As Integer = RateCollectSpecificDs.Tables("tblAll").Rows(0).Item(0)
        Dim TypeOfPitch As String = RateCollectSpecificDs.Tables("tblAll").Rows(0).Item(1)
        Dim PricePerYear As Double = RateCollectSpecificDs.Tables("tblAll").Rows(0).Item(2)
        Dim PricePerHalfYear As Double = RateCollectSpecificDs.Tables("tblAll").Rows(0).Item(3)

		'sets the variables to the relvent text boxes.
		txtRateID.Text = PitchTypeID
        txtRateType.Text = TypeOfPitch
        txtYearRate.Text = PricePerYear
        txtHalfYearRate.Text = PricePerHalfYear
    End Sub

    ''' <summary>
    ''' This is used to load a users information into the textboxes at the side from the datagrid. 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgdUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdUsers.CellClick

		'gets the specific user from the database.
		Sql = "Select * From tblUser Where UserID=" & dgdUsers(0, dgdUsers.CurrentCell.RowIndex).Value() & ";"

        Dim UserCollectionObject As CollectionClass = New CollectionClass()
        UserCollectionObject.LoadUserSpecific()

		'sets the values from the dataset to variables.
		Dim UserID As Integer = UserCollectionSpecificDs.Tables("tblAll").Rows(0).Item(0)
        Dim UserType As String = UserCollectionSpecificDs.Tables("tblAll").Rows(0).Item(4)
        Dim UserName As String = UserCollectionSpecificDs.Tables("tblAll").Rows(0).Item(1)
        Dim PasswordSelect As String = UserCollectionSpecificDs.Tables("tblAll").Rows(0).Item(2)
        Dim EmailAdd As String = UserCollectionSpecificDs.Tables("tblAll").Rows(0).Item(3)

		'sets the variables to the relvent text boxes. 
		txtUserID.Text = UserID
        cmbUserType.Text = UserType
        txtUserName.Text = UserName
        txtPasswordStore.Text = PasswordSelect
        txtEmail.Text = EmailAdd
    End Sub

	''' <summary>
	''' validates all the inputs for user inforamtion.
	''' </summary>
	''' <returns></returns>
	Public Function ValidateUserInfo() As Boolean

		'checks the presence of the inputs.
		If txtUserName.Text = String.Empty Or cmbUserType.Text = String.Empty Or txtPasswordStore.Text = String.Empty Or
        txtEmail.Text = String.Empty Then
            MessageBox.Show("Information is required in every text box")
            Return False

        Else
			'length check
			If txtUserName.Text.Length > 25 Then
                MessageBox.Show("Username exceeds maximum length")
                Return False

            Else
				'length check
				If txtPasswordStore.Text.Length > 25 Then
                    MessageBox.Show("Password exceeds maximum length")
                    Return False

                Else
					'length check
					If cmbUserType.Text.Length > 10 Then
                        MessageBox.Show("User type exceeds maximum length")
                        Return False

                    Else
						'length check
						If txtEmail.Text.Length > 50 Then
                            MessageBox.Show("Email exceeds maximum length")
                            Return False

                        Else

                            'If all inputs are ok true is returned and the rest will run.
                            Return True
                        End If
                    End If
                End If
            End If
        End If
    End Function

	''' <summary>
	''' validates all the rate inputs.
	''' </summary>
	''' <returns></returns>
	Public Function ValidateRateInfo() As Boolean

		'presence checks the inputs.
		If txtRateType.Text = String.Empty Or txtHalfYearRate.Text = String.Empty Or txtYearRate.Text = String.Empty Then
            MessageBox.Show("Information is required in every box.")
            Return False

        Else
			'length checks
			If txtRateType.Text.Length > 10 Or txtHalfYearRate.Text.Length > 10 Or txtYearRate.Text.Length > 10 Then
                MessageBox.Show("Inputs exceed maximum length")
                Return False

            Else


                Return True
            End If
        End If
    End Function
End Class