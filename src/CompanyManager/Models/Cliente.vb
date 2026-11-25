Public Class Cliente
    Inherits Pessoa

    Private Shared ProximoCodigo As Integer = 0
    Private ReadOnly _codigoCliente As Integer
    Private _dataCadastro As DateTime
    Private _ativo As Boolean
    Private _empresa As Integer

    Public Sub New(nome As String, idade As Integer, email As String, codigoEmpresa As Integer)
        MyBase.New(nome, idade, email)

        ProximoCodigo += 1
        _codigoCliente = ProximoCodigo
        Me._dataCadastro = DateTime.Now
        Me._ativo = True
        Me._empresa = codigoEmpresa
    End Sub

    Public ReadOnly Property DataCadastro As DateTime
        Get
            Return _dataCadastro
        End Get
    End Property

    Public ReadOnly Property Empresa As Integer
        Get
            Return _empresa
        End Get
    End Property

    Public Property Ativo As Boolean
        Get
            Return _ativo
        End Get
        Set(value As Boolean)
            _ativo = value
        End Set
    End Property

    Public ReadOnly Property CodigoCliente As Integer
        Get
            Return _codigoCliente
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & vbCrLf & $"Cadastro: {DataCadastro}" & vbCrLf & $"Ativo: {Ativo}" & vbCrLf & $"Empresa: {Empresa}"
    End Function

End Class