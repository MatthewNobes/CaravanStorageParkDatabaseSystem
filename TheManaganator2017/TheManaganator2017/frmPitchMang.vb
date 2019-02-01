Public Class frmPitchMang

    ''' <summary>
    ''' The information for the datgrid is loaded in from the databse.
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmPitchMang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the object to the pitch collection sub in the collection class.
        Dim PitchTableObject As CollectionClass = New CollectionClass()
        PitchTableObject.PitchCollection()

        'Sets the datagrid to the pitch dataset.
        dgdPitches.DataSource = PitchDs.Tables("tblAll")
    End Sub

    ''' <summary>
    ''' This is used to search the whole pitch data set for a user set criteria. 
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearchPitch_Click(sender As Object, e As EventArgs) Handles btnSearchPitch.Click
        'Rsets the datagrid
        dgdPitches.DataSource = PitchDs.Tables("tblAll")

        'Asks the user for the search criteria
        Dim SearchCriteria As String = InputBox("Please enter the search criertia", "Search Pitches")

        'This is used to set if the output statement needs to be ran or not. 
        Dim AreAnyRecordFound As Boolean = False

        Dim RecordFound As Boolean = False

        'Used to make sure the scan stops if the record contaisn the criteria. 
        Dim FoundInRecord As Boolean

        'Makes a list for storing the ID's of the pitches where the cirteria has been found. 
        Dim FoundIDs As List(Of Integer) = New List(Of Integer)

        'Starts a ROW counter at zero. 
        Dim CollumCounter As Integer = 0

        'Runs the loop for the amount of rows in the data set
        For Each row As DataRow In PitchDs.Tables(0).Rows
            'incriments the collum counter by 1, collum counter is actually refering to row count.
            CollumCounter = CollumCounter + 1
            'makes sure the search is done for every collum in the record. 
            For i As Integer = 0 To PitchDs.Tables(0).Columns.Count - 1
                'only runs if the criteria has not been found in the code. 
                If FoundInRecord = False Then
                    'Looks for the criteria in the current collum. 
                    If row.Item(i).ToString() = SearchCriteria Then
                        'Used as a test feature to show when a record has been found.
                        MessageBox.Show("Found")

                        'Used to let the statement adding the pitch to the found list.
                        RecordFound = True
                        'Used to mkae sure the output is now ran. 
                        AreAnyRecordFound = True
                        'Used to make sure the rest of the record is not searched. 
                        FoundInRecord = True
                    End If

                    'Only ran if the crieria has been found in this record. 
                    If RecordFound = True Then

                        'Add the ID of the record it was found on to a list
                        FoundIDs.Add(PitchDs.Tables("tblAll").Rows(CollumCounter - 1)("PitchID").ToString())


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

            'Starts the SQL statement for retriving the nessassary customers.
            Sql = "select * from tblPitch Where PitchID= " & FoundIDs(0)

            'Runs if the criteria was found in more than one record.
            For a As Integer = 1 To FoundIDs.Count - 1

                'Adds to the sql statement in the event that their is more than one record that needs to be located.
                Sql &= " Or PitchID= " & FoundIDs(a)


            Next

            'The final end of the sql statement.
            Sql &= ";"

            'Calls the class for setting the data adapter and getting the results
            Dim ToSearchCustDAdapter As DataAdapterClass = New DataAdapterClass()
            ToSearchCustDAdapter.SearchPitchDataAdpt()

            'Fills the datagrid with the dataset that containes the serach results
            dgdPitches.DataSource = SearchPitchDs.Tables("tblAll")
        End If
    End Sub


    ''' <summary>
    ''' This sub is used to add pitches to the pitch table in the database. 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddPitch_Click(sender As Object, e As EventArgs) Handles btnAddPitch.Click

        If ValidatePitchInputs() = True Then

            'Decleares all the variables for adding to the database.
            Dim Site As String = cmbSite.Text
            Dim PitchType As String = txtPitchType.Text
            Dim PitchLength As String = txtPitchLength.Text
            Dim OccupantID As String = txtOccupantID.Text
            Dim Occupied As Boolean = chbOccupied.Checked

            'The sql statement to insert records into the table. 
            Sql = "Insert Into tblPitch ( Occupied, PitchLengthFt, PitchTypeID, Site, CustomerID) VALUES (" & Occupied & ", " & PitchLength & ", " & PitchType & ", '" & Site & "', " & OccupantID & ");"

            'This sets up the sql stament to be ran adding the new ptich to the table. 
            Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            ToDAdapter.AddingPitchDa()

            'Calls the class for class for the dataset with the new pitch. 
            Dim PitchTableObject As CollectionClass = New CollectionClass()
            PitchTableObject.PitchCollection()

            'This updates the datgrid with the newly updates data.
            dgdPitches.DataSource = PitchDs.Tables("tblAll")
        End If
    End Sub

    ''' <summary>
    ''' This is used to remove pitches completly from the pitch table. 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemovePitch_Click(sender As Object, e As EventArgs) Handles btnRemovePitch.Click

        'This asks the user for the ID of the pitch they wish to remove
        Dim RemoveId As Integer = InputBox("Input the ID of the pitch you wish to remove from the databse.")

        'The sql statement to remove the chosen pitch from the database
        Sql = "delete from tblPitch Where PitchID= " & RemoveId & ";"


        'Calls the class for setting the data adapter for running the sql statement
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        ToDAdapter.RemovePitchDa()

        'refreshes the datagrid with the newly updated data.
        Dim myObject As CollectionClass = New CollectionClass()
        myObject.PitchCollection()

        'fills the data grid with the new tblpitch with the removed pitch no longer in it.
        dgdPitches.DataSource = PitchDs.Tables("tblAll")
    End Sub

    ''' <summary>
    ''' This is used to load whatever pitch is selected into the text boxes on the side. 
    ''' 
    ''' This works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgdPitches_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdPitches.CellClick

        'This sets an sql statement to get the information of the currently selected pitch.
        Sql = "Select * From tblPitch Where PitchID=" & dgdPitches(0, dgdPitches.CurrentCell.RowIndex).Value() & ";"

        'Calls the class for setting the data adapter for running the sql statement
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        ToDAdapter.PitchSpecificDa()

        'Sets variables for each collum and sets these to the values from the data set.
        Dim PitchID As Integer = PitchSpecificDs.Tables("tblAll").Rows(0).Item(0)
        Dim Occupied As Boolean = PitchSpecificDs.Tables("tblAll").Rows(0).Item(1)
        Dim PitchLengthFt As Integer = PitchSpecificDs.Tables("tblAll").Rows(0).Item(2)
        Dim PitchTypeID As Integer = PitchSpecificDs.Tables("tblAll").Rows(0).Item(3)
        Dim Site As String = PitchSpecificDs.Tables("tblAll").Rows(0).Item(4)
        Dim CustomerID As Integer = PitchSpecificDs.Tables("tblAll").Rows(0).Item(5)

        'Sets the text boxes to the variables made above. 
        txtPitchID.Text = PitchID
        chbOccupied.Checked = Occupied
        txtPitchLength.Text = PitchLengthFt
        txtPitchType.Text = PitchTypeID
        cmbSite.Text = Site
        txtOccupantID.Text = CustomerID

    End Sub

    ''' <summary>
    ''' This updates the currently selected pitch with the infroamtion changed in the side text boxes.
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdatePitch_Click(sender As Object, e As EventArgs) Handles btnUpdatePitch.Click

        If ValidatePitchInputs() = True Then

            'This sets the ID of the record which is going to be updated.
            Dim PitchID As Integer = txtPitchID.Text

            'This sets the other varibles which will be used to update. 
            Dim Occupied As Boolean = chbOccupied.Checked
            Dim PitchLengthFt As Integer = txtPitchLength.Text
            Dim PitchTypeID As Integer = txtPitchType.Text
            Dim Site As String = cmbSite.Text
            Dim CustID As Integer = txtOccupantID.Text

            'This sets the SQL statement for updating to have all the correct values in it. 
            Sql = "Update tblPitch Set Occupied = " & Occupied & ", PitchLengthFt = " & PitchLengthFt & ", PitchTypeID = " & PitchTypeID & ", Site = '" & Site &
            "', CustomerID = " & CustID & " Where PitchID = " & PitchID & ";"

            'Calls the correct sub to run the SQL command
            Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            ToDAdapter.UpdateUserDa()

            'refreshes the datagrid with the newly updated data.
            Dim myObject As CollectionClass = New CollectionClass()
            myObject.PitchCollection()

            'fills the data grid with the new tblpitch with the pitch data updated. 
            dgdPitches.DataSource = PitchDs.Tables("tblAll")
        End If
    End Sub

	''' <summary>
	''' this validates all the inputs for the pitches
	''' </summary>
	''' <returns></returns>
	Public Function ValidatePitchInputs() As Boolean

        'Presence checks all the necssassary text boxes
        If txtOccupantID.Text = String.Empty Or txtPitchLength.Text = String.Empty Or txtPitchType.Text = String.Empty Then
            MessageBox.Show("Information is required in all textboxes besides pitch ID")
            Return False

        Else
			'Length checks
			If cmbSite.Text.Length > 25 Then
				MessageBox.Show("Site exceeds maximum length")
				Return False

			Else

				'Length checks the integre value.
				If Convert.ToInt64(txtPitchLength.Text) > 100 Then
                    MessageBox.Show("Pitch length is too large")
                    Return False

                Else
					'Length checks
					If txtPitchType.Text.Length > 15 Then
                        MessageBox.Show("Pitch type exceeds maximum length")
                        Return False
                    Else
                        Return True
                    End If
                End If
            End If
            End If
    End Function
End Class



