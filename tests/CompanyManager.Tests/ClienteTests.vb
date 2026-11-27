Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CompanyManager

<TestClass>
Public Class ClienteTests

    Private Const CodigoEmpresaTeste As Integer = 10

    <TestMethod>
    Public Sub Construtor_AtribuiPropriedadesHerdadasDePessoa()
        ' Arrange / Act
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)

        ' Assert
        Assert.AreEqual("Roberto", cliente.Nome)
        Assert.AreEqual(33, cliente.Idade)
        Assert.AreEqual("roberto@email.com", cliente.Email)
    End Sub

    <TestMethod>
    Public Sub Construtor_AtribuiCodigoEmpresaInformado()
        ' Arrange / Act
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)

        ' Assert
        Assert.AreEqual(CodigoEmpresaTeste, cliente.Empresa)
    End Sub

    <TestMethod>
    Public Sub Construtor_DefineAtivoComoTrue()
        ' Arrange / Act
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)

        ' Assert
        Assert.IsTrue(cliente.Ativo)
    End Sub

    <TestMethod>
    Public Sub Construtor_DefineDataCadastroComDataAtual()
        ' Arrange
        Dim antes = DateTime.Now

        ' Act
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)
        Dim depois = DateTime.Now

        ' Assert
        Assert.IsTrue(cliente.DataCadastro >= antes AndAlso cliente.DataCadastro <= depois)
    End Sub

    <TestMethod>
    Public Sub CodigoCliente_NovasInstancias_SaoSequenciais()
        ' O contador é Shared e acumula entre os testes, por isso a verificação é relativa.
        ' Arrange / Act
        Dim primeiro As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)
        Dim segundo As New Cliente("Flavia", 27, "flavia@email.com", CodigoEmpresaTeste)

        ' Assert
        Assert.AreEqual(primeiro.CodigoCliente + 1, segundo.CodigoCliente)
    End Sub

    <TestMethod>
    Public Sub Ativo_AoDefinirFalse_RetornaFalse()
        ' Arrange
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)

        ' Act
        cliente.Ativo = False

        ' Assert
        Assert.IsFalse(cliente.Ativo)
    End Sub

    <TestMethod>
    Public Sub Cliente_EhInstanciaDePessoa()
        ' Arrange / Act
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)

        ' Assert
        Assert.IsInstanceOfType(Of Pessoa)(cliente)
    End Sub

    <TestMethod>
    Public Sub ToString_IncluiDadosDePessoaECliente()
        ' Arrange
        Dim cliente As New Cliente("Roberto", 33, "roberto@email.com", CodigoEmpresaTeste)
        ' DataCadastro e Ativo dependem da cultura atual, então usam a mesma interpolação da classe.
        Dim esperado = vbCrLf & "Nome: Roberto" & vbCrLf & "Idade: 33" & vbCrLf & "Email: roberto@email.com" &
                       vbCrLf & $"Cadastro: {cliente.DataCadastro}" &
                       vbCrLf & $"Ativo: {cliente.Ativo}" &
                       vbCrLf & $"Empresa: {CodigoEmpresaTeste}"

        ' Act
        Dim resultado = cliente.ToString()

        ' Assert
        Assert.AreEqual(esperado, resultado)
    End Sub

End Class
