Imports System.Data
Imports System.Data.SqlClient

Module DBSql
    Public con As New SqlConnection("Data Source=DESKTOP-1G21BHF\SQLEXPRESS;Initial Catalog=SalesInventory;Integrated Security=True")
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public dt As DataTable
    Public qr As String

    Public Function SearchData(ByVal qr As String) As DataSet
        da = New SqlDataAdapter(qr, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function



End Module
