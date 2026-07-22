Imports System.Data.Entity
Imports Npgsql

Public Class ModeloDbConfiguration
    Inherits DbConfiguration

    Public Sub New()
        SetProviderServices("Npgsql", NpgsqlServices.Instance)
        SetProviderFactory("Npgsql", NpgsqlFactory.Instance)
    End Sub
End Class
