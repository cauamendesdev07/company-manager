Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CompanyManager

<TestClass>
Public Class EmpresaTests

    Private Const MensagemSucessoCadastro As String = vbCrLf & "Cliente cadastrado com sucesso na empresa!"
    Private Const MensagemSucessoRemocao As String = vbCrLf & "Cliente removido com sucesso!"
    Private Const MensagemNaoPertence As String = vbCrLf & "O cliente não pertence a essa empresa!"

    Private Shared Function CriarEmpresa() As Empresa
        Return New Empresa("Empresa Teste", "12345678000199", "Rua das Flores, 100")
    End Function

    Private Shared Function CriarClienteDa(empresa As Empresa) As Cliente
        Return New Cliente("Roberto", 33, "roberto@email.com", empresa.CodigoEmpresa)
    End Function

    <TestMethod>
    Public Sub Construtor_AtribuiNomeCnpjEndereco()
        ' Arrange / Act
        Dim empresa = CriarEmpresa()

        ' Assert
        Assert.AreEqual("Empresa Teste", empresa.Nome)
        Assert.AreEqual("12345678000199", empresa.Cnpj)
        Assert.AreEqual("Rua das Flores, 100", empresa.Endereco)
    End Sub

    <TestMethod>
    Public Sub CodigoEmpresa_NovasInstancias_SaoSequenciais()
        ' O contador é Shared e acumula entre os testes, por isso a verificação é relativa.
        ' Arrange / Act
        Dim primeira = CriarEmpresa()
        Dim segunda = CriarEmpresa()

        ' Assert
        Assert.AreEqual(primeira.CodigoEmpresa + 1, segunda.CodigoEmpresa)
    End Sub

    <TestMethod>
    Public Sub ListarClientes_EmpresaNova_RetornaListaVazia()
        ' Arrange
        Dim empresa = CriarEmpresa()

        ' Act
        Dim clientes = empresa.ListarClientes()

        ' Assert
        Assert.AreEqual(0, clientes.Count)
    End Sub

    <TestMethod>
    Public Sub AddCliente_ClienteDaEmpresa_AdicionaERetornaSucesso()
        ' Arrange
        Dim empresa = CriarEmpresa()
        Dim cliente = CriarClienteDa(empresa)

        ' Act
        Dim resultado = empresa.AddCliente(cliente)

        ' Assert
        Assert.AreEqual(MensagemSucessoCadastro, resultado)
        Assert.AreEqual(1, empresa.ListarClientes().Count)
        Assert.AreSame(cliente, empresa.ListarClientes()(0))
    End Sub

    <TestMethod>
    Public Sub AddCliente_ClienteDeOutraEmpresa_NaoAdicionaERetornaMensagem()
        ' Arrange
        Dim empresa = CriarEmpresa()
        Dim outraEmpresa = CriarEmpresa()
        Dim cliente = CriarClienteDa(outraEmpresa)

        ' Act
        Dim resultado = empresa.AddCliente(cliente)

        ' Assert
        Assert.AreEqual(MensagemNaoPertence, resultado)
        Assert.AreEqual(0, empresa.ListarClientes().Count)
    End Sub

    <TestMethod>
    Public Sub RemoverCliente_ClienteCadastrado_RemoveERetornaSucesso()
        ' Arrange
        Dim empresa = CriarEmpresa()
        Dim cliente = CriarClienteDa(empresa)
        empresa.AddCliente(cliente)

        ' Act
        Dim resultado = empresa.RemoverCliente(cliente)

        ' Assert
        Assert.AreEqual(MensagemSucessoRemocao, resultado)
        Assert.AreEqual(0, empresa.ListarClientes().Count)
    End Sub

    <TestMethod>
    Public Sub RemoverCliente_ClienteNaoCadastrado_RetornaMensagem()
        ' Arrange
        Dim empresa = CriarEmpresa()
        Dim clienteCadastrado = CriarClienteDa(empresa)
        Dim clienteNaoCadastrado = CriarClienteDa(empresa)
        empresa.AddCliente(clienteCadastrado)

        ' Act
        Dim resultado = empresa.RemoverCliente(clienteNaoCadastrado)

        ' Assert
        Assert.AreEqual(MensagemNaoPertence, resultado)
        Assert.AreEqual(1, empresa.ListarClientes().Count)
    End Sub

    <TestMethod>
    Public Sub ListarClientes_RetornaColecaoSomenteLeitura()
        ' Arrange
        Dim empresa = CriarEmpresa()
        empresa.AddCliente(CriarClienteDa(empresa))

        ' Act
        Dim clientes = empresa.ListarClientes()

        ' Assert
        Dim colecao = TryCast(clientes, ICollection(Of Cliente))
        Assert.IsNotNull(colecao)
        Assert.IsTrue(colecao.IsReadOnly)
        Assert.ThrowsExactly(Of NotSupportedException)(Sub() colecao.Add(CriarClienteDa(empresa)))
    End Sub

    <TestMethod>
    Public Sub ToString_RetornaDadosFormatados()
        ' Arrange
        Dim empresa = CriarEmpresa()
        Dim esperado = vbCrLf & "Nome: Empresa Teste" & vbCrLf & "CNPJ: 12345678000199" & vbCrLf & "Endereço: Rua das Flores, 100"

        ' Act
        Dim resultado = empresa.ToString()

        ' Assert
        Assert.AreEqual(esperado, resultado)
    End Sub

End Class
