Imports System

Module Program

    Sub ExibirClientes(clientes As IReadOnlyList(Of Cliente), nomeEmpresa As String)
        Console.WriteLine(vbCrLf & "Clientes da empresa " & nomeEmpresa)
        For Each cliente In clientes
            Console.WriteLine(cliente.ToString())
        Next
    End Sub

    Sub Main(args As String())

        Dim pessoa As New Pessoa("Cauã", 22, "cauamendes.dev@gmail.com")
        Dim empresa As New Empresa("Empresa1", "100200300000121", "Rua dos patos, 777")
        Dim empresa2 As New Empresa("Empresa2", "100200300000122", "Rua dos patos, 007")
        Dim cliente As New Cliente("Roberto", 33, "robertinho@gmail.com", empresa.CodigoEmpresa)
        Dim cliente2 As New Cliente("Flavia", 27, "flavinha@gmail.com", empresa2.CodigoEmpresa)

        ''Console.WriteLine(pessoa.ToString & vbCrLf & empresa.ToString & vbCrLf & cliente.ToString)

        Console.WriteLine(empresa.AddCliente(cliente))
        Console.WriteLine(empresa2.AddCliente(cliente2))

        Dim clientesEmpresa = empresa.ListarClientes()
        Dim clientesEmpresa2 = empresa2.ListarClientes()

        If empresa.ListarClientes().Count = 0 Then
            Console.WriteLine("Nenhum cliente cadastrado para essa empresa!")
        Else
            ExibirClientes(clientesEmpresa, empresa.Nome)
        End If
        
        If empresa2.ListarClientes().Count = 0 Then
            Console.WriteLine("Nenhum cliente cadastrado para essa empresa!")
        Else
            ExibirClientes(clientesEmpresa, empresa.Nome)
        End If

    End Sub
End Module