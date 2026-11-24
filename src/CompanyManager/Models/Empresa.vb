Public Class Empresa

    Private Shared ProximoCodigoEmpresa As Integer = 0
    Private ReadOnly CodigoEmpresa As Integer
    Private Nome As String
    Private CNPJ As String
    Private Endereco As String
    Private Clientes As List(Of Cliente)

    Public Sub New(nome As String, cnpj As String, endereco As String)
        Me.Nome = nome
        Me.CNPJ = cnpj
        Me.Endereco = endereco

        ProximoCodigoEmpresa += 1
        CodigoEmpresa = ProximoCodigoEmpresa
    End Sub

    Public Function GetDadosEmpresa() As (Nome As String, CNPJ As String, Endereco As String)
        Return (Nome, CNPJ, Endereco)
    End Function

    Public Function GetClientes() As List(Of Cliente)
        Return Clientes
    End Function

    Public Sub AddCliente(cliente As Cliente)
        Clientes.Add(cliente)
    End Sub

End Class
