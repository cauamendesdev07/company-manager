Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CompanyManager

<TestClass>
Public Class PessoaTests

    <TestMethod>
    Public Sub Construtor_ComDadosValidos_AtribuiNomeIdadeEmail()
        ' Arrange / Act
        Dim pessoa As New Pessoa("Ana", 30, "ana@email.com")

        ' Assert
        Assert.AreEqual("Ana", pessoa.Nome)
        Assert.AreEqual(30, pessoa.Idade)
        Assert.AreEqual("ana@email.com", pessoa.Email)
    End Sub

    <TestMethod>
    Public Sub Nome_AoAlterar_RetornaNovoValor()
        ' Arrange
        Dim pessoa As New Pessoa("Ana", 30, "ana@email.com")

        ' Act
        pessoa.Nome = "Beatriz"

        ' Assert
        Assert.AreEqual("Beatriz", pessoa.Nome)
    End Sub

    <TestMethod>
    Public Sub Idade_AoAlterar_RetornaNovoValor()
        ' Arrange
        Dim pessoa As New Pessoa("Ana", 30, "ana@email.com")

        ' Act
        pessoa.Idade = 31

        ' Assert
        Assert.AreEqual(31, pessoa.Idade)
    End Sub

    <TestMethod>
    Public Sub Email_AoAlterar_RetornaNovoValor()
        ' Arrange
        Dim pessoa As New Pessoa("Ana", 30, "ana@email.com")

        ' Act
        pessoa.Email = "ana.nova@email.com"

        ' Assert
        Assert.AreEqual("ana.nova@email.com", pessoa.Email)
    End Sub

    <TestMethod>
    Public Sub ToString_RetornaNomeIdadeEmailFormatados()
        ' Arrange
        Dim pessoa As New Pessoa("Ana", 30, "ana@email.com")
        Dim esperado = vbCrLf & "Nome: Ana" & vbCrLf & "Idade: 30" & vbCrLf & "Email: ana@email.com"

        ' Act
        Dim resultado = pessoa.ToString()

        ' Assert
        Assert.AreEqual(esperado, resultado)
    End Sub

End Class
