Public Class InvoiceNoClass
    'This sets a variable for the invoice number. 
    Dim InvoiceNo As Integer

    ''' <summary>
    ''' This returns the value for the invoice number.
    ''' </summary>
    ''' <returns></returns>
    Public Function GiveInvoiceNo()
        Return (InvoiceNo)
    End Function


    ''' <summary>
    ''' This is used to get the invoice number out of the invocie table. 
    ''' 
    ''' This works for the prototype.
    ''' </summary>
    Public Sub InvoiceCounterLoad()
		'clears the invoice dataset
		NextInvoiceDs.Clear()

		'sets an sql statement to get the invoice numbers.
		Sql = "select * from tblInvoice Order By InvoiceID Desc;"

		'sets the data adapter
		da = New OleDb.OleDbDataAdapter(Sql, Connect)

		'fills the dataset with the result.
		Dim resultsAffected As Integer = da.Fill(NextInvoiceDs, "tblAll")

		'closes the database connection.
		Connect.Close()

		'picks out the exact invoice nuber from the dataset.
		InvoiceNo = NextInvoiceDs.Tables("tblAll").Rows(0).Item("InvoiceNo")


    End Sub

End Class
