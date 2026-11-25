Imports System.Net

Public Class Empresa

    Private Shared ProximoCodigoEmpresa As Integer = 0
    Private ReadOnly _codigoEmpresa As Integer
    Private _nome As String
    Private _cnpj As String
    Private _endereco As String
    Private _clientes As List(Of Cliente)

    Public Sub New(nome As String, cnpj As String, endereco As String)
        Me._nome = nome
        Me._cnpj = cnpj
        Me._endereco = endereco
        Me._clientes = New List(Of Cliente)()

        ProximoCodigoEmpresa += 1
        Me._codigoEmpresa = ProximoCodigoEmpresa
    End Sub

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return _endereco
        End Get
        Set(value As String)
            _endereco = value
        End Set
    End Property

    Public ReadOnly Property CodigoEmpresa As Integer
        Get
            Return _codigoEmpresa
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return vbCrLf & $"Nome: {Nome}" & vbCrLf & $"CNPJ: {Cnpj}" & vbCrLf & $"Endereço: {Endereco}"
    End Function

    Public Function AddCliente(cliente As Cliente) As String
        Try
            If cliente.Empresa <> Me.CodigoEmpresa Then
                Return vbCrLf & "O cliente não pertence a essa empresa!"
            End If

            Me._clientes.Add(cliente)
            Return vbCrLf & "Cliente cadastrado com sucesso na empresa!"
        Catch ex As Exception
            Return (vbCrLf & "Não foi possivel cadastrar o cliente! " & vbCrLf & "Erro: " & ex.Message)
        End Try
    End Function

    Public Function RemoverCliente(cliente As Cliente) As String
        Try
            If Not _clientes.Contains(cliente) Then
                Return vbCrLf & "O cliente não pertence a essa empresa!"
            End If

            _clientes.Remove(cliente)
            Return vbCrLf & "Cliente removido com sucesso!"
        Catch ex As Exception
            Return (vbCrLf & "Não foi possivel remover o cliente! " & vbCrLf & "Erro: " & ex.Message)
        End Try
    End Function

    Public Function ListarClientes() As IReadOnlyList(Of Cliente)
        Return _clientes.AsReadOnly()
    End Function

End Class
