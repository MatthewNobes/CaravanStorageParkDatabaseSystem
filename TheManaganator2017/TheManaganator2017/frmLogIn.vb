Public Class frmLogIn

    ''' <summary>
    ''' This section is used to run the login process when clicked. 
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        'This checks if the username is under the required length
        If txtUserName.Text.Length > 25 Then
            MessageBox.Show("The username exceeds the required length.")
        Else
            'This checs if the password is under the required length
            If txtPassword.Text.Length > 25 Then
                MessageBox.Show("The password exceeds the required length")
            Else
                'This sets the username and password as variables and sets them to equal what the user has inputted. 
                Dim UserName As String = txtUserName.Text
                Dim Password As String = txtPassword.Text

                'sets an object set to the collection class
                Dim myObject As CollectionClass = New CollectionClass()
                'This calls the correct sub from within the collection class.
                myObject.UserCollect()

                Dim RowCounter As Integer

                Dim AreAnyRecordsFound As Boolean = False

                Dim AttemptedLoginID As Integer

                For Each row As DataRow In LoginDs.Tables("tblAll").Rows
                    'This increases the row counter by one everytime a row has been searched. 
                    RowCounter = RowCounter + 1
                    'This compares if the search criteria is the same as what is in the currenyl looked at box.
                    If row.Item(1).ToString() = UserName Then

                        'This lets the output of the found ID's be ran.
                        AreAnyRecordsFound = True

                        'Add the ID of the record it was found on to a variable
                        AttemptedLoginID = (LoginDs.Tables("tblAll").Rows(RowCounter - 1)("UserID").ToString())

                    End If

                Next

                'If the username is not found the code in this section is ran.
                If AreAnyRecordsFound = False Then
                    MessageBox.Show("The Username is not found in the database")

                Else

                    'Sets a variable for the password which is expected
                    Dim ExpectedPassword As String

                    'Runs an SQL statement to collect the expected password
                    Sql = "select PasswordStore from tblUser Where UserID= " & AttemptedLoginID

                    Dim PassCollectObj As CollectionClass = New CollectionClass()
                    'This calls the correct sub from within the collection class.
                    PassCollectObj.CollectPassword()

                    'Sets the expected password to the correct value from the dataset
                    ExpectedPassword = PassDs.Tables("tblAll").Rows(0).Item("PasswordStore")

                    'checks the users input from the expected password
                    If ExpectedPassword = Password Then

                        'informs the user the password matches
                        MessageBox.Show("The password matches")

						'makes a select statement for collecting the user type of the logged in user. 
						Sql = "select UserType from tblUser Where UserID= " & AttemptedLoginID

                        Dim UserTypeCollectObj As CollectionClass = New CollectionClass()
                        'This calls the correct sub from within the collection class.
                        PassCollectObj.CollectPassword()

						'Pulls out the user type from the dataset to a variable.
						Dim UserType As String = PassDs.Tables("tblAll").Rows(0).Item("UserType")

						'works out if the logged in user is an admin or not.
						If UserType = "Admin" Then
							'set the boolean to true if they are admin
							IsAdmin = True

						Else
							'sets th boolean to false if the user is not an admin
							IsAdmin = False
                        End If

						'opens the main mneu form.
						frmMainMenu.Show()
                        'This hides the current form.
                        Me.Hide()
                    Else
                        'Informs the user if the password did not match
                        MessageBox.Show("The password does not match, try again.")
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' This button is used to clear both the text boxes on the login form. 
    ''' 
    ''' This section works perfectly fine for the post-prototype. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'This clears the username text box.
        txtUserName.Clear()

        'This clears the password box. 
        txtPassword.Clear()
    End Sub

	''' <summary>
	''' This code collects the log in infromation when the form starts
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This makes the databse connection
        DBConnect()

        'This sets the message to show it was connected. 
        lblConnectStatus.Text = "Now Connected"
    End Sub
End Class