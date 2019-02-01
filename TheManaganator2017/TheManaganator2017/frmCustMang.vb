Public Class frmCustMang

    ''' <summary>
    ''' This sub will open the email form when the email button is pressed. 
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        'opens the email form
        frmEmailForm.Show()
    End Sub

    ''' <summary>
    ''' The sub that loads in all the required information when the form is opened, such as the 
    ''' loading of the invoice counter and the loading of the datagrid table. 
    ''' 
    ''' All of the parts in this section work for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCustMang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes sure the user does not try to change data by typing it into the data grid.
        dgdCustomers.ReadOnly = True


        Sql = "select * from tblCustOne"

        'Calls the sub in the collection class that gets the customer information from the 
        'database, then saves this to the data set named allcustomerds.
        Dim myObject As CollectionClass = New CollectionClass()
        'This calls the correct sub from within the collection class.
        myObject.CustomerInfoGet()

        'Fills the datagrid with the customer info from the datset allcustomerds.
        dgdCustomers.DataSource = AllCustomerDs.Tables("tblAll")


        'The next bit of code loads the invocie number

        'Runs the subroutine to get the invoice number out of the database. 
        Dim InvoiceObject As InvoiceNoClass = New InvoiceNoClass()
        'This calls the correct sub from within the invoice class.
        InvoiceObject.InvoiceCounterLoad()


        'Sets the invoice number to the invoice text box
        txtInvoiceNo.Text = InvoiceObject.GiveInvoiceNo()

    End Sub




    ''' <summary>
    ''' The following sub routine is used to add a new customer to the customer table. 
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click


        'Runs a function which checks if the inputs are valid
        If ValidateInputs() = True Then
            ' Clears the customer daset ready for the adding of new data to the custemr table. 
            AllCustomerDs.Clear()

            'Declaring all the vaibles for the adding of customers
            Dim Tile As String = cmbTitle.Text
            Dim CustomerFName As String = txtFName.Text
            Dim CustomerSName As String = txtSurname.Text
            Dim PitchIDOne As String = txtTelphoneNo.Text
            Dim AddressOne As String = txtAddressOne.Text
            Dim AddressTwo As String = txtAddressTwo.Text
            Dim City As String = cmbCity.Text
            Dim County As String = cmbCounty.Text
            Dim PostCode As String = txtPostCode.Text
            Dim TelephoneNo As String = txtTelphoneNo.Text
            Dim MobileNo As String = txtMobileNo.Text
            Dim EmailAdd As String = txtEmailAdd.Text
            Dim RenewalDate As String = txtRenewalDateOne.Text
            Dim RemainingRenewalsOne As String = txtRemainingRenewals.Text
            Dim RenewalLength As String = cmbRenewalLengthOne.Text



            'Converts the relevent variables to their relevent format.
            Convert.ToInt64(RemainingRenewalsOne)
            Convert.ToDateTime(RenewalDate)

            'If the customer has a secound pitch then this will be ran insted adding the extra info to the databse. 
            If rdbSecoundPitch.Checked = True Then

                ' This section of the IF statement is ran if 
                Dim RenewalLengthTwo As String = cmbRenewalLengthTwo.Text
                Dim RenewalDateTwo As String = txtRenewalDateTwo.Text
                Dim RemainingRenewalsTwo As String = txtRemainingRenewalsTwo.Text

                'Converts the relevent variables to their relevent format.
                Convert.ToInt32(RemainingRenewalsTwo)
                Convert.ToDateTime(RenewalDateTwo)

                'The SQL statement for adding a customer that has multiple pitches. 
                Sql = "Insert Into tblCustOne ( Title, FirstName, Surname, AddressOne, AddressTwo, City, County, PostCode, TelephoneNo, MobileNo, EmailAdd, RenewalDateOne, 
            RenewalDateTwo, NoRemainingRenewalsOne, NoRemainingRenewalsTwo, RenewalLengthOne, RenewalLengthTwo) Values ('" & Tile & "', '" & CustomerFName & "', '" & CustomerSName & "', '" &
                AddressOne & "', '" & AddressTwo & "', '" & City & "', '" & County & "', '" & PostCode & "', '" & TelephoneNo & "', '" & MobileNo & "', '" &
                EmailAdd & "', '" & RemainingRenewalsOne & "', '" & RemainingRenewalsTwo & "', '" & RenewalDate & "', '" & RenewalDateTwo & "', '" & RemainingRenewalsOne & "', '" & RenewalLength & "', '" &
                RenewalLengthTwo & "');"

                'Calls the class for setting the data adapter for 
                Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
                ToDAdapter.DataAdapter()

            Else

                ' This SQL statement is ran if the customer has not got a secound pitch and uses the data from groupbox main customer info
                Sql = "Insert Into tblCustOne ( Title, FirstName, Surname, AddressOne, AddressTwo, City, County, PostCode, TelephoneNo, MobileNo, EmailAdd, RenewalDateOne,
            NoRemainingRenewalsOne, RenewalLengthOne) Values ('" & Tile & "', '" & CustomerFName & "', '" & CustomerSName & "', '" & AddressOne & "', '" &
                AddressTwo & "', '" & City & "', '" & County & "', '" & PostCode & "', '" & TelephoneNo & "', '" & MobileNo & "', '" & EmailAdd & "', '" & RenewalDate & "', '" &
                RemainingRenewalsOne & "', '" & RenewalLength & "');"

                'Calls the class for setting the data adapter 
                Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
                'Sets the right sub to be called.
                ToDAdapter.DataAdapter()


            End If

            Sql = "select * from tblCustOne"
            'refreshes the datagrid with the newly updated data.
            Dim CustomerInfoObject As CollectionClass = New CollectionClass()
            'This calls the right sub in the collection class.
            CustomerInfoObject.CustomerInfoGet()

            'This will update the datagrid with the new customer added to it. 
            dgdCustomers.DataSource = AllCustomerDs.Tables("tblAll")

        End If



    End Sub




    ''' <summary>
    ''' This following sub routine is used to update the invoice counter when the button is pressed to indicate that it
    ''' has moved along. It updates the database and runs the request code to get that value from the database again as it did when the form loaded in. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNextInvoice_Click(sender As Object, e As EventArgs) Handles btnNextInvoice.Click

        'A variable to store the new invoice number
        Dim NewInvoiceNo As Integer
        'This collects the invoice id of the record that needs updating.
        Dim InvoiceID As Integer

        'This line extracts the old invoice number from the data set.
        NewInvoiceNo = NextInvoiceDs.Tables("tblAll").Rows(0).Item("InvoiceNo")

        'This adds one to the invoice number
        NewInvoiceNo = NewInvoiceNo + 1

        'This gets the correct invoice id for when updating the database with the new 
        InvoiceID = NextInvoiceDs.Tables("tblAll").Rows(0).Item("InvoiceID")

        'This is used as the update sql statement for adding one to the invoice number.
        Sql = "Update tblInvoice Set InvoiceNo=" & NewInvoiceNo & " Where InvoiceID = " & InvoiceID & ";"

        'Calls the class for setting the data adapter 
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        'This calls the correct sub from within the data adapter class.
        ToDAdapter.InvoiceDataAdpt()

        'Runs the subroutine to get the invoice number out of the database. 
        Dim InvoiceObject As InvoiceNoClass = New InvoiceNoClass()
        'This sets invoice object to the corretcsub in the invoice no class.
        InvoiceObject.InvoiceCounterLoad()


        'Sets the invoice number to the invoice text box
        txtInvoiceNo.Text = InvoiceObject.GiveInvoiceNo()

    End Sub


    ''' <summary>
    ''' This sub is used to search the dataset for sepcific information, and will leave the entire record if 
    ''' anything in the record matches the search criteria.
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

		'Rsets the datagrid
		dgdCustomers.DataSource = AllCustomerDs.Tables("tblAll")

        'Asks the user for the search criteria
        Dim SearchCriteria As String = InputBox("Please enter the search criertia", "Search Customers")

        'This is used to makes sure that some of the code is not ran if no records are found.
        Dim AreAnyRecordFound As Boolean = False

        'This is used to make sure that the code that adds the found id to the list is ran when needed
        Dim RecordFound As Boolean = False

        'This is used to make sure that if the search criteria is found in the record then it stops searching that record.
        Dim FoundInRecord As Boolean

        'This sets a list called found Id's for use when the algorithem finds a value.
        Dim FoundIDs As List(Of Integer) = New List(Of Integer)

        'This keeps a count of how many rows have been searched. 
        Dim CollumCounter As Integer = 0

        'This loops the indented code for the number of records in the custoemr dataset. 
        For Each row As DataRow In AllCustomerDs.Tables(0).Rows
            'This increases the collum counter by one everytime a row has been searched. 
            CollumCounter = CollumCounter + 1
            'This makes sure that the search is ran for each indevdual collum. 
            For i As Integer = 0 To AllCustomerDs.Tables(0).Columns.Count - 1
                'This code is only ran if the search criteria hasn't been found in the record yet.
                If FoundInRecord = False Then
                    'This compares if the search criteria is the same as what is in the currenyl looked at box.
                    If row.Item(i).ToString() = SearchCriteria Then
                        'If the record is found then this message is shown, this is aminly used as a test feature. 
                        MessageBox.Show("Found")
                        'This sets that a record is found to make sure the id is added to the list.
                        RecordFound = True
                        'This lets the output of the found ID's be ran.
                        AreAnyRecordFound = True
                        'This makes sure that the search for this record is stpped and it moves onto the next record
                        FoundInRecord = True
                    End If
                    'This code is ran if the search criteria was found in the record.
                    If RecordFound = True Then

                        'Add the ID of the record it was found on to a list
                        FoundIDs.Add(AllCustomerDs.Tables("tblAll").Rows(CollumCounter - 1)("CustomerID").ToString())


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

            'This line starts an sql command to look gather the first id that the search criteria was foudn in. 
            Sql = "select * from tblCustOne Where CustomerID= " & FoundIDs(0)

            'This loop is ran if there is more than one record in which the search crietria was found. 
            For a As Integer = 1 To FoundIDs.Count - 1


                'Adds to the sql statement in the event that their is more than one record that needs to be located.
                Sql &= " Or CustomerID= " & FoundIDs(a)


            Next

            'The final end of the sql statement, needed here due to its self-writting capabilities.
            Sql &= ";"

            'Calls the class for setting the data adapter for 
            Dim ToSearchCustDAdapter As DataAdapterClass = New DataAdapterClass()
            'This picks out the correct sub from within the data adapter class.
            ToSearchCustDAdapter.SearchCustDataAdpt()

			'Fills the datagrid with the dataset that containes the serach results
			dgdCustomers.DataSource = SearchResultDs.Tables("tblAll")
		End If

	End Sub



    ''' <summary>
    ''' The following sub is used to remove a preset customer when the remove button is pressed. 
    ''' 
    ''' This section works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click


        'This asks the user for the ID 
        Dim RemoveId As Integer = InputBox("Input the ID of customer you wish to remove from the databse.")





        'The sql statement to remove a customer from the customer table.
        Sql = "delete from tblCustOne Where CustomerID= " & RemoveId & ";"


        'Calls the class for setting the data adapter  
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        'This sets the object to call the correct sub in the data adpater class. 
        ToDAdapter.DataAdapter()

        Sql = "select * from tblCustOne"

        'refreshes the datagrid with the newly updated data.
        Dim myObject As CollectionClass = New CollectionClass()
        'This calls the customer info get sub from within the collection class.
        myObject.CustomerInfoGet()

        'fills the data set with the new tblCustOne with the removed customer no longer in it.
        dgdCustomers.DataSource = AllCustomerDs.Tables("tblAll")
    End Sub

    ''' <summary>
    ''' This loads the customer information of the currently selected customer into the textboxes on the side.
    ''' 
    ''' This section works for the prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgdCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdCustomers.CellClick

        'This requests the information of the currently selected customer.
        Sql = "Select * From tblCustOne Where CustomerID=" & dgdCustomers(0, dgdCustomers.CurrentCell.RowIndex).Value() & ";"

        'This sets an object to the class where the data adapter sub is stored. 
        Dim UserCollectionObject As CollectionClass = New CollectionClass()
        'This sets the object to the correct sub routine. 
        UserCollectionObject.LoadCustomerSpecific()

        'This section holds variables where all the customer information is set into individual variables. 
        Dim CustomerID As Integer = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(0)
        Dim Title As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(1)
        Dim FirstName As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(2)
        Dim Surname As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(3)
        Dim AddressOne As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(4)
        Dim AddressTwo As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(5)
        Dim City As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(6)
        Dim County As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(7)
        Dim PostCode As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(8)
        Dim TelephoneNo As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(9)
        Dim MobileNo As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(10)
        Dim EmailAdd As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(11)
        Dim RenewalDateOne As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(12)
        'Dim RenewalDateTwo As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(13)
        Dim NoRemainingRenewalsOne As Integer = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(14)
        'Dim NoRemainingRenewalsTwo As Integer = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(15)
        Dim RenewalLengthOne As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(16)
        'Dim RenewalLengthTwo As String = CusotmerSpecficDs.Tables("tblAll").Rows(0).Item(17)

        'This sets the textboxes to the values of the selected customer as saved in the vairbles above.
        txtCustomerID.Text = CustomerID
        cmbTitle.Text = Title
        txtFName.Text = FirstName
        txtSurname.Text = Surname
        txtAddressOne.Text = AddressOne
        txtAddressTwo.Text = AddressTwo
        cmbCity.Text = City
        cmbCounty.Text = County
        txtPostCode.Text = PostCode
        txtTelphoneNo.Text = TelephoneNo
        txtMobileNo.Text = MobileNo
        txtEmailAdd.Text = EmailAdd
        txtRenewalDateOne.Text = RenewalDateOne
        txtRemainingRenewals.Text = NoRemainingRenewalsOne
        cmbRenewalLengthOne.Text = RenewalLengthOne

    End Sub


    ''' <summary>
    ''' This sub is used to update customer information when the update button is pressed.
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Runs a function which checks if the inputs are valid
        If ValidateInputs() = True Then

            'This sets the ID of the record that is going to be updated.
            Dim CustomerID As Integer = txtCustomerID.Text

            'This sets the new values for updating the database.
            Dim Title As String = cmbTitle.Text
            Dim FirstName As String = txtFName.Text
            Dim Surname As String = txtSurname.Text
            Dim AddressOne As String = txtAddressOne.Text
            Dim AddressTwo As String = txtAddressTwo.Text
            Dim City As String = cmbCity.Text
            Dim County As String = cmbCounty.Text
            Dim PostCode As String = txtPostCode.Text
            Dim TelephoneNo As String = txtTelphoneNo.Text
            Dim MobileNo As String = txtMobileNo.Text
            Dim EmailAdd As String = txtEmailAdd.Text
            Dim RenewalDateOne As String = txtRenewalDateOne.Text
            Dim RenewalDateTwo As String = txtRenewalDateTwo.Text
            Dim NoRemainingRenewalsOne As Integer = txtRemainingRenewals.Text
            Dim NoRemainingRenewalsTwo As Integer = txtRemainingRenewalsTwo.Text Or 0
            Dim RenewalLengthOne As String = cmbRenewalLengthOne.Text
            Dim RenewalLengthTwo As String = cmbRenewalLengthTwo.Text

            'This creates the SQL statement for updating the record
            Sql = "Update tblCustOne Set Title = '" & Title & "', FirstName = '" & FirstName & "', Surname = '" & Surname &
            "', AddressOne = '" & AddressOne & "', AddressTwo = '" & AddressTwo & "', City = '" &
            City & "', County = '" & County & "', PostCode = '" & PostCode & "', TelephoneNo = '" & TelephoneNo & "', MobileNo = '" & MobileNo &
            "', EmailAdd = '" & EmailAdd & "', RenewalDateOne = '" & RenewalDateOne & "', RenewalDateTwo = '" & RenewalDateTwo &
            "', NoRemainingRenewalsOne= " & NoRemainingRenewalsOne & ", NoRemainingRenewalsTwo= " & NoRemainingRenewalsTwo & ", RenewalLengthOne= '" &
            RenewalLengthOne & "', RenewalLengthTwo = '" & RenewalLengthTwo & "' Where CustomerID = " & CustomerID & ";"

            'This sets an object to link to the data adpater class
            Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
            'This calls the specific sub for updating in the data adapter class. 
            ToDAdapter.UpdateCustDa()

            Sql = "select * from tblCustOne"

            'refreshes the datagrid with the newly updated data.
            Dim myObject As CollectionClass = New CollectionClass()
            'This calls the customer info get sub from within the collection class.
            myObject.CustomerInfoGet()

            'fills the data set with the new tblCustOne with the removed customer no longer in it.
            dgdCustomers.DataSource = AllCustomerDs.Tables("tblAll")
        End If
    End Sub

    ''' <summary>
    ''' The following sub is ran to display the inforamtion forming an invoice for the currently selected customer
    ''' 
    ''' This works for the final version.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFormInvoice_Click(sender As Object, e As EventArgs) Handles btnFormInvoice.Click

        'Runs if no customer is in the boxes
        If txtFName.Text = String.Empty Then
            MessageBox.Show("No customer selected")
        Else
            'Runs if no customer is in the boxes
            If txtSurname.Text = String.Empty Then

                MessageBox.Show("No customer Selected")
            Else
                'Ouputs all the customer information for an invoice.
                MessageBox.Show("Customer Name = " & txtFName.Text & " " & txtSurname.Text + Environment.NewLine + "Invoice Number = " &
                txtInvoiceNo.Text + Environment.NewLine + "Address = " + Environment.NewLine + txtAddressOne.Text + Environment.NewLine +
                txtAddressTwo.Text + Environment.NewLine + cmbCity.Text & " " & cmbCounty.Text + Environment.NewLine + txtPostCode.Text)
            End If
        End If

    End Sub

    ''' <summary>
    ''' This is used to show the information to make a contract for the currently selected customer. 
    ''' 
    ''' This works for the final version.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnContract_Click(sender As Object, e As EventArgs) Handles btnContract.Click

        'Runs if no customer is in the boxes
        If txtFName.Text = String.Empty Then
            MessageBox.Show("No customer selected")
        Else

            'Runs if no customer is in the boxes
            If txtSurname.Text = String.Empty Then
                MessageBox.Show("No customer selected")
            Else

                'Runs if no customer is in the boxes
                If txtRenewalDateOne.Text = String.Empty Then
                    MessageBox.Show("No customer selected")

                Else
                    'Displays the contract information.
                    MessageBox.Show("Customer Name = " & txtFName.Text & " " & txtSurname.Text + Environment.NewLine + "Renewal Date = " & txtRenewalDateOne.Text)
                End If
            End If
        End If

    End Sub



    ''' <summary>
    ''' This function is used to validate all the inputs for customer information. 
    ''' 
    ''' This all works for the final version.
    ''' </summary>
    ''' <returns></returns>
    Public Function ValidateInputs() As Boolean
        'Used if the title does not match 
        Dim TitleNoMatch As Boolean = True

        'runs a loop fr the length of the title collection
        For i As Integer = 0 To cmbTitle.Items.Count - 1

            'If the user entered title is one of the acceptable titles.
            If cmbTitle.Text = cmbTitle.Items(i) Then
                TitleNoMatch = False

                'checks the length of first name input 
                If txtFName.Text.Length > 25 Then
                    MessageBox.Show("The first name exceeds the maximum length.")
                    Return False
                    'Should be ran if it does not exceed the length
                Else

                    'checks the surname length 
                    If txtSurname.Text.Length > 25 Then
                        MessageBox.Show("The surname exceeds the maximum length.")
                        Return False

                    Else

                        'checks the length of the address line one
                        If txtAddressOne.Text.Length > 30 Then
                            MessageBox.Show("The address line one exceeds the maximum length")
                            Return False
                        Else

                            'checks the length of address line two 
                            If txtAddressTwo.Text.Length > 30 Then
                                MessageBox.Show("The address line two exceeds the maximum length")
                                Return False
                            Else

                                'checks the city length
                                If cmbCity.Text.Length > 25 Then
                                    MessageBox.Show("The city exceeds the maximum length")
                                    Return False

                                Else

                                    'Length checks the county
                                    If cmbCounty.Text.Length > 25 Then
                                        MessageBox.Show("County exceeds maximum length")
                                        Return False
                                    Else

                                        'Length checks the post code
                                        If txtPostCode.Text.Length > 10 Then
                                            MessageBox.Show("Post code exceeds maximum length")
                                            Return False
                                        Else

                                            'Length checks the telephone number
                                            If txtTelphoneNo.Text.Length > 15 Then
                                                MessageBox.Show("Telephone number exceeds maximum length")
                                                Return False
                                            Else

                                                'Length checks the mobile number
                                                If txtMobileNo.Text.Length > 15 Then
                                                    MessageBox.Show("Mobile Number exceeds maximum length")
                                                    Return False
                                                Else

                                                    'Length checks the email box
                                                    If txtEmailAdd.Text.Length > 40 Then
                                                        MessageBox.Show("Email exceeds maximum lenth")
                                                        Return False
                                                    Else

														'Presence checks all necassary text boxes. 
														If txtFName.Text = String.Empty Or txtSurname.Text = String.Empty Or txtAddressOne.Text = String.Empty Or
															txtAddressTwo.Text = String.Empty Or cmbCity.Text = String.Empty Or cmbCounty.Text = String.Empty Or txtPostCode.Text = String.Empty Or
															txtTelphoneNo.Text = String.Empty Or txtMobileNo.Text = String.Empty Or txtEmailAdd.Text = String.Empty Or
															txtRenewalDateOne.Text = String.Empty Or txtRemainingRenewals.Text = String.Empty Then
															'This displays an error message to tell the user they need information in every box.
															MessageBox.Show("Informtion is required in every text box.")


															Return False
														Else

															'Returnes true if all the validation was sucessfull
															Return True
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Next
		'runs if the title inputted by the user is not valid.
		If TitleNoMatch = True Then
            MessageBox.Show("Ttle input is not an acceptable value.")
            Return False
        End If
    End Function

End Class