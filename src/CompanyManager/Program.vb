Imports System

Module Program
    Sub Main(args As String())
        Dim pessoa As New Pessoa("Cauã", 22, "cauamendes.dev@gmail.com")
        Dim nome As String
        Dim email As String
        Dim idade As String

        nome = pessoa.GetNome()
        email = pessoa.GetEmail()
        idade = pessoa.GetIdade()

        Console.WriteLine("Dados das Pessoas")
        Console.WriteLine("Nome: " & nome)
        Console.WriteLine("Idade: " & idade)
        Console.WriteLine("E-mail: " & email)

        Dim empresa1 As New Empresa("Empresa", "100500200000130", "Rua dos coqueiros, 001")
        Dim dadosEmpresa = empresa1.GetDadosEmpresa()

        Console.WriteLine("Dados da empresa")
        Console.WriteLine("Nome: " & dadosEmpresa.Nome)
        Console.WriteLine("CNPJ: " & dadosEmpresa.CNPJ)
        Console.WriteLine("Endereço: " & dadosEmpresa.Endereco)

        Dim cliente As New Cliente("Cliente 1", 20, "cauamendes.dev@gmail.com", dadosEmpresa.CodigoEmpresa)

        Console.WriteLine("Dados dos clientes")
        Console.WriteLine("Nome:" & cliente.GetNome())
        Console.WriteLine("Email:" & cliente.GetEmail())
        Console.WriteLine("Idade:" & cliente.GetIdade())
        Console.WriteLine("CodCliente:" & cliente.GetIdade())
        Console.WriteLine("DataCadastro:" & cliente.GetIdade())
        Console.WriteLine("Empresa:" & cliente.GetIdade())
        Console.WriteLine("Empresa:" & cliente.GetIdade())

    End Sub
End Module