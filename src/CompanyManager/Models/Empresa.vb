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

    Public Property Clientes As List(Of Cliente)
        Get
            Return _clientes
        End Get
        Set(value As List(Of Cliente))
            _clientes = value
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
End Class
