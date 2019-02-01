Public Class frmRenewalManagement
    ''' <summary>
    ''' This sub loads the custome rdata into the datagrid.
    ''' 
    ''' This all works for the prototype.
    ''' this all works for the final version now.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmRenewalManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'sets the SQL statment to get the customes information but only those who have reamining renewals that year.
        Sql = "select * from tblCustOne Where NoRemainingRenewalsOne <> 0"

        'connects to the class where the customer info get is kept.
        Dim myObject As CollectionClass = New CollectionClass()
        myObject.CustomerInfoGet()

        'Sets the data grid to show that dataset.
        dgdUpcomingRenewals.DataSource = AllCustomerDs.Tables("tblAll")
    End Sub


End Class