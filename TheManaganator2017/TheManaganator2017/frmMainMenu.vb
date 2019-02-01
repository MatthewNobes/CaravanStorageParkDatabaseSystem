Public Class frmMainMenu

    ''' <summary>
    ''' This runs all the form startup tasks needed.
    ''' 
    ''' This section works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsAdmin = False Then
            btnAdminMenu.Hide()
        Else
            btnAdminMenu.Show()
        End If
    End Sub

    ''' <summary>
    ''' When pressed the customer managment form will be loaded.
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCustomerMng_Click(sender As Object, e As EventArgs) Handles btnCustomerMng.Click
        'This opens the customer managment form  
        frmCustMang.Show()
    End Sub

    ''' <summary>
    ''' When pressed this opens the admin form. 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdminMenu_Click(sender As Object, e As EventArgs) Handles btnAdminMenu.Click
        'This opens the admin form
        frmAdminMenu.Show()
    End Sub

    ''' <summary>
    ''' When pressed this will open the renewal managment form.
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRenewalMng_Click(sender As Object, e As EventArgs) Handles btnRenewalMng.Click
        'This opens the renewal managment form.
        frmRenewalManagement.Show()
    End Sub

    ''' <summary>
    ''' When pressed the pitch management form will open.
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPitchMng_Click(sender As Object, e As EventArgs) Handles btnPitchMng.Click
        'This opens the pitch managment form.
        frmPitchMang.Show()
    End Sub

    ''' <summary>
    ''' This ensures that when this form is closed the whole program is closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'This clsoes the program.
        Application.Exit()
    End Sub
End Class
