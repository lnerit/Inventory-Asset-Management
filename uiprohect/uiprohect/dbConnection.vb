Option Explicit On
Imports System.Data.OleDb
Imports System.String

Public Module Globalvariables
    Public Provider As String
    Public dataFile As String
    Public connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
End Module

Public Class dbConnectionClass
    Public Function dbConnectionString() As String
        Provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = My.Application.Info.DirectoryPath + "\UnitechAMS.accdb " ' Change it to your Access Database location"
        connString = Provider & dataFile
        dbConnectionString = connString
    End Function

End Class