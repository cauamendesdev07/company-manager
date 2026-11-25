Public Class Pessoa
    Private _nome As String
    Private _idade As Integer
    Private _email As String

    Public Sub New(nome As String, idade As Integer, email As String)
        Me._nome = nome
        Me._idade = idade
        Me._email = email
    End Sub

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Idade As Integer
        Get
            Return _idade
        End Get
        Set(value As Integer)
            _idade = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return vbCrLf & $"Nome: {Nome}" & vbCrLf & $"Idade: {Idade}" & vbCrLf & $"Email: {Email}"
    End Function

End Class