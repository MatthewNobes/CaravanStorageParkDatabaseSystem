Public Class frmEmailForm

    'This declares a list that is used to store the ID's of the customers who are going to be sent the email.
    'The list is a global variable that can be accessed any where in this class.
    Public RecipientList As List(Of Integer) = New List(Of Integer)


    ''' <summary>
    ''' This sub loads in all of the start up tasks needed for when the form loads. 
    ''' This contains the code for loading the customer information into the customer datagrid. 
    ''' 
    ''' This all works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmEmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This calls the class for collecting the customers data.
        Dim myObject As CollectionClass = New CollectionClass()
        'This line requests that the customer information for email sub routine is ran from the collection class.
        myObject.CustomerInfoForEmailForm()

        'This sets the recipient datagrid to be occupied by the email data set from the collection class.
        dgdRecipients.DataSource = EmailDs.Tables("tblAll")

    End Sub

    ''' <summary>
    ''' This sub is used to send the email to each individual client.
    ''' 
    ''' This section does work.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        'Checks that there is a message and a subject for the email before it is sent. 
        If txtSubject.Text = String.Empty Or txtMessage.Text = String.Empty Then
            MessageBox.Show("The email requires a subject and message to be sent.")

        Else

            'Used to check there are some recipients 
            If txtRecipientList.Text = String.Empty Then
                MessageBox.Show("The email requires recipients to be sent.")

            Else
                'This loop is ran for the number of records in the recipient list.
                For i As Integer = 0 To RecipientList.Count - 1

                    'This clears the email datset everytime the loop is ran.
                    EmailSendDs.Clear()

                    'Searcehes for that specific recipient 
                    Sql = "select EmailAdd from tblCustOne where CustomerID=" & RecipientList(i) & ";"

                    'Sets the data adapter to have the sql statement
                    da = New OleDb.OleDbDataAdapter(Sql, Connect)
                    'Fills the data into the correct data set.
                    Dim resultsAffected As Integer = da.Fill(EmailSendDs, "tblAll")

                    'Closes the SQL connection
                    Connect.Close()

                    'Extracts the email address from the dataset
                    Dim Emails As String = EmailSendDs.Tables("tblAll").Rows(i).Item("EmailAdd")

                    'Objects required to have an outlook connection
                    Dim objOutlook As Object
                    Dim objOutlookMsg As Object

                    'Uses the object to open Outlook to send the emails.
                    objOutlook = CreateObject("Outlook.Application")
                    objOutlookMsg = objOutlook.CreateItem(0)
                    With objOutlookMsg

                        'Add the customers In Bcc For secuirty 
                        .BCc = Emails

                        'Links the user email subject To the message
                        .Subject = txtSubject.Text
                        'Adds the message to the email
                        .Body = txtMessage.Text
                        'Sends the message
                        .Send()
                    End With
                    objOutlookMsg = Nothing
                    objOutlook = Nothing
                Next
            End If
        End If


    End Sub

    ''' <summary>
    ''' This sub is used to add recipients to the list of recipients. 
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddRecipient_Click(sender As Object, e As EventArgs) Handles btnAddRecipient.Click
        'Dim NextRecipientNo As Integer = RecipientList.Count + 1
        Dim RecipentsToOuput As String = ""

        'Asks the user which customer they wish to add
        Dim AddClient = InputBox("Input the ID of the Customer you wish to add to the recipient list.", "Add Recipient")

        'RecipientList(NextRecipientNo) = txtAddCustID.Text
        RecipientList.Add(AddClient)

        'Prepares the list into a from so that it can be outputted into the correct text box.
        'The loop is ran for the amount of ID' in the list, the minus one is needed as lists always have one extra in them at the end.
        For i As Integer = 0 To RecipientList.Count - 1
            'This adds to the variable the next id in the sequence with a commer. 
            RecipentsToOuput += Convert.ToString(RecipientList(i)) & ", "
        Next

        'Ouputs the variable listing all the recipients to the textbox
        txtRecipientList.Text = RecipentsToOuput
    End Sub


    ''' <summary>
    ''' This sub is used to add all the clinets in the customer table to the email list.
    ''' 
    ''' This section fully works for the prototype
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click

        'This collects all the ID's of all the customers in the database. 
        Sql = "select CustomerID from tblCustOne"

        'Calls the class for setting the data adapter 
        Dim ToDAdapter As DataAdapterClass = New DataAdapterClass()
        'This picks the correct sub in the class.
        ToDAdapter.DataAdapter()

        'This loop is used to repeate for the amount of records in the dataset
        For Each row As DataRow In AllCustomerDs.Tables(0).Rows
            'Ths makes sure it only adds the customer ID and not any of the other collums.
            For i As Integer = 0 To 1 - 1
                'This adds the customer ID to the recipient list.
                RecipientList.Add(row.Item(i).ToString())
            Next
        Next


        'The next bit of code is used to output the list of recipeints into the text box.

        'This sets a variable for outputting the list
        Dim RecipentsToOuput As String = ""

        'Prepares the array into a from so that it cna be outputted into the correct text box.
        For i As Integer = 0 To RecipientList.Count - 1
            'This adds to the variable the next id in the sequence with a commer.
            RecipentsToOuput += Convert.ToString(RecipientList(i)) & ", "
        Next

        'Ouputs the array to textbox
        txtRecipientList.Text = RecipentsToOuput
    End Sub

    ''' <summary>
    ''' This sub is used to remove all ID's from the recipient list and clear the text box.
    ''' 
    ''' This fully works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click

        'This lines wipes the text box shoing the reicpients 
        txtRecipientList.Text = ""
        'This line clears the list f all recipients. 
        RecipientList.Clear()
    End Sub

    ''' <summary>
    ''' This sub routine is used to remove a user specified recipient from the list of recipients and output the new list
    ''' 
    ''' This section fully works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemoveRecipient_Click(sender As Object, e As EventArgs) Handles btnRemoveRecipient.Click

        'This creates an input for the user to ask which reicpients they wish to remove. 
        Dim RemoveID As Integer = InputBox("Input the ID of the Customer you wish to remove from the recipient list.", "Remove Recipient")

        'This loop is ran for the amount of recipients in the list. 
        For i As Integer = 0 To RecipientList.Count - 1
            'This checks if that ID is the one that needs to be removed. 
            If RecipientList(i) = RemoveID Then
                'Does not work yet
                RecipientList.Remove(i)
            End If
        Next

        'Dim NextRecipientNo As Integer = RecipientList.Count + 1
        Dim RecipentsToOuput As String = ""

        'Prepares the array into a from so that it cna be outputted into the correct text box.
        For i As Integer = 0 To RecipientList.Count - 1
            'This adds to the variable the next id in the sequence with a commer.
            RecipentsToOuput += Convert.ToString(RecipientList(i)) & ", "
        Next

        'Ouputs the array to textbox
        txtRecipientList.Text = RecipentsToOuput
    End Sub
End Class