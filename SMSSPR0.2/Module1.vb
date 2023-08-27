Imports System.Data.OleDb
Imports System.IO

Module Module1
    Public cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spr.accdb")
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
End Module
