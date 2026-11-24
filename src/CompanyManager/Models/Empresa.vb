Public Class Empresa
    Private Nome As String
    Private CNPJ As String
    Private Endereco As String

    Public Sub New(nome As String, cnpj As String, endereco As String)
        Me.Nome = nome
        Me.CNPJ = cnpj
        Me.Endereco = endereco
    End Sub

    Public Function GetDadosEmpresa() As (Nome As String, CNPJ As String, Endereco As String)
        Return (Nome, CNPJ, Endereco)
    End Function

End Class
