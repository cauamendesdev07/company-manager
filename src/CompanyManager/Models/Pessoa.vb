Public Class Pessoa
    Private Nome As String
    Private Idade As Integer
    Private Email As String

    Public Sub New(nome As String, idade As Integer, email As String)
        Me.Nome = nome
        Me.Idade = idade
        Me.Email = email
    End Sub

    Public Function GetNome() As String
        Return Nome
    End Function

    Public Function GetIdade() As String
        Return Idade
    End Function

    Public Function GetEmail() As String
        Return Email
    End Function

End Class
