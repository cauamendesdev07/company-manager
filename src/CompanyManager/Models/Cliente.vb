Public Class Cliente
    Inherits Pessoa

    Private Shared ProximoCodigo As Integer = 0
    Private ReadOnly CodigoCliente As Integer
    Private DataCadastro As DateTime
    Private Ativo As Boolean
    Private Empresa As Integer

    Public Sub New(nome As String, idade As Integer, email As String, codigoEmpresa As Integer)
        MyBase.New(nome, idade, email)

        Empresa = codigoEmpresa

        ProximoCodigo += 1
        CodigoCliente = ProximoCodigo
        DataCadastro = DateTime.Now
        Ativo = True
    End Sub

End Class